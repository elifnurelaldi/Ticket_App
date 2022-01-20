using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_App.My_DB;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Ticket_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_35_Clicked(object sender, EventArgs e)
        {
            var data = (from film in Conn_Class.Conn.Table<Film>() select film);
            Film_XAML_List.ItemsSource = data;
    
        }

        private void Button_36_Clicked(object sender, EventArgs e)
        {
            var data = (from cus in Conn_Class.Conn.Table<Customer>() select cus);
            Cus_XAML_List.ItemsSource = data;
        }
    }
}