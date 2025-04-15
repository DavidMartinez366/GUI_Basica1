using Microsoft.Maui.Controls;
using Agenda; 

namespace Agenda
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainPage());
        }
    }
}