using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class CentroAtencion
    {
        LinkedList<Solicitud> SolicitudEntrantes = new LinkedList<Solicitud>();
        Queue<Solicitud> colaDeAtencion = new Queue<Solicitud>();
        public void ImportarCsvSolicitudesEntrantes(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);

            sr.ReadLine();

            while (sr.EndOfStream==false)
            {
                string linea = sr.ReadLine();
                Solicitud solicitud = new Solicitud();
                solicitud.Importar(linea);

                SolicitudEntrantes.AddLast(solicitud);

            }
            sr.Close();
        }
        public LinkedListNode<Solicitud> GetSolicitudePendiente() { return SolicitudEntrantes.First;}
        public void Atender(Solicitud solicitud)
        {
            //Remueve la solicitud de la lista
            if (SolicitudEntrantes.Remove(solicitud))
            {
                colaDeAtencion.Enqueue(solicitud);
            }
        }
        public string[] VerDescripcionColaAtencion()
        {
            string[] descripciones = new string[colaDeAtencion.Count];
            int n = 0;
            foreach (Solicitud solicitud in colaDeAtencion)
            {
                descripciones[n++] = solicitud.ToString();
            }
            return descripciones;
        }
    }
}
