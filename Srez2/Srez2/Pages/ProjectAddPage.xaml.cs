using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Srez2.Model;
using Srez2.Data;
using Srez2.Pages;

namespace Srez2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectAddPage : ContentPage
    {
        public ProjectAddPage()
        {
            InitializeComponent();
        }

        private async void BRemove_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectsPage());
        }

        private void BAddProject_Clicked(object sender, EventArgs e)
        {
            Project project = new Project();
            project.Name = ProjectName.Text;
            project.DateTime = ProjectDate.Date;
            App.Database.SaveProject(project);

            this.Navigation.PopAsync();
        }
    }
}