using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes_Ecografia
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Crear_Informe_Click(object sender, EventArgs e)
        {
            if (TextBox_Tipo_Ecografía.Text == "Abdominal")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal(textBox_Apellido.Text + " " + textBox_Nombre.Text, textBox_Edad.Text, maskedTextBox_Fecha.Text);
                Eco1.ShowDialog();
            }
            /*
            if (TextBox_Tipo_Ecografía.Text == "Cerebral")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
            if (TextBox_Tipo_Ecografía.Text == "Hepatica")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
            if (TextBox_Tipo_Ecografía.Text == "Musculo-esqueletica")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
            if (TextBox_Tipo_Ecografía.Text == "Renal")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
            if (TextBox_Tipo_Ecografía.Text == "Reno-Vesical")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
            if (TextBox_Tipo_Ecografía.Text == "Obstetrica")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
            if (TextBox_Tipo_Ecografía.Text == "Pancreatica")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
            if (TextBox_Tipo_Ecografía.Text == "Testicular")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
            if (TextBox_Tipo_Ecografía.Text == "Transvaginal")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
            if (TextBox_Tipo_Ecografía.Text == "Vesical")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
            if (TextBox_Tipo_Ecografía.Text == "4D")
            {
                this.Hide();
                Ecografia_Abdominal Eco1 = new Ecografia_Abdominal();
                Eco1.ShowDialog();
                this.Show();
            }
        }
            */
        }
    }
}
