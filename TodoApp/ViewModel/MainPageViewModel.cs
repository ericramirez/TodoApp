using System;
using System.Collections.Generic;

namespace TodoApp
{
	public class MainPageViewModel
	{
		public MainPageViewModel ()
		{
		}


		public void AddTask(string todo, bool isDeleted, int updatedID)
		{
			var newTodo = new TodoItem{ 
				Task = todo,
				ID = updatedID,
				IsDeleted = isDeleted
			};
			App.DataBase.SaveToDo (newTodo);
		}

	



	
	}
}

