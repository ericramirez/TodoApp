using System;
using SQLite.Net;
using SQLite.Net.Platform;
using System.IO;
using TodoApp.Droid;
using Xamarin.Forms;


[assembly: Dependency(typeof(AndroidSQLite))]
namespace TodoApp.Droid
{
	public class AndroidSQLite : ISQLite
	{
		public SQLiteConnection GetConnection ()
		{

			var filename = "Todo.db3";
			var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentspath, filename);


			var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
			var connection = new SQLite.Net.SQLiteConnection (platform, path);
			return connection;
		}
	}
}

