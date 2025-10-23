using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models;

[Serializable]
public class Solicitud : IExportable
{
    public int Numero {  get; set; }
    public string Motivo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    /// <param name= "datos">linea a importar<\param>
    public Solicitud() { }
    public Solicitud(int numero, string motivo)
    {
        this.Numero = numero;
        this.Motivo = motivo;
    }

    public string Exportar()
    {
        throw new NotImplementedException();
    }

    public void Importar(string datos)
    {
        string[] campos = datos.Split(';');
        Numero = Convert.ToInt32(campos[0]);
        Motivo = campos[1];
    }

    public override string ToString()
    {
        return $"Numero solicitud: {Numero}, motivo: {Motivo}"; 
    }
}
