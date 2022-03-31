using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projeto1
{
    /// <summary>
    /// Lógica interna para Calculadora.xaml
    /// </summary>
    public partial class Calculadora : Window
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;
        bool porcentagem = false;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void bt_Um_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += "1";
            txt_Operação.Text += "1";

        }

        private void bt_Dois_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += "2";
            txt_Operação.Text += "2";
        }

        private void bt_Tres_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += "3";
            txt_Operação.Text += "3";
        }

        private void bt_Quatro_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += "4";
            txt_Operação.Text += "4";
        }

        private void bt_Cinco_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += "5";
            txt_Operação.Text += "5";
        }

        private void bt_Seis_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += "6";
            txt_Operação.Text += "6";
        }

        private void bt_Sete_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += "7";
            txt_Operação.Text += "7";
        }

        private void bt_Oito_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += "8";
            txt_Operação.Text += "8";
        }

        private void bt_Nove_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += "9";
            txt_Operação.Text += "9";
        }

        private void bt_Mais_Click(object sender, RoutedEventArgs e)
        {
            calculo = Convert.ToDecimal(txt_Resposta.Text);

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;

            txt_Operação.Text += "+";
            txt_Resposta.Text = "";
        }

        private void bt_Igualdade_Click(object sender, RoutedEventArgs e)
        {
            resultado = true;
            txt_Operação.Text += "=";

            if(adicao == true)
            {
                txt_Resposta.Text = Convert.ToString(Convert.ToDecimal(txt_Resposta.Text) + calculo);
                txt_Operação.Text += txt_Resposta.Text;
            }
            if (subtracao == true)
            {
                txt_Resposta.Text = Convert.ToString(calculo - Convert.ToDecimal(txt_Resposta.Text));
                txt_Operação.Text += txt_Resposta.Text;
            }
            if (multiplicacao == true)
            {
                txt_Resposta.Text = Convert.ToString(Convert.ToDecimal(txt_Resposta.Text) * calculo);
                txt_Operação.Text += txt_Resposta.Text;
            }
            if (divisao == true)
            {
                txt_Resposta.Text = Convert.ToString(calculo / Convert.ToDecimal(txt_Resposta.Text));
                txt_Operação.Text += txt_Resposta.Text;
            }
           
        }

        private void bt_Limpar_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text = "";
            txt_Operação.Text = "";
        }

        private void bt_Subtracao_Click(object sender, RoutedEventArgs e)
        {
            calculo = Convert.ToDecimal(txt_Resposta.Text);

            subtracao = true;
            adicao = false;
            multiplicacao = false;
            divisao = false;
            porcentagem = false;

            txt_Operação.Text += "-";
            txt_Resposta.Text = "";

        }

        private void bt_Multiplicacao_Click(object sender, RoutedEventArgs e)
        {
            calculo = Convert.ToDecimal(txt_Resposta.Text);

            multiplicacao = true;
            subtracao = false;
            adicao = false;
            divisao = false;
            porcentagem = false;

            txt_Operação.Text += "*";
            txt_Resposta.Text = "";

        }

        private void bt_Divisao_Click(object sender, RoutedEventArgs e)
        {
            calculo = Convert.ToDecimal(txt_Resposta.Text);

            divisao = true;
            multiplicacao = false;
            subtracao = false;
            adicao = false;
            porcentagem = false;

            txt_Operação.Text += "/";
            txt_Resposta.Text = "";

        }

        private void bt_Zero_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += "0";
            txt_Operação.Text += "0";
        }

        private void bt_Ponto_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += ".";
            txt_Operação.Text += ".";
        }

        private void bt_Virgula_Click(object sender, RoutedEventArgs e)
        {
            txt_Resposta.Text += ";";
            txt_Operação.Text += ";";
        }

        private void bt_ApagUltimo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string apagar = txt_Resposta.Text;
                apagar = apagar.Remove(apagar.Length - 1);
                txt_Resposta.Text = apagar;
                txt_Operação.Text = apagar;
            }
            catch(Exception)
            {

            }
        }

        private void bt_Porcentagem_Click(object sender, RoutedEventArgs e)
        {
            //calculo = Convert.ToDecimal(txt_Resposta.Text);

           // porcentagem = true;
          //  divisao = false;
           // multiplicacao = false;
            //subtracao = false;
           // adicao = false;

           // txt_Operação.Text += "%";
            //txt_Resposta.Text = "";
        }
    }
}
