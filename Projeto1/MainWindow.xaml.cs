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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        string login;
        string senha;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login = Properties.Settings.Default.Login;
            senha = Properties.Settings.Default.Senha;

            if (txt_login.Text == login && pwSenha.Password == senha)
            {
                MessageBox.Show("LONGIN CONFIRMADO COM SUCESSO!");
                Calculadora calcu = new Calculadora();
                calcu.ShowDialog();
            }
            else
            {
               MessageBox.Show("LONGIN NEGADO!");
               txt_login.Clear();
               pwSenha.Clear();
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Redefinir alterar = new Redefinir();
            alterar.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
           
        }

        private void bt_Fechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
