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

namespace Cines
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        cineDataSetTableAdapters.usersTableAdapter usersTableAdapter = new cineDataSetTableAdapters.usersTableAdapter();

        public Login()
        {
            InitializeComponent();
        }

        private void Acept_Button_Click(object sender, RoutedEventArgs e)
        {
           string result=  usersTableAdapter.GetPass(UserTextBox.Text);
            if (result!=null && result.Equals(PassBox.Password))
            {
                MessageBox.Show("Bienvenido, " + result);
                bool? priv = usersTableAdapter.GetPriv(UserTextBox.Text);
                MainWindow mw = new MainWindow(priv);
                
                mw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no válidos");
            }
        }

        private void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Usuarios por defecto \n Usuario=user Pass= user (Sin privilegios) \n Usuario=admin Pass=admin (Privilegios de administrador)");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
