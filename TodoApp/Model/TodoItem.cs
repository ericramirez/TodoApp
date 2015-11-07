using System;
using SQLite.Net.Attributes;
using System.Collections.Generic;


namespace TodoApp
{
	public class TodoItem 
	{
		[PrimaryKey, AutoIncrement]
		public int ID {
			get;
			set;
		}

		public string Task {
			get;
			set;
		}


		public bool IsDeleted {
			get;
			set;
		}
	}
}

