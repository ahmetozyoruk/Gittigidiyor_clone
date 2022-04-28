using GittiGidiyor.Services;
using GittiGidiyor.ViewModels;
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
    public partial class KesfetPage : ContentPage
    {
        public KesfetPage()
        {
            InitializeComponent();
        }

        private void Label_SizeChanged(object sender, EventArgs e)
        {

        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            //searchResults.ItemsSource = UrunService.Instance.GetUrunlerFiltername(searchBar.Text);
        }
    }
}