using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes_Ecografia
{
    public partial class Ecografia_Abdominal : Form
    {
        public Ecografia_Abdominal(String NyA,string Edad_, string Fecha_)
        {
            InitializeComponent();
            AyN_Eco_Abd.Text = NyA;
            textBox_Edad_.Text = Edad_;
            textBox_Fecha_.Text = Fecha_;
            
        }

        private void AyN_Eco_Abd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();

        }

        private void Imprimir(object sender,PrintPageEventArgs e)
        {
            Font Cabezera = new Font("Franklin Gothic Demi", 16, FontStyle.Bold, GraphicsUnit.Point);
            Font Cuerpo = new Font("Calibri (Body)", 14, FontStyle.Regular, GraphicsUnit.Point);
            Font Titulos = new Font("Calibri (Body)", 14, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Font Ecos = new Font("Calibri (Body)", 10, FontStyle.Regular, GraphicsUnit.Point);
            
            e.Graphics.DrawString("Dra. Marina Irrazabal", Cabezera, Brushes.Black, new Rectangle(10, 10, 500, 500));
            //Pen LapizNegroRect = new Pen(Color.Black, 6.0F);
            //Rectangle Rect_Cabezera = new Rectangle(0, 0, 500, 500);

            //            // Set the DashCap to round.
            //LapizNegroRect.DashCap = System.Drawing.Drawing2D.DashCap.Round;

            //// Create a custom dash pattern.
            //LapizNegroRect.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
            //e.Graphics.DrawRectangle(LapizNegroRect, Rect_Cabezera);


        }
    }
}
