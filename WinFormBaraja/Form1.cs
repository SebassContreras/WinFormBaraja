using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBaraja
{
    public partial class formBaraja : Form
    {
        Baraja baraja = new Baraja();



        public formBaraja()
        {
            InitializeComponent();
        }

        private void butnumCartas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Numero Es: " + baraja.numCartas());
        }

        private void butBaraja_Click(object sender, EventArgs e)
        {
            string mensaje;
            string separator = "\n";

            mensaje= string.Join(separator, baraja.escribeBaraja());

            MessageBox.Show("Lista de Cartas: " + "\n" + mensaje);
        }
    }
}
