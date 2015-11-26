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

namespace MobileServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataBaseService dbService = new DataBaseService();
            


            List<Thread> listeThreads = new List<Thread>();
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.0.101"), 1212);
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

        private static void Envoyer(string message,Socket sock)
        {
            byte[] buffer = new byte[1000];
            buffer = StringToBytes(message);
            sock.Send(buffer, 0, buffer.Length, SocketFlags.None);
            Thread.Sleep(100);
        }

        private static string BytesToString(byte[] bytes)
        {
            string temp = Encoding.ASCII.GetString(bytes);
            return temp.Replace("\0", "");
        }

        private static byte[] StringToBytes(string message)
        {
            return Encoding.ASCII.GetBytes(message);
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
            string listeLivres = "titre1/titre2/titre3/titre4/titre5/titre6/titre7/titre8/titre9/titre10/titre2/titre3/titre4/titre5/titre6/titre7/titre8/titre9/titre10/titre2/titre3/titre4/titre5/titre6/titre7/titre8/titre9/titre10/titre2/titre3/titre4/titre5/titre6/titre7/titre8/titre9/titre10/titre2/titre3/titre4/titre5/titre6/titre7/titre8/titre9/titre10"; // mettre les bon titre selon la coop
            Envoyer(listeLivres, sock);
        }
        private static void EnvoyerListeCoop(Socket sock) // a completer (liste des coops)
        {
            string Coops = "Coop1/Coop2/Coop3"; // donner les vrais coop séparer par /
            Envoyer(Coops, sock);
        }
        private static void EnvoyerInformationLivre(Socket sock) // a completer (info du livre dans la liste de livre)
        {


            byte[] buffer = new byte[1000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);

            string temp = BytesToString(buffer);
            int numeroDuLivre = int.Parse(temp);
            string Livre = // mettre les bonnes infos (le livre avec l'ID numeroDuLivre) et les séparer de "/"
                "Titre/Auteur/Éditeur/Langue/Cathégorie/prix/Nb de pages/condition/a echanger";

            Envoyer(Livre, sock);
        }
        private static void AjoutLivre(Socket sock)// a completer (ajouter livre dans la base de données)
        {
            byte[] buffer = new byte[1000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);

            string Livre = BytesToString(buffer);
            string[] livreDecode = Decoder(Livre);

            int noCode = int.Parse(livreDecode[0]);
            if (noCode == 0)
            {
                int ISBN = int.Parse(livreDecode[1]);
            }
            else if (noCode == 1)
            {
                int EAN = int.Parse(livreDecode[1]);
            }
            else
            {
                int UPC = int.Parse(livreDecode[1]);
            }
            //--------Les mettre dans la base de données----------
            string titre = livreDecode[2];
            string auteur = livreDecode[3]; 
            string editeur= livreDecode[4];
            string langue = livreDecode[5];
            string cathegorie = livreDecode[6];
            string etat = livreDecode[7];
            string transaction = livreDecode[8];
            int prix = int.Parse(livreDecode[9]);
            string nbDePages = livreDecode[10];
            int coop = int.Parse(livreDecode[11]); //le munérode la coop dans l'ordre envoyé commance à 0
            //--------------------------------------------------
        }

        private static void EnvoyerLivres(Socket sock) // a completer (recherche du livre par isbn/ean/upc)
        {
            byte[] buffer = new byte[1000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            int Code = int.Parse(BytesToString(buffer)); // utiliser le code pour trouver les informations ci-dessous

            //--------------------------------------------------
            string titre = "t";
            string auteur = "a";
            string editeur = "e";
            string langue = "l";
            string cathegorie = "c";
            int prix = 10;
            int nbDePages = 100;
            //--------------------------------------------------

            string envoi = titre + "/" + auteur + "/" + editeur + "/" + langue + "/" + cathegorie + "/" +
                           prix.ToString() + "/" + nbDePages.ToString();
            Envoyer(envoi, sock);
        }
        private static void Connexion(Socket sock) //a completer
        {
            byte[] buffer = new byte[1000];
            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            string nomUtilisateur = BytesToString(buffer);

            sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            string motDePasse = BytesToString(buffer);

            if (nomUtilisateur == motDePasse && motDePasse == "client") // mettre la bonne logique
            {
                Envoyer("/Client", sock);
            }
            else if (nomUtilisateur == motDePasse && motDePasse == "gestionnaire") // mettre la bonne logique
            {
                Envoyer("/Gestionnaire", sock);
            }
            else
            {
                Envoyer("/Invalide", sock);
            }
        }
    }
}



