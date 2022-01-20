using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ticket_App
{
    public interface SQLight_Interface
    {
        SQLiteConnection GetConnection();
    }
}
