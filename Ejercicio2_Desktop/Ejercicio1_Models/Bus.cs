using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Models
{
    [Serializable]
    public class Bus: Transporte
    {
        public string Patente {  get; set; }
        public int Clase { get; set; }

        override public double CalcularPrecioFinal()
        {
            double precio = base.CalcularPrecioFinal();
            double iva = precio * 21.5 / 100;
            return precio + iva;
        }
    }
}
