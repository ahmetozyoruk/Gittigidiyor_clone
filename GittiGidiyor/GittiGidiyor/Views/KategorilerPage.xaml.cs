using GittiGidiyor.Models;
using GittiGidiyor.Services;
using GittiGidiyor.ViewModels;
using GittiGidiyor.Views.BaseViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GittiGidiyor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KategorilerPage : ContentPage
    {

        KategoriViewModel kategoriViewModel = new KategoriViewModel();
        public KategorilerPage()
        {
            InitializeComponent();
            BindingContext = kategoriViewModel;
        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedCategory = listview.SelectedItem as Category;
            kategoriViewModel.GetSubAllCategorys(selectedCategory.text);

        }

        protected override bool OnBackButtonPressed()
        {
            kategoriViewModel.GetAllCategorys();
            return true;
        }

        //private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    SearchBar searchBar = (SearchBar)sender;
        //    searchResults.ItemsSource = UrunService.Instance.GetUrunlerFiltername(searchBar.Text);
        //}

        //private void searchResults_SizeChanged(object sender, EventArgs e)
        //{
            
        //}
    }
}