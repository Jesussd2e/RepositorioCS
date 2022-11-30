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
    public partial class Form1 : Form
    {
        //instanciando clases
        Validar v = new Validar();//validar enteros
        //metodo suma,reta,mul,divide
        Operacioness op = new Operacioness();
        
       
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void txtnum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
          
        }

        private void txtnum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
           
        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == "" && txtnum2.Text == "")
            {
                errorProvider1.SetError(txtnum1, "No se permiten espacios blanco");
                errorProvider1.SetError(txtnum2, "No se permiten espacios en blanco");
                txtnum1.Focus();
                return;
            }
            errorProvider1.SetError(txtnum1, "");
            errorProvider1.SetError(txtnum2, "");

            op.Num1 = Convert.ToDecimal(txtnum1.Text);
            op.Num2 = Convert.ToDecimal(txtnum2.Text);
            //variable temporal v1
            string v1 = op.Sumarr(Convert.ToDecimal(op.Num1), Convert.ToDecimal(op.Num2)).ToString();
            lbresultado.Text = v1;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtnum2.Clear();
            lbresultado.Text = "R";
            txtnum1.Focus();

        }

        private void lbsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            //alarma de espacios en blanco
            if (txtnum1.Text == "" && txtnum2.Text == "")
            {
                errorProvider1.SetError(txtnum1, "No se permiten espacios blanco");
                errorProvider1.SetError(txtnum2, "No se permiten espacios en blanco");
                txtnum1.Focus();
                return;
            }
            errorProvider1.SetError(txtnum1, "");
            errorProvider1.SetError(txtnum2, "");
            //termina alarma
            op.Num1 = Convert.ToDecimal(txtnum1.Text);
            op.Num2 = Convert.ToDecimal(txtnum2.Text);
            //variable temporal v1
            string v1 = op.Restaa(Convert.ToDecimal(op.Num1), Convert.ToDecimal(op.Num2)).ToString();
            lbresultado.Text = v1;
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            //alarma de espacios en blanco
            if (txtnum1.Text == "" && txtnum2.Text == "")
            {
                errorProvider1.SetError(txtnum1, "No se permiten espacios blanco");
                errorProvider1.SetError(txtnum2, "No se permiten espacios en blanco");
                txtnum1.Focus();
                return;
            }
            errorProvider1.SetError(txtnum1, "");
            errorProvider1.SetError(txtnum2, "");

            //termina alarma
            op.Num1 = Convert.ToDecimal(txtnum1.Text);
            op.Num2 = Convert.ToDecimal(txtnum2.Text);
            //variable temporal v1
            string v1 = op.Multiplica(Convert.ToDecimal(op.Num1), Convert.ToDecimal(op.Num2)).ToString();
            lbresultado.Text = v1;

        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            //alarma de espacios en blanco
            if (txtnum1.Text == "" && txtnum2.Text == "")
            {
                errorProvider1.SetError(txtnum1, "No se permiten espacios blanco");
                errorProvider1.SetError(txtnum2, "No se permiten espacios en blanco");
                txtnum1.Focus();
                return;
            }
            errorProvider1.SetError(txtnum1, "");
            errorProvider1.SetError(txtnum2, "");

            //termina alarma

            op.Num1 = Convert.ToDecimal(txtnum1.Text);
            op.Num2 = Convert.ToDecimal(txtnum2.Text);
            //variable temporal v1
            string v1 = op.Divide(Convert.ToDecimal(op.Num1), Convert.ToDecimal(op.Num2)).ToString();
            lbresultado.Text = v1;

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = checkedListBox1.SelectedIndex;
        }

        private void btnseno_Click(object sender, EventArgs e)
        {
            //alarma espacios en blanco
            if (txtnum1.Text == "" && txtnum2.Text == "")
            {
                errorProvider1.SetError(txtnum1, "No se permiten espacios blanco");
                errorProvider1.SetError(txtnum2, "No se permiten espacios en blanco");
                txtnum1.Focus();
                return;
            }
            errorProvider1.SetError(txtnum1, "");
            errorProvider1.SetError(txtnum2, "");

            //termina alarma
            double numero,factor,resultado;
            int indice = checkedListBox1.SelectedIndex;
            if(indice==0)//grados}
            {
                numero = double.Parse(txtnum1.Text);
                factor = Math.PI / 180;
                resultado = factor * numero;
                lbresultado.Text = Math.Sin(resultado).ToString();

            }
            else//radianes
            {
                numero = double.Parse(txtnum1.Text);
                resultado = Math.Sin(numero);
                lbresultado.Text = resultado.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form rec = new Rectangular();
            rec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form pol = new Polar();
            pol.Show();
        }
    }
}
