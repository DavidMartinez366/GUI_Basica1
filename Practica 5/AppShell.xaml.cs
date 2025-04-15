namespace Practica_5
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Configurar NavigationPage como contenedor principal
            CurrentItem = new ShellContent
            {
                Content = new NavigationPage(new MainPage())
                {
                    Title = "Agenda Personal",
                    BarBackgroundColor = Color.FromArgb("#512BD4"),
                    BarTextColor = Colors.White
                }
            };

            // Registrar rutas
            Routing.RegisterRoute("ContactosPage", typeof(ContactosPage));
            Routing.RegisterRoute("CrearContactoPage", typeof(CrearContactoPage));
            Routing.RegisterRoute("ConfiguracionPage", typeof(ConfiguracionPage));
            Routing.RegisterRoute("DetalleContactoPage", typeof(DetalleContactoPage));
        }
    }
}