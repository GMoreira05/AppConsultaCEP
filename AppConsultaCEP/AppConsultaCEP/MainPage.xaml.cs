using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppConsultaCEP.View;

namespace AppConsultaCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_CEP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConsultaCEP());
        }
    }
}
