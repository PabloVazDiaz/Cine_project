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
        List<Seat> seats;
        int cont = 0;
        public RoomVisual()
        {
            InitializeComponent();
            seats= new List<Seat>();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    seats.Add(new Seat());
                    //seats[cont].Content = string.Format("Row: {0}, Column: {1}", i, j);
                    //var brush = new ImageBrush();
                    //brush.ImageSource = seat.Source;

                    //seats[cont].Background = brush;
                    seats[cont].Content = Update_image(seats[cont]);
                    Grid.SetColumn(seats[cont], i);
                    Grid.SetRow(seats[cont], j);
                    seats[cont].Name = "seat" + i + j;
                    seats[cont].Click += Button_Click;
                    
                    SeatGrid.Children.Add(seats[cont]);

                    cont++;
                }
            }
            
            
            
        }
        
        private Grid Update_image(Seat s)
        {
            Grid g = new Grid();
            Image img = new Image();
            if(s.Reserved)
            {
                img.Source = reserved_seat.Source;
            }else
            {
                img.Source = seat.Source;
            }
            
            g.Children.Add(img);
            return g;
            
        }
        
        private void Button_Click(object sender, EventArgs e)
        {
            if(((Seat)sender).Available && ((Seat)sender).Reserved)
            {
                ((Seat)sender).Reserved = false;
            }else if(((Seat)sender).Available && !((Seat)sender).Reserved)
            {
                ((Seat)sender).Reserved = true;

            }

            ((Seat)sender).Content = Update_image((Seat)sender);
        }
    }
}
