using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TodoApp.Droid
{
	[Activity (Label = "TodoApp.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		private TaskManager taskManager;
		ListView taskListView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			SetContentView (Resource.Layout.Main);

			taskManager = new TaskManager ();

			Button button = FindViewById<Button> (Resource.Id.addButton);
			taskListView = FindViewById<ListView> (Resource.Id.listTasks);

			button.Click += delegate {
				var todoText = FindViewById<EditText> (Resource.Id.TodoItemText);
				taskManager.NewTodoItem.Text = todoText.Text;
				taskManager.AddTodoItem();

			};


			LoadApplication (new App ());
		}

		protected override void OnResume()
		{
			base.OnResume ();
			var TaskListAdapter = new TaskListAdapter (this, taskManager.TodoItems);
			taskListView.Adapter = TaskListAdapter;
		}
			
	}
}

