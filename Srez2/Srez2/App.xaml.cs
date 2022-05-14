using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Srez2.Data;
using System.IO;

namespace Srez2
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "project.db";
        public static UserDB database;
        public static UserDB Database
        {
            get
            {
                if (database == null)
                {
                    database = new UserDB(
                    Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
