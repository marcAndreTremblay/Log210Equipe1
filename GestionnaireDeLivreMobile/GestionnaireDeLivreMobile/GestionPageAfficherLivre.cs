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

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.PageAfficherLivre);

			// Get our button from the layout resource,
			// and attach an event to it
            TextView titre = FindViewById<TextView>(Resource.Id.texteTitre);
            TextView auteur = FindViewById<TextView>(Resource.Id.texteAuteur);
            TextView cathegorie = FindViewById<TextView>(Resource.Id.texteCategorie);
            TextView editeur = FindViewById<TextView>(Resource.Id.texteEditeur);
            TextView prix = FindViewById<TextView>(Resource.Id.textePrix);
            TextView condition = FindViewById<TextView>(Resource.Id.texteCondition);
            TextView typeTransaction = FindViewById<TextView>(Resource.Id.texteTypeTransaction);
		}
	}
}

