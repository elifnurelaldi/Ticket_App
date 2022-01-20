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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_34_Clicked(object sender, EventArgs e)
        {
            Customer CUS_Rec = new Customer();

            CUS_Rec.Name = Entry1.Text;
            CUS_Rec.Phone = Entry2.Text;
            CUS_Rec.Email= Entry3.Text;

            Conn_Class.Conn.Insert(CUS_Rec);
        }
    }
}