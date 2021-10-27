
namespace Informes_Ecografia
{
    partial class Ecografia_Cerebral
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
            this.AyN_Eco_Cerebral = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label_VLD = new System.Windows.Forms.Label();
            this.label_VLI = new System.Windows.Forms.Label();
            this.textBox_VLD = new System.Windows.Forms.TextBox();
            this.textBox_VLI = new System.Windows.Forms.TextBox();
            this.label_cm = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Solicitante
            // 
            this.textBox_Solicitante.Location = new System.Drawing.Point(143, 128);
            this.textBox_Solicitante.Name = "textBox_Solicitante";
            this.textBox_Solicitante.Size = new System.Drawing.Size(100, 20);
            this.textBox_Solicitante.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Medico\\a Solicitante:";
            // 
            // textBox_Mot_Consulta
            // 
            this.textBox_Mot_Consulta.Location = new System.Drawing.Point(135, 92);
            this.textBox_Mot_Consulta.Name = "textBox_Mot_Consulta";
            this.textBox_Mot_Consulta.Size = new System.Drawing.Size(100, 20);
            this.textBox_Mot_Consulta.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Motivo de Consulta:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Edad_
            // 
            this.textBox_Edad_.Location = new System.Drawing.Point(86, 57);
            this.textBox_Edad_.Name = "textBox_Edad_";
            this.textBox_Edad_.ReadOnly = true;
            this.textBox_Edad_.Size = new System.Drawing.Size(100, 20);
            this.textBox_Edad_.TabIndex = 25;
            // 
            // textBox_Fecha_
            // 
            this.textBox_Fecha_.Location = new System.Drawing.Point(715, 26);
            this.textBox_Fecha_.Name = "textBox_Fecha_";
            this.textBox_Fecha_.ReadOnly = true;
            this.textBox_Fecha_.Size = new System.Drawing.Size(100, 20);
            this.textBox_Fecha_.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha de Informe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Edad:";
            // 
            // textBox_Comentarios
            // 
            this.textBox_Comentarios.AcceptsTab = true;
            this.textBox_Comentarios.AllowDrop = true;
            this.textBox_Comentarios.Location = new System.Drawing.Point(497, 111);
            this.textBox_Comentarios.MaxLength = 590;
            this.textBox_Comentarios.Multiline = true;
            this.textBox_Comentarios.Name = "textBox_Comentarios";
            this.textBox_Comentarios.Size = new System.Drawing.Size(329, 155);
            this.textBox_Comentarios.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Comentarios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Paciente:";
            // 
            // AyN_Eco_Cerebral
            // 
            this.AyN_Eco_Cerebral.HideSelection = false;
            this.AyN_Eco_Cerebral.Location = new System.Drawing.Point(86, 26);
            this.AyN_Eco_Cerebral.Name = "AyN_Eco_Cerebral";
            this.AyN_Eco_Cerebral.ReadOnly = true;
            this.AyN_Eco_Cerebral.Size = new System.Drawing.Size(153, 20);
            this.AyN_Eco_Cerebral.TabIndex = 18;
            this.AyN_Eco_Cerebral.TextChanged += new System.EventHandler(this.AyN_Eco_Cerebral_TextChanged);
            // 
            // label_VLD
            // 
            this.label_VLD.AutoSize = true;
            this.label_VLD.Location = new System.Drawing.Point(28, 158);
            this.label_VLD.Name = "label_VLD";
            this.label_VLD.Size = new System.Drawing.Size(31, 13);
            this.label_VLD.TabIndex = 33;
            this.label_VLD.Text = "VLD:";
            // 
            // label_VLI
            // 
            this.label_VLI.AutoSize = true;
            this.label_VLI.Location = new System.Drawing.Point(28, 183);
            this.label_VLI.Name = "label_VLI";
            this.label_VLI.Size = new System.Drawing.Size(26, 13);
            this.label_VLI.TabIndex = 34;
            this.label_VLI.Text = "VLI:";
            // 
            // textBox_VLD
            // 
            this.textBox_VLD.Location = new System.Drawing.Point(69, 154);
            this.textBox_VLD.Name = "textBox_VLD";
            this.textBox_VLD.Size = new System.Drawing.Size(45, 20);
            this.textBox_VLD.TabIndex = 35;
            this.textBox_VLD.TextChanged += new System.EventHandler(this.textBox_VLD_TextChanged);
            // 
            // textBox_VLI
            // 
            this.textBox_VLI.Location = new System.Drawing.Point(69, 180);
            this.textBox_VLI.Name = "textBox_VLI";
            this.textBox_VLI.Size = new System.Drawing.Size(45, 20);
            this.textBox_VLI.TabIndex = 36;
            // 
            // label_cm
            // 
            this.label_cm.AutoSize = true;
            this.label_cm.Location = new System.Drawing.Point(120, 161);
            this.label_cm.Name = "label_cm";
            this.label_cm.Size = new System.Drawing.Size(21, 13);
            this.label_cm.TabIndex = 37;
            this.label_cm.Text = "cm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "cm";
            // 
            // Ecografia_Cerebral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 333);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_cm);
            this.Controls.Add(this.textBox_VLI);
            this.Controls.Add(this.textBox_VLD);
            this.Controls.Add(this.label_VLI);
            this.Controls.Add(this.label_VLD);
            this.Controls.Add(this.textBox_Solicitante);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.AyN_Eco_Cerebral);
            this.Name = "Ecografia_Cerebral";
            this.Text = "Ecografia_Cerebral";
            this.Load += new System.EventHandler(this.Ecografia_Cerebral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Solicitante;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.TextBox AyN_Eco_Cerebral;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label_VLD;
        private System.Windows.Forms.Label label_VLI;
        private System.Windows.Forms.TextBox textBox_VLD;
        private System.Windows.Forms.TextBox textBox_VLI;
        private System.Windows.Forms.Label label_cm;
        private System.Windows.Forms.Label label6;
    }
}