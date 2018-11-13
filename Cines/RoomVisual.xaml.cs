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
                    
                    seats[cont].Content = Update_image(seats[cont]);
                    Grid.SetColumn(seats[cont], i);
                    Grid.SetRow(seats[cont], j);
                    seats[cont].Name = "seat" + i + j;
                    seats[cont].Click += Button_Reserve_Click;
                    
                    
                    SeatGrid.Children.Add(seats[cont]);

                    cont++;
                }
            }
            
            
            
        }
        
        private Grid Update_image(Seat s)
        {
            Grid g = new Grid();
            
            Image img = new Image();
            if(!s.Available)
            {
                img.Source = taken_seat.Source;
            }else if(s.Reserved)
            {
                img.Source = reserved_seat.Source;
            }
            else
            {
                img.Source = seat.Source;

            }

            g.Children.Add(img);
            return g;
            
        }
        
        private void Button_Reserve_Click(object sender, EventArgs e)
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

        private void Button_Click_cancelar(object sender, RoutedEventArgs e)
        {
            ((Seat)sender).Available = true;
            ((Seat)sender).Reserved = false;
            ((Seat)sender).Content = Update_image((Seat)sender);
            

        }

        private void Button_Aceptar_Click(object sender, RoutedEventArgs e)
        {
            foreach(Seat s in seats)
            {
                if (s.Reserved)
                {
                    s.Available = false;
                    s.Content = Update_image(s);
                }

      
            }
        }

        private void Salir_button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void Cancelar_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Seleccione los asientos que quiere cancelar y presione reservar para volver a la funcionalidad normal");
            foreach(Seat s in seats)
            {
                s.Click -= Button_Reserve_Click;
                s.Click += Button_Click_cancelar;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Seat s in seats)
            {
                s.Click -= Button_Click_cancelar;
                s.Click += Button_Reserve_Click;
            }
        }
    }
}
