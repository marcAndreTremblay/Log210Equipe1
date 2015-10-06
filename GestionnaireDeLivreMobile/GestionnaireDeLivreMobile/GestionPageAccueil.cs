using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Java.Security;

namespace GestionnaireDeLivreMobile
{
	[Activity (Label = "Accueil", MainLauncher = false, Icon = "@drawable/icon")]
	public class GestionPageAccueil : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.PageAccueil);

			// Get our button from the layout resource,
			// and attach an event to it
			TextView valeurLivres = FindViewById<TextView> (Resource.Id.texteValeurLivre);
		    Button deconnexion = FindViewById<Button>(Resource.Id.boutonDeconexion);
		    Button ajouterLivre = FindViewById<Button>(Resource.Id.boutonAjouterLivre);


            deconnexion.Click += delegate
            {
                var pageCreationCompteEtudiant = new Intent(this, typeof(GestionPageConnexion));
                pageCreationCompteEtudiant.PutExtra("FirstData", "Data from FirstActivity");
                StartActivity(pageCreationCompteEtudiant);
            };
            ajouterLivre.Click += delegate
            {
                var pageCreationCompteEtudiant = new Intent(this, typeof(GestionPageAjoutLivre));
                pageCreationCompteEtudiant.PutExtra("FirstData", "Data from FirstActivity");
                StartActivity(pageCreationCompteEtudiant);
            };
		    
		}
	}
}

