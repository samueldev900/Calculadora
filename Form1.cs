using System.Globalization;

namespace Calculadora
{

    public partial class calculadora : Form
    {
        private decimal valor { get; set; }
        private decimal resultado { get; set; }
        private Operacao operacaoSelecionada = Operacao.nulo;


        private enum Operacao
        {
            adicao,
            subtracao,
            multiplicacao,
            divisao,
            nulo
        }

        public calculadora()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private void calculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar se a tecla pressionada é a tecla "0" do teclado
            if (e.KeyChar == '0')
            {
                // Atribuir o valor "0" ao TextBox
                textBox1.Text = "0";

                // Impedir que a tecla "0" seja inserida novamente no TextBox
                e.Handled = true;
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void buttonMais_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                operacaoSelecionada = Operacao.adicao;
                valor = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                operacaoSelecionada = Operacao.subtracao;
                valor = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                operacaoSelecionada = Operacao.divisao;
                valor = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                operacaoSelecionada = Operacao.multiplicacao;
                valor = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = "";
            }
        }


        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                decimal numero;
                if (decimal.TryParse(textBox1.Text, out numero))
                {
                    switch (operacaoSelecionada)
                    {
                        case Operacao.adicao:
                            resultado = valor + numero;
                            break;
                        case Operacao.subtracao:
                            resultado = valor - numero;
                            break;
                        case Operacao.divisao:
                            if (numero != 0) // Verificar divisão por zero
                                resultado = valor / numero;
                            else
                            {
                                MessageBox.Show("Não é possível dividir por zero!");
                                return;
                            }
                            break;
                        case Operacao.multiplicacao:
                            resultado = valor * numero;
                            break;
                        case Operacao.nulo:
                            resultado = 0;
                            valor = 0;
                            break;
                    }

                    string resultadoFormatado = resultado.ToString(CultureInfo.CurrentCulture);

                    // Verificar se o resultado possui vírgula ou ponto decimal
                    // Se for ponto, substituir por vírgula
                    resultadoFormatado = resultadoFormatado.Replace('.', ',');

                    textBox1.Text = resultadoFormatado;


                }
                else
                {
                    MessageBox.Show("Entrada inválida! Insira um valor numérico válido.");
                }
            }
            else
            {
                MessageBox.Show("A caixa de texto está vazia. Insira um valor numérico antes de clicar no botão de igual.");
            }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            valor = 0;
            operacaoSelecionada = Operacao.nulo;

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}