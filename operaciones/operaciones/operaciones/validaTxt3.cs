using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operaciones
{
    class validaTxt3
    {
        public static bool txtVacios(TextBox pTxt)
        {
            if(pTxt.Text==string.Empty)
            {
                pTxt.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
