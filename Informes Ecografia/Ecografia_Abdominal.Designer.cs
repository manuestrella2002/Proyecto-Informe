
namespace Informes_Ecografia
{
    partial class Ecografia_Abdominal
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
            this.AyN_Eco_Abd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Comentarios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Fecha_ = new System.Windows.Forms.TextBox();
            this.textBox_Edad_ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.textControl1 = new TXTextControl.TextControl();
            this.SuspendLayout();
            // 
            // AyN_Eco_Abd
            // 
            this.AyN_Eco_Abd.HideSelection = false;
            this.AyN_Eco_Abd.Location = new System.Drawing.Point(88, 27);
            this.AyN_Eco_Abd.Name = "AyN_Eco_Abd";
            this.AyN_Eco_Abd.ReadOnly = true;
            this.AyN_Eco_Abd.Size = new System.Drawing.Size(153, 20);
            this.AyN_Eco_Abd.TabIndex = 0;
            this.AyN_Eco_Abd.TextChanged += new System.EventHandler(this.AyN_Eco_Abd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comentarios:";
            // 
            // textBox_Comentarios
            // 
            this.textBox_Comentarios.AcceptsTab = true;
            this.textBox_Comentarios.AllowDrop = true;
            this.textBox_Comentarios.Location = new System.Drawing.Point(33, 160);
            this.textBox_Comentarios.Multiline = true;
            this.textBox_Comentarios.Name = "textBox_Comentarios";
            this.textBox_Comentarios.Size = new System.Drawing.Size(525, 151);
            this.textBox_Comentarios.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de Informe:";
            // 
            // textBox_Fecha_
            // 
            this.textBox_Fecha_.Location = new System.Drawing.Point(466, 33);
            this.textBox_Fecha_.Name = "textBox_Fecha_";
            this.textBox_Fecha_.ReadOnly = true;
            this.textBox_Fecha_.Size = new System.Drawing.Size(100, 20);
            this.textBox_Fecha_.TabIndex = 6;
            // 
            // textBox_Edad_
            // 
            this.textBox_Edad_.Location = new System.Drawing.Point(75, 58);
            this.textBox_Edad_.Name = "textBox_Edad_";
            this.textBox_Edad_.ReadOnly = true;
            this.textBox_Edad_.Size = new System.Drawing.Size(100, 20);
            this.textBox_Edad_.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // textControl1
            // 
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(515, 99);
            this.textControl1.Name = "textControl1";
            this.textControl1.Size = new System.Drawing.Size(600, 200);
            this.textControl1.TabIndex = 9;
            this.textControl1.Text = "textControl1";
            this.textControl1.UserNames = null;
            // 
            // Ecografia_Abdominal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 350);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Edad_);
            this.Controls.Add(this.textBox_Fecha_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Comentarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AyN_Eco_Abd);
            this.Name = "Ecografia_Abdominal";
            this.Text = "Ecografia_Abdominal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AyN_Eco_Abd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Comentarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Fecha_;
        private System.Windows.Forms.TextBox textBox_Edad_;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TXTextControl.TextControl textControl1;
    }
}