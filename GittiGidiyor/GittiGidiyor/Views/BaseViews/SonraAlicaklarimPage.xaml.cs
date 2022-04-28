using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GittiGidiyor.ViewModels;
using GittiGidiyor.Models;

namespace GittiGidiyor.Views.BaseViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SonraAlicaklarimPage : ContentPage
    {
        public SonraAlicaklarimPage()
        {
            InitializeComponent();
            BindingContext = SonraAlacaklarimViewModel.Instance;
        }
        protected override void OnAppearing()
        {
            ToplamUcret.Text = SonraAlacaklarimViewModel.Instance.SonraAlacaklarim.Select((item) => item.Price).ToList().Sum().ToString();
            SonraAlacaklarimViewModel.Instance.LoadSonrAlacaklarim();
            BindingContext = SonraAlacaklarimViewModel.Instance;
            base.OnAppearing();
        }

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Page1");
        }
    }
}