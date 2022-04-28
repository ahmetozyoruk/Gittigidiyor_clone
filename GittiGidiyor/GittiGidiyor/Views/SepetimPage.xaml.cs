using GittiGidiyor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GittiGidiyor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SepetimPage : ContentPage
    {
        public SepetimPage()
        {
            InitializeComponent();
            BindingContext = SepetimViewModel.Instance;
            
        }

        protected override void OnAppearing()
        {
            ToplamUcret.Text = SepetimViewModel.Instance.Sepet.Select((item) => item.Price).ToList().Sum().ToString();
            BindingContext = SepetimViewModel.Instance;
            SepetimViewModel.Instance.LoadSepetim();
            base.OnAppearing();
        }


        private async void buttonOde_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"OdemeSayfasiPage?price={ToplamUcret.Text}");
        }
    }

}