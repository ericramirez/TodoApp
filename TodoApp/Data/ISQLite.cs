using System;
using SQLite.Net;

namespace TodoApp
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

