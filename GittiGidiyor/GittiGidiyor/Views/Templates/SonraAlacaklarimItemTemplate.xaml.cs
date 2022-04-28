using GittiGidiyor.Services.Firebase;
using GittiGidiyor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GittiGidiyor.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SonraAlacaklarimItemTemplate : ContentView
    {
        public SonraAlacaklarimItemTemplate()
        {
            InitializeComponent();
        }

        public static void LoadSonraAlacaklarim()
        {
            SonraAlacaklarimViewModel.Instance.LoadSonrAlacaklarim();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var label = new Label();
            label.BindingContext = BindingContext;
            label.SetBinding(Label.TextProperty, new Binding("ProductId"));
            SonraAlacaklarimService.Instance.SilSonraAlinacaklar(label.Text);
            LoadSonraAlacaklarim();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var label = new Label();
            label.BindingContext = BindingContext;
            label.SetBinding(Label.TextProperty, new Binding("ProductId"));
            SonraAlacaklarimService.Instance.SepeteEkle(label.Text);
            LoadSonraAlacaklarim();
            SepetimItemTemplate.LoadSepet();
        }
    }
}