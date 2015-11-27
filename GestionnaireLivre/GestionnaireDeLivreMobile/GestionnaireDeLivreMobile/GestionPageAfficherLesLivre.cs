using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Java.Security;

namespace GestionnaireDeLivreMobile
{
	[Activity (Label = "Accueil", MainLauncher = false, Icon = "@drawable/icon")]
	public class GestionPageAfficherLesLivre : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.PageAfficherLesLivres);

			// Get our button from the layout resource,
			// and attach an event to it
            TextView listeLivres = FindViewById<TextView>(Resource.Id.texteListeLivres);
		    TextView noLivre = FindViewById<TextView>(Resource.Id.champNumeroLivre);
		    Button afficher = FindViewById<Button>(Resource.Id.bouttonChercherLeLivre);
		    int count = 0;
		    listeLivres.Text = "";
		    string[] ListeLivres =  GestionReseau.DemanderListeLivreDansLaCoop();
		    


		    foreach (string VARIABLE in ListeLivres)
		    {
		        if (VARIABLE != "")
		        {
		            count++;
		            listeLivres.Text = listeLivres.Text + count + "- " + VARIABLE + "\n";
		        }

		    }
            afficher.Enabled = false;
            noLivre.TextChanged += delegate
            {
                try
                {
                    if (int.Parse(noLivre.Text) < 0)
                    {
                        afficher.Enabled = true;
                    }
                    else
                    {
                        afficher.Enabled = false;
                    }
                }
                catch (Exception e)
                {
                }
            };


            afficher.Click += delegate
            {
                var prochainePage = new Intent(this, typeof(GestionPageAfficherLivre));
                prochainePage.PutExtra("Data", noLivre.Text);
                StartActivity(prochainePage);
            };

		}
	}
}

