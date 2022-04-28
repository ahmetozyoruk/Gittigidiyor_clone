using GittiGidiyor.Services;
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
    public partial class SepetimItemTemplate : ContentView
    {
        public SepetimItemTemplate()
        {
            InitializeComponent();
        }
        public static void LoadSepet()
        {
            SepetimViewModel.Instance.LoadSepetim();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var label = new Label();
            label.BindingContext = BindingContext;
            label.SetBinding(Label.TextProperty, new Binding("ProductId"));
            SepetimService.Instance.SilSepet(label.Text);
            LoadSepet();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var label = new Label();
            label.BindingContext = BindingContext;
            label.SetBinding(Label.TextProperty, new Binding("ProductId"));
            SepetimService.Instance.EkleSonraAlacaklar(label.Text);
            LoadSepet();
        }
    }
}