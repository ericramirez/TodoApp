using System;
//using TodoApp;
using Android.Views;

using Android.App;
using System.Collections.ObjectModel;
using Android.Widget;

namespace TodoApp.Droid
{
	public class TaskListAdapter : BaseAdapter<TodoItem>
	{
		protected Activity context = null;
		protected ObservableCollection<TodoItem> tasks;

		public TaskListAdapter (Activity context, ObservableCollection<TodoItem> tasks) : base()
		{
			this.context = context;
			this.tasks = tasks;
			tasks.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) => {
				this.NotifyDataSetChanged();
			};
		}

		public override TodoItem this[int position]
		{
			get { return tasks [position]; }
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override int Count
		{
			get { return tasks.Count; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var item = tasks [position];

			var view = (convertView ??
			           context.LayoutInflater.Inflate (
				           global::Android.Resource.Layout.SimpleListItemChecked,
				           parent,
				           false)) as CheckedTextView;


			view.SetText (item.Text, TextView.BufferType.Normal);
			view.Checked = item.IsCompleted;


			return view;


			
		}
		
	}
}

