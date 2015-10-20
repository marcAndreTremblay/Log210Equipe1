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

            Spinner spinnerCode = FindViewById<Spinner>(Resource.Id.spinnerCode);
            Spinner spinnerConditionLivre = FindViewById<Spinner>(Resource.Id.spinnerConditionLivre);
            Spinner spinnerTypeTransaction = FindViewById<Spinner>(Resource.Id.spinnerTypeTransaction);
		    Button chercher = FindViewById<Button>(Resource.Id.boutonChercher);
            //Button ajouterLivre = FindViewById<Button>(Resource.Id.boutonAjouterLivre);
		    EditText code = FindViewById<EditText>(Resource.Id.champCode);


            spinnerConditionLivre.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapterConditionLivre = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.liste_etats, Android.Resource.Layout.SimpleSpinnerItem);

            adapterConditionLivre.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerConditionLivre.Adapter = adapterConditionLivre;




            spinnerTypeTransaction.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapterTransaction = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.liste_transactions, Android.Resource.Layout.SimpleSpinnerItem);

            adapterTransaction.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerTypeTransaction.Adapter = adapterTransaction;



            spinnerCode.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapterCode = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.liste_code, Android.Resource.Layout.SimpleSpinnerItem);

            adapterCode.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerCode.Adapter = adapterCode;

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

