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
            lblNombre = new Label();
            txbNombre = new TextBox();
            lblApellido = new Label();
            lblDNI = new Label();
            lblCorreoElectronico = new Label();
            lblContrasenia = new Label();
            txbApellido = new TextBox();
            txbDNI = new TextBox();
            txbCorreoElectronico = new TextBox();
            txbContrasenia = new TextBox();
            chkCambioContraseñaObligatorio = new CheckBox();
            chkVerContrasenia = new CheckBox();
            tabCursos = new TabPage();
            tlpCursosInscriptos = new TableLayoutPanel();
            lsbCursosInscriptos = new ListBox();
            btnAgregarCurso = new Button();
            btnEliminarCurso = new Button();
            btnGuardar = new Button();
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
            tlpEstudiante.Location = new Point(12, 12);
            tlpEstudiante.Name = "tlpEstudiante";
            tlpEstudiante.RowCount = 3;
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEstudiante.Size = new Size(1003, 380);
            tlpEstudiante.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(890, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
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
            tacEstudiante.Size = new Size(847, 374);
            tacEstudiante.TabIndex = 0;
            // 
            // tabDatosPersonales
            // 
            tabDatosPersonales.Controls.Add(tlpDatosPersonales);
            tabDatosPersonales.Location = new Point(4, 24);
            tabDatosPersonales.Name = "tabDatosPersonales";
            tabDatosPersonales.Padding = new Padding(3);
            tabDatosPersonales.Size = new Size(839, 346);
            tabDatosPersonales.TabIndex = 0;
            tabDatosPersonales.Text = "Datos Personales";
            tabDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // tlpDatosPersonales
            // 
            tlpDatosPersonales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpDatosPersonales.ColumnCount = 3;
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpDatosPersonales.Controls.Add(lblNombre, 0, 0);
            tlpDatosPersonales.Controls.Add(txbNombre, 1, 0);
            tlpDatosPersonales.Controls.Add(lblApellido, 0, 1);
            tlpDatosPersonales.Controls.Add(lblDNI, 0, 2);
            tlpDatosPersonales.Controls.Add(txbApellido, 1, 1);
            tlpDatosPersonales.Controls.Add(txbDNI, 1, 2);
            tlpDatosPersonales.Controls.Add(lblCorreoElectronico, 0, 3);
            tlpDatosPersonales.Controls.Add(lblContrasenia, 0, 4);
            tlpDatosPersonales.Controls.Add(txbCorreoElectronico, 1, 3);
            tlpDatosPersonales.Controls.Add(txbContrasenia, 1, 4);
            tlpDatosPersonales.Controls.Add(chkCambioContraseñaObligatorio, 1, 5);
            tlpDatosPersonales.Controls.Add(chkVerContrasenia, 2, 4);
            tlpDatosPersonales.Location = new Point(6, 7);
            tlpDatosPersonales.Name = "tlpDatosPersonales";
            tlpDatosPersonales.RowCount = 7;
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDatosPersonales.Size = new Size(827, 336);
            tlpDatosPersonales.TabIndex = 0;
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
            txbNombre.Size = new Size(521, 23);
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
            // lblContrasenia
            // 
            lblContrasenia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(3, 160);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(144, 40);
            lblContrasenia.TabIndex = 8;
            lblContrasenia.Text = "Contraseña:";
            lblContrasenia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbApellido
            // 
            txbApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbApellido.Location = new Point(153, 43);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(521, 23);
            txbApellido.TabIndex = 9;
            // 
            // txbDNI
            // 
            txbDNI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbDNI.Location = new Point(153, 83);
            txbDNI.Name = "txbDNI";
            txbDNI.Size = new Size(521, 23);
            txbDNI.TabIndex = 10;
            // 
            // txbCorreoElectronico
            // 
            txbCorreoElectronico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCorreoElectronico.Location = new Point(153, 123);
            txbCorreoElectronico.Name = "txbCorreoElectronico";
            txbCorreoElectronico.Size = new Size(521, 23);
            txbCorreoElectronico.TabIndex = 14;
            // 
            // txbContrasenia
            // 
            txbContrasenia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbContrasenia.Location = new Point(153, 163);
            txbContrasenia.Name = "txbContrasenia";
            txbContrasenia.Size = new Size(521, 23);
            txbContrasenia.TabIndex = 15;
            // 
            // chkCambioContraseñaObligatorio
            // 
            chkCambioContraseñaObligatorio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkCambioContraseñaObligatorio.AutoSize = true;
            chkCambioContraseñaObligatorio.Location = new Point(153, 203);
            chkCambioContraseñaObligatorio.Name = "chkCambioContraseñaObligatorio";
            chkCambioContraseñaObligatorio.Size = new Size(521, 34);
            chkCambioContraseñaObligatorio.TabIndex = 16;
            chkCambioContraseñaObligatorio.Text = "Solicitar cambio en próximo logueo";
            chkCambioContraseñaObligatorio.UseVisualStyleBackColor = true;
            // 
            // chkVerContrasenia
            // 
            chkVerContrasenia.AutoSize = true;
            chkVerContrasenia.Location = new Point(680, 163);
            chkVerContrasenia.Name = "chkVerContrasenia";
            chkVerContrasenia.Size = new Size(105, 19);
            chkVerContrasenia.TabIndex = 17;
            chkVerContrasenia.Text = "Ver Contraseña";
            chkVerContrasenia.UseVisualStyleBackColor = true;
            // 
            // tabCursos
            // 
            tabCursos.Controls.Add(tlpCursosInscriptos);
            tabCursos.Location = new Point(4, 24);
            tabCursos.Name = "tabCursos";
            tabCursos.Padding = new Padding(3);
            tabCursos.Size = new Size(839, 346);
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
            tlpCursosInscriptos.Controls.Add(lsbCursosInscriptos, 0, 0);
            tlpCursosInscriptos.Controls.Add(btnAgregarCurso, 0, 1);
            tlpCursosInscriptos.Controls.Add(btnEliminarCurso, 2, 1);
            tlpCursosInscriptos.Location = new Point(9, 9);
            tlpCursosInscriptos.Name = "tlpCursosInscriptos";
            tlpCursosInscriptos.RowCount = 2;
            tlpCursosInscriptos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCursosInscriptos.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCursosInscriptos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCursosInscriptos.Size = new Size(824, 331);
            tlpCursosInscriptos.TabIndex = 0;
            // 
            // lsbCursosInscriptos
            // 
            lsbCursosInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCursosInscriptos.SetColumnSpan(lsbCursosInscriptos, 3);
            lsbCursosInscriptos.FormattingEnabled = true;
            lsbCursosInscriptos.ItemHeight = 15;
            lsbCursosInscriptos.Location = new Point(3, 3);
            lsbCursosInscriptos.Name = "lsbCursosInscriptos";
            lsbCursosInscriptos.Size = new Size(818, 289);
            lsbCursosInscriptos.TabIndex = 0;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Anchor = AnchorStyles.None;
            btnAgregarCurso.Location = new Point(87, 304);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(99, 23);
            btnAgregarCurso.TabIndex = 3;
            btnAgregarCurso.Text = "Agregar Curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCurso
            // 
            btnEliminarCurso.Anchor = AnchorStyles.None;
            btnEliminarCurso.Location = new Point(636, 304);
            btnEliminarCurso.Name = "btnEliminarCurso";
            btnEliminarCurso.Size = new Size(99, 23);
            btnEliminarCurso.TabIndex = 4;
            btnEliminarCurso.Text = "Eliminar Curso";
            btnEliminarCurso.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(890, 38);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // formABMProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 404);
            Controls.Add(tlpEstudiante);
            Name = "formABMProfesor";
            Text = "formABMProfesor";
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
        private Label lblContrasenia;
        private TextBox txbApellido;
        private TextBox txbDNI;
        private TextBox txbCorreoElectronico;
        private TextBox txbContrasenia;
        private CheckBox chkCambioContraseñaObligatorio;
        private CheckBox chkVerContrasenia;
        private TabPage tabCursos;
        private TableLayoutPanel tlpCursosInscriptos;
        private ListBox lsbCursosInscriptos;
        private Button btnAgregarCurso;
        private Button btnEliminarCurso;
        private Button btnGuardar;
    }
}