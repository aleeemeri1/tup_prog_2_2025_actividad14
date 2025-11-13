

using System.Net.Sockets;

namespace Ejercicio1_Models;


[Serializable]
public class Tickets : IComparable<Tickets>
{
    public DateTime Fecha { get; set; }
    public double precioFinal {  get; set; }
    public string Destino { get; set; }
    public string transporte { get; set; }

    string cuit;
    string nombre;
    string telefono;
    string tarjeta;

    public void Ticket(string cuit, string nombre, string telefono, string tarjeta)
    {
        if (ValidarCuit(cuit) == false)
        {
            throw new Exception("cuit no válido");
        }
        if (ValidarTarjeta(tarjeta) == false)
        {
            throw new Exception("tarjeta no válida");
        }
        this.cuit = cuit;
        this.nombre = nombre;
        this.telefono = telefono;
        this.tarjeta = tarjeta;
    }
    protected bool ValidarCuit(string cuit)
    {
        return cuit.Length == 11;
    }

    protected bool ValidarTarjeta(string tarjeta)
    {
        return tarjeta.Length == 16;

    }

    public int CompareTo(Tickets other)
    {
        if (other != null) Destino.CompareTo(other.Destino);
        return -1;
    }

    public override string ToString ()
    {
        return $"{nombre}({cuit}) {Destino} ${precioFinal:f2}";
    }
}
