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
    public partial class Form1 : Form

    {

        private double numero1;
        private double numero2;
        private string operacao;
        private double resultado;
        private Boolean PressionouIgual;
        public Form1()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            numero1 = 0;
            numero2 = 0;
            operacao = String.Empty;
            resultado = 0;
            PressionouIgual = false;
            txtDisplay.Clear();
        }
        private void Calcular()
        {
            switch (operacao)
            {
                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("Impossivel divisão por zero!",
                            "Aviso de Sistema", MessageBoxButtons.OK);
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

            }
            txtDisplay.Text = resultado.ToString();
        }

        private void adicionarOperacao(string caractere)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                txtDisplay.Clear();
                operacao = caractere;
            }
        }

       

        void adicionarDigito(String digito)
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



     

        private void btnDivide_Click(object sender, EventArgs e)
        {
            adicionarOperacao("/");
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
                Calcular();
                PressionouIgual = true;
            }
        }



            private void button0_Click(object sender, EventArgs e)
          {
            if (!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        } 
        
        private void btnbutton1_Click(object sender, EventArgs e)
        {
            adicionarDigito("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            adicionarDigito("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adicionarDigito("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adicionarDigito("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adicionarDigito("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adicionarDigito("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adicionarDigito("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adicionarDigito("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            adicionarDigito("9");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            adicionarDigito("+");
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            adicionarDigito("-");
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            adicionarDigito("*");
        }

        private void btnPonto_Clik(object sender, EventArgs e)
        {
            if(PressionouIgual)
            {
                LimparCampos();
            }
            if(txtDisplay.Text.Trim().Equals(String.Empty))
            {
                txtDisplay.Text += "0,";
            }
            if (txtDisplay.Text.Trim().Contains(",")) return;
            txtDisplay.Text += ","
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEleva_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "x^2":
                    if (numero1 == 0)
                    {
                        MessageBox.Show("Potencia igual a zero",
                            "Aviso de Sistema", MessageBoxButtons.OK);
                        break;
                    }
                    resultado = numero1 * numero1;
                    break;
            

            }
            txtDisplay.Text = resultado.ToString();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
}
