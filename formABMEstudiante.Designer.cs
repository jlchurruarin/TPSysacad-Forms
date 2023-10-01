namespace TPSysacad___Forms
{
    partial class formABMEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpEstudiante = new TableLayoutPanel();
            tacEstudiante = new TabControl();
            tabDatosPersonales = new TabPage();
            tabCursosInscriptos = new TabPage();
            tabPagos = new TabPage();
            btnGuardar = new Button();
            btnCancelar = new Button();
            tlpDatosPersonales = new TableLayoutPanel();
            tlpEstudiante.SuspendLayout();
            tacEstudiante.SuspendLayout();
            tabDatosPersonales.SuspendLayout();
            SuspendLayout();
            // 
            // tlpEstudiante
            // 
            tlpEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpEstudiante.ColumnCount = 2;
            tlpEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpEstudiante.Controls.Add(btnCancelar, 1, 1);
            tlpEstudiante.Controls.Add(tacEstudiante, 0, 0);
            tlpEstudiante.Controls.Add(btnGuardar, 1, 0);
            tlpEstudiante.Location = new Point(12, 12);
            tlpEstudiante.Name = "tlpEstudiante";
            tlpEstudiante.RowCount = 3;
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEstudiante.Size = new Size(827, 536);
            tlpEstudiante.TabIndex = 0;
            // 
            // tacEstudiante
            // 
            tacEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tacEstudiante.Controls.Add(tabDatosPersonales);
            tacEstudiante.Controls.Add(tabCursosInscriptos);
            tacEstudiante.Controls.Add(tabPagos);
            tacEstudiante.Location = new Point(3, 3);
            tacEstudiante.Name = "tacEstudiante";
            tlpEstudiante.SetRowSpan(tacEstudiante, 3);
            tacEstudiante.SelectedIndex = 0;
            tacEstudiante.Size = new Size(671, 530);
            tacEstudiante.TabIndex = 0;
            // 
            // tabDatosPersonales
            // 
            tabDatosPersonales.Controls.Add(tlpDatosPersonales);
            tabDatosPersonales.Location = new Point(4, 24);
            tabDatosPersonales.Name = "tabDatosPersonales";
            tabDatosPersonales.Padding = new Padding(3);
            tabDatosPersonales.Size = new Size(663, 502);
            tabDatosPersonales.TabIndex = 0;
            tabDatosPersonales.Text = "Datos Personales";
            tabDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // tabCursosInscriptos
            // 
            tabCursosInscriptos.Location = new Point(4, 24);
            tabCursosInscriptos.Name = "tabCursosInscriptos";
            tabCursosInscriptos.Padding = new Padding(3);
            tabCursosInscriptos.Size = new Size(663, 502);
            tabCursosInscriptos.TabIndex = 1;
            tabCursosInscriptos.Text = "Cursos Inscriptos";
            tabCursosInscriptos.UseVisualStyleBackColor = true;
            // 
            // tabPagos
            // 
            tabPagos.Location = new Point(4, 24);
            tabPagos.Name = "tabPagos";
            tabPagos.Size = new Size(663, 502);
            tabPagos.TabIndex = 2;
            tabPagos.Text = "Pagos";
            tabPagos.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(714, 13);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(714, 63);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tlpDatosPersonales
            // 
            tlpDatosPersonales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpDatosPersonales.ColumnCount = 3;
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpDatosPersonales.Location = new Point(6, 6);
            tlpDatosPersonales.Name = "tlpDatosPersonales";
            tlpDatosPersonales.RowCount = 6;
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.Size = new Size(651, 490);
            tlpDatosPersonales.TabIndex = 0;
            // 
            // formABMEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 560);
            Controls.Add(tlpEstudiante);
            Name = "formABMEstudiante";
            Text = "formEstudiante";
            tlpEstudiante.ResumeLayout(false);
            tacEstudiante.ResumeLayout(false);
            tabDatosPersonales.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpEstudiante;
        private Button btnCancelar;
        private TabControl tacEstudiante;
        private TabPage tabDatosPersonales;
        private TableLayoutPanel tlpDatosPersonales;
        private TabPage tabCursosInscriptos;
        private TabPage tabPagos;
        private Button btnGuardar;
    }
}