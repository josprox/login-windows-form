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
    public partial class Form3 : Form
    {
        double sindical = .03;
        public Form3()
        {
            InitializeComponent();
        }

        private void Finish_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has cerrado sesión con éxito");
            Form2 F2 = new Form2();
            F2.Show();
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo = float.Parse(Sueldo.Text);
            double extra = float.Parse(Salario_hora.Text) * float.Parse(Horas_extra.Text);
            double comision = float.Parse(Comisiones.Text);
            double Total_pe = sueldo + extra + comision;
            double Seguro = (Total_pe * .25);
            double irpf = (Total_pe * .03);
            double cuota_sindical = (Total_pe * sindical);
            double deducciones = Seguro + irpf + cuota_sindical;
            double total = Total_pe - deducciones;

            IRPF.Text = irpf.ToString();
            SeguroSocial.Text = Seguro.ToString();
            Total_perce.Text = Total_pe.ToString();

            Sindical.Text = cuota_sindical.ToString();
            Texto_total_1.Show();
            Total_perce.Show();

            Total_deducciones.Text = deducciones.ToString();
            Texto_total_2.Show();
            Total_deducciones.Show();

            Total_final.Text = total.ToString();
            Liquido.Show();

        }

        private void Percepciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
