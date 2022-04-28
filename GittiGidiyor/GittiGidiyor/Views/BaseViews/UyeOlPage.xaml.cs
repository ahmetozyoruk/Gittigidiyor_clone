using GittiGidiyor.Models;
using GittiGidiyor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GittiGidiyor.Views.BaseViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UyeOlPage : ContentPage
    {
        UyeOlPageViewModel UyeOlPageViewModel = new UyeOlPageViewModel();

        public UyeOlPage()
        {
            InitializeComponent();
        }

        //Firebase connection database
        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    ShoppingCart shoppingCart = new ShoppingCart() { ID = 1, DiscountID = 1, KargoUcret = 4, ToplamSayi = 5, ToplamUcret = 256 };
        //    await UyeOlPageViewModel.AddUser(Ad.Text, Tel.Text, Email.Text,Sifre.Text, shoppingCart);
        //    Ad.Text = string.Empty;
        //    Tel.Text = string.Empty;
        //    Email.Text = string.Empty;
        //    Sifre.Text = string.Empty;
        //    await DisplayAlert("Success", "Person Added Successfully", "OK");
        //}

        //Sql Connection Database
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var user = (User)BindingContext;
            await App.Database.SaveUserAsync(new User { Ad = Ad.Text, Tel = Tel.Text, Email = Email.Text, Sifre = Sifre.Text});
            await DisplayAlert("Success", "Person Added Successfully", "OK");
        }

    }
}