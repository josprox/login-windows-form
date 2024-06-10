
namespace idusers
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Test = new System.Windows.Forms.Button();
            this.Registrar_button = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Conect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(304, 56);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(100, 20);
            this.Usuario.TabIndex = 0;
            // 
            // Contra
            // 
            this.Contra.Location = new System.Drawing.Point(304, 98);
            this.Contra.Name = "Contra";
            this.Contra.PasswordChar = '*';
            this.Contra.Size = new System.Drawing.Size(100, 20);
            this.Contra.TabIndex = 1;
            this.Contra.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Test);
            this.groupBox1.Controls.Add(this.Registrar_button);
            this.groupBox1.Controls.Add(this.Regresar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.Conect);
            this.groupBox1.Controls.Add(this.Usuario);
            this.groupBox1.Controls.Add(this.Contra);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(396, 19);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 9;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Visible = false;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // Registrar_button
            // 
            this.Registrar_button.Location = new System.Drawing.Point(210, 173);
            this.Registrar_button.Name = "Registrar_button";
            this.Registrar_button.Size = new System.Drawing.Size(75, 23);
            this.Registrar_button.TabIndex = 8;
            this.Registrar_button.Text = "Registrar";
            this.Registrar_button.UseVisualStyleBackColor = true;
            this.Registrar_button.Click += new System.EventHandler(this.Registrar_button_Click);
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(291, 173);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(75, 23);
            this.Regresar.TabIndex = 7;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de usuario";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(372, 173);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Salir";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Conect
            // 
            this.Conect.Location = new System.Drawing.Point(317, 124);
            this.Conect.Name = "Conect";
            this.Conect.Size = new System.Drawing.Size(75, 23);
            this.Conect.TabIndex = 2;
            this.Conect.Text = "Conectar";
            this.Conect.UseVisualStyleBackColor = true;
            this.Conect.Click += new System.EventHandler(this.Conect_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 291);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Conect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button Registrar_button;
        private System.Windows.Forms.Button Test;
    }
}