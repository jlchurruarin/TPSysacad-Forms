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
            tabCursosInscriptos = new TabPage();
            tabPagos = new TabPage();
            btnGuardar = new Button();
            lblNombre = new Label();
            txbNombre = new TextBox();
            lblApellido = new Label();
            lblDNI = new Label();
            lblLegajo = new Label();
            lblNumeroDeTelefono = new Label();
            lblDireccion = new Label();
            lblCorreoElectronico = new Label();
            lblContrasenia = new Label();
            txbApellido = new TextBox();
            txbDNI = new TextBox();
            txbLegajo = new TextBox();
            txbNumeroDeTelefono = new TextBox();
            txbDireccion = new TextBox();
            txbCorreoElectronico = new TextBox();
            txbContrasenia = new TextBox();
            chkCambioContraseñaObligatorio = new CheckBox();
            chkVerContrasenia = new CheckBox();
            tlpEstudiante.SuspendLayout();
            tacEstudiante.SuspendLayout();
            tabDatosPersonales.SuspendLayout();
            tlpDatosPersonales.SuspendLayout();
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
            tlpEstudiante.Size = new Size(700, 453);
            tlpEstudiante.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(587, 138);
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
            tacEstudiante.Controls.Add(tabCursosInscriptos);
            tacEstudiante.Controls.Add(tabPagos);
            tacEstudiante.Location = new Point(3, 3);
            tacEstudiante.Name = "tacEstudiante";
            tlpEstudiante.SetRowSpan(tacEstudiante, 3);
            tacEstudiante.SelectedIndex = 0;
            tacEstudiante.Size = new Size(544, 447);
            tacEstudiante.TabIndex = 0;
            // 
            // tabDatosPersonales
            // 
            tabDatosPersonales.Controls.Add(tlpDatosPersonales);
            tabDatosPersonales.Location = new Point(4, 24);
            tabDatosPersonales.Name = "tabDatosPersonales";
            tabDatosPersonales.Padding = new Padding(3);
            tabDatosPersonales.Size = new Size(536, 419);
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
            tlpDatosPersonales.Controls.Add(lblLegajo, 0, 3);
            tlpDatosPersonales.Controls.Add(lblNumeroDeTelefono, 0, 4);
            tlpDatosPersonales.Controls.Add(lblDireccion, 0, 5);
            tlpDatosPersonales.Controls.Add(lblCorreoElectronico, 0, 6);
            tlpDatosPersonales.Controls.Add(lblContrasenia, 0, 7);
            tlpDatosPersonales.Controls.Add(txbApellido, 1, 1);
            tlpDatosPersonales.Controls.Add(txbDNI, 1, 2);
            tlpDatosPersonales.Controls.Add(txbLegajo, 1, 3);
            tlpDatosPersonales.Controls.Add(txbNumeroDeTelefono, 1, 4);
            tlpDatosPersonales.Controls.Add(txbDireccion, 1, 5);
            tlpDatosPersonales.Controls.Add(txbCorreoElectronico, 1, 6);
            tlpDatosPersonales.Controls.Add(txbContrasenia, 1, 7);
            tlpDatosPersonales.Controls.Add(chkCambioContraseñaObligatorio, 1, 8);
            tlpDatosPersonales.Controls.Add(chkVerContrasenia, 2, 7);
            tlpDatosPersonales.Location = new Point(6, 6);
            tlpDatosPersonales.Name = "tlpDatosPersonales";
            tlpDatosPersonales.RowCount = 10;
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosPersonales.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDatosPersonales.Size = new Size(524, 407);
            tlpDatosPersonales.TabIndex = 0;
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
            btnGuardar.Location = new Point(587, 38);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
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
            txbNombre.Size = new Size(247, 23);
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
            // lblContrasenia
            // 
            lblContrasenia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(3, 210);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(144, 30);
            lblContrasenia.TabIndex = 8;
            lblContrasenia.Text = "Contraseña:";
            lblContrasenia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbApellido
            // 
            txbApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbApellido.Location = new Point(153, 33);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(247, 23);
            txbApellido.TabIndex = 9;
            // 
            // txbDNI
            // 
            txbDNI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbDNI.Location = new Point(153, 63);
            txbDNI.Name = "txbDNI";
            txbDNI.Size = new Size(247, 23);
            txbDNI.TabIndex = 10;
            // 
            // txbLegajo
            // 
            txbLegajo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbLegajo.Location = new Point(153, 93);
            txbLegajo.Name = "txbLegajo";
            txbLegajo.Size = new Size(247, 23);
            txbLegajo.TabIndex = 11;
            // 
            // txbNumeroDeTelefono
            // 
            txbNumeroDeTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNumeroDeTelefono.Location = new Point(153, 123);
            txbNumeroDeTelefono.Name = "txbNumeroDeTelefono";
            txbNumeroDeTelefono.Size = new Size(247, 23);
            txbNumeroDeTelefono.TabIndex = 12;
            // 
            // txbDireccion
            // 
            txbDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbDireccion.Location = new Point(153, 153);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(247, 23);
            txbDireccion.TabIndex = 13;
            // 
            // txbCorreoElectronico
            // 
            txbCorreoElectronico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCorreoElectronico.Location = new Point(153, 183);
            txbCorreoElectronico.Name = "txbCorreoElectronico";
            txbCorreoElectronico.Size = new Size(247, 23);
            txbCorreoElectronico.TabIndex = 14;
            // 
            // txbContrasenia
            // 
            txbContrasenia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbContrasenia.Location = new Point(153, 213);
            txbContrasenia.Name = "txbContrasenia";
            txbContrasenia.Size = new Size(247, 23);
            txbContrasenia.TabIndex = 15;
            // 
            // chkCambioContraseñaObligatorio
            // 
            chkCambioContraseñaObligatorio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkCambioContraseñaObligatorio.AutoSize = true;
            chkCambioContraseñaObligatorio.Location = new Point(153, 243);
            chkCambioContraseñaObligatorio.Name = "chkCambioContraseñaObligatorio";
            chkCambioContraseñaObligatorio.Size = new Size(247, 24);
            chkCambioContraseñaObligatorio.TabIndex = 16;
            chkCambioContraseñaObligatorio.Text = "Solicitar cambio en próximo logueo";
            chkCambioContraseñaObligatorio.UseVisualStyleBackColor = true;
            // 
            // chkVerContrasenia
            // 
            chkVerContrasenia.AutoSize = true;
            chkVerContrasenia.Location = new Point(406, 213);
            chkVerContrasenia.Name = "chkVerContrasenia";
            chkVerContrasenia.Size = new Size(105, 19);
            chkVerContrasenia.TabIndex = 17;
            chkVerContrasenia.Text = "Ver Contraseña";
            chkVerContrasenia.UseVisualStyleBackColor = true;
            // 
            // formABMEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 477);
            Controls.Add(tlpEstudiante);
            MinimumSize = new Size(740, 516);
            Name = "formABMEstudiante";
            Text = "formEstudiante";
            tlpEstudiante.ResumeLayout(false);
            tacEstudiante.ResumeLayout(false);
            tabDatosPersonales.ResumeLayout(false);
            tlpDatosPersonales.ResumeLayout(false);
            tlpDatosPersonales.PerformLayout();
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
        private Label lblContrasenia;
        private TextBox txbApellido;
        private TextBox txbDNI;
        private TextBox txbLegajo;
        private TextBox txbNumeroDeTelefono;
        private TextBox txbDireccion;
        private TextBox txbCorreoElectronico;
        private TextBox txbContrasenia;
        private CheckBox chkCambioContraseñaObligatorio;
        private CheckBox chkVerContrasenia;
    }
}