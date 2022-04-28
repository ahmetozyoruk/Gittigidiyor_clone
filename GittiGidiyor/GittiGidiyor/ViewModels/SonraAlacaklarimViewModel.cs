using GittiGidiyor.Models;
using GittiGidiyor.Services.Firebase;
using GittiGidiyor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GittiGidiyor.ViewModels
{
    public class SonraAlacaklarimViewModel : ViewModelBase
    {
        public static SonraAlacaklarimViewModel _instance;

        public static SonraAlacaklarimViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SonraAlacaklarimViewModel();

                return _instance;
            }
        }
        public SonraAlacaklarimViewModel()
        {
            List<Urun> actualSonraAlinacaklar = SonraAlacaklarimService.Instance.GetAllSonraAlinacaklar().Result;
            SonraAlacaklarim = new ObservableCollection<Urun>(actualSonraAlinacaklar);

        }
        private ObservableCollection<Urun> _sonraAlacaklarim;
        public  ObservableCollection<Urun> SonraAlacaklarim
        {
            get { return _sonraAlacaklarim; }
            set
            {
                _sonraAlacaklarim = value;
                OnPropertyChanged();
            }
        }
        public void LoadSonrAlacaklarim()
        {
            List<Urun> actualSonraAlinacaklar = SonraAlacaklarimService.Instance.GetAllSonraAlinacaklar().Result;
            SonraAlacaklarim = new ObservableCollection<Urun>(actualSonraAlinacaklar);
        }
    }
}
