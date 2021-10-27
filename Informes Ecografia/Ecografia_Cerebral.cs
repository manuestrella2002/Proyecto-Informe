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
using System.IO;
using System.Reflection;
using System.Security.Permissions;


namespace Informes_Ecografia
{
    public partial class Ecografia_Cerebral : Form
    {
        public Ecografia_Cerebral(String NyA, string Edad_, string Fecha_)
        {
            InitializeComponent();
            AyN_Eco_Cerebral.Text = NyA;
            textBox_Edad_.Text = Edad_;
            textBox_Fecha_.Text = Fecha_;
            

        }

        private void Ecografia_Cerebral_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();

            printDocument1.PrinterSettings = ps;

            printDocument1.PrintPage += Imprimir;

            //printPreviewDialog1 = new PrintPreviewDialog();
            //printPreviewDialog1.Document=printDocument1;
            //printPreviewDialog1.Show();

            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font Cabezera = new Font("Franklin Gothic Demi", 16, FontStyle.Bold, GraphicsUnit.Point);
            Font Cuerpo = new Font("Cambria", 12, FontStyle.Regular, GraphicsUnit.Point);
            Font Titulos = new Font("Cambria", 14, FontStyle.Bold | FontStyle.Underline);
            Font Ecos = new Font("Cambria", 8, FontStyle.Regular, GraphicsUnit.Point);
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Imagenes\Icono.png");

            System.Drawing.Image img = System.Drawing.Image.FromFile(path);
            Point loc = new Point(100, 100);
            e.Graphics.DrawImage(img, new Rectangle(625, 45, 100, 85));

            e.Graphics.DrawString("Dra. Marina Irrazabal", Cabezera, Brushes.Black, 400, 50);
            e.Graphics.DrawString("\nEspecialista en Diagnostico por Imagenes", Cabezera, Brushes.Black, 198, 50);
            e.Graphics.DrawString("\n\nM.P.:1581 \t M.E.:831", Cabezera, Brushes.Black, 250, 50);

            Pen Linea = new Pen(Brushes.Black, 2);
            Linea.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;

            e.Graphics.DrawLine(Linea, 50, 135, 775, 135);
            e.Graphics.DrawLine(Linea, 250, 135, 250, 1150);
            e.Graphics.DrawLine(Linea, 50, 40, 50, 1150);
            e.Graphics.DrawLine(Linea, 775, 40, 775, 1150);
            e.Graphics.DrawLine(Linea, 50, 40, 775, 40);
            e.Graphics.DrawLine(Linea, 50, 1150, 775, 1150);
            e.Graphics.DrawLine(Linea, 250, 330, 775, 330);


            e.Graphics.DrawString("Paciente: ", Titulos, Brushes.Black, 260, 150);
            e.Graphics.DrawString(AyN_Eco_Cerebral.Text, Cuerpo, Brushes.Black, 350, 152);

            e.Graphics.DrawString("Solicita: ", Titulos, Brushes.Black, 260, 180);
            e.Graphics.DrawString(textBox_Solicitante.Text, Cuerpo, Brushes.Black, 350, 182);


            e.Graphics.DrawString("Fecha: ", Titulos, Brushes.Black, 260, 220);
            e.Graphics.DrawString(textBox_Fecha_.Text, Cuerpo, Brushes.Black, 350, 222);


            e.Graphics.DrawString("Ecografía: ", Titulos, Brushes.Black, 260, 260);

            //FIJARSE TIPO ECOGRAFIA
            e.Graphics.DrawString("Cerebral", Cuerpo, Brushes.Black, 355, 262);


            e.Graphics.DrawString("Motivo de Consulta: ", Titulos, Brushes.Black, 260, 300);
            e.Graphics.DrawString(textBox_Mot_Consulta.Text, Cuerpo, Brushes.Black, 450, 302);


            e.Graphics.DrawString("Informe: ", Titulos, Brushes.Black, 260, 370);

            e.Graphics.DrawString("Cortes coronales y sagitales realizados a nivel de la fontanela anterior:", Cuerpo, Brushes.Black,260, 400);

            e.Graphics.DrawString("Estructuras Infraselares: ", Titulos, Brushes.Black, 260, 440);
            e.Graphics.DrawString("tronco y cerebelo son de tamaño\n y forma normal. Ecoestructura y \necogenicidad conservadas.", Cuerpo, Brushes.Black, 500, 442);

            e.Graphics.DrawString("Ventriculos: ", Titulos, Brushes.Black, 260, 520);
           
            e.Graphics.DrawString("Tercer Ventriculo:", Titulos, Brushes.Black, 280, 540);
            e.Graphics.DrawString("de forma y tamaño normal.", Cuerpo, Brushes.Black, 450, 542);

            e.Graphics.DrawString("Cuarto Ventriculo:", Titulos, Brushes.Black, 280, 560);
            e.Graphics.DrawString("de forma y tamaño normal.", Cuerpo, Brushes.Black, 450, 562);
            
            e.Graphics.DrawString("Ventriculos Laterales:", Titulos, Brushes.Black, 280, 580);
            e.Graphics.DrawString("VLD:"+textBox_VLD.Text+"cm"+"\tVLI:"+textBox_VLI.Text+"cm", Cuerpo, Brushes.Black, 500, 582);


            e.Graphics.DrawString("Plexos coroideos:", Titulos, Brushes.Black, 260, 620);
            e.Graphics.DrawString("de tamaño y forma normal. Contornos Regulares.\nEcogenicidad y ecoestructura conservadas.", Cuerpo, Brushes.Black, 420, 622);

            e.Graphics.DrawString("Nucleos Basales: ", Titulos, Brushes.Black, 260, 660);
            e.Graphics.DrawString("de caracteristicas normales.", Cuerpo, Brushes.Black, 410, 662);

            e.Graphics.DrawString("Cuerpo Calloso: ", Titulos, Brushes.Black, 260, 700);
            e.Graphics.DrawString("de caracteristicas normales.", Cuerpo, Brushes.Black, 410, 702);


            e.Graphics.DrawString("Parénquima Cerebral: ", Titulos, Brushes.Black, 260, 740);
            e.Graphics.DrawString("ecoestructura y ecogenicidad conservada.", Cuerpo, Brushes.Black, 460, 742);

            e.Graphics.DrawString("Surcos subaracnoideos: ", Titulos, Brushes.Black, 260, 780);
            e.Graphics.DrawString("Normales.", Cuerpo, Brushes.Black, 475, 782);


            e.Graphics.DrawString("Comentarios: ", Titulos, Brushes.Black, 260, 860);

            if (textBox_Comentarios.Text.Length==0)
            {
                e.Graphics.DrawString("Sin comentarios.", Cuerpo, Brushes.Black, 260, 882);
            }
            else
            {
                e.Graphics.DrawString(BajarTexto(textBox_Comentarios.Text), Cuerpo, Brushes.Black, 260, 902);
            }


            //ESTRUCTURA INFORME 
            e.Graphics.DrawString("DOPPLER FETAL", Ecos, Brushes.Gray, 55, 150);
            e.Graphics.DrawString("DOPPLER", Ecos, Brushes.Gray, 55, 190);
            e.Graphics.DrawString("DOPPLER HEPATICO", Ecos, Brushes.Gray, 55, 230);
            e.Graphics.DrawString("DOPPLER OBSTETRICO", Ecos, Brushes.Gray, 55, 270);
            e.Graphics.DrawString("DOPPLER RENAL", Ecos, Brushes.Gray, 55, 310);
            e.Graphics.DrawString("DOPPLER VENOSO", Ecos, Brushes.Gray, 55, 350);
            e.Graphics.DrawString("ECOGRAFIA 2D", Ecos, Brushes.Gray, 55, 390);
            e.Graphics.DrawString("ECOGRAFIA 3D", Ecos, Brushes.Gray, 55, 430);
            e.Graphics.DrawString("ECOGRAFIA 4D", Ecos, Brushes.Gray, 55, 470);
            e.Graphics.DrawString("ECOGRAFIA ABDOMINAL", Ecos, Brushes.Gray, 55, 510);
            e.Graphics.DrawString("ECOGRAFIA ARTICULAR", Ecos, Brushes.Gray, 55, 550);
            e.Graphics.DrawString("ECOGRAFIA BILATERAL", Ecos, Brushes.Gray, 55, 590);
            e.Graphics.DrawString("ECOGRAFIA CEREBRAL", Ecos, Brushes.Gray, 55, 630);
            e.Graphics.DrawString("ECOGRAFIA DE CADERA", Ecos, Brushes.Gray, 55, 670);
            e.Graphics.DrawString("ECOGRAFIA DE CUELLO", Ecos, Brushes.Gray, 55, 710);
            e.Graphics.DrawString("ECOGRAFIA DE PARTES BLANDAS", Ecos, Brushes.Gray, 55, 750);
            e.Graphics.DrawString("ECOGRAFIA GINECOLOGICA", Ecos, Brushes.Gray, 55, 790);
            e.Graphics.DrawString("HEPATOBILIOPANCREATICA", Ecos, Brushes.Gray, 55, 830);
            e.Graphics.DrawString("ECOGRAFIA MAMARIA", Ecos, Brushes.Gray, 55, 870);
            e.Graphics.DrawString("ECOGRAFIA RENAL", Ecos, Brushes.Gray, 55, 910);
            e.Graphics.DrawString("ECOGRAFIA RENOVESICAL", Ecos, Brushes.Gray, 55, 950);
            e.Graphics.DrawString("ECOGRAFIA TESTICULAR", Ecos, Brushes.Gray, 55, 990);
            e.Graphics.DrawString("TRANSLUCENCIA NUCAL", Ecos, Brushes.Gray, 55, 1030);
            e.Graphics.DrawString("SCAN MORFOLOGICO FETAL", Ecos, Brushes.Gray, 55, 1070);
            e.Graphics.DrawString("TRIPLE SCREENING", Ecos, Brushes.Gray, 55, 1090);
            e.Graphics.DrawString("ECOGRAFIA TRANSVAGINAL", Ecos, Brushes.Gray, 55, 1130);
        }
        public string BajarTexto(string texto_)
        {
            var item = texto_;
            const int interval = 55;
            var words = item.Split();
            var result = "";
            var symbolsInCurrentLine = 0;
            foreach (var word in words)
            {
                if (word.Length + symbolsInCurrentLine > interval)  // after adding word line will be longer than required
                {
                    result += "\n";
                    symbolsInCurrentLine = 0;
                }
                else
                {
                    if (symbolsInCurrentLine > 0)  // add space after previous word if needed
                    {
                        result += " ";
                        symbolsInCurrentLine++;
                    }
                    result += word;  // append word
                    symbolsInCurrentLine += word.Length;
                }
            }
            return result;
        }

        private void AyN_Eco_Cerebral_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_VLD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
