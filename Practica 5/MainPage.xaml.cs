namespace Practica_5;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void IrListaContactos(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ContactosPage");
    }

    private async void IrCrearContacto(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CrearContactoPage");
    }

    private async void IrConfiguracion(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ConfiguracionPage");
    }
}

