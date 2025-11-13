

namespace Ejercicio1_Models;

public abstract class Transporte
{
    public double precioBase {  get; set; }
    public string Destino { get; set; }

    virtual public double CalcularPrecioFinal()
    {
        return precioBase;

    }
}
