using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;

using GestionnaireLivre.Model.DataObject;
using GestionnaireLivre.Model.Services;
using Google.Apis.Books.v1.Data;

namespace MobileServer
{
    public class Program
    {
        static void Main(string[] args)
        {




            List<Thread> listeThreads = new List<Thread>();
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            // Get the IP
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();


            Thread udpThread = new Thread(EnvoyerIpUdp);
            udpThread.Start();



            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(myIP), 1212);
            sock.Bind(iep);
            sock.Listen(1);
            while (true)
            {
                Socket actif = sock.Accept();
                Thread thread = new Thread(() => GererCommunication(actif));
                listeThreads.Add(thread);
                thread.Start();
            }
        }


        private static void EnvoyerIpUdp()
        {
            UdpClient client = new UdpClient(9900);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9900);

            while (true)
            {
                try
                {
                    Byte[] receiveBytes = client.Receive(ref iep);

                    string data = Encoding.ASCII.GetString(receiveBytes);
                    if (data == "/getIP")
                    {
                        Console.WriteLine("Connexion avec :" + iep.Address);

                        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                        IPEndPoint endPoint = new IPEndPoint(iep.Address, 11000);
                        Thread.Sleep(500);
                        string text = "Hello";
                        byte[] send_buffer = Encoding.ASCII.GetBytes(text);

                        sock.SendTo(send_buffer, endPoint);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }


        private static void Envoyer(string message, Socket sock)
        {
            Thread.Sleep(200);
            byte[] buffer = new byte[10000];
            buffer = StringToBytes(message);
            sock.Send(buffer, 0, buffer.Length, SocketFlags.None);
            Thread.Sleep(200);
        }

        private static string BytesToString(byte[] bytes)
        {
            string temp = Encoding.UTF8.GetString(bytes);
            return temp.Replace("\0", "");
        }

        private static byte[] StringToBytes(string message)
        {
            return Encoding.UTF8.GetBytes(message);
        }

        private static string[] Decoder(string message)
        {
            return message.Split('/');
        }



        private static void GererCommunication(Socket sock)
        {
            string Operation = null;
            DataBaseService dbServiceUser = new DataBaseService();
            User utilisateur = new User();
            while (Operation != "/Quitter")
            {
                byte[] buffer = new byte[10000];
                sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);

                Operation = BytesToString(buffer);

                Console.WriteLine(Operation);
                if (Operation == "/VerificationUtilisateur")
                {
                    utilisateur = Connexion(sock, dbServiceUser);
                }
                else if (Operation == "/DemandeInformationLivre")
                {
                    EnvoyerLivres(sock);
                }
                else if (Operation == "/AjoutLivre")
                {
                    AjoutLivre(sock, dbServiceUser);
                }
                else if (Operation == "/DemandeLivres")
                {
                    EnvoyerInformationLivre(sock, utilisateur, dbServiceUser);
                }
                else if (Operation == "/DemandeListeCoop")
                {
                    EnvoyerListeCoop(sock, dbServiceUser);
                }
                else if (Operation == "/DemandeListeLivres")
                {
                    EnvoyerListeLivres(sock, utilisateur, dbServiceUser);
                }
            }

            sock.Shutdown(SocketShutdown.Both);
            sock.Close();
        }

        private static void EnvoyerListeLivres(Socket sock, User utilisateur, DataBaseService dbServiceUser) // a completer (liste des livres)
        {
            string listeLivres = "";
            List<Book> lesLivres = dbServiceUser.RetrieveBooksByCoopId(utilisateur.CoopRefID);

            for (int i = 0; i < lesLivres.Count; i++)
            {
                listeLivres = listeLivres + "/" + lesLivres[i].Title;
            }
            Envoyer(listeLivres, sock);
        }

        private static void EnvoyerListeCoop(Socket sock, DataBaseService dbServiceUser) // Tester et fonctionne (liste des coops)
        {
            string listeCoop = "";
            List<Cooperative> listeCoops = dbServiceUser.RetrieveCooperatives();
            for (int i = 0; i < listeCoops.Count; i++)
            {
                if (i < listeCoops.Count - 1)
                {
                    listeCoop = listeCoop + listeCoops[i].Name + "/";
                }
                else
                {
                    listeCoop = listeCoop + listeCoops[i].Name;
                }
            }

            Envoyer(listeCoop, sock);
        }
        private static void EnvoyerInformationLivre(Socket sock, User utilisateur, DataBaseService dbServiceUser)
        {


            byte[] buffer = new byte[10000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);

            string temp = BytesToString(buffer);
            int numeroDuLivre = int.Parse(temp);

            List<Book> lesLivres = dbServiceUser.RetrieveBooksByCoopId(utilisateur.CoopRefID);

            Book leLivre = lesLivres[numeroDuLivre - 1];

            string condition;
            string transaction;

            if (leLivre.FK_bookcondition == 1)
            {
                condition = "Comme neuf";
            }
            else if (leLivre.FK_bookcondition == 2)
            {
                condition = "Quelques pages pliés, utilisation d’un marqueur";
            }
            else if (leLivre.FK_bookcondition == 3)
            {
                condition = "Livre très utilisé, pages plié, couverture endommagés";
            }
            else
            {
                condition = "Livre en mauvaise condition";
            }

            if (leLivre.FK_transactionType == 1)
            {
                transaction = "À vendre";
            }
            else
            {
                transaction = "À échanger";
            }





            string Livre = leLivre.Title + "/" + leLivre.Author + "/" + leLivre.Publishier + "/" + leLivre.Language +
                           "/" + leLivre.Categorie + "/" + leLivre.price + "/" + leLivre.PageCpt.ToString() + "/" +
                           condition + "/" + transaction;

            Envoyer(Livre, sock);
        }
        private static void AjoutLivre(Socket sock, DataBaseService dbServiceUser)// fait (ajouter livre dans la base de données)
        {
            byte[] buffer = new byte[10000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);

            string Livre = BytesToString(buffer);
            string[] livreDecode = Decoder(Livre);

            NewBook NouveauLivre = new NewBook();

            int noCode = int.Parse(livreDecode[0]);
            if (noCode == 0)
            {
                NouveauLivre.ISBN = livreDecode[1];
            }
            else if (noCode == 1)
            {
                NouveauLivre.EANcode = livreDecode[1];
            }
            else
            {
                NouveauLivre.UPCcode = livreDecode[1];
            }

            NouveauLivre.Title = livreDecode[2];
            NouveauLivre.Author = livreDecode[3];
            NouveauLivre.Publishier = livreDecode[4];
            NouveauLivre.Language = livreDecode[5];
            NouveauLivre.Categorie = livreDecode[6];

            NouveauLivre.FK_bookcondition = int.Parse(livreDecode[7]) + 1;



            NouveauLivre.FK_transactionType = int.Parse(livreDecode[8]) + 1;
            NouveauLivre.price = double.Parse(livreDecode[9]);
            NouveauLivre.PageCpt = int.Parse(livreDecode[10]);
            NouveauLivre.FK_coop_ref = int.Parse(livreDecode[11]) + 1; //le munérode la coop dans l'ordre envoyé commance à 0 dans le tableau(à vérifier)
            dbServiceUser.RegisterBook(NouveauLivre);
        }

        private static void EnvoyerLivres(Socket sock) // vérifié et fonctionne (recherche du livre par isbn/ean/upc)
        {
            byte[] buffer = new byte[10000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            string Code = BytesToString(buffer);

            BookSeachService bookSeach = new BookSeachService("gestionnaireBD", "AIzaSyAKEJaaZvVIMzPCOxqScfyP5UKcrtpjS4c");

            Task<Volume> livreTask = bookSeach.SearchBookISBN(Code);

            Volume result = livreTask.Result;


            //--------------------------------------------------
            string titre = result.VolumeInfo.Title;
            string auteur = "";
            string editeur = result.VolumeInfo.Publisher;
            string langue = result.VolumeInfo.Language;
            string cathegorie = "";
            double prix = 0;
            if (result.VolumeInfo.Authors != null)
            {
                auteur = result.VolumeInfo.Authors.FirstOrDefault();
            }
            if (result.VolumeInfo.Categories != null)
            {
                cathegorie = result.VolumeInfo.Categories.FirstOrDefault();
            }
            int nbDePages = 0;
            nbDePages = result.VolumeInfo.PageCount.Value;
            //--------------------------------------------------

            string envoi = titre + "/" + auteur + "/" + editeur + "/" + langue + "/" + cathegorie + "/" +
                           prix.ToString("0.##") + "/" + nbDePages.ToString();
            Envoyer(envoi, sock);
        }
        private static User Connexion(Socket sock, DataBaseService dbServiceUser) // fonctionne
        {
            byte[] buffer = new byte[10000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            string nomUtilisateur = BytesToString(buffer);

            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            string motDePasse = BytesToString(buffer);

            int loginID = dbServiceUser.loginID = dbServiceUser.CheckLogInCredentials(nomUtilisateur, motDePasse);
            User utilisateur = dbServiceUser.RetrieveSpecificUser(loginID);

            if (loginID == -1)
            {
                Envoyer("/Invalide", sock);
            }
            else if (utilisateur.UserTypeID == 2)
            {
                Envoyer("/Gestionnaire", sock);
            }
            else if (utilisateur.UserTypeID == 1)
            {
                Envoyer("/Client", sock);
            }
            else
            {
                Envoyer("/Invalide", sock);
            }
            return utilisateur;
        }
    }
}