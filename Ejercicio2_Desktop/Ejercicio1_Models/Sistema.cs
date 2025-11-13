

namespace Ejercicio1_Models;

public class Sistema
{
    List<Tickets> tickets = new List<Tickets>();
    List<Transporte> Transportes = new List<Transporte>();

    public void AgregarTransporte(Transporte untransporte)
    {
        Transportes.Add(untransporte);
    }

    public void CrearTickets (string cuit, string nombre,string telefono, string tarjeta)
    {
        Tickets t = new Tickets( cuit , nombre,  telefono,  tarjeta);
        tickets.Add(t);
    }

    public void ImportarTransporte()
    {
        while (!sr.EndOfStream)
        {
            string line = Sr.ReadLine();
            string Campos = line.Split(';');
            string destino = Campos[0];

        }
    }

    public string[] VerTickets()
    {
        string[] lista = new string[tickets.Count];
        tickets.Sort();

        int n = 0;
        foreach (Tickets t in tickets)
        {
            lista[n++] = t.ToString();
        }
        return lista;
    }
}
