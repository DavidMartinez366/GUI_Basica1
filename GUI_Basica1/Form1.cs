using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Basica1
{
    public partial class Form1 : Form
    {
        private Dictionary<string , string> contactos = new Dictionary<string , string>();
        private ListBox ListaContactos;
        private Button btnBuscar;
        private TextBox txtBusqueda;
        private Label lblBusqueda;
        private List<Button> dynamicButtons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = ("Interfaz Basica de usuario");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String telefono = textBox2.Text;
            String Correo = textBox3.Text;

            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(telefono) && !String.IsNullOrEmpty(Correo))
            {
                contactos[nombre] =  telefono + "\n" +  Correo;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                MessageBox.Show("El usuario " + nombre + " ha sido agregado a la lista");
            }
            else {
                MessageBox.Show("llena todos los espacios");
                    
                 }

        }
        //Crear los eventos que realiza el boton num 5 (lista)
        private void button5_Click(object sender, EventArgs e)
        {
            if (ListaContactos != null)
            {
               this.Controls.Remove(ListaContactos);
                ListaContactos.Dispose();

            }
            //Colocar dinamicamente un listbox con los nombres de los usuarios guardados
            ListaContactos = new ListBox();
            ListaContactos.Size = new Size(200, 150);
            ListaContactos.Location = new Point(430, 80);
            foreach (var contacto in contactos.Keys)
            {
                ListaContactos.Items.Add(contacto); 
            }
            this.Controls.Add(ListaContactos); 

            //Condicional para crear un boton dinamicamente 
            if(btnBuscar == null)
            {
                btnBuscar = new Button();
                btnBuscar.Location = new Point(430, 230);
                btnBuscar.Text = "Buscar";
                btnBuscar.Click += new EventHandler (BuscarContacto);
                this.Controls.Add(btnBuscar);

                
            }   
            if (txtBusqueda == null)
            {
                txtBusqueda = new TextBox();
                txtBusqueda.Location = new Point(430, 260);
                this.Controls.Add(txtBusqueda);
            }

        }

        //crear el metodo "buscar contacto" que busca entre los contactos 
        private void BuscarContacto(object sender, EventArgs e) 
        {
            String nombreBuscado = txtBusqueda.Text.Trim();
            if (contactos.ContainsKey(nombreBuscado))
            {
                string datos = contactos[nombreBuscado];
                MessageBox.Show("Datos del contacto:\n" + datos);
            }
            else
            {
                MessageBox.Show("El contacto no existe");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBusqueda == null)
            {
                txtBusqueda= new TextBox();
                txtBusqueda.Location = new Point(430, 290);
                this.Controls.Add (txtBusqueda);
            }
            
            Button btnEliminar = new Button();
            btnEliminar.Location = new Point(430, 320);
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += new EventHandler(EliminarContacto);
            this.Controls.Add(btnEliminar);
                      
        }
        private void EliminarContacto(object sender, EventArgs e)
        {
            String nombreBuscado = txtBusqueda.Text.Trim();

            if (contactos.ContainsKey(nombreBuscado))
            {
                contactos.Remove(nombreBuscado);
                ListaContactos.Items.Clear();
                foreach (var contacto in contactos.Keys)
                {
                    ListaContactos.Items.Add(contacto);

                    MessageBox.Show("contacto" + nombreBuscado + "eliminado");

                }
                txtBusqueda.Clear();
            }
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (contactos.Keys.Count > 0) {

                if (contactos != null) {
                    ListaContactos.Items.Clear();

                }
                MessageBox.Show("La lista fue borrada");
            }
            else
            {
                MessageBox.Show("No existen contactos para eliminar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Directorio de usuarios para guardar informacion de correos y numeros de telefono");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) && (String.IsNullOrEmpty(textBox2.Text) && (String.IsNullOrEmpty(textBox3.Text))))
           { 
               MessageBox.Show("no hay elementos por borrar");
        }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                MessageBox.Show("los elementos han sido borrados exitosamente");
            }
        }
    }
}
