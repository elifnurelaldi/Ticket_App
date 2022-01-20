﻿using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using SQLite;

using Xamarin.Forms;
using Ticket_App.iOS;
[assembly: Dependency(typeof(SQLite_iOS))]

namespace Ticket_App.iOS
{
    public class SQLite_iOS : SQLight_Interface
    {
        public SQLiteConnection GetConnection()
        {
            var DB_Name = "My_DB.sql";
            var DB_Path = System.Environment.GetFolderPath(
                System.Environment.SpecialFolder.Personal);
            var Full_Path = System.IO.Path.Combine(DB_Path, DB_Name);
            var Conn = new SQLiteConnection(Full_Path);
            return Conn;
        }
    }
}
