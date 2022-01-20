using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

using Ticket_App.Droid;
using Xamarin.Forms;
[assembly: Dependency(typeof(SQLite_Android))]

namespace Ticket_App.Droid
{
    public class SQLite_Android : SQLight_Interface
    {
        public SQLiteConnection GetConnection()
        {
            var DB_Name = "My_DB.sql";
            var DB_Path = System.Environment.GetFolderPath(
                System.Environment.SpecialFolder.ApplicationData);
            var Full_Path = System.IO.Path.Combine(DB_Path, DB_Name);
            var Conn = new SQLiteConnection(Full_Path);
            return Conn;
        }
    }
}
