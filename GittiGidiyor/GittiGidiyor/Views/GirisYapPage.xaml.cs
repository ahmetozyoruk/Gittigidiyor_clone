using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GittiGidiyor.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GittiGidiyor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirisYapPage : ContentPage
    {
        GirisYapViewModel girisYapViewModel = new GirisYapViewModel();
        public GirisYapPage()
        {
            InitializeComponent();
        }

        //Firebase Connection Database
        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    var user = await girisYapViewModel.GetUser(EntryKullanici.Text, EntrySifre.Text);
        //    if (user != null)
        //    {
        //        await DisplayAlert("Success", "Person Retrive Successfully", "OK");
        //    }
        //    else
        //    {
        //        await DisplayAlert("Success", "No Person Available", "OK");
        //    }
        //}

        //Sql Connection Database

        private async void Button_Clicked(object sender, EventArgs e)
        {

            var user = await App.Database.GetUserAsync(EntryKullanici.Text, EntrySifre.Text);
            if (user != null)
            {
                await DisplayAlert("Success", "Person Retrive Successfully", "OK");
            }
            else
            {
                await DisplayAlert("Success", "No Person Available", "OK");
            }
        }

    }
}