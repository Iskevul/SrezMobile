using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Srez2.Pages;
using Srez2;
using Srez2.Data;
using Srez2.Model;
using Srez2.Pages;

namespace Srez2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void BRegistration_Clicked(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = EName.Text;
            user.Login = ELogin.Text;
            user.Password = EPassword.Text;
            App.Database.SaveUser(user);
            await Navigation.PushAsync(new ProjectsPage());
        }
    }
}