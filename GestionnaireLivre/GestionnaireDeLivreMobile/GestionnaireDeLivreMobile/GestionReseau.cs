using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GestionnaireDeLivreMobile
{
    static class GestionReseau
    {

        private static Socket _sock;


#region commandes
        public static string BytesToString(byte[] bytes)
        {
            string temp = Encoding.UTF8.GetString(bytes);
            return temp.Replace("\0", "");
        }

        public static byte[] StringToBytes(string message)
        {
            return Encoding.UTF8.GetBytes(message);
        }

        public static void Envoyer(string message)
        {
            byte[] buffer = new byte[1000];
            buffer = StringToBytes(message);
            _sock.Send(buffer, 0, buffer.Length, SocketFlags.None);
            Thread.Sleep(100);
        }

        private static string[] Decoder(string message)
        {
           return  message.Split('/');
        }
#endregion 
        public static void SeConnecter(IPAddress ip)
        {
            _sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(ip, 1212);
            _sock.Connect(iep);
        }

        public static IPAddress RecevoirIP()
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Broadcast, 9900);

            byte[] data = Encoding.ASCII.GetBytes("/getIP");

            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            sock.SendTo(data, iep);
            sock.Close();



            UdpClient client = new UdpClient(11000);
            IPEndPoint iep2 = new IPEndPoint(IPAddress.Any, 11000);

            Byte[] receiveBytes = client.Receive(ref iep2);

            return iep2.Address;

        }
        public static void EnvoyerNomUtilisateurEtMdp(string nomUtilisateur, string motDePasse)
        {
            Envoyer("/VerificationUtilisateur");
            Envoyer(nomUtilisateur);   
            Envoyer(motDePasse);
        }

        public static string[] DemanderLivreNo(int numero)
        {
            Envoyer("/DemandeLivres");
            Envoyer(numero.ToString());
            return Decoder(Recevoir());
        }

        public static void EnvoyerNouveauLivre(int noCode, string code , string titre , string auteur , string editeur , string langue , string cathegorie , string etat , string transaction , string prix , string nbDePages, string coop)
        {
            Envoyer("/AjoutLivre");
            string envoi = noCode.ToString() + "/" + code + "/" + titre + "/" + auteur + "/" + editeur +
                           "/" + langue + "/" + cathegorie + "/" + etat + "/" + transaction + "/" + prix +
                           "/" + nbDePages + "/" + coop;
            Envoyer(envoi);
        }

        public static string[] DemanderListeLivreDansLaCoop()
        {
            Envoyer("/DemandeListeLivres");
            return Decoder(Recevoir());
        }
        public static string[] DemaderListeCoop()
        {
            Envoyer("/DemandeListeCoop");
            return Decoder(Recevoir());
        }
        public static string[] DemanderInfoLivre(string code)
        {
            Envoyer("/DemandeInformationLivre");
            Envoyer(code);

            return Decoder(Recevoir());
        }

        public static string Recevoir()
        {
            byte[] buffer = new byte[1000];
            _sock.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            return BytesToString(buffer);
        }

        public static void FermerConnexion()
        {
            byte[] buffer = new byte[1000];
            buffer = StringToBytes("/Quitter");
            _sock.Send(buffer, 0, buffer.Length, SocketFlags.None);
            _sock.Shutdown(SocketShutdown.Both);
            _sock.Close();
        }
    }
}