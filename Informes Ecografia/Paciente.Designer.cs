
namespace Informes_Ecografia
{
    partial class Paciente
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
            this.Apellido = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.maskedTextBox_Fecha = new System.Windows.Forms.MaskedTextBox();
            this.Edad = new System.Windows.Forms.Label();
            this.textBox_Edad = new System.Windows.Forms.TextBox();
            this.Ecografía = new System.Windows.Forms.Label();
            this.TextBox_Tipo_Ecografía = new System.Windows.Forms.ComboBox();
            this.button_Crear_Informe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(57, 36);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 0;
            this.Apellido.Text = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(57, 85);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(370, 36);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 2;
            this.Fecha.Text = "Fecha";
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(102, 33);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_Apellido.TabIndex = 3;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(102, 85);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre.TabIndex = 4;
            // 
            // maskedTextBox_Fecha
            // 
            this.maskedTextBox_Fecha.Location = new System.Drawing.Point(413, 33);
            this.maskedTextBox_Fecha.Mask = "00/00/0000";
            this.maskedTextBox_Fecha.Name = "maskedTextBox_Fecha";
            this.maskedTextBox_Fecha.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBox_Fecha.TabIndex = 6;
            this.maskedTextBox_Fecha.ValidatingType = typeof(System.DateTime);
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Location = new System.Drawing.Point(57, 146);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(32, 13);
            this.Edad.TabIndex = 7;
            this.Edad.Text = "Edad";
            // 
            // textBox_Edad
            // 
            this.textBox_Edad.Location = new System.Drawing.Point(102, 143);
            this.textBox_Edad.Name = "textBox_Edad";
            this.textBox_Edad.Size = new System.Drawing.Size(43, 20);
            this.textBox_Edad.TabIndex = 8;
            // 
            // Ecografía
            // 
            this.Ecografía.AutoSize = true;
            this.Ecografía.Location = new System.Drawing.Point(57, 195);
            this.Ecografía.Name = "Ecografía";
            this.Ecografía.Size = new System.Drawing.Size(54, 13);
            this.Ecografía.TabIndex = 9;
            this.Ecografía.Text = "Ecografía";
            this.Ecografía.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBox_Tipo_Ecografía
            // 
            this.TextBox_Tipo_Ecografía.FormattingEnabled = true;
            this.TextBox_Tipo_Ecografía.Items.AddRange(new object[] {
            "Abdominal",
            "Cerebal",
            "Obstetrica",
            "Hepatica",
            "Musculo-esqueletica",
            "Renal",
            "Reno-Vesical",
            "Obstetrica",
            "Pancreatica",
            "Testicular",
            "Transvaginal",
            "Vesical",
            "4D",
            "",
            ""});
            this.TextBox_Tipo_Ecografía.Location = new System.Drawing.Point(118, 195);
            this.TextBox_Tipo_Ecografía.Name = "TextBox_Tipo_Ecografía";
            this.TextBox_Tipo_Ecografía.Size = new System.Drawing.Size(121, 21);
            this.TextBox_Tipo_Ecografía.TabIndex = 10;
            // 
            // button_Crear_Informe
            // 
            this.button_Crear_Informe.Location = new System.Drawing.Point(392, 101);
            this.button_Crear_Informe.Name = "button_Crear_Informe";
            this.button_Crear_Informe.Size = new System.Drawing.Size(96, 30);
            this.button_Crear_Informe.TabIndex = 11;
            this.button_Crear_Informe.Text = "Crear Informe";
            this.button_Crear_Informe.UseVisualStyleBackColor = true;
            this.button_Crear_Informe.Click += new System.EventHandler(this.button_Crear_Informe_Click);
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 340);
            this.Controls.Add(this.button_Crear_Informe);
            this.Controls.Add(this.TextBox_Tipo_Ecografía);
            this.Controls.Add(this.Ecografía);
            this.Controls.Add(this.textBox_Edad);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.maskedTextBox_Fecha);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Apellido);
            this.Name = "Paciente";
            this.Text = "Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Fecha;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.TextBox textBox_Edad;
        private System.Windows.Forms.Label Ecografía;
        private System.Windows.Forms.ComboBox TextBox_Tipo_Ecografía;
        private System.Windows.Forms.Button button_Crear_Informe;
    }
}