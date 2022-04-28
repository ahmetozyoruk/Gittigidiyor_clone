using GittiGidiyor.Controls;
using GittiGidiyor.Models;
using GittiGidiyor.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GittiGidiyor.Views.BaseViews
{
    [QueryProperty(nameof(Price), "price")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OdemeSayfasiPage : ContentPage
    {
        public OdemeSayfasiPage()
        {
            InitializeComponent();
            ReceivedUrunler();
            BindingContext = this;
            Liste.SetBinding(ListView.ItemsSourceProperty, "receivedUrunler");
            SepetimService.Instance.SilSepetAll();
        }

        private void ReceivedUrunler()
        {
                var alinanUrunler = SepetimService.Instance.GetSepet().Result;
                receivedUrunler = new ObservableCollection<Urun>(alinanUrunler);
        }

        private string price;

        public string Price
        {
            get { return price; }
            set
            {
                LoadUrun(value);
            }
        }
        private void LoadUrun(string price_)
        {
            ToplamUcret.Text = string.Format("Toplam {0}TL odendi", price_);
        }

        private ObservableCollection<Urun> _receivedUrunler;

        public ObservableCollection<Urun> receivedUrunler
        {
            get { return _receivedUrunler; }
            set
            {
                _receivedUrunler = value;
                OnPropertyChanged();
            }
        }

        private void Liste_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            Urun SecilmisUrun = sender as Urun;

            UrunService.Urunler.Select((item) => item.ProductId = SecilmisUrun.ProductId);


        }
    }
}