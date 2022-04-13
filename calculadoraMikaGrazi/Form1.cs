using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraMikaGrazi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Calculadora
    {
        public partial class Form1 : Form
        {
            private double numero1;
            private double numero2;
            private string operacao;
            private double resultado;
            private Boolean PressionouIgual;

            public Form1()
            {
                InitializeComponent();//metodo especial, onde ele começa a construir
            }

            private void LimparCampos()
            {
                numero1 = 0;
                numero1 = 0;
                operacao = String.Empty;
                resultado = 0;
                PressionouIgual = false;
                txtDisplay.Clear();
            }

            private void Calcular() //método
            {
                switch (operacao)
                {
                    case "/":
                        if (numero2 == 0)
                        {
                            MessageBox.Show("Impossível divisão por zero!", "Aviso do sistema", MessageBoxButtons.OK);
                            break;
                        }
                        resultado = numero1 / numero2;
                        break;
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "^y":
                        resultado = Math.Pow(numero1, numero2);
                        break;
                }
                txtDisplay.Text = resultado.ToString();
            }

            private void adicionarOperacao(string caractere)
            {
                if (!txtDisplay.Text.Trim().Equals(String.Empty))
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                    txtDisplay.Clear(); //limpar display da calculadora
                    operacao = caractere;
                }
            }

            void adicionarDigito(string digito)
            {
                if (txtDisplay.Text.Trim().Equals("0"))
                {
                    txtDisplay.Text = digito;
                }
                else
                {
                    txtDisplay.Text = txtDisplay.Text + digito;
                }
            }

            private void button3_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
            private void btnZero_Click(object sender, EventArgs e)
            {
                adicionarDigito("0");
            }

            private void btnUm_Click(object sender, EventArgs e)
            {
                adicionarDigito("1");
            }

            private void btnDois_Click(object sender, EventArgs e)
            {
                adicionarDigito("2");
            }

            private void btnTres_Click(object sender, EventArgs e)
            {
                adicionarDigito("3");
            }

            private void btnQuatro_Click(object sender, EventArgs e)
            {
                adicionarDigito("4");
            }

            private void btnCinco_Click(object sender, EventArgs e)
            {
                adicionarDigito("5");
            }

            private void btnSeis_Click(object sender, EventArgs e)
            {
                adicionarDigito("6");
            }

            private void btnSete_Click(object sender, EventArgs e)
            {
                adicionarDigito("7");
            }

            private void btnOito_Click(object sender, EventArgs e)
            {
                adicionarDigito("8");
            }

            private void btnNove_Click(object sender, EventArgs e)
            {
                adicionarDigito("9");
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                LimparCampos();
            }

            private void btnIgual_Click(object sender, EventArgs e)
            {
                if (!txtDisplay.Text.Trim().Equals(String.Empty)) ;
                {
                    numero2 = Convert.ToDouble(txtDisplay.Text.Trim());
                    Calcular(); //chama método calcular (que foi criado agora)
                    PressionouIgual = true;
                }

            }

            private void btnSoma_Click(object sender, EventArgs e)
            {
                adicionarOperacao("+");
            }

            private void btnSubtracao_Click(object sender, EventArgs e)
            {
                adicionarOperacao("-");
            }

            private void btnMultiplica_Click(object sender, EventArgs e)
            {
                adicionarOperacao("*");
            }

            private void btnDivide_Click(object sender, EventArgs e)
            {
                adicionarOperacao("/"); //método
            }

            private void bntPonto_Click(object sender, EventArgs e)
            {
                if (PressionouIgual)
                {
                    LimparCampos();
                }
                if (txtDisplay.Text.Trim().Equals(String.Empty))
                {
                    txtDisplay.Text += "0";
                }
                if (txtDisplay.Text.Trim().Contains(",")) return;     //se ja tem um numero
                txtDisplay.Text += ","; // mesma coisa que -> txtDisplay.Text = txtDisplay.Text + (",") | se ele encontrar uma virgula ele volta, do contrario ele faz

            }

            private void btnEleva_Click(object sender, EventArgs e)
            {
                if (!txtDisplay.Text.Trim().Equals(String.Empty))
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                    resultado = Math.Pow(numero1, 2);
                    //resultado = numero1 * numero1;
                    txtDisplay.Text = resultado.ToString();
                }
            }

            private void btnInversao_Click(object sender, EventArgs e)
            {
                if (!txtDisplay.Text.Trim().Equals(String.Empty))
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                    resultado = (-1) * (numero1);
                    txtDisplay.Text = resultado.ToString();
                }
            }

            private void btnC_Click(object sender, EventArgs e)
            {
                txtDisplay.Clear();
            }

            private void btnSqrt_Click(object sender, EventArgs e)
            {
                if (!txtDisplay.Text.Trim().Equals(String.Empty))
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                    resultado = Math.Sqrt(numero1);
                    txtDisplay.Text = resultado.ToString();
                }
            }

            private void btnPower_Click(object sender, EventArgs e)
            {
                adicionarOperacao("^y");
            }

            private void btnFracao_Click(object sender, EventArgs e)
            {
                if (!txtDisplay.Text.Trim().Equals(String.Empty))
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                    resultado = 1 / numero1;
                    txtDisplay.Text = resultado.ToString();
                }
            }

            private void btnBackspace_Click(object sender, EventArgs e)
            {
                if (txtDisplay.TextLength > 0)
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            private void btnCE_Click(object sender, EventArgs e)
            {
                txtDisplay.Clear();
            }

            private void txtDisplay_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }