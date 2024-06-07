using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idusers
{
    public partial class Form2 : Form
    {
        string usuario = "Joss";
        string contra = "1234";

        public Form2()
        {
            InitializeComponent();
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
            string userName = Username.Text;
            string password = Pass.Text;

            if (usuario != userName || contra != password)
            {
                // Usuario o contraseña incorrectos
                MessageBox.Show("El usuario o la contraseña es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Username.Clear();
                Pass.Clear();
            }
            else
            {
                // Usuario y contraseña correctos
                Form3 F3 = new Form3();
                F3.Most_user.Text = userName;
                F3.Show();
                Close();
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // Lógica de carga de la forma si es necesarioz
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
    }
}
