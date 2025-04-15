using System;
using Microsoft.Maui.Controls;
using System.Diagnostics; 
using System.Threading.Tasks;
using Agenda;

namespace Agenda
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            try
            {
                InitializeComponent();
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error en InitializeComponent: {ex.Message}");
            }

        }

        private async void ListaContactos(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ListaContactos());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al navegar a ListaContactos: {ex.Message}");
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
        private async void CrearContacto (object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CrearContacto());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al navegar a CrearContacto: {ex.Message}");
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}