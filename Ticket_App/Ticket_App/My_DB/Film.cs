using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ticket_App.My_DB
{
    public class Film
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FilmName { get; set; }
        public string SeatNumber { get; set; }
        
    }
}
