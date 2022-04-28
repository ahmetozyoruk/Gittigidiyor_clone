using System;
using System.Collections.Generic;
using Xamarin.Forms;
using GittiGidiyor.Views.BaseViews;

namespace GittiGidiyor
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("UrunListeKatagoriPage", typeof(UrunListeKatagoriPage));
            Routing.RegisterRoute("UrunDetay", typeof(UrunDetayPage));
            Routing.RegisterRoute("OdemeSayfasiPage", typeof(OdemeSayfasiPage));

        }

    }
}
