using GittiGidiyor.Models;
using GittiGidiyor.Services;
using GittiGidiyor.Services.Firebase;
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
    [QueryProperty(nameof(SelectedUrun), "SelectedUrun")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrunDetayPage : ContentPage
    {
        public UrunDetayPage()
        {
            InitializeComponent();
        }
        private string _selectedUrun;

        public string SelectedUrun
        {
            get { return _selectedUrun; }
            set
            {
                LoadUrun(value);
            }
        }
        private void LoadUrun(string SelectedUrun)
        {
            var receivedUrunler = UrunService.Urunler;
            var result = (from u in receivedUrunler
                          where u.ProductId.Contains(SelectedUrun)
                          select u);

            BindingContext = (Urun)result.FirstOrDefault();
            _selectedUrun = SelectedUrun;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var receivedUrunler = UrunService.Urunler;
            var result = (from u in receivedUrunler
                          where u.ProductId.Contains(SelectedUrun)
                          select u);
            Urun urun = (Urun)result.FirstOrDefault();
            urun.isSonraAlinacak = true;
            SonraAlacaklarimViewModel.Instance.LoadSonrAlacaklarim();
        }
    }
}