using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ejercicio1_Models
{
    [Serializable]
    public class Avion: Transporte
    {
        public string identificador {  get; set; }

        override public double CalcularPrecioFinal()
        {
            double impuesto = base.CalcularPrecioFinal() * 0.30/100;
            double precio= base.CalcularPrecioFinal()* impuesto;
            double iva = precio * 11.5 / 100;
            return precio * iva;

        }
    }
}
