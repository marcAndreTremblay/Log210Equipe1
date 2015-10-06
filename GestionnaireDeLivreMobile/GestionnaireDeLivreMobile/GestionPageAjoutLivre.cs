using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Java.Security;

namespace GestionnaireDeLivreMobile
{
	[Activity (Label = "Ajouter un livre", MainLauncher = false, Icon = "@drawable/icon")]
	public class GestionPageAjoutLivre : Activity
	{
	    private int position = 0;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.PageAjoutLivre);

			// Get our button from the layout resource,
			// and attach an event to it

            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner);
		    Button chercher = FindViewById<Button>(Resource.Id.boutonChercher);
		    Button ajouterLivre = FindViewById<Button>(Resource.Id.boutonAjouterLivre);
		    EditText code = FindViewById<EditText>(Resource.Id.champCode);
		    TextView valeurLivre = FindViewById<TextView>(Resource.Id.texteInfoLivre);

            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.liste_code, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;

		    code.TextChanged += delegate
		    {
		        if (code.Text.Length > 0)
		        {
		            chercher.Enabled = true;
		        }
		        else
		        {
		            chercher.Enabled = false;
		        }
		    };
		    chercher.Click += delegate
		    {
                string toast = string.Format("Vous avez choisi {0}", spinner.GetItemAtPosition(position));
                Toast.MakeText(this, toast, ToastLength.Long).Show();
                // afficher les info sur le livre
		    };

		}
        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            position = e.Position;
            Spinner spinner = (Spinner)sender;
            string toast = string.Format("Vous avez choisi {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
	}
}

