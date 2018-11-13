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
    /// Lógica de interacción para RoomVisual.xaml
    /// </summary>
    public partial class RoomVisual : Window
    {
        public List<Button> seats;
        int cont = 0;
        public RoomVisual()
        {
            InitializeComponent();
            seats= new List<Button>();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    seats.Add(new Button());
                    //seats[cont].Content = string.Format("Row: {0}, Column: {1}", i, j);
                    //var brush = new ImageBrush();
                    //brush.ImageSource = seat.Source;

                    //seats[cont].Background = brush;
                    seats[cont].Content = Update_image();
                    Grid.SetColumn(seats[cont], i);
                    Grid.SetRow(seats[cont], j);
                    seats[cont].Name = "seat" + i + j;
                    seats[cont].Click += Button_Click;
                    
                    SeatGrid.Children.Add(seats[cont]);

                    cont++;
                }
            }
            
            
            
        }
        
        private Grid Update_image()
        {
            Grid g = new Grid();
            Image img = new Image();
            img.Source = seat.Source;
            g.Children.Add(img);
            return g;
            
        }
        
        private void Button_Click(Object sender, EventArgs e)
        {

            var brush = new ImageBrush();
            brush.ImageSource = reserved_seat.Source;
            ((Button)sender).Background = brush;
        }
    }
}
