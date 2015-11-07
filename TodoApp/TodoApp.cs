using System;

using Xamarin.Forms;

namespace TodoApp
{
	public class App : Application
	{
		private static TodoDatabase database;

		public static TodoDatabase DataBase {
			get
			{
				if (database == null)
					database = new TodoDatabase ();
				return database;
			}

		}

		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

