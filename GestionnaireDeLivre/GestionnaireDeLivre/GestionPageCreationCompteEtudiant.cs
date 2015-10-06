using Android.App;
using Android.OS;
using Android.Widget;
using GestionnaireDeLivreMobile.Resources;

namespace GestionnaireDeLivreMobile
{
	[Activity (Label = "GestionnaireDeLivre", MainLauncher = false, Icon = "@drawable/icon")]
	public class GestionPageCreationCompteEtudiant : Activity
	{
		int count = 100;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.PageCreationCompteEtudiant);

			// Get our button from the layout resource,
			// and attach an event to it
			Button creerCompte = FindViewById<Button> (Resource.Id.boutonCreerCompte);
			EditText Courriel = FindViewById<EditText> (Resource.Id.champCourriel);
			EditText MotDePasse = FindViewById<EditText> (Resource.Id.champMotDePasse);
			TextView ErreurLogin = FindViewById<TextView> (Resource.Id.texteErreurLogin);

			creerCompte.Click += delegate {
				creerCompte.Text = string.Format ("{0} clicks!", count++);
				ErreurLogin.Text = "erreur 1";
			};
		}
	}
}


