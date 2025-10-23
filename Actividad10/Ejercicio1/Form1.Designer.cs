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
            listBox2 = new ListBox();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 126);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione de la lista";
            // 
            // btnConfirmarAtencion
            // 
            btnConfirmarAtencion.Location = new Point(261, 196);
            btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            btnConfirmarAtencion.Size = new Size(114, 68);
            btnConfirmarAtencion.TabIndex = 3;
            btnConfirmarAtencion.Text = "Confirmar a cala de atencion solicitud seleccionada";
            btnConfirmarAtencion.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(381, 68);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(245, 199);
            listBox2.TabIndex = 4;
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
            groupBox1.Controls.Add(listBox2);
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
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImportarSolicitudes;
        private ListBox lsbVerSolicitudesImportadas;
        private Label label1;
        private Button btnConfirmarAtencion;
        private ListBox listBox2;
        private Button btnResolverSolicitud;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
