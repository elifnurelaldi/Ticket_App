using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ticket_App.My_DB
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
