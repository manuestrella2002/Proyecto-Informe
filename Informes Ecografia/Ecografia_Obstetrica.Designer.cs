
namespace Informes_Ecografia
{
    partial class Ecografia_Obstetrica
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
            this.textBox_Solicitante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Higado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Mot_Consulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Edad_ = new System.Windows.Forms.TextBox();
            this.textBox_Fecha_ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Comentarios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AyN_Eco_Abd = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // textBox_Solicitante
            // 
            this.textBox_Solicitante.Location = new System.Drawing.Point(134, 124);
            this.textBox_Solicitante.Name = "textBox_Solicitante";
            this.textBox_Solicitante.Size = new System.Drawing.Size(100, 20);
            this.textBox_Solicitante.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Medico\\a Solicitante:";
            // 
            // comboBox_Higado
            // 
            this.comboBox_Higado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Higado.FormattingEnabled = true;
            this.comboBox_Higado.Items.AddRange(new object[] {
            "0 (Normal)",
            "I",
            "II",
            "III"});
            this.comboBox_Higado.Location = new System.Drawing.Point(147, 218);
            this.comboBox_Higado.Name = "comboBox_Higado";
            this.comboBox_Higado.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Higado.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Grado de Higado Graso:";
            // 
            // textBox_Mot_Consulta
            // 
            this.textBox_Mot_Consulta.Location = new System.Drawing.Point(126, 88);
            this.textBox_Mot_Consulta.Name = "textBox_Mot_Consulta";
            this.textBox_Mot_Consulta.Size = new System.Drawing.Size(100, 20);
            this.textBox_Mot_Consulta.TabIndex = 28;
            this.textBox_Mot_Consulta.TextChanged += new System.EventHandler(this.textBox_Mot_Consulta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Motivo de Consulta:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_Edad_
            // 
            this.textBox_Edad_.Location = new System.Drawing.Point(77, 53);
            this.textBox_Edad_.Name = "textBox_Edad_";
            this.textBox_Edad_.ReadOnly = true;
            this.textBox_Edad_.Size = new System.Drawing.Size(100, 20);
            this.textBox_Edad_.TabIndex = 25;
            // 
            // textBox_Fecha_
            // 
            this.textBox_Fecha_.Location = new System.Drawing.Point(706, 22);
            this.textBox_Fecha_.Name = "textBox_Fecha_";
            this.textBox_Fecha_.ReadOnly = true;
            this.textBox_Fecha_.Size = new System.Drawing.Size(100, 20);
            this.textBox_Fecha_.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha de Informe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Edad:";
            // 
            // textBox_Comentarios
            // 
            this.textBox_Comentarios.AcceptsTab = true;
            this.textBox_Comentarios.AllowDrop = true;
            this.textBox_Comentarios.Location = new System.Drawing.Point(488, 107);
            this.textBox_Comentarios.MaxLength = 590;
            this.textBox_Comentarios.Multiline = true;
            this.textBox_Comentarios.Name = "textBox_Comentarios";
            this.textBox_Comentarios.Size = new System.Drawing.Size(329, 155);
            this.textBox_Comentarios.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Comentarios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Paciente:";
            // 
            // AyN_Eco_Abd
            // 
            this.AyN_Eco_Abd.HideSelection = false;
            this.AyN_Eco_Abd.Location = new System.Drawing.Point(77, 22);
            this.AyN_Eco_Abd.Name = "AyN_Eco_Abd";
            this.AyN_Eco_Abd.ReadOnly = true;
            this.AyN_Eco_Abd.Size = new System.Drawing.Size(153, 20);
            this.AyN_Eco_Abd.TabIndex = 18;
            // 
            // Ecografia_Obstetrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.textBox_Solicitante);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_Higado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Mot_Consulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Edad_);
            this.Controls.Add(this.textBox_Fecha_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Comentarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AyN_Eco_Abd);
            this.Name = "Ecografia_Obstetrica";
            this.Text = "Ecografia_Obstetrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Solicitante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Higado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Mot_Consulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Edad_;
        private System.Windows.Forms.TextBox textBox_Fecha_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Comentarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AyN_Eco_Abd;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}