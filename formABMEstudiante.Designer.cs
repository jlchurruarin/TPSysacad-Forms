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
            btnCancelar = new Button();
            tacEstudiante = new TabControl();
            tabDatosPersonales = new TabPage();
            tlpDatosPersonales = new TableLayoutPanel();
            lblNombre = new Label();
            txbNombre = new TextBox();
            lblApellido = new Label();
            lblDNI = new Label();
            lblLegajo = new Label();
            lblNumeroDeTelefono = new Label();
            lblDireccion = new Label();
            lblCorreoElectronico = new Label();
            txbApellido = new TextBox();
            txbDNI = new TextBox();
            txbLegajo = new TextBox();
            txbNumeroDeTelefono = new TextBox();
            txbDireccion = new TextBox();
            txbCorreoElectronico = new TextBox();
            chkCambioContraseñaObligatorio = new CheckBox();
            tabCursosInscriptos = new TabPage();
            tlpCursosInscriptos = new TableLayoutPanel();
            lsbCursosInscriptos = new ListBox();
            btnAgregarCurso = new Button();
            btnEliminarCurso = new Button();
            tabPagos = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAgregarPago = new Button();
            btnEliminarPago = new Button();
            lsbPagos = new ListBox();
            btnEditarPago = new Button();
            btnGuardar = new Button();
            btnResetearContrasenia = new Button();
            label1 = new Label();
            tlpEstudiante.SuspendLayout();
            tacEstudiante.SuspendLayout();
            tabDatosPersonales.SuspendLayout();
            tlpDatosPersonales.SuspendLayout();
            tabCursosInscriptos.SuspendLayout();
            tlpCursosInscriptos.SuspendLayout();
            tabPagos.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpEstudiante
            // 
            tlpEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpEstudiante.ColumnCount = 2;
            tlpEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpEstudiante.Controls.Add(btnResetearContrasenia, 1, 2);
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
            tlpEstudiante.Size = new Size(605, 375);
            tlpEstudiante.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(492, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            tlpDatosPersonales.Controls.Add(lblNombre, 0, 0);
            tlpDatosPersonales.Controls.Add(txbNombre, 1, 0);
            tlpDatosPersonales.Controls.Add(lblApellido, 0, 1);
            tlpDatosPersonales.Controls.Add(lblDNI, 0, 2);
            tlpDatosPersonales.Controls.Add(lblLegajo, 0, 3);
            tlpDatosPersonales.Controls.Add(lblNumeroDeTelefono, 0, 4);
            tlpDatosPersonales.Controls.Add(lblDireccion, 0, 5);
            tlpDatosPersonales.Controls.Add(lblCorreoElectronico, 0, 6);
            tlpDatosPersonales.Controls.Add(txbApellido, 1, 1);
            tlpDatosPersonales.Controls.Add(txbDNI, 1, 2);
            tlpDatosPersonales.Controls.Add(txbLegajo, 1, 3);
            tlpDatosPersonales.Controls.Add(txbNumeroDeTelefono, 1, 4);
            tlpDatosPersonales.Controls.Add(txbDireccion, 1, 5);
            tlpDatosPersonales.Controls.Add(txbCorreoElectronico, 1, 6);
            tlpDatosPersonales.Controls.Add(chkCambioContraseñaObligatorio, 1, 7);
            tlpDatosPersonales.Controls.Add(label1, 0, 7);
            tlpDatosPersonales.Location = new Point(6, 6);
            tlpDatosPersonales.Name = "tlpDatosPersonales";
            tlpDatosPersonales.RowCount = 9;
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.Size = new Size(429, 329);
            tlpDatosPersonales.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(144, 30);
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
            lblApellido.Location = new Point(3, 30);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(144, 30);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            lblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            lblDNI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(3, 60);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(144, 30);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI";
            lblDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLegajo
            // 
            lblLegajo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(3, 90);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(144, 30);
            lblLegajo.TabIndex = 4;
            lblLegajo.Text = "Legajo:";
            lblLegajo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumeroDeTelefono
            // 
            lblNumeroDeTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumeroDeTelefono.AutoSize = true;
            lblNumeroDeTelefono.Location = new Point(3, 120);
            lblNumeroDeTelefono.Name = "lblNumeroDeTelefono";
            lblNumeroDeTelefono.Size = new Size(144, 30);
            lblNumeroDeTelefono.TabIndex = 5;
            lblNumeroDeTelefono.Text = "Numero de telefono:";
            lblNumeroDeTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(3, 150);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(144, 30);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Location = new Point(3, 180);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(144, 30);
            lblCorreoElectronico.TabIndex = 7;
            lblCorreoElectronico.Text = "Correo Electronico:";
            lblCorreoElectronico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbApellido
            // 
            txbApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbApellido.Location = new Point(153, 33);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(273, 23);
            txbApellido.TabIndex = 9;
            // 
            // txbDNI
            // 
            txbDNI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbDNI.Location = new Point(153, 63);
            txbDNI.Name = "txbDNI";
            txbDNI.Size = new Size(273, 23);
            txbDNI.TabIndex = 10;
            // 
            // txbLegajo
            // 
            txbLegajo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbLegajo.Location = new Point(153, 93);
            txbLegajo.Name = "txbLegajo";
            txbLegajo.Size = new Size(273, 23);
            txbLegajo.TabIndex = 11;
            // 
            // txbNumeroDeTelefono
            // 
            txbNumeroDeTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNumeroDeTelefono.Location = new Point(153, 123);
            txbNumeroDeTelefono.Name = "txbNumeroDeTelefono";
            txbNumeroDeTelefono.Size = new Size(273, 23);
            txbNumeroDeTelefono.TabIndex = 12;
            // 
            // txbDireccion
            // 
            txbDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbDireccion.Location = new Point(153, 153);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(273, 23);
            txbDireccion.TabIndex = 13;
            // 
            // txbCorreoElectronico
            // 
            txbCorreoElectronico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCorreoElectronico.Location = new Point(153, 183);
            txbCorreoElectronico.Name = "txbCorreoElectronico";
            txbCorreoElectronico.Size = new Size(273, 23);
            txbCorreoElectronico.TabIndex = 14;
            // 
            // chkCambioContraseñaObligatorio
            // 
            chkCambioContraseñaObligatorio.Anchor = AnchorStyles.None;
            chkCambioContraseñaObligatorio.AutoSize = true;
            chkCambioContraseñaObligatorio.Location = new Point(282, 218);
            chkCambioContraseñaObligatorio.Name = "chkCambioContraseñaObligatorio";
            chkCambioContraseñaObligatorio.Size = new Size(15, 14);
            chkCambioContraseñaObligatorio.TabIndex = 16;
            chkCambioContraseñaObligatorio.UseVisualStyleBackColor = true;
            // 
            // tabCursosInscriptos
            // 
            tabCursosInscriptos.Controls.Add(tlpCursosInscriptos);
            tabCursosInscriptos.Location = new Point(4, 24);
            tabCursosInscriptos.Name = "tabCursosInscriptos";
            tabCursosInscriptos.Padding = new Padding(3);
            tabCursosInscriptos.Size = new Size(536, 419);
            tabCursosInscriptos.TabIndex = 1;
            tabCursosInscriptos.Text = "Cursos Inscriptos";
            tabCursosInscriptos.UseVisualStyleBackColor = true;
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
            tlpCursosInscriptos.Location = new Point(6, 6);
            tlpCursosInscriptos.Name = "tlpCursosInscriptos";
            tlpCursosInscriptos.RowCount = 2;
            tlpCursosInscriptos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCursosInscriptos.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCursosInscriptos.Size = new Size(524, 407);
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
            lsbCursosInscriptos.Size = new Size(518, 364);
            lsbCursosInscriptos.TabIndex = 0;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Anchor = AnchorStyles.None;
            btnAgregarCurso.Location = new Point(37, 380);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(99, 23);
            btnAgregarCurso.TabIndex = 3;
            btnAgregarCurso.Text = "Agregar Curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCurso
            // 
            btnEliminarCurso.Anchor = AnchorStyles.None;
            btnEliminarCurso.Location = new Point(386, 380);
            btnEliminarCurso.Name = "btnEliminarCurso";
            btnEliminarCurso.Size = new Size(99, 23);
            btnEliminarCurso.TabIndex = 4;
            btnEliminarCurso.Text = "Eliminar Curso";
            btnEliminarCurso.UseVisualStyleBackColor = true;
            // 
            // tabPagos
            // 
            tabPagos.Controls.Add(tableLayoutPanel1);
            tabPagos.Location = new Point(4, 24);
            tabPagos.Name = "tabPagos";
            tabPagos.Size = new Size(536, 419);
            tabPagos.TabIndex = 2;
            tabPagos.Text = "Pagos";
            tabPagos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(btnAgregarPago, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEliminarPago, 2, 1);
            tableLayoutPanel1.Controls.Add(lsbPagos, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEditarPago, 1, 1);
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(524, 407);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAgregarPago
            // 
            btnAgregarPago.Anchor = AnchorStyles.None;
            btnAgregarPago.Location = new Point(37, 380);
            btnAgregarPago.Name = "btnAgregarPago";
            btnAgregarPago.Size = new Size(99, 23);
            btnAgregarPago.TabIndex = 3;
            btnAgregarPago.Text = "Agregar Pago";
            btnAgregarPago.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPago
            // 
            btnEliminarPago.Anchor = AnchorStyles.None;
            btnEliminarPago.Location = new Point(386, 380);
            btnEliminarPago.Name = "btnEliminarPago";
            btnEliminarPago.Size = new Size(99, 23);
            btnEliminarPago.TabIndex = 4;
            btnEliminarPago.Text = "Eliminar Pago";
            btnEliminarPago.UseVisualStyleBackColor = true;
            // 
            // lsbPagos
            // 
            lsbPagos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(lsbPagos, 3);
            lsbPagos.FormattingEnabled = true;
            lsbPagos.ItemHeight = 15;
            lsbPagos.Location = new Point(3, 3);
            lsbPagos.Name = "lsbPagos";
            lsbPagos.Size = new Size(518, 364);
            lsbPagos.TabIndex = 0;
            // 
            // btnEditarPago
            // 
            btnEditarPago.Anchor = AnchorStyles.None;
            btnEditarPago.Location = new Point(211, 380);
            btnEditarPago.Name = "btnEditarPago";
            btnEditarPago.Size = new Size(99, 23);
            btnEditarPago.TabIndex = 5;
            btnEditarPago.Text = "Editar Pago";
            btnEditarPago.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(492, 38);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
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
            btnResetearContrasenia.TabIndex = 17;
            btnResetearContrasenia.Text = "Reestablecer contraseña";
            btnResetearContrasenia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 210);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 18;
            label1.Text = "Cambio de contraseña obligatorio";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formABMEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 399);
            Controls.Add(tlpEstudiante);
            MinimumSize = new Size(645, 438);
            Name = "formABMEstudiante";
            Text = "formEstudiante";
            Load += formABMEstudiante_Load;
            tlpEstudiante.ResumeLayout(false);
            tacEstudiante.ResumeLayout(false);
            tabDatosPersonales.ResumeLayout(false);
            tlpDatosPersonales.ResumeLayout(false);
            tlpDatosPersonales.PerformLayout();
            tabCursosInscriptos.ResumeLayout(false);
            tlpCursosInscriptos.ResumeLayout(false);
            tabPagos.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
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
        private Label lblNombre;
        private TextBox txbNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblLegajo;
        private Label lblNumeroDeTelefono;
        private Label lblDireccion;
        private Label lblCorreoElectronico;
        private TextBox txbApellido;
        private TextBox txbDNI;
        private TextBox txbLegajo;
        private TextBox txbNumeroDeTelefono;
        private TextBox txbDireccion;
        private TextBox txbCorreoElectronico;
        private CheckBox chkCambioContraseñaObligatorio;
        private TableLayoutPanel tlpCursosInscriptos;
        private ListBox lsbCursosInscriptos;
        private Button btnAgregarCurso;
        private Button btnEliminarCurso;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAgregarPago;
        private Button btnEliminarPago;
        private ListBox lsbPagos;
        private Button btnEditarPago;
        private Button btnResetearContrasenia;
        private Label label1;
    }
}