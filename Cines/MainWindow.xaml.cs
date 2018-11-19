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

namespace Cines
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool? admin;
        List<Room> rooms = new List<Room>();
        public MainWindow(bool? admin)
        {
            InitializeComponent();
            this.admin = admin;
            rooms.Add(new Room(1, "Los vengadores"));
            MovieListBox.Items.Add(rooms.Last().movieTitle);
            rooms.Add(new Room(2, "Memento"));
            MovieListBox.Items.Add(rooms.Last().movieTitle);
        }



        private void Button_Open_Click(object sender, RoutedEventArgs e)
        {
            if (MovieListBox.SelectedIndex >= 0)
            {
                ((Room)rooms[MovieListBox.SelectedIndex]).roomVisual.ShowDialog();
            }
            else
            {
                MessageBox.Show("No has seleccionado sala para abrir");
            }
            
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            InputBox ib = new InputBox();
            ib.ShowDialog();
            rooms.Add(new Room(MovieListBox.Items.Count, ib.title));
            MovieListBox.Items.Add(rooms.Last().movieTitle);
            
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Main_Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (admin==false)
            {
                CreateRoom_Button.Visibility = Visibility.Hidden;
                User_TextBox.Visibility = Visibility.Hidden;
                Pass_TextBox.Visibility = Visibility.Hidden;
                Priv_check.Visibility = Visibility.Hidden;
                NewUser_Button.Visibility = Visibility.Hidden;
                Usuario_label.Visibility = Visibility.Hidden;
                Pass_label.Visibility = Visibility.Hidden;
            }
            else
            {
                CreateRoom_Button.Visibility = Visibility.Visible;
                User_TextBox.Visibility = Visibility.Visible;
                Pass_TextBox.Visibility = Visibility.Visible;
                Priv_check.Visibility = Visibility.Visible;
                NewUser_Button.Visibility = Visibility.Visible;
                Usuario_label.Visibility = Visibility.Visible;
                Pass_label.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (User_TextBox.Text == "")
            {
                MessageBox.Show("Introduce un nombre de usuario válido");
            }
            else
            {
                cineDataSetTableAdapters.usersTableAdapter usersTableAdapter = new cineDataSetTableAdapters.usersTableAdapter();
                usersTableAdapter.InsertUser(User_TextBox.Text, Pass_TextBox.Text, Priv_check.IsChecked);
                MessageBox.Show("Usuario Creado");
                User_TextBox.Text = "";
                Pass_TextBox.Text = "";
            }
        }
    }
}
