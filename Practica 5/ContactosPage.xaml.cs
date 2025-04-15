namespace Practica_5;

public partial class ContactosPage : ContentPage
{
    public ContactosPage()
    {
        InitializeComponent();
        BindingContext = new ContactosViewModel();
    }
}

public class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
}

public class ContactosViewModel
{
    public List<Contacto> Contactos { get; set; }

    public ContactosViewModel()
    {
        Contactos = new List<Contacto>
        {
            new Contacto { Nombre = "Juan Pérez", Telefono = "555-1234", Correo = "juan@example.com" },
            new Contacto { Nombre = "María García", Telefono = "555-5678", Correo = "maria@example.com" },
            new Contacto { Nombre = "Carlos López", Telefono = "555-9012", Correo = "carlos@example.com" }
        };
    }
}