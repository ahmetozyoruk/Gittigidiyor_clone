using GittiGidiyor.Services;
using GittiGidiyor.Services.SqlDatabase;
using GittiGidiyor.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GittiGidiyor
{
    public partial class App : Application
    {
        static UserSqlDatabase database;

        // Create the database connection as a singleton.
        public static UserSqlDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new UserSqlDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Comments.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            UrunService.Instance.GetUrunlerAsync();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
