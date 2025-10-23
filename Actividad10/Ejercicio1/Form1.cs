using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CentroAtencion centro = new CentroAtencion();
        private void btnImportarSolicitudes_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    centro.ImportarCsvSolicitudesEntrantes(fs);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { if (fs != null) fs.Close(); }
            }
            VerSolicitudesPendientes();
        }
        protected void VerSolicitudesPendientes()
        {

            lsbVerSolicitudesImportadas.Items.Clear();
            LinkedListNode<Solicitud> nodo = centro.GetSolicitudePendiente();
            while (nodo != null)
            {
                lsbVerSolicitudesImportadas.Items.Add(nodo.Value);
                nodo = nodo.Next;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void lsbVerSolicitudesImportadas_SelectedValueChanged(object sender, EventArgs e)
        {
            Solicitud seleccionada = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;
            if (seleccionada != null)
            {

                label1.Text = seleccionada.ToString();
            }
        }

        private void btnConfirmarAtencion_Click(object sender, EventArgs e)
        {
            Solicitud seleccionada = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;
            if (seleccionada != null)
            {
                centro.Atender(seleccionada);
                lsbVerSolicitudesImportadas.Items.Remove(seleccionada);
                lsbColaDeSolicidudesAAtender.Items.Add( seleccionada.ToString());

            }
        }
    }

}
