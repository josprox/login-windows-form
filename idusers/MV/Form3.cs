using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace idusers
{
    public partial class Form3 : Form
    {
        public Dictionary<string, object> datosUsuario;
        double sindical = .03;

        public Form3(Dictionary<string, object> datosUsuario)
        {
            InitializeComponent();
            this.datosUsuario = datosUsuario;

            double extra = Convert.ToDouble(datosUsuario["salario_x_hora"]) * Convert.ToDouble(datosUsuario["horas_extras"]);
            double Total_pe = Convert.ToDouble(datosUsuario["sueldo"]) + extra + Convert.ToDouble(datosUsuario["comisiones"]);
            double Seguro = (Total_pe * .25);
            double irpf = (Total_pe * .03);
            double cuota_sindical = (Total_pe * sindical);
            double deducciones = Seguro + irpf + cuota_sindical;
            double total = Total_pe - deducciones;

            Sueldo.Text = datosUsuario["sueldo"].ToString();
            Salario_hora.Text = datosUsuario["salario_x_hora"].ToString();
            Horas_extra.Text = datosUsuario["horas_extras"].ToString();
            Comisiones.Text = datosUsuario["comisiones"].ToString();

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
