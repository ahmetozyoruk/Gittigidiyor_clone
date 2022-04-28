using GittiGidiyor.Models;
using GittiGidiyor.Services;
using GittiGidiyor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GittiGidiyor.ViewModels
{
    public class UrunListeKategoriViewModel : ViewModelBase
    {
        private ObservableCollection<Urun> _urunler;
        private Urun _selectedUrun;
        public decimal _total;
        public string SelectedCategory { get; set; }

        public UrunListeKategoriViewModel(string selectedCategory,Urun urun)
        {
            _selectedUrun = urun;
            SelectedCategory = selectedCategory;
            LoadUrunler();

            SelectedCommand = new Command(
            async () =>
            {
                await Shell.Current.GoToAsync($"UrunDetay?SelectedUrun={SelectedUrun.ProductId}"); 
            });
        }

        public ObservableCollection<Urun> Urunler
        {
            get { return _urunler; }
            set
            {
                _urunler = value;
                OnPropertyChanged();
            }
        }

        public Urun SelectedUrun
        {
            get { return _selectedUrun; }
            set
            {
                _selectedUrun = value;
                OnPropertyChanged();
            }
        }
        public decimal Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectedCommand { private set; get; }

        private void LoadUrunler()
        {
            var receivedUrunler = UrunService.Urunler;
            var result = (from u in receivedUrunler
                          where u.Category.Contains(SelectedCategory)
                          select u);

            Urunler = new ObservableCollection<Urun>(result.ToList());
        }

        public void filtrelePrice()
        {
            if(Urunler[Urunler.Count-1].Price<Urunler[0].Price)
            {
                var receivedUrunler = UrunService.Urunler;
                var result = (from u in receivedUrunler
                              where u.Category.Contains(SelectedCategory)
                              orderby u.Price ascending
                              select u);
            Urunler = new ObservableCollection<Urun>(result.ToList());
            }
            else
            {
            var receivedUrunler = UrunService.Urunler;
            var result = (from u in receivedUrunler
                          where u.Category.Contains(SelectedCategory)
                          orderby u.Price descending
                          select u);
            Urunler = new ObservableCollection<Urun>(result.ToList());
            }
        }

        public void filtreleName()
        {
            if (Urunler[Urunler.Count - 1].Price < Urunler[0].Price)
            {
                var receivedUrunler = UrunService.Urunler;
                var result = (from u in receivedUrunler
                              where u.Category.Contains(SelectedCategory)
                              orderby u.Name ascending
                              select u);
                Urunler = new ObservableCollection<Urun>(result.ToList());
            }
            else
            {
                var receivedUrunler = UrunService.Urunler;
                var result = (from u in receivedUrunler
                              where u.Category.Contains(SelectedCategory)
                              orderby u.Name descending
                              select u);
                Urunler = new ObservableCollection<Urun>(result.ToList());
            }
        }

        public void filtreleUretici(string ad)
        {
            var receivedUrunler = UrunService.Urunler;
            var result = (from u in receivedUrunler
                          where u.Category.Contains(SelectedCategory) && u.SupplierName.Contains(ad)
                          select u);
            Urunler = new ObservableCollection<Urun>(result.ToList());
        }

    }
}
