namespace TPSysacad___Forms
{
    partial class formABMProfesor
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
            btnCancelar = new Button();
            tacEstudiante = new TabControl();
            tabDatosPersonales = new TabPage();
            tlpDatosPersonales = new TableLayoutPanel();
            label1 = new Label();
            lblNombre = new Label();
            txbNombre = new TextBox();
            lblApellido = new Label();
            lblDNI = new Label();
            txbApellido = new TextBox();
            txbCUIT = new TextBox();
            lblCorreoElectronico = new Label();
            txbCorreoElectronico = new TextBox();
            chkCambioContraseñaObligatorio = new CheckBox();
            tabCursos = new TabPage();
            tlpCursosInscriptos = new TableLayoutPanel();
            lsbCursos = new ListBox();
            btnAgregarCurso = new Button();
            btnEliminarCurso = new Button();
            btnGuardar = new Button();
            btnResetearContrasenia = new Button();
            tlpEstudiante.SuspendLayout();
            tacEstudiante.SuspendLayout();
            tabDatosPersonales.SuspendLayout();
            tlpDatosPersonales.SuspendLayout();
            tabCursos.SuspendLayout();
            tlpCursosInscriptos.SuspendLayout();
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
            tlpEstudiante.Controls.Add(btnResetearContrasenia, 1, 2);
            tlpEstudiante.Location = new Point(12, 12);
            tlpEstudiante.Name = "tlpEstudiante";
            tlpEstudiante.RowCount = 3;
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEstudiante.Size = new Size(605, 375);
            tlpEstudiante.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(486, 129);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 42);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tacEstudiante
            // 
            tacEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tacEstudiante.Controls.Add(tabDatosPersonales);
            tacEstudiante.Controls.Add(tabCursos);
            tacEstudiante.Location = new Point(3, 3);
            tacEstudiante.Name = "tacEstudiante";
            tlpEstudiante.SetRowSpan(tacEstudiante, 3);
            tacEstudiante.SelectedIndex = 0;
            tacEstudiante.Size = new Size(449, 369);
            tacEstudiante.TabIndex = 0;
            // 
            // tabDatosPersonales
            // 
            tabDatosPersonales.Controls.Add(tlpDatosPersonales);
            tabDatosPersonales.Location = new Point(4, 24);
            tabDatosPersonales.Name = "tabDatosPersonales";
            tabDatosPersonales.Padding = new Padding(3);
            tabDatosPersonales.Size = new Size(441, 341);
            tabDatosPersonales.TabIndex = 0;
            tabDatosPersonales.Text = "Datos Personales";
            tabDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // tlpDatosPersonales
            // 
            tlpDatosPersonales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpDatosPersonales.ColumnCount = 2;
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDatosPersonales.Controls.Add(label1, 0, 4);
            tlpDatosPersonales.Controls.Add(lblNombre, 0, 0);
            tlpDatosPersonales.Controls.Add(txbNombre, 1, 0);
            tlpDatosPersonales.Controls.Add(lblApellido, 0, 1);
            tlpDatosPersonales.Controls.Add(lblDNI, 0, 2);
            tlpDatosPersonales.Controls.Add(txbApellido, 1, 1);
            tlpDatosPersonales.Controls.Add(txbCUIT, 1, 2);
            tlpDatosPersonales.Controls.Add(lblCorreoElectronico, 0, 3);
            tlpDatosPersonales.Controls.Add(txbCorreoElectronico, 1, 3);
            tlpDatosPersonales.Controls.Add(chkCambioContraseñaObligatorio, 1, 4);
            tlpDatosPersonales.Location = new Point(6, 7);
            tlpDatosPersonales.Name = "tlpDatosPersonales";
            tlpDatosPersonales.RowCount = 6;
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.Size = new Size(429, 331);
            tlpDatosPersonales.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 160);
            label1.Name = "label1";
            label1.Size = new Size(144, 40);
            label1.TabIndex = 17;
            label1.Text = "Cambio de contraseña obligatorio";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(144, 40);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbNombre
            // 
            txbNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNombre.Location = new Point(153, 3);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(273, 23);
            txbNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(3, 40);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(144, 40);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            lblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            lblDNI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(3, 80);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(144, 40);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "CUIT";
            lblDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbApellido
            // 
            txbApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbApellido.Location = new Point(153, 43);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(273, 23);
            txbApellido.TabIndex = 9;
            // 
            // txbCUIT
            // 
            txbCUIT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCUIT.Location = new Point(153, 83);
            txbCUIT.Name = "txbCUIT";
            txbCUIT.Size = new Size(273, 23);
            txbCUIT.TabIndex = 10;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Location = new Point(3, 120);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(144, 40);
            lblCorreoElectronico.TabIndex = 7;
            lblCorreoElectronico.Text = "Correo Electronico:";
            lblCorreoElectronico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbCorreoElectronico
            // 
            txbCorreoElectronico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCorreoElectronico.Location = new Point(153, 123);
            txbCorreoElectronico.Name = "txbCorreoElectronico";
            txbCorreoElectronico.Size = new Size(273, 23);
            txbCorreoElectronico.TabIndex = 14;
            // 
            // chkCambioContraseñaObligatorio
            // 
            chkCambioContraseñaObligatorio.Anchor = AnchorStyles.None;
            chkCambioContraseñaObligatorio.AutoSize = true;
            chkCambioContraseñaObligatorio.Location = new Point(282, 173);
            chkCambioContraseñaObligatorio.Name = "chkCambioContraseñaObligatorio";
            chkCambioContraseñaObligatorio.Size = new Size(15, 14);
            chkCambioContraseñaObligatorio.TabIndex = 16;
            chkCambioContraseñaObligatorio.UseVisualStyleBackColor = true;
            // 
            // tabCursos
            // 
            tabCursos.Controls.Add(tlpCursosInscriptos);
            tabCursos.Location = new Point(4, 24);
            tabCursos.Name = "tabCursos";
            tabCursos.Padding = new Padding(3);
            tabCursos.Size = new Size(441, 341);
            tabCursos.TabIndex = 1;
            tabCursos.Text = "Cursos";
            tabCursos.UseVisualStyleBackColor = true;
            // 
            // tlpCursosInscriptos
            // 
            tlpCursosInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCursosInscriptos.ColumnCount = 3;
            tlpCursosInscriptos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCursosInscriptos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpCursosInscriptos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpCursosInscriptos.Controls.Add(lsbCursos, 0, 0);
            tlpCursosInscriptos.Controls.Add(btnAgregarCurso, 0, 1);
            tlpCursosInscriptos.Controls.Add(btnEliminarCurso, 2, 1);
            tlpCursosInscriptos.Location = new Point(9, 9);
            tlpCursosInscriptos.Name = "tlpCursosInscriptos";
            tlpCursosInscriptos.RowCount = 2;
            tlpCursosInscriptos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCursosInscriptos.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCursosInscriptos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCursosInscriptos.Size = new Size(426, 326);
            tlpCursosInscriptos.TabIndex = 0;
            // 
            // lsbCursos
            // 
            lsbCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCursosInscriptos.SetColumnSpan(lsbCursos, 3);
            lsbCursos.FormattingEnabled = true;
            lsbCursos.ItemHeight = 15;
            lsbCursos.Location = new Point(3, 3);
            lsbCursos.Name = "lsbCursos";
            lsbCursos.Size = new Size(420, 289);
            lsbCursos.TabIndex = 0;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Anchor = AnchorStyles.None;
            btnAgregarCurso.Location = new Point(21, 299);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(99, 23);
            btnAgregarCurso.TabIndex = 3;
            btnAgregarCurso.Text = "Agregar Curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCurso
            // 
            btnEliminarCurso.Anchor = AnchorStyles.None;
            btnEliminarCurso.Location = new Point(305, 299);
            btnEliminarCurso.Name = "btnEliminarCurso";
            btnEliminarCurso.Size = new Size(99, 23);
            btnEliminarCurso.TabIndex = 4;
            btnEliminarCurso.Text = "Eliminar Curso";
            btnEliminarCurso.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(486, 29);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(87, 42);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnResetearContrasenia
            // 
            btnResetearContrasenia.Anchor = AnchorStyles.None;
            btnResetearContrasenia.Location = new Point(486, 266);
            btnResetearContrasenia.Name = "btnResetearContrasenia";
            btnResetearContrasenia.Size = new Size(87, 42);
            btnResetearContrasenia.TabIndex = 3;
            btnResetearContrasenia.Text = "Reestablecer contraseña";
            btnResetearContrasenia.UseVisualStyleBackColor = true;
            // 
            // formABMProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 399);
            Controls.Add(tlpEstudiante);
            MinimumSize = new Size(645, 438);
            Name = "formABMProfesor";
            Text = "formABMProfesor";
            FormClosing += formABMProfesor_FormClosing;
            Load += formABMProfesor_Load;
            tlpEstudiante.ResumeLayout(false);
            tacEstudiante.ResumeLayout(false);
            tabDatosPersonales.ResumeLayout(false);
            tlpDatosPersonales.ResumeLayout(false);
            tlpDatosPersonales.PerformLayout();
            tabCursos.ResumeLayout(false);
            tlpCursosInscriptos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpEstudiante;
        private Button btnCancelar;
        private TabControl tacEstudiante;
        private TabPage tabDatosPersonales;
        private TableLayoutPanel tlpDatosPersonales;
        private Label lblNombre;
        private TextBox txbNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblCorreoElectronico;
        private TextBox txbApellido;
        private TextBox txbCUIT;
        private TextBox txbCorreoElectronico;
        private CheckBox chkCambioContraseñaObligatorio;
        private TabPage tabCursos;
        private TableLayoutPanel tlpCursosInscriptos;
        private ListBox lsbCursos;
        private Button btnAgregarCurso;
        private Button btnEliminarCurso;
        private Button btnGuardar;
        private Button btnResetearContrasenia;
        private Label label1;
    }
}