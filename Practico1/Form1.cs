using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            TPanel.Text = TApellido.Text + ' ' + TNombre.Text;
        }

        private void BEliminar_Click(Object sender, EventArgs e)
        {
            TPanel.Clear();
        }
    }
}
