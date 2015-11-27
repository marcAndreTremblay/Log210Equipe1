using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Java.Security;

namespace GestionnaireDeLivreMobile
{
	[Activity (Label = "Accueil", MainLauncher = false, Icon = "@drawable/icon")]
	public class GestionPageAfficherLivre : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
		    int noLivre = int.Parse(Intent.GetStringExtra("Data"));
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.PageAfficherLivre);

			// Get our button from the layout resource,
			// and attach an event to it
            TextView titre = FindViewById<TextView>(Resource.Id.texteTitre);
            TextView auteur = FindViewById<TextView>(Resource.Id.texteAuteur);
            TextView cathegorie = FindViewById<TextView>(Resource.Id.texteCategorie);
            TextView editeur = FindViewById<TextView>(Resource.Id.texteEditeur);
		    TextView langue = FindViewById<TextView>(Resource.Id.texteLangue);
            TextView prix = FindViewById<TextView>(Resource.Id.textePrix);
		    TextView nbPages = FindViewById<TextView>(Resource.Id.texteNbPage);
            TextView condition = FindViewById<TextView>(Resource.Id.texteCondition);
            TextView typeTransaction = FindViewById<TextView>(Resource.Id.texteTypeTransaction);

		    string[] leLivre = GestionReseau.DemanderLivreNo(noLivre);
		    titre.Text = "Titre: " + leLivre[0];
            auteur.Text = "Auteur: " +  leLivre[1];
            editeur.Text = "Éditeur: " + leLivre[2];
            langue.Text = "Langue: " + leLivre[3];
            cathegorie.Text = "Cathégorie: " + leLivre[4];
            prix.Text = "Prix: " + leLivre[5];
            nbPages.Text = "Nb de pages: " + leLivre[6];
		    condition.Text = "Condition: " + leLivre[7];
		    typeTransaction.Text = leLivre[8];
		}
	}
}

