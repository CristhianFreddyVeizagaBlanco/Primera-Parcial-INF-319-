using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Calculadora
{
    public partial class Form1 : Form
    {
        int valor;
        int valor1;
        int res;
        Boolean sws, swr, swm, swd = true;
        public Form1()
        {
            InitializeComponent();
            valor = 0;
            valor1 = 0;
            res = 0;
            sws = swr = swm = swd = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != ("+") && ((Button)sender).Text != ("-") 
                && ((Button)sender).Text != ("*") && ((Button)sender).Text != ("/") 
                && ((Button)sender).Text != ("C") && ((Button)sender).Text != ("="))
            {
                valor = valor * 10 + Convert.ToInt32(((Button)sender).Text);
                textBox1.Text = valor.ToString();
            }
            else
            {
                if (((Button)sender).Text.Equals("="))
                {
                    if (sws == false)
                    {
                        res = valor1 + valor;
                    }
                    if (swr == false)
                    {
                        res = valor1 - valor;
                    }
                    if (swm == false)
                    {
                        res = valor1 * valor;
                    }
                    if (swd == false)
                    {
                        if (valor != 0)
                        {
                            res = valor1 / valor;
                        }
                    }
                    textBox1.Text = res.ToString();
                    res = 0;
                    sws = swr = swm = swd = true;
                }
                else
                {
                    valor1 = valor;
                    if (((Button)sender).Text == ("+"))
                    {
                        textBox1.Text = "";
                        valor1 = valor;
                        valor = 0;
                        sws = false;
                    }
                    if (((Button)sender).Text == ("-"))
                    {
                        textBox1.Text = "";
                        valor = 0;
                        swr = false;
                    }
                    if (((Button)sender).Text == ("*"))
                    {
                        textBox1.Text = "";
                        valor = 0;
                        swm = false;
                    }
                    if (((Button)sender).Text ==("/"))
                    {
                        textBox1.Text = "";
                        valor = 0;
                        swd = false;
                    }
                }
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor = 0;
            textBox1.Text = "";
            valor1 = 0;
            res = 0;
            sws = swr = swm = swd = true;
        }
    }
}
