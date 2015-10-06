using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using GestionnaireDeLivreMobile.Resources;

namespace GestionnaireDeLivreMobile
{
	[Activity (Label = "GestionnaireDeLivre", MainLauncher = true, Icon = "@drawable/icon")]
	public class GestionPageConnection : Activity
	{
		int count = 100;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.PageConnection);

			// Get our button from the layout resource,
			// and attach an event to it
			Button SeConnecter = FindViewById<Button> (Resource.Id.boutonSeConnecter);
			EditText Courriel = FindViewById<EditText> (Resource.Id.champIdentifiant);
			EditText MotDePasse = FindViewById<EditText> (Resource.Id.champMotDePasse);
			TextView ErreurLogin = FindViewById<TextView> (Resource.Id.texteErreurLogin);

			// si on modifie le mot de passe ou le nom d'utilisateur
			MotDePasse.TextChanged += delegate {
				if (Courriel.Text.Length > 0 && MotDePasse.Text.Length > 0) 
				{
					SeConnecter.Enabled = true;
				}
				else 
				{
					SeConnecter.Enabled = false;
				}
			};
			Courriel.TextChanged += delegate {
				if (Courriel.Text.Length > 0 && MotDePasse.Text.Length > 0) 
				{
					SeConnecter.Enabled = true;
				}
				else 
				{
					SeConnecter.Enabled = false;
				}
			};
			//-------------------------

			//si on clique sur se connecter 
			SeConnecter.Click += delegate 
			{
				if (false) //-------------------si est pas dans la base de données-------------------------
				{
					ErreurLogin.Text = "Courriel ou mot de passe invalide";
				}
				else 
				{
					var pageCreationCompteEtudiant = new Intent(this, typeof(GestionPageCreationCompteEtudiant));
					pageCreationCompteEtudiant.PutExtra("FirstData", "Data from FirstActivity");
					StartActivity (pageCreationCompteEtudiant);
				}

			};
			//--------------------------
		}
	}
}

