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
    [QueryProperty(nameof(SelectedCategory), "selectedCategory")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrunListeKatagoriPage : ContentPage
    {
        public UrunListeKatagoriPage()
        {
            InitializeComponent();
        }

        UrunListeKategoriViewModel connectView;

        public string SelectedCategory
        {
            set
            {
                LoadContent(value);
            }
        }

        private void LoadContent(string selectedCategory)
        {
            connectView = new UrunListeKategoriViewModel(selectedCategory, (Urun)Collection.SelectedItem);
            BindingContext = connectView;
            pickerUretici.ItemsSource = connectView.Urunler.Select((item) => item.SupplierName).Distinct().ToList();
        }

        private void PriceSirala(object sender, EventArgs e)
        {
            connectView.filtrelePrice();
        }
        private void NameSirala(object sender, EventArgs e)
        {
            connectView.filtreleName();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                var text = ((string)picker.ItemsSource[selectedIndex]);
                connectView.filtreleUretici(text); 
            }
        }
    }
}