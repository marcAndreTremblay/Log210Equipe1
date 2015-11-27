using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace GestionnaireDeLivreMobile.UITests
{
	[TestFixture]
	public class Tests
	{
		AndroidApp _app;

		[SetUp]
		public void BeforeEachTest ()
		{
			_app = ConfigureApp.Android.StartApp ();
		}

		[Test]
		public void ClickingButtonTwiceShouldChangeItsLabel ()
		{
			Func<AppQuery, AppQuery> myButton = c => c.Button ("myButton");

			_app.Tap (myButton);
			_app.Tap (myButton);
			AppResult[] results = _app.Query (myButton);
			_app.Screenshot ("Button clicked twice.");

			Assert.AreEqual ("2 clicks!", results [0].Text);
		}
	}
}

