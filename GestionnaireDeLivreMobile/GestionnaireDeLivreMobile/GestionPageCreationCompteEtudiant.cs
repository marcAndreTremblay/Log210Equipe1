using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace GestionnaireDeLivreMobile
{
	[Activity (Label = "Création d'un compte étudiant", MainLauncher = false, Icon = "@drawable/icon")]
	public class GestionPageCreationCompteEtudiant : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.PageCreationCompteEtudiant);

			// Get our button from the layout resource,
			// and attach an event to it
			Button creerCompte = FindViewById<Button> (Resource.Id.boutonCreerCompte);
			EditText courriel = FindViewById<EditText> (Resource.Id.champCourriel);
			EditText motDePasse = FindViewById<EditText> (Resource.Id.champMotDePasse);
            EditText confirmationMotDePasse = FindViewById<EditText> (Resource.Id.champConfirmationMotDePasse);
		    EditText telephone = FindViewById<EditText>(Resource.Id.champTelephone);
			TextView erreurLogin = FindViewById<TextView> (Resource.Id.texteErreurLogin);

            // si on modifie un champ

            courriel.TextChanged += delegate
            {
                if ((courriel.Text.Length > 0 || telephone.Text.Length > 0) && motDePasse.Text.Length > 0 && confirmationMotDePasse.Text.Length > 0)
                {
                    creerCompte.Enabled = true;
                }
                else
                {
                    creerCompte.Enabled = false;
                }
            };
            telephone.TextChanged += delegate
            {
                if ((courriel.Text.Length > 0 || telephone.Text.Length > 0) && motDePasse.Text.Length > 0 && confirmationMotDePasse.Text.Length > 0)
                {
                    creerCompte.Enabled = true;
                }
                else
                {
                    creerCompte.Enabled = false;
                }
            };
            motDePasse.TextChanged += delegate
            {
                if ((courriel.Text.Length > 0 || telephone.Text.Length > 0) && motDePasse.Text.Length > 0 && confirmationMotDePasse.Text.Length > 0)
                {
                    creerCompte.Enabled = true;
                }
                else
                {
                    creerCompte.Enabled = false;
                }
            };
            confirmationMotDePasse.TextChanged += delegate
            {
                if ((courriel.Text.Length > 0 || telephone.Text.Length > 0) && motDePasse.Text.Length > 0 && confirmationMotDePasse.Text.Length > 0)
                {
                    creerCompte.Enabled = true;
                }
                else
                {
                    creerCompte.Enabled = false;
                }
            };
            //-------------------------
			creerCompte.Click += delegate 
            {
                if (!courriel.Text.Contains("@") || !courriel.Text.Contains("."))
                {
                    erreurLogin.Text = "Courriel non valide";
                }
                else if (motDePasse.Text != confirmationMotDePasse.Text)
                {
                    erreurLogin.Text = "Mots de passes différents";
                }
                else
                {
                    //se qui sera fait quand on crée un compte----------------------------
                    var pageCreationCompteEtudiant = new Intent(this, typeof(GestionPageConnexion));
                    pageCreationCompteEtudiant.PutExtra("FirstData", "Data from FirstActivity");
                    StartActivity(pageCreationCompteEtudiant);
                }
				
			};
		}
	}
}


