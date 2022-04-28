using GittiGidiyor.Models;
using GittiGidiyor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyor.ViewModels
{
    public class UrunDetayViewModel : ViewModelBase
    {
        private Urun _urun;

        public Urun Urun
        {
            get { return _urun; }
            set
            {
                _urun = value;
                OnPropertyChanged();
            }
        }

        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is Urun)
                Urun = (Urun)navigationData;
            return base.InitializeAsync(navigationData);
        }
    }
}
