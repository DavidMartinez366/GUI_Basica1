using Microsoft.Maui.Controls;
using Agenda; 

namespace Agenda
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState) 
        {
            return new Window(new NavigationPage(new MainPage()));
        }
    }
}