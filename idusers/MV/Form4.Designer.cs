
namespace idusers
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Percepciones = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Salario_hora = new System.Windows.Forms.TextBox();
            this.Total_perce = new System.Windows.Forms.Label();
            this.Texto_total_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Comisiones = new System.Windows.Forms.TextBox();
            this.Horas_extra = new System.Windows.Forms.TextBox();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.Percepciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos del recibo:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(150, 47);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 4;
            // 
            // Contra
            // 
            this.Contra.Location = new System.Drawing.Point(150, 78);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(100, 20);
            this.Contra.TabIndex = 5;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(150, 111);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 6;
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(37, 397);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 8;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(145, 397);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(75, 23);
            this.Regresar.TabIndex = 9;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(250, 397);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 10;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Percepciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cerrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Regresar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Enviar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.Contra);
            this.groupBox1.Location = new System.Drawing.Point(36, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 482);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regístrate";
            // 
            // Percepciones
            // 
            this.Percepciones.Controls.Add(this.label11);
            this.Percepciones.Controls.Add(this.Salario_hora);
            this.Percepciones.Controls.Add(this.Total_perce);
            this.Percepciones.Controls.Add(this.Texto_total_1);
            this.Percepciones.Controls.Add(this.label5);
            this.Percepciones.Controls.Add(this.label6);
            this.Percepciones.Controls.Add(this.label7);
            this.Percepciones.Controls.Add(this.Comisiones);
            this.Percepciones.Controls.Add(this.Horas_extra);
            this.Percepciones.Controls.Add(this.Sueldo);
            this.Percepciones.Location = new System.Drawing.Point(51, 184);
            this.Percepciones.Name = "Percepciones";
            this.Percepciones.Size = new System.Drawing.Size(263, 185);
            this.Percepciones.TabIndex = 11;
            this.Percepciones.TabStop = false;
            this.Percepciones.Text = "Percepciones";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Salario por hora";
            // 
            // Salario_hora
            // 
            this.Salario_hora.Location = new System.Drawing.Point(27, 96);
            this.Salario_hora.Name = "Salario_hora";
            this.Salario_hora.Size = new System.Drawing.Size(100, 20);
            this.Salario_hora.TabIndex = 8;
            this.Salario_hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salario_hora_KeyPress);
            // 
            // Total_perce
            // 
            this.Total_perce.AutoSize = true;
            this.Total_perce.Location = new System.Drawing.Point(129, 164);
            this.Total_perce.Name = "Total_perce";
            this.Total_perce.Size = new System.Drawing.Size(19, 13);
            this.Total_perce.TabIndex = 7;
            this.Total_perce.Text = "$0";
            this.Total_perce.Visible = false;
            // 
            // Texto_total_1
            // 
            this.Texto_total_1.AutoSize = true;
            this.Texto_total_1.Location = new System.Drawing.Point(89, 165);
            this.Texto_total_1.Name = "Texto_total_1";
            this.Texto_total_1.Size = new System.Drawing.Size(34, 13);
            this.Texto_total_1.TabIndex = 6;
            this.Texto_total_1.Text = "Total:";
            this.Texto_total_1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comisiones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Horas extras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sueldo bruto (Quincenal)";
            // 
            // Comisiones
            // 
            this.Comisiones.Location = new System.Drawing.Point(73, 142);
            this.Comisiones.Name = "Comisiones";
            this.Comisiones.Size = new System.Drawing.Size(100, 20);
            this.Comisiones.TabIndex = 2;
            // 
            // Horas_extra
            // 
            this.Horas_extra.Location = new System.Drawing.Point(133, 96);
            this.Horas_extra.Name = "Horas_extra";
            this.Horas_extra.Size = new System.Drawing.Size(100, 20);
            this.Horas_extra.TabIndex = 1;
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(71, 57);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(100, 20);
            this.Sueldo.TabIndex = 0;
            this.Sueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sueldo_KeyPress);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 565);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de captura";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Percepciones.ResumeLayout(false);
            this.Percepciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Percepciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Salario_hora;
        private System.Windows.Forms.Label Total_perce;
        private System.Windows.Forms.Label Texto_total_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Comisiones;
        private System.Windows.Forms.TextBox Horas_extra;
        private System.Windows.Forms.TextBox Sueldo;
    }
}