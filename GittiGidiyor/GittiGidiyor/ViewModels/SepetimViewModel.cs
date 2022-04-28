using GittiGidiyor.Models;
using GittiGidiyor.Services;
using GittiGidiyor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GittiGidiyor.ViewModels
{
    public class SepetimViewModel : ViewModelBase
    {
        public static SepetimViewModel _instance;

        public static SepetimViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SepetimViewModel();

                return _instance;
            }
        }

        public SepetimViewModel()
        {
            var actualSepet = SepetimService.Instance.GetSepet().Result;
            Sepet = new ObservableCollection<Urun>(actualSepet);
        }
        private ObservableCollection<Urun> _sepet;
        public ObservableCollection<Urun> Sepet
        {
            get { return _sepet; }
            set
            {
                _sepet = value;
                OnPropertyChanged();
            }
        }


        public void LoadSepetim()
        {
            var actualSepet = SepetimService.Instance.GetSepet().Result;
            Sepet = new ObservableCollection<Urun>(actualSepet);
        }
    }
}
