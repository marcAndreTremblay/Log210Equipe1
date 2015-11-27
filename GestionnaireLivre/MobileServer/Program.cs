﻿using System;
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
        private static DataBaseService dbService;
        static void Main(string[] args)
        {
            dbService = new DataBaseService();
            


            List<Thread> listeThreads = new List<Thread>();
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            Console.WriteLine(hostName);
            // Get the IP
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Console.WriteLine("My IP Address is :" + myIP);


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
                        Console.WriteLine("Received " + iep.Address);

                        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,ProtocolType.Udp);

                        IPEndPoint endPoint = new IPEndPoint(iep.Address, 11000);
                        Thread.Sleep(200);
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


        private static void Envoyer(string message,Socket sock)
        {
            byte[] buffer = new byte[1000];
            buffer = StringToBytes(message);
            sock.Send(buffer, 0, buffer.Length, SocketFlags.None);
            Thread.Sleep(100);
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
            while (Operation != "/Quitter")
            {
                byte[] buffer = new byte[1000];
                sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);

                Operation = BytesToString(buffer);

                Console.WriteLine(Operation);
                if (Operation == "/VerificationUtilisateur")
                {
                    Connexion(sock);
                }
                else if (Operation == "/DemandeInformationLivre")
                {
                    EnvoyerLivres(sock);
                }
                else if (Operation == "/AjoutLivre")
                {
                    AjoutLivre(sock);
                }
                else if (Operation == "/DemandeLivres")
                {
                    EnvoyerInformationLivre(sock);
                }
                else if (Operation == "/DemandeListeCoop")
                {
                    EnvoyerListeCoop(sock);
                }
                else if (Operation == "/DemandeListeLivres")
                {
                    EnvoyerListeLivres(sock);
                }


                
            }

            sock.Shutdown(SocketShutdown.Both);
            sock.Close();
        }

        private static void EnvoyerListeLivres(Socket sock) // a completer (liste des livres)
        {
            string listeLivres = "";
            List<Book> lesLivres = dbService.RetriveAllBooks(); //Utilier la nouvelle commande

            for (int i = 0; i < listeLivres.Length; i++)
            {
                if (i < listeLivres.Length - 1)
                {
                    listeLivres = listeLivres + lesLivres[i].Title + "/";
                }
                else
                {
                    listeLivres = listeLivres + lesLivres[i].Title;
                }
            }
            Envoyer(listeLivres, sock);
        }

        private static void EnvoyerListeCoop(Socket sock) // (liste des coops)
        {
            string listeCoop = "";
            List<Cooperative> listeCoops = dbService.RetrieveCooperatives();
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
        private static void EnvoyerInformationLivre(Socket sock) // a completer (info du livre dans la liste de livre)
        {


            byte[] buffer = new byte[1000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);

            string temp = BytesToString(buffer);
            int numeroDuLivre = int.Parse(temp);

            List<Book> lesLivres = dbService.RetriveAllBooks(); //Utilier la nouvelle commande

            Book leLivre = lesLivres[numeroDuLivre - 1];

            string condition;
            string transaction;
            //----------------------------------------------
            if (leLivre.FK_bookcondition == 0)
            {
                condition = "";
            }
            else if (leLivre.FK_bookcondition == 1)
            {
                condition = "";
            }
            else
            {
                condition = "";
            }

            if (leLivre.FK_transactionType == 0)
            {
                transaction = "";
            }
            else if (leLivre.FK_transactionType == 1)
            {
                transaction = "";
            }
            else
            {
                transaction = "";
            }

            //------------------------------------------------



            //ajouter le nombre de page
            string Livre = leLivre.Title + "/" + leLivre.Author + "/" + leLivre.Publishier + "/" + leLivre.Language +
                           "/" + leLivre.Categorie + "/" + leLivre.price + /* "/" + leLivre.NOMBREDEPAGE*/ "/ 12" + "/" +
                           condition + "/" + transaction;

            Envoyer(Livre, sock);
        }
        private static void AjoutLivre(Socket sock)// a completer (ajouter livre dans la base de données)
        {
            byte[] buffer = new byte[1000];
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
            
            string etat = livreDecode[7]; // a faire

            string transaction = livreDecode[8]; // a faire
            NouveauLivre.price = double.Parse(livreDecode[9]);
            string nbDePages = livreDecode[10]; // a faire
            NouveauLivre.FK_coop_ref = int.Parse(livreDecode[11]); //le munérode la coop dans l'ordre envoyé commance à 0 (à vérifier)


            dbService.RegisterBook(NouveauLivre);
        }

        private static void EnvoyerLivres(Socket sock) // a completer (recherche du livre par isbn/ean/upc)
        {
            byte[] buffer = new byte[1000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            string Code = BytesToString(buffer); // utiliser le code pour trouver les informations ci-dessous

            BookSeachService bookSeach = new BookSeachService("gestionnaireBD", "AIzaSyAKEJaaZvVIMzPCOxqScfyP5UKcrtpjS4c");

            Task<Volume> livreTask = bookSeach.SearchBookISBN(Code);

            Volume result = livreTask.Result;


            //--------------------------------------------------
            string titre = result.VolumeInfo.Title;
            string auteur = result.VolumeInfo.Authors.FirstOrDefault();
            string editeur = result.VolumeInfo.Publisher;
            string langue = result.VolumeInfo.Language;
            string cathegorie = result.VolumeInfo.Categories.FirstOrDefault();
            double prix = 10;
            int nbDePages = 0;
            nbDePages = result.VolumeInfo.PageCount.Value; // verifier
            //--------------------------------------------------

            string envoi = titre + "/" + auteur + "/" + editeur + "/" + langue + "/" + cathegorie + "/" +
                           prix.ToString("0.##") + "/" + nbDePages.ToString();
            Envoyer(envoi, sock);
        }
        private static void Connexion(Socket sock) //a completer
        {
            byte[] buffer = new byte[1000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            string nomUtilisateur = BytesToString(buffer);

            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            string motDePasse = BytesToString(buffer);

            int loginID = dbService.CheckLogInCredentials(nomUtilisateur, motDePasse);// faire quelquechose avec

            if (loginID == -1)
            {
                Envoyer("/Invalide", sock);
            }
            else if (nomUtilisateur == motDePasse && motDePasse == "gestionnaire") // mettre la bonne logique
            {
                Envoyer("/Gestionnaire", sock);
            }
            else
            {
                Envoyer("/Client", sock);
            }
        }
    }
}


