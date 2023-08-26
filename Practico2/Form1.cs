using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private bool ValidarEntrada(TextBox textBox, char tecla)
        {
            // Verificar si la tecla es una letra, espacio en blanco, tecla de retroceso (Backspace) o tecla de suprimir (Delete).
            if (char.IsLetter(tecla) || char.IsWhiteSpace(tecla) || char.IsControl(tecla))
            {
                return true; // Tecla válida
            }
            else
            {
                return false; // Tecla no válida
            }
        }


        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidarEntrada(TNombre, e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Unicamente pueden ingresarse letras o espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (!char.IsDigit(tecla) && !char.IsControl(tecla))
            {
                e.Handled = true;
                MessageBox.Show("Unicamente pueden ingresarse numeros o espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidarEntrada(TNombre, e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Unicamente pueden ingresarse letras o espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = Properties.Resources.hombre;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox1.Image = Properties.Resources.mujer;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string dni = TDni.Text;
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;

            string resultado = apellido + ", " + nombre;

            if (!string.IsNullOrEmpty(dni) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(nombre) )
            {
            DialogResult result = MessageBox.Show("Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if(result == DialogResult.Yes)
                {
                    LMod.Text = resultado;
                    MessageBox.Show("El Cliente: " + resultado + " se inserto correctamente", "Guardar", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Se deben completar todos los campos obligatorios (*).","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            string resultado = apellido + ", " + nombre;

            DialogResult result = MessageBox.Show("El cliente: " + resultado + " esta apunto de ser eliminado. Esta seguro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                {
                    LMod.Text = "modificar";
                    textBox.Clear();
                }
            }
        }

     
    }
}
