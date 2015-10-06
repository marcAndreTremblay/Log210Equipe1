using System;
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

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.PageConnexion);

			// Get our button from the layout resource,
			// and attach an event to it
			Button seConnecter = FindViewById<Button> (Resource.Id.boutonSeConnecter);
            Button creerCompteEtudiant = FindViewById<Button>(Resource.Id.boutonCreerCompteEtudiant);
            Button creerCompteGestionnaire = FindViewById<Button>(Resource.Id.boutonCreerCompteGestionnaire);
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
				if (false) //-------------------si est pas dans la base de données-------------------------
				{
					erreurLogin.Text = "Courriel ou mot de passe invalide";
				}
				else 
				{
                    var pageCreationCompteEtudiant = new Intent(this, typeof(GestionPageAccueil));
                    pageCreationCompteEtudiant.PutExtra("FirstData", "Data from FirstActivity");
                    StartActivity(pageCreationCompteEtudiant);
				}

			};
			//--------------------------

            creerCompteEtudiant.Click += delegate
            {
                var pageCreationCompteEtudiant = new Intent(this, typeof(GestionPageCreationCompteEtudiant));
                pageCreationCompteEtudiant.PutExtra("FirstData", "Data from FirstActivity");
                StartActivity(pageCreationCompteEtudiant);
            };
            creerCompteGestionnaire.Click += delegate
            {
                var pageCreationCompteEtudiant = new Intent(this, typeof(GestionPageCreationCompteGestionnaire));
                pageCreationCompteEtudiant.PutExtra("FirstData", "Data from FirstActivity");
                StartActivity(pageCreationCompteEtudiant);
            };
		    
		}
	}
}

