using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operaciones
{
    class Validar
    {
        public void Sololetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//permitir letras
            {
                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))//permitir backspace
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))//permitir avance
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))//permite numeros
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))//permitir control
            {
                e.Handled = false;
            }
            else if (char.IsPunctuation(e.KeyChar))//signos puntuacion
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
         
            else
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
