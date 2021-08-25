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

//using Aspose.Words;




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
        
            //printPreviewDialog1 = new PrintPreviewDialog();
            //printPreviewDialog1.Document=printDocument1;
            //printPreviewDialog1.ShowDialog();

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
            e.Graphics.DrawString(AyN_Eco_Abd.Text, Cuerpo, Brushes.Black, 350, 152);

            e.Graphics.DrawString("Solicita: ", Titulos, Brushes.Black, 260, 180);
            e.Graphics.DrawString(textBox_Solicitante.Text, Cuerpo, Brushes.Black, 350, 182);


            e.Graphics.DrawString("Fecha: ", Titulos, Brushes.Black, 260, 220);
            e.Graphics.DrawString(textBox_Fecha_.Text, Cuerpo, Brushes.Black, 350, 222);


            e.Graphics.DrawString("Ecografía: ", Titulos, Brushes.Black, 260, 260);
            
            //FIJARSE TIPO ECOGRAFIA
            e.Graphics.DrawString("Abdominal", Cuerpo, Brushes.Black, 355, 262);


            e.Graphics.DrawString("Motivo de Consulta: ", Titulos, Brushes.Black, 260, 300);
            e.Graphics.DrawString(textBox_Mot_Consulta.Text, Cuerpo, Brushes.Black, 450, 300);


            e.Graphics.DrawString("Informe: ", Titulos, Brushes.Black, 260, 370);

            e.Graphics.DrawString("Comentarios: ", Titulos, Brushes.Black, 260, 860);

            //DEPENDE DE TIPO ECOGRAFIA
            if (comboBox_Higado.Text == "0 (Normal)")
            {
                e.Graphics.DrawString("Páncreas: ", Titulos, Brushes.Black, 260, 400);
                e.Graphics.DrawString("de tamaño y forma normal. Ecoestructura homogenea.\n Ecogenicidad normal.", Cuerpo, Brushes.Black, 350, 402);


                e.Graphics.DrawString("Hígado: ", Titulos, Brushes.Black, 260, 440);
                e.Graphics.DrawString("de tamaño y forma normal. Contornos Regulares.\nEcogenicidad normal y ecoestructura normal.\nVena porta y supra hepáticas de calibre y flujo conservado.", Cuerpo, Brushes.Black, 350, 442);

                e.Graphics.DrawString("Vía biliar intrahepática: ", Titulos, Brushes.Black, 260, 520);
                e.Graphics.DrawString("\t\tde calibre normal.", Cuerpo, Brushes.Black, 350, 522);

                e.Graphics.DrawString("Vía biliar Principal: ", Titulos, Brushes.Black, 260, 560);
                e.Graphics.DrawString("\ts/p.", Cuerpo, Brushes.Black, 370, 562);

                e.Graphics.DrawString("Vesícula: ", Titulos, Brushes.Black, 260, 600);
                e.Graphics.DrawString("distendida, piriforme. Con paredes de grosor normal\ny tabique completo. Alitiásica.", Cuerpo, Brushes.Black, 350, 602);

                e.Graphics.DrawString("Bazo:", Titulos, Brushes.Black, 260, 640);
                e.Graphics.DrawString("de tamaño y forma normal. Contornos Regulares.\nEcogenicidad y ecoestructura conservadas.", Cuerpo, Brushes.Black, 325, 642);

                e.Graphics.DrawString("Aorta y VCS: ", Titulos, Brushes.Black, 260, 680);
                e.Graphics.DrawString("s/p.", Cuerpo, Brushes.Black, 375, 682);

                e.Graphics.DrawString("Riñones: ", Titulos, Brushes.Black, 260, 720);
                e.Graphics.DrawString("de tamaño y forma normal. Contornos regulares.\nEcoestructura y ecogenicidad conservada.\nRelación cortico sinusal normal.", Cuerpo, Brushes.Black, 350, 722);

                e.Graphics.DrawString("Vía excretora: ", Titulos, Brushes.Black, 260, 780);
                e.Graphics.DrawString("\tSin dilatación.", Cuerpo, Brushes.Black, 335, 782);

                e.Graphics.DrawString("Fondo saco de Douglas: ", Titulos, Brushes.Black, 260, 820);
                e.Graphics.DrawString("\t\tLibre.", Cuerpo, Brushes.Black, 340, 822);
            }
            //INFORME ECO ABDOMINAL HIGADO GRASO TIPO I
            else if (comboBox_Higado.Text == "I")
            {
                e.Graphics.DrawString("Páncreas: ", Titulos, Brushes.Black, 260, 400);
                e.Graphics.DrawString("de tamaño y forma normal. Ecoestructura homogénea.\n Ecogenicidad aumentada.", Cuerpo, Brushes.Black, 350, 402);


                e.Graphics.DrawString("Hígado: ", Titulos, Brushes.Black, 260, 440);
                e.Graphics.DrawString("de tamaño y forma normal. Contornos Regulares.\nEcogenicidad normal y ecoestructura heterogénea.\n", Cuerpo, Brushes.Black, 350, 442);

                e.Graphics.DrawString("Higado Graso: ", Titulos, Brushes.Black, 260, 480);
                e.Graphics.DrawString("de tipo I, compatible con paredes\n y diafragma visible.", Cuerpo, Brushes.Black, 385, 482);

                e.Graphics.DrawString("Vía biliar intrahepática: ", Titulos, Brushes.Black, 260, 520);
                e.Graphics.DrawString("\t\tde calibre normal.", Cuerpo, Brushes.Black, 350, 522);

                e.Graphics.DrawString("Vía biliar Principal: ", Titulos, Brushes.Black, 260, 560);
                e.Graphics.DrawString("\ts/p.", Cuerpo, Brushes.Black, 370, 562);

                e.Graphics.DrawString("Vesícula: ", Titulos, Brushes.Black, 260, 600);
                e.Graphics.DrawString("distendida, piriforme. Con paredes de grosor normal\ny tabique completo. Alitiásica.", Cuerpo, Brushes.Black, 350, 602);

                e.Graphics.DrawString("Bazo:", Titulos, Brushes.Black, 260, 640);
                e.Graphics.DrawString("de tamaño y forma normal. Contornos Regulares.\nEcogenicidad y ecoestructura conservadas.", Cuerpo, Brushes.Black, 325, 642);

                e.Graphics.DrawString("Aorta y VCS: ", Titulos, Brushes.Black, 260, 680);
                e.Graphics.DrawString("s/p.", Cuerpo, Brushes.Black, 375, 682);

                e.Graphics.DrawString("Riñones: ", Titulos, Brushes.Black, 260, 720);
                e.Graphics.DrawString("de tamaño y forma normal. Contornos regulares.\nEcoestructura y ecogenicidad conservada.\nRelación cortico sinusal normal.", Cuerpo, Brushes.Black, 350, 722);

                e.Graphics.DrawString("Vía excretora: ", Titulos, Brushes.Black, 260, 780);
                e.Graphics.DrawString("\tSin dilatación.", Cuerpo, Brushes.Black, 335, 782);

                e.Graphics.DrawString("Fondo saco de Douglas: ", Titulos, Brushes.Black, 260, 820);
                e.Graphics.DrawString("\t\tLibre.", Cuerpo, Brushes.Black, 340, 822);
            }
            //INFORME ECO ABDOMINAL HIGADO GRASO TIPO II
            else if (comboBox_Higado.Text == "II")
            {
                e.Graphics.DrawString("Páncreas: ", Titulos, Brushes.Black, 260, 400);
                e.Graphics.DrawString("de tamaño y forma normal. Ecoestructura homogénea.\n Ecogenicidad aumentada.", Cuerpo, Brushes.Black, 350, 402);


                e.Graphics.DrawString("Hígado: ", Titulos, Brushes.Black, 260, 440);
                e.Graphics.DrawString("de tamaño y forma normal. Contornos Regulares.\nEcogenicidad normal y ecoestructura heterogénea.\n", Cuerpo, Brushes.Black, 350, 442);

                e.Graphics.DrawString("Higado Graso: ", Titulos, Brushes.Black, 260, 480);
                e.Graphics.DrawString("de tipo I, compatible con paredes\n y diafragma visible.", Cuerpo, Brushes.Black, 385, 482);

                e.Graphics.DrawString("Vía biliar intrahepática: ", Titulos, Brushes.Black, 260, 520);
                e.Graphics.DrawString("\t\tde calibre normal.", Cuerpo, Brushes.Black, 350, 522);

                e.Graphics.DrawString("Vía biliar Principal: ", Titulos, Brushes.Black, 260, 560);
                e.Graphics.DrawString("\ts/p.", Cuerpo, Brushes.Black, 370, 562);

                e.Graphics.DrawString("Vesícula: ", Titulos, Brushes.Black, 260, 600);
                e.Graphics.DrawString("distendida, piriforme. Con paredes de grosor normal\ny tabique completo. Alitiásica.", Cuerpo, Brushes.Black, 350, 602);

                e.Graphics.DrawString("Bazo:", Titulos, Brushes.Black, 260, 640);
                e.Graphics.DrawString("de tamaño y forma normal. Contornos Regulares.\nEcogenicidad y ecoestructura conservadas.", Cuerpo, Brushes.Black, 325, 642);

                e.Graphics.DrawString("Aorta y VCS: ", Titulos, Brushes.Black, 260, 680);
                e.Graphics.DrawString("s/p.", Cuerpo, Brushes.Black, 375, 682);

                e.Graphics.DrawString("Riñones: ", Titulos, Brushes.Black, 260, 720);
                e.Graphics.DrawString("de tamaño y forma normal. Contornos regulares.\nEcoestructura y ecogenicidad conservada.\nRelación cortico sinusal normal.", Cuerpo, Brushes.Black, 350, 722);

                e.Graphics.DrawString("Vía excretora: ", Titulos, Brushes.Black, 260, 780);
                e.Graphics.DrawString("\tSin dilatación.", Cuerpo, Brushes.Black, 335, 782);

                e.Graphics.DrawString("Fondo saco de Douglas: ", Titulos, Brushes.Black, 260, 820);
                e.Graphics.DrawString("\t\tLibre.", Cuerpo, Brushes.Black, 340, 822);
            }


            if (textBox_Comentarios.Text.Length == 0)
            {
                e.Graphics.DrawString("Sin comentarios.", Cuerpo, Brushes.Black, 260, 882);
            }
            else
            {
                var item = textBox_Comentarios.Text;
                const int interval = 51;
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
                e.Graphics.DrawString(result, Cuerpo, Brushes.Black, 260, 882);

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

        private void textBox_Comentarios_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
