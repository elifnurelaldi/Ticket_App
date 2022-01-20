using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using Ticket_App.My_DB;

namespace Ticket_App
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            Conn_Class.Conn = DependencyService.Get<SQLight_Interface>().GetConnection();
            Conn_Class.Conn.CreateTable<Customer>();
            Conn_Class.Conn.CreateTable<Film>();
        }
    }
}
