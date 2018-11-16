using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cines
{
    public partial class InputBox : Form
    {
        public string title;
        public InputBox()
        {
            InitializeComponent();
        }

        private void Acept_Button_Click(object sender, EventArgs e)
        {
            if (Pelicula_text_Box?.Text!= "")
            {
                title= Pelicula_text_Box.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduce un nombre valido");
            }
        }
    }
}
