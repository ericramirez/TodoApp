using System;
using Xamarin.Forms;
using System.Collections.Generic;



namespace TodoApp
{
	public partial class MainPage : ContentPage
	{

		private MainPageViewModel _vm;
	

		public MainPage ()
		{
			_vm = new MainPageViewModel ();
			BindingContext = _vm;

			InitializeComponent ();
		}
			
		public void OnSave(object o, EventArgs e)
		{
			_vm.AddTask (
				Todo.Text,
				false,
				0
			);
			Clear ();

		}

		public void OnReview(object o, EventArgs e)
		{
			Clear ();
			Navigation.PushAsync (new DisplayTasksPage());
		
		}

		private void Clear()
		{
			Todo.Text = String.Empty;
		}
	}
}

