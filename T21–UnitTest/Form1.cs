using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T21_UnitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            string a = calculadora().ToString();
            MessageBox.Show("El resultado es : " + a);
        }
        Geometria g = new Geometria();

        //Metodo que calcula y devulve el resultado
        private double calculadora()
        {
            
            try
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = 0;
                int num3 = 0;
                double a;

                if (rb_cuadrado.Checked)
                {
                    a = g.areacuadrado(num1);
                    return a;
                }
                else if (rb_Circulo.Checked)
                {
                    a = g.areaCirculo(num1);
                    return a;
                }
                else if (rb_triangulo.Checked)
                {
                    num2 = Convert.ToInt32(textBox2.Text);
                    a = g.areatriangulo(num1, num2);
                    return a;

                }
                else if (rb_rectangulo.Checked)
                {
                    num2 = Convert.ToInt32(textBox2.Text);
                    a = g.arearectangulo(num1, num2);
                    return a;

                }
                else if (rb_pentagono.Checked)
                {
                    num2 = Convert.ToInt32(textBox2.Text);
                    a = g.areapentagono(num1, num2);
                    return a;

                }
                else if (rb_Rombo.Checked)
                {
                    num2 = Convert.ToInt32(textBox2.Text);
                    a = g.arearombo(num1, num2);
                    return a;

                }
                else if (rb_romboide.Checked)
                {
                    num2 = Convert.ToInt32(textBox2.Text);
                    a = g.arearomboide(num1, num2);
                    return a;

                }
                else if (rb_trapecio.Checked)
                {
                    num2 = Convert.ToInt32(textBox2.Text);
                    num3 = Convert.ToInt32(textBox3.Text);
                    a = g.areatrapecio(num1, num2, num3);
                    return a;

                }
                else return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Uno o más valores son incorrectos");
                return 0;
            }
           
        }


        //Metodo para mostrar por pantalla los elementos necesarios
        private void showTXT(object sender, EventArgs e)
        {

            if (rb_cuadrado.Checked)
            {
                label1.Text = "Lado :";
                label2.Visible = false; label3.Visible = false;
                textBox2.Visible = false; textBox3.Visible = false;
            }
            else if (rb_Circulo.Checked)
            {
                label1.Text = "Radio :";
                label2.Visible = false; label3.Visible = false;
                textBox2.Visible = false; textBox3.Visible = false;
            }
            else if (rb_triangulo.Checked)
            {
                label1.Text = "Base :";
                label2.Visible = true; label2.Text = "Altura :"; textBox2.Visible = true;
                label3.Visible = false; textBox3.Visible = false;
            }
            else if (rb_rectangulo.Checked)
            {
                label1.Text = "Base :";
                label2.Visible = true; label2.Text = "Altura :"; textBox2.Visible = true;
                label3.Visible = false; textBox3.Visible = false;

            }
            else if (rb_pentagono.Checked)
            {
                label1.Text = "Perimetro :";
                label2.Visible = true; label2.Text = "Apotema :"; textBox2.Visible = true;
                label3.Visible = false; textBox3.Visible = false;
            }
            else if (rb_Rombo.Checked)
            {
                label1.Text = "Diagonal Mayor :";
                label2.Visible = true; label2.Text = "Diagonal menor :"; textBox2.Visible = true;
                label3.Visible = false; textBox3.Visible = false;

            }
            else if (rb_romboide.Checked)
            {
                label1.Text = "Base :";
                label2.Visible = true; label2.Text = "Altura relativa :"; textBox2.Visible = true;
                label3.Visible = false; textBox3.Visible = false;

            }
            else if (rb_trapecio.Checked)
            {
                label1.Text = "Base mayor :";
                label2.Visible = true; label2.Text = "Base menor"; textBox2.Visible = true;
                label3.Visible = true; label3.Text = "Altura :"; textBox3.Visible = true;
            }
        }

      }
    
}
