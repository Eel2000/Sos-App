﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sos.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void BtnAlert_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert(null, "Votre alerte santé a été envoyé!", "Ok");
        }
    }
}