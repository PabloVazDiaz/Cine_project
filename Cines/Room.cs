using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cines
{
    class Room
    {
        public Room(int cont, string movieTitle)
        {
             
            Id = cont+1;
            this.movieTitle = movieTitle;
            this.seats = new List<Seat>();
            this.roomVisual = new RoomVisual();
        }

        public int Id { get; set; }
        public String movieTitle { get; set; }
        public List<Seat> seats { get; set; }
        public RoomVisual roomVisual { get; set; }
     
    }
}
