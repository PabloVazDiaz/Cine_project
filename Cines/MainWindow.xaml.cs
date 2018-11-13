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
        List<Room> rooms = new List<Room>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Open_Click(object sender, RoutedEventArgs e)
        {

            ((Room)rooms[MovieListBox.SelectedIndex]).roomVisual.ShowDialog();
            
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            rooms.Add(new Room(MovieListBox.Items.Count, "Cars"));
            MovieListBox.Items.Add(rooms.Last().movieTitle);
            
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
