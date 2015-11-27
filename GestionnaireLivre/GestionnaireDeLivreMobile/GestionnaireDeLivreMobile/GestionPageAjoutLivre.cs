using System;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Google.Apis.Books.v1.Data;
using Java.Security;
using ZXing.Mobile;
using Resource = Android.Resource;

namespace GestionnaireDeLivreMobile
{
    [Activity(Label = "Ajouter un livre", MainLauncher = false, Icon = "@drawable/icon")]
    public class GestionPageAjoutLivre : Activity
    {
        private EditText code;
        private int position = 0;
        private int noCode = 0;
        private string etat = "Comme neuf";
        private string transaction = "À vendre";



        MobileBarcodeScanner scanner;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            MobileBarcodeScanner.Initialize(Application);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.PageAjoutLivre);
            scanner = new MobileBarcodeScanner();
            // Get our button from the layout resource,
            // and attach an event to it

            Spinner spinnerCode = FindViewById<Spinner>(Resource.Id.spinnerCode);
            Spinner spinnerConditionLivre = FindViewById<Spinner>(Resource.Id.spinnerConditionLivre);
            Spinner spinnerTypeTransaction = FindViewById<Spinner>(Resource.Id.spinnerTypeTransaction);
            Button chercher = FindViewById<Button>(Resource.Id.boutonChercher);
            Button scannerCode = FindViewById<Button>(Resource.Id.bouttonScanner);
            Button ajouterLivre = FindViewById<Button>(Resource.Id.boutonAjouterLivre);
            EditText auteur = FindViewById<EditText>(Resource.Id.champAuteur);
            //EditText code = FindViewById<EditText>(Resource.Id.champCode);
            EditText editeur = FindViewById<EditText>(Resource.Id.champEditeur);
            EditText titre = FindViewById<EditText>(Resource.Id.champTitre);
            EditText langue = FindViewById<EditText>(Resource.Id.champLangue);
            EditText cathegorie = FindViewById<EditText>(Resource.Id.champCathegorie);
            EditText prix = FindViewById<EditText>(Resource.Id.champPrix);
            EditText nbPages = FindViewById<EditText>(Resource.Id.champNbPages);
            TextView lesCoops = FindViewById<TextView>(Resource.Id.texteCoopZZ);
            EditText noCoop = FindViewById<EditText>(Resource.Id.champNoCoop);
            TextView erreur = FindViewById<TextView>(Resource.Id.texteErreur);

            lesCoops.Text = "";
            int count = 0;
            string[] listeCoop = GestionReseau.DemaderListeCoop();
            foreach (string coop in listeCoop)
            {
                lesCoops.Text = lesCoops.Text + "#" + count + "- " + coop + "\n";
                count++;
            }

            code = FindViewById<EditText>(Resource.Id.champCode);


            ajouterLivre.Click += async delegate
            {
                try
                {
                    if (int.Parse(noCoop.Text) <= count)
                    {
                        GestionReseau.EnvoyerNouveauLivre(noCode, code.Text, titre.Text, auteur.Text, editeur.Text, langue.Text,
                            cathegorie.Text, etat, transaction, prix.Text, nbPages.Text, noCoop.Text.ToString());
                        code.Text = "";
                        titre.Text = "Titre";
                        auteur.Text = "Auteur";
                        editeur.Text = "Éditeur";
                        langue.Text = "Langue";
                        cathegorie.Text = "Cathégorie";
                        prix.Text = "Prix";
                        nbPages.Text = "Nb de pages"; 
                    }
                    else
                    {
                        erreur.Text = "Coop Invalide";
                    }
                }
                catch (Exception e)
                {
                    erreur.Text = "erreur";
                }
                
            };



            scannerCode.Click += async delegate
            {

                //Tell our scanner to use the default overlay
                scanner.UseCustomOverlay = false;

                //We can customize the top and bottom text of the default overlay
                scanner.TopText = "Hold the camera up to the barcode\nAbout 6 inches away";
                scanner.BottomText = "Wait for the barcode to automatically scan!";

                //Start scanning
                var result = await scanner.Scan();

                HandleScanResult(result);
            };




            spinnerConditionLivre.ItemSelected +=
                new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelectedEtat);
            var adapterConditionLivre = ArrayAdapter.CreateFromResource(
                this, Resource.Array.liste_etats, Android.Resource.Layout.SimpleSpinnerItem);

            adapterConditionLivre.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerConditionLivre.Adapter = adapterConditionLivre;


            spinnerTypeTransaction.ItemSelected +=
                new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelectedTransaction);
            var adapterTransaction = ArrayAdapter.CreateFromResource(
                this, Resource.Array.liste_transactions, Android.Resource.Layout.SimpleSpinnerItem);

            adapterTransaction.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerTypeTransaction.Adapter = adapterTransaction;


            spinnerCode.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelectedCode);
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
               //-------
                string[] info = GestionReseau.DemanderInfoLivre(code.Text);
                titre.Text = info[0];
                auteur.Text = info[1];
                editeur.Text = info[2];
                langue.Text = info[3];
                cathegorie.Text = info[4];
                prix.Text = info[5];
                nbPages.Text = info[6];
            };
        }

        private void spinner_ItemSelectedCode(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            string Code = string.Format("{0}", spinner.GetItemAtPosition(e.Position));
            if (Code == "ISBN")
            {
                noCode = 0;
            }
            else if (Code == "EAN")
            {
                noCode = 1;
            }
            else
            {
                noCode = 2;
            }
        }
        private void spinner_ItemSelectedEtat(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            etat = string.Format("{0}", spinner.GetItemAtPosition(e.Position));
        }

        private void spinner_ItemSelectedTransaction(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            transaction = string.Format("{0}", spinner.GetItemAtPosition(e.Position));
        }

        void HandleScanResult(ZXing.Result result)
        {
            string msg = "";

            if (result != null && !string.IsNullOrEmpty(result.Text+""))
            {
                msg = "Found Barcode: " + result.Text;

                code.Text = "" + result.Text;
            }
            else
            {
                msg = "Scanning Canceled!";
            }

            this.RunOnUiThread(() => Toast.MakeText(this, msg, ToastLength.Short).Show());
        }
    }
}