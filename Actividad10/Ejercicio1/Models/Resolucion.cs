
namespace Ejercicio1.Models;
[Serializable]
public class Resolucion : IExportable
{
    public string Descripcion { get; set; }
    public Resolucion(string descripcion, Solicitud solicitud)
    {
        this.Descripcion = descripcion;
    }

    public string Exportar()
    {
        throw new NotImplementedException();
    }

    public void Importar(string datos)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
