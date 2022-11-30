using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operaciones
{
    public partial class Rectangular : Form
    {
        public Rectangular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form prin = new Form1();
            prin.Show();
            this.Close();
        }
    }
}
