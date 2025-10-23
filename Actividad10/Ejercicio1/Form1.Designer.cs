namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImportarSolicitudes = new Button();
            lsbVerSolicitudesImportadas = new ListBox();
            label1 = new Label();
            btnConfirmarAtencion = new Button();
            lsbColaDeSolicidudesAAtender = new ListBox();
            btnResolverSolicitud = new Button();
            groupBox1 = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnImportarSolicitudes
            // 
            btnImportarSolicitudes.Location = new Point(6, 22);
            btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            btnImportarSolicitudes.Size = new Size(96, 40);
            btnImportarSolicitudes.TabIndex = 0;
            btnImportarSolicitudes.Text = "Importar Solicitudes";
            btnImportarSolicitudes.UseVisualStyleBackColor = true;
            btnImportarSolicitudes.Click += btnImportarSolicitudes_Click;
            // 
            // lsbVerSolicitudesImportadas
            // 
            lsbVerSolicitudesImportadas.FormattingEnabled = true;
            lsbVerSolicitudesImportadas.ItemHeight = 15;
            lsbVerSolicitudesImportadas.Location = new Point(6, 68);
            lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            lsbVerSolicitudesImportadas.Size = new Size(248, 199);
            lsbVerSolicitudesImportadas.TabIndex = 1;
            lsbVerSolicitudesImportadas.SelectedValueChanged += lsbVerSolicitudesImportadas_SelectedValueChanged;
            // 
            // label1
            // 
            label1.Location = new Point(260, 134);
            label1.Name = "label1";
            label1.Size = new Size(115, 59);
            label1.TabIndex = 2;
            label1.Text = "Seleccione de la lista";
            label1.Click += label1_Click;
            // 
            // btnConfirmarAtencion
            // 
            btnConfirmarAtencion.Location = new Point(261, 196);
            btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            btnConfirmarAtencion.Size = new Size(114, 68);
            btnConfirmarAtencion.TabIndex = 3;
            btnConfirmarAtencion.Text = "Confirmar a cola de atencion solicitud seleccionada";
            btnConfirmarAtencion.UseVisualStyleBackColor = true;
            btnConfirmarAtencion.Click += btnConfirmarAtencion_Click;
            // 
            // lsbColaDeSolicidudesAAtender
            // 
            lsbColaDeSolicidudesAAtender.FormattingEnabled = true;
            lsbColaDeSolicidudesAAtender.ItemHeight = 15;
            lsbColaDeSolicidudesAAtender.Location = new Point(381, 68);
            lsbColaDeSolicidudesAAtender.Name = "lsbColaDeSolicidudesAAtender";
            lsbColaDeSolicidudesAAtender.Size = new Size(245, 199);
            lsbColaDeSolicidudesAAtender.TabIndex = 4;
            // 
            // btnResolverSolicitud
            // 
            btnResolverSolicitud.Location = new Point(651, 77);
            btnResolverSolicitud.Name = "btnResolverSolicitud";
            btnResolverSolicitud.Size = new Size(75, 46);
            btnResolverSolicitud.TabIndex = 5;
            btnResolverSolicitud.Text = "Resolver Solicitud";
            btnResolverSolicitud.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImportarSolicitudes);
            groupBox1.Controls.Add(btnResolverSolicitud);
            groupBox1.Controls.Add(lsbVerSolicitudesImportadas);
            groupBox1.Controls.Add(lsbColaDeSolicidudesAAtender);
            groupBox1.Controls.Add(btnConfirmarAtencion);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(746, 270);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 294);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnImportarSolicitudes;
        private Button btnConfirmarAtencion;
        private Button btnResolverSolicitud;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        public ListBox lsbVerSolicitudesImportadas;
        public ListBox lsbColaDeSolicidudesAAtender;
        public Label label1;
    }
}
