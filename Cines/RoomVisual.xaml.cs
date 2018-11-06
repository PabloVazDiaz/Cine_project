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
                    seats[cont].Content = string.Format("Row: {0}, Column: {1}", i, j);
                    Grid.SetColumn(seats[cont], i);
                    Grid.SetRow(seats[cont], j);
                    seats[cont].Name = "seat" + i + j;
                    
                    cont++;
                }
            }
            
            
        }
    }
}
