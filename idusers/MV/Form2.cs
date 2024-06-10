using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idusers
{
    public partial class Form2 : Form
    {
        public Dictionary<string, object> datosUsuario;

        public Form2()
        {
            InitializeComponent();

            // Obtener los datos del salario y asignarlos a datosUsuario
            datosUsuario = DatosCompartidos.DatosUsuario;
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Conect_Click(object sender, EventArgs e)
        {
            string userName = Usuario.Text;
            string password = Contra.Text;

            // Verificar si datosUsuario no es null antes de acceder a él
            if (datosUsuario != null && datosUsuario.ContainsKey("nombre") && datosUsuario.ContainsKey("contra"))
            {
                if (datosUsuario["nombre"].ToString() != userName || datosUsuario["contra"].ToString() != password)
                {
                    // Usuario o contraseña incorrectos
                    MessageBox.Show("El usuario o la contraseña es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Usuario.Clear();
                    Contra.Clear();
                }
                else
                {
                    // Usuario y contraseña correctos
                    Form3 F3 = new Form3(datosUsuario); // Pasar datosUsuario al constructor de Form3
                    F3.Most_user.Text = datosUsuario["nombre"].ToString();
                    F3.Most_user.Show();
                    F3.Show();
                    Close();
                }
            }
            else
            {
                // datosUsuario no está inicializado, mostrar un mensaje de error o tomar alguna otra acción
                MessageBox.Show("No se han proporcionado datos de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool VerificarTexto(TextBox textBox, string texto, string mensaje)
        {
            if (textBox.Text.Equals(texto, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true; // Devolver true si se activó el modo de pruebas
            }
            else
            {
                return false; // Devolver false si no se activó el modo de pruebas
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Suscribir el método VerificarTexto al evento TextChanged del TextBox Usuario
            Usuario.TextChanged += (s, eventArgs) =>
            {
                bool modoPruebasActivado = VerificarTexto(Usuario, "tecnotech.ovh", "Modo pruebas activado");
                Test.Visible = modoPruebasActivado;
            };
        }


        private void Pass_TextChanged(object sender, EventArgs e)
        {
            // Lógica si es necesario
        }

        private void Registrar_button_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Lógica si es necesario
        }

        private void Test_Click(object sender, EventArgs e)
        {
            if (datosUsuario != null)
            {
                MessageBox.Show($"Los datos de acceso son, usuario '{datosUsuario["nombre"]}'  y contraseña '{datosUsuario["contra"]}'");
            }
            else
            {
                MessageBox.Show("No se han proporcionado datos de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
