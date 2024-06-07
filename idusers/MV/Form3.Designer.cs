
namespace idusers
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.Most_user = new System.Windows.Forms.Label();
            this.Finish_window = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Percepciones = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Salario_hora = new System.Windows.Forms.TextBox();
            this.Total_perce = new System.Windows.Forms.Label();
            this.Texto_total_1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Comisiones = new System.Windows.Forms.TextBox();
            this.Horas_extra = new System.Windows.Forms.TextBox();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.Deducciones = new System.Windows.Forms.GroupBox();
            this.Total_deducciones = new System.Windows.Forms.Label();
            this.Sindical = new System.Windows.Forms.Label();
            this.Texto_total_2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IRPF = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SeguroSocial = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Liquido = new System.Windows.Forms.GroupBox();
            this.Imprimir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Total_final = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Percepciones.SuspendLayout();
            this.Deducciones.SuspendLayout();
            this.Liquido.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // Most_user
            // 
            this.Most_user.AutoSize = true;
            this.Most_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Most_user.Location = new System.Drawing.Point(149, 10);
            this.Most_user.Name = "Most_user";
            this.Most_user.Size = new System.Drawing.Size(87, 26);
            this.Most_user.TabIndex = 1;
            this.Most_user.Text = "Usuario";
            this.Most_user.Visible = false;
            // 
            // Finish_window
            // 
            this.Finish_window.Location = new System.Drawing.Point(436, 455);
            this.Finish_window.Margin = new System.Windows.Forms.Padding(2);
            this.Finish_window.Name = "Finish_window";
            this.Finish_window.Size = new System.Drawing.Size(76, 29);
            this.Finish_window.TabIndex = 2;
            this.Finish_window.Text = "Salir";
            this.Finish_window.UseVisualStyleBackColor = true;
            this.Finish_window.Click += new System.EventHandler(this.Finish_window_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(680, 12);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(109, 29);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Cerrar sesión";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Percepciones
            // 
            this.Percepciones.Controls.Add(this.label11);
            this.Percepciones.Controls.Add(this.Salario_hora);
            this.Percepciones.Controls.Add(this.Total_perce);
            this.Percepciones.Controls.Add(this.Texto_total_1);
            this.Percepciones.Controls.Add(this.label4);
            this.Percepciones.Controls.Add(this.label3);
            this.Percepciones.Controls.Add(this.label2);
            this.Percepciones.Controls.Add(this.Comisiones);
            this.Percepciones.Controls.Add(this.Horas_extra);
            this.Percepciones.Controls.Add(this.Sueldo);
            this.Percepciones.Location = new System.Drawing.Point(63, 133);
            this.Percepciones.Name = "Percepciones";
            this.Percepciones.Size = new System.Drawing.Size(263, 185);
            this.Percepciones.TabIndex = 8;
            this.Percepciones.TabStop = false;
            this.Percepciones.Text = "Percepciones";
            this.Percepciones.Enter += new System.EventHandler(this.Percepciones_Enter);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Comisiones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horas extras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sueldo bruto (Quincenal)";
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
            // 
            // Deducciones
            // 
            this.Deducciones.Controls.Add(this.Total_deducciones);
            this.Deducciones.Controls.Add(this.Sindical);
            this.Deducciones.Controls.Add(this.Texto_total_2);
            this.Deducciones.Controls.Add(this.label9);
            this.Deducciones.Controls.Add(this.IRPF);
            this.Deducciones.Controls.Add(this.label7);
            this.Deducciones.Controls.Add(this.SeguroSocial);
            this.Deducciones.Controls.Add(this.label5);
            this.Deducciones.Location = new System.Drawing.Point(436, 133);
            this.Deducciones.Name = "Deducciones";
            this.Deducciones.Size = new System.Drawing.Size(226, 185);
            this.Deducciones.TabIndex = 9;
            this.Deducciones.TabStop = false;
            this.Deducciones.Text = "Deducciones";
            // 
            // Total_deducciones
            // 
            this.Total_deducciones.AutoSize = true;
            this.Total_deducciones.Location = new System.Drawing.Point(124, 164);
            this.Total_deducciones.Name = "Total_deducciones";
            this.Total_deducciones.Size = new System.Drawing.Size(19, 13);
            this.Total_deducciones.TabIndex = 9;
            this.Total_deducciones.Text = "$0";
            this.Total_deducciones.Visible = false;
            // 
            // Sindical
            // 
            this.Sindical.AutoSize = true;
            this.Sindical.Location = new System.Drawing.Point(105, 127);
            this.Sindical.Name = "Sindical";
            this.Sindical.Size = new System.Drawing.Size(68, 13);
            this.Sindical.TabIndex = 5;
            this.Sindical.Text = "Del 1% al 3%";
            // 
            // Texto_total_2
            // 
            this.Texto_total_2.AutoSize = true;
            this.Texto_total_2.Location = new System.Drawing.Point(84, 165);
            this.Texto_total_2.Name = "Texto_total_2";
            this.Texto_total_2.Size = new System.Drawing.Size(34, 13);
            this.Texto_total_2.TabIndex = 8;
            this.Texto_total_2.Text = "Total:";
            this.Texto_total_2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cuota sindical:";
            // 
            // IRPF
            // 
            this.IRPF.AutoSize = true;
            this.IRPF.Location = new System.Drawing.Point(63, 87);
            this.IRPF.Name = "IRPF";
            this.IRPF.Size = new System.Drawing.Size(117, 13);
            this.IRPF.TabIndex = 3;
            this.IRPF.Text = "3% sobre percepciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "IRPF:";
            // 
            // SeguroSocial
            // 
            this.SeguroSocial.AutoSize = true;
            this.SeguroSocial.Location = new System.Drawing.Point(103, 54);
            this.SeguroSocial.Name = "SeguroSocial";
            this.SeguroSocial.Size = new System.Drawing.Size(109, 13);
            this.SeguroSocial.TabIndex = 1;
            this.SeguroSocial.Text = "25% de percepciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seguro social:";
            // 
            // Liquido
            // 
            this.Liquido.Controls.Add(this.Total_final);
            this.Liquido.Controls.Add(this.label6);
            this.Liquido.Location = new System.Drawing.Point(125, 344);
            this.Liquido.Name = "Liquido";
            this.Liquido.Size = new System.Drawing.Size(525, 94);
            this.Liquido.TabIndex = 10;
            this.Liquido.TabStop = false;
            this.Liquido.Text = "Liquido";
            this.Liquido.Visible = false;
            // 
            // Imprimir
            // 
            this.Imprimir.Location = new System.Drawing.Point(243, 455);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(83, 29);
            this.Imprimir.TabIndex = 11;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.Location = new System.Drawing.Point(65, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sueldo a recibir:";
            // 
            // Total_final
            // 
            this.Total_final.AutoSize = true;
            this.Total_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Total_final.Location = new System.Drawing.Point(240, 40);
            this.Total_final.Name = "Total_final";
            this.Total_final.Size = new System.Drawing.Size(59, 26);
            this.Total_final.TabIndex = 11;
            this.Total_final.Text = "Total";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.Liquido);
            this.Controls.Add(this.Deducciones);
            this.Controls.Add(this.Percepciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Finish_window);
            this.Controls.Add(this.Most_user);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Percepciones.ResumeLayout(false);
            this.Percepciones.PerformLayout();
            this.Deducciones.ResumeLayout(false);
            this.Deducciones.PerformLayout();
            this.Liquido.ResumeLayout(false);
            this.Liquido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Most_user;
        private System.Windows.Forms.Button Finish_window;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Percepciones;
        private System.Windows.Forms.GroupBox Deducciones;
        private System.Windows.Forms.GroupBox Liquido;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Comisiones;
        private System.Windows.Forms.TextBox Horas_extra;
        private System.Windows.Forms.TextBox Sueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SeguroSocial;
        private System.Windows.Forms.Label Sindical;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label IRPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Total_perce;
        private System.Windows.Forms.Label Texto_total_1;
        private System.Windows.Forms.Label Total_deducciones;
        private System.Windows.Forms.Label Texto_total_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Salario_hora;
        private System.Windows.Forms.Label Total_final;
        private System.Windows.Forms.Label label6;
    }
}