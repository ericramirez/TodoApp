using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TodoApp
{
	public partial class DisplayTasksPage : ContentPage
	{
		public DisplayTasksPage ()
		{
			InitializeComponent ();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing ();
			TaskList.ItemsSource = App.DataBase.GetToDos ();
		}
	}
}

