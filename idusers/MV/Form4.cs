using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idusers
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        public void Advertencia_solo_numeros(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Permitir solo números y punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }

            // Si se maneja el evento y no es control, mostrar mensaje
            if (e.Handled && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y un punto decimal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            Close();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
{
    try
    {
        // Validar si todos los campos están llenos
        if (string.IsNullOrWhiteSpace(Nombre.Text) || string.IsNullOrWhiteSpace(Contra.Text) ||
            string.IsNullOrWhiteSpace(Sueldo.Text) || string.IsNullOrWhiteSpace(Salario_hora.Text) ||
            string.IsNullOrWhiteSpace(Horas_extra.Text) || string.IsNullOrWhiteSpace(Comisiones.Text))
        {
            MessageBox.Show("Por favor, rellene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Almacenar los valores en el formulario Salario
        Salario salarioForm = new Salario();
        salarioForm.AgregarValores(Convert.ToInt32(id.Text), Nombre.Text, Contra.Text, Convert.ToDouble(Sueldo.Text), 
            Convert.ToDouble(Salario_hora.Text), Convert.ToDouble(Horas_extra.Text), Convert.ToDouble(Comisiones.Text));
         // Diccionario completo.
         Dictionary<string, object> valores = salarioForm.ObtenerValores();
         DatosCompartidos.DatosUsuario = valores;
         MessageBox.Show($"Usuario {valores["nombre"]} y contraseña {valores["contra"]} registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

         }
            catch (FormatException)
    {
        MessageBox.Show("Por favor, ingresa valores válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}


        private void Sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Advertencia_solo_numeros(sender, e);
        }

        private void Salario_hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Advertencia_solo_numeros(sender, e);
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            // Asignar eventos KeyPress para solo números
            id.KeyPress += Advertencia_solo_numeros;
            Sueldo.KeyPress += Advertencia_solo_numeros;
            Salario_hora.KeyPress += Advertencia_solo_numeros;
            Horas_extra.KeyPress += Advertencia_solo_numeros;
            Comisiones.KeyPress += Advertencia_solo_numeros;
        }
    }
}
