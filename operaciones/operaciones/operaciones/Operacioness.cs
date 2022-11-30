using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operaciones
{
    public class Operacioness
    {
        //asignamos atributos
        private decimal num1;
        private decimal num2;

        //constructor para obtener
        //y asignar atributos
        //get y set metodo preconstruidos
        public decimal Num1 { get; set; }
        public decimal Num2 { get; set; }

        //metodo suma
        public decimal Sumarr(decimal x, decimal y)
        {
            decimal r;
            r = x+y;
            return r;
        }

        //metodo resta
        public decimal Restaa(decimal x, decimal y)
        {
            decimal r;
            r = x - y;
            return r;
        }

        //metodo multiplicacion
        public decimal Multiplica(decimal x, decimal y)
        {
            decimal r;
            r = x * y;
            return r;
        }

        //metodo dividir
        public decimal Divide(decimal x, decimal y)
        {
            decimal r;
            r = x / y;
            return r;
        }



    }
}
