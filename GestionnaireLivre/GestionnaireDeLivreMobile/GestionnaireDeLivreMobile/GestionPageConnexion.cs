using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Java.Security;

namespace GestionnaireDeLivreMobile
{
	[Activity (Label = "Se connecter", MainLauncher = true, Icon = "@drawable/icon")]
	public class GestionPageConnexion : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            GestionReseau.SeConnecter(GestionReseau.RecevoirIP());


			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.PageConnexion);

			// Get our button from the layout resource,
			// and attach an event to it
			Button seConnecter = FindViewById<Button> (Resource.Id.boutonSeConnecter);
            Button quitter = FindViewById<Button>(Resource.Id.boutonQuitter); 
			EditText identifiant = FindViewById<EditText> (Resource.Id.champIdentifiant);
			EditText motDePasse = FindViewById<EditText> (Resource.Id.champMotDePasse);
			TextView erreurLogin = FindViewById<TextView> (Resource.Id.texteErreurLogin);



			// si on modifie le mot de passe ou le nom d'utilisateur
			motDePasse.TextChanged += delegate {
				if (identifiant.Text.Length > 0 && motDePasse.Text.Length > 0) 
				{
					seConnecter.Enabled = true;
				}
				else 
				{
					seConnecter.Enabled = false;
				}
			};
			identifiant.TextChanged += delegate {
				if (identifiant.Text.Length > 0 && motDePasse.Text.Length > 0) 
				{
					seConnecter.Enabled = true;
				}
				else 
				{
					seConnecter.Enabled = false;
				}
			};
			//-------------------------

			//si on clique sur se connecter 
			seConnecter.Click += delegate 
			{
                GestionReseau.EnvoyerNomUtilisateurEtMdp(identifiant.Text, motDePasse.Text);
                string typeCompte = GestionReseau.Recevoir();


				if (typeCompte == "/Gestionnaire") //-------------------Si est gestionnaire-------------------------
				{
                    var prochainePage = new Intent(this, typeof(GestionPageAfficherLesLivre));
                    prochainePage.PutExtra("FirstData", "Data from FirstActivity");
                    StartActivity(prochainePage);
				}
                else if (typeCompte == "/Client") //-------------------si est client-------------------------
				{
                    var prochainePage = new Intent(this, typeof(GestionPageAjoutLivre));
                    prochainePage.PutExtra("FirstData", "Data from FirstActivity");
                    StartActivity(prochainePage);
				}
                else //-------------------si est pas dans la base de données-------------------------
				{
				    erreurLogin.Text = "Courriel ou mot de passe invalide";
				}

			};
            quitter.Click += delegate
            {
                GestionReseau.FermerConnexion();
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            };
		}
	}
}

