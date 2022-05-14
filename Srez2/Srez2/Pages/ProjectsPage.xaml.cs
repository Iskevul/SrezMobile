using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Srez2.Model;
using Srez2.Data;

namespace Srez2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsPage : ContentPage
    {
        public List<Project> LVProjectsName { get; set; }
        public ProjectsPage()
        {
            InitializeComponent();
            LVProjectsName = App.Database.GetProjects().ToList();
            this.BindingContext = this;
        }

        private async void AddProject_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectAddPage());
        }
    }
}