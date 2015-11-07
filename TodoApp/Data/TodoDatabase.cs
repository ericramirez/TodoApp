using System;
using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using SQLite.Net;

namespace TodoApp
{
	public class TodoDatabase
	{

		private SQLiteConnection database;
		static object locker = new object();

		public TodoDatabase ()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			database.CreateTable<TodoItem> ();

		}

		public TodoItem GetTodo(int id)
		{
			lock (locker) {

				return database.Table<TodoItem> ().Where (c => c.ID == id).FirstOrDefault ();
			}
		}

		public IEnumerable<TodoItem> GetToDos()
		{
			lock (locker) {
				return (from c in database.Table<TodoItem>() select c).ToList();
			}
		}

		public int SaveToDo(TodoItem todoItem)
		{

			lock (locker) {
			
				if (todoItem.ID != 0) {
					database.Update (todoItem);
					return todoItem.ID;
				
				} else {

					return database.Insert (todoItem);
				}
			}
			
		}
	}
}

