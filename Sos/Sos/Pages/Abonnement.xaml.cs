using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sos.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abonnement : ContentPage
    {
        public Abonnement()
        {
            InitializeComponent();
          
        }

        private void Tlb_Cancel_Clicked(object sender, EventArgs e)
        {
            this.txt_firstname.Text = "";
            this.txt_lastname.Text = "";
            this.txt_age.Text = "";
        }

        private async void Tlb_save_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Information", "Abonnement effectué avec succes!", "Ok");
        }
    }
}