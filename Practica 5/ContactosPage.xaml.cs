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
            new Contacto { Nombre = "Juan ", Telefono = "123456", Correo = "juan@gmail.com" },
            new Contacto { Nombre = "María ", Telefono = "123456", Correo = "maria@gmail.com" },
            new Contacto { Nombre = "Carlos ", Telefono = "123456", Correo = "carlos@gmail.com" }
        };
    }
}