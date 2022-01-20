using Ticket_App.My_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ticket_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

        }

        private void Button_2_Clicked(object sender, EventArgs e)
        {
            Button_2.BackgroundColor = Color.Yellow;
            Label17.Text = Button_2.Text;

        }

        private void Button_3_Clicked(object sender, EventArgs e)
        {
            Button_3.BackgroundColor=Color.Yellow;
            Label17.Text = Button_3.Text;

        }

        private void Button_6_Clicked(object sender, EventArgs e)
        {
            Button_6.BackgroundColor = Color.Yellow;
            Label17.Text = Button_6.Text;
        }

        private void Button_7_Clicked(object sender, EventArgs e)
        {
            Button_7.BackgroundColor = Color.Yellow;
            Label17.Text = Button_7.Text;
        }

        private void Button_9_Clicked(object sender, EventArgs e)
        {
            Button_9.BackgroundColor = Color.Yellow;
            Label17.Text = Button_9.Text;
        }

        private void Button_12_Clicked(object sender, EventArgs e)
        {
            Button_12.BackgroundColor = Color.Yellow;
            Label17.Text = Button_12.Text;
        }

        private void Button_14_Clicked(object sender, EventArgs e)
        {
            Button_14.BackgroundColor = Color.Yellow;
            Label17.Text = Button_14.Text;
        }

        private void Button_19_Clicked(object sender, EventArgs e)
        {
            Button_19.BackgroundColor = Color.Yellow;
            Label17.Text = Button_19.Text;
        }

        private void Button_20_Clicked(object sender, EventArgs e)
        {
            Button_20.BackgroundColor = Color.Yellow;
            Label17.Text = Button_20.Text;
        }

        private void Button_22_Clicked(object sender, EventArgs e)
        {
            Button_22.BackgroundColor = Color.Yellow;
            Label17.Text = Button_22.Text;
        }

        private void Button_23_Clicked(object sender, EventArgs e)
        {
            Button_23.BackgroundColor = Color.Yellow;
            Label17.Text = Button_23.Text;
        }

        private void Button_26_Clicked(object sender, EventArgs e)
        {
            Button_26.BackgroundColor = Color.Yellow;
            Label17.Text = Button_26.Text;
        }

        private void Button_27_Clicked(object sender, EventArgs e)
        {
            Button_27.BackgroundColor = Color.Yellow;
            Label17.Text = Button_27.Text;
        }

        private void Button_30_Clicked(object sender, EventArgs e)
        {
            Button_30.BackgroundColor = Color.Yellow;
            Label17.Text = Button_30.Text;
        }

        private void Button_31_Clicked(object sender, EventArgs e)
        {
            Button_31.BackgroundColor = Color.Yellow;
            Label17.Text = Button_31.Text;
        }

        private void Button_33_Clicked(object sender, EventArgs e)
        {
            Film Film_Rec = new Film();

            Film_Rec.FilmName = (string)picker1.SelectedItem;
            Film_Rec.SeatNumber = Label17.Text;

            Conn_Class.Conn.Insert(Film_Rec);


        }
    }
}