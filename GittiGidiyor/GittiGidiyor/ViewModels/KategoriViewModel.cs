using GittiGidiyor.Models;
using GittiGidiyor.Services;
using GittiGidiyor.Services.Firebase;
using GittiGidiyor.ViewModels.Base;
using GittiGidiyor.Views.BaseViews;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace GittiGidiyor.ViewModels
{
    public class KategoriViewModel : ViewModelBase
    {
        CategoryService categoryService = new CategoryService();

        private ObservableCollection<Category> _kategoriler;
        public List<Category> AnaKategiriler { get; set; }

        public KategoriViewModel()
        {
            LoadKategori();
        }

        private async void LoadKategori()
        {
            List<Category> categories = CategoryService.Instance.GetAllCategorys();
            Kategoriler = new ObservableCollection<Category>(categories);
            AnaKategiriler = categories;
        }

        public ObservableCollection<Category> Kategoriler
        {
            get { return _kategoriler; }
            set
            {
                _kategoriler = value;
                OnPropertyChanged();
            }
        }

        public async void GetAllCategorys()
        {
            List<Category> categories = CategoryService.Instance.GetAllCategorys();
            Kategoriler = new ObservableCollection<Category>(categories);
        }

        public async void GetSubAllCategorys(string ad)
        {
            List<Category> categories = await CategoryService.Instance.GetSubAllCategorys(ad);
            
            
            if (categories!=null)
            {
                Kategoriler = new ObservableCollection<Category>(categories);
            }
            else
            {
                await Shell.Current.GoToAsync($"UrunListeKatagoriPage?selectedCategory={ad}");
            }
        }
    }
}
