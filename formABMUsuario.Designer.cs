namespace TPSysacad___Forms
{
    partial class formABMUsuario
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
            btnResetearContrasenia = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
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
            label1 = new Label();
            lblContraseñaProvisional = new Label();
            txbContraseñaProvisional = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            textBox1 = new TextBox();
            tlpEstudiante.SuspendLayout();
            tlpDatosPersonales.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tlpEstudiante.Controls.Add(btnGuardar, 1, 0);
            tlpEstudiante.Controls.Add(tlpDatosPersonales, 0, 0);
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
            // btnResetearContrasenia
            // 
            btnResetearContrasenia.Anchor = AnchorStyles.None;
            btnResetearContrasenia.Location = new Point(486, 266);
            btnResetearContrasenia.Name = "btnResetearContrasenia";
            btnResetearContrasenia.Size = new Size(87, 42);
            btnResetearContrasenia.TabIndex = 17;
            btnResetearContrasenia.Text = "Reestablecer contraseña";
            btnResetearContrasenia.UseVisualStyleBackColor = true;
            btnResetearContrasenia.Click += btnResetearContrasenia_Click;
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
            tlpDatosPersonales.Controls.Add(lblContraseñaProvisional, 0, 8);
            tlpDatosPersonales.Controls.Add(txbContraseñaProvisional, 1, 8);
            tlpDatosPersonales.Location = new Point(3, 3);
            tlpDatosPersonales.Name = "tlpDatosPersonales";
            tlpDatosPersonales.RowCount = 10;
            tlpEstudiante.SetRowSpan(tlpDatosPersonales, 3);
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
            tlpDatosPersonales.Size = new Size(449, 369);
            tlpDatosPersonales.TabIndex = 18;
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
            txbNombre.Size = new Size(293, 23);
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
            txbApellido.Size = new Size(293, 23);
            txbApellido.TabIndex = 9;
            // 
            // txbDNI
            // 
            txbDNI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbDNI.Location = new Point(153, 63);
            txbDNI.Name = "txbDNI";
            txbDNI.Size = new Size(293, 23);
            txbDNI.TabIndex = 10;
            // 
            // txbLegajo
            // 
            txbLegajo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbLegajo.Location = new Point(153, 93);
            txbLegajo.Name = "txbLegajo";
            txbLegajo.Size = new Size(293, 23);
            txbLegajo.TabIndex = 11;
            // 
            // txbNumeroDeTelefono
            // 
            txbNumeroDeTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNumeroDeTelefono.Location = new Point(153, 123);
            txbNumeroDeTelefono.Name = "txbNumeroDeTelefono";
            txbNumeroDeTelefono.Size = new Size(293, 23);
            txbNumeroDeTelefono.TabIndex = 12;
            // 
            // txbDireccion
            // 
            txbDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbDireccion.Location = new Point(153, 153);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(293, 23);
            txbDireccion.TabIndex = 13;
            // 
            // txbCorreoElectronico
            // 
            txbCorreoElectronico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCorreoElectronico.Location = new Point(153, 183);
            txbCorreoElectronico.Name = "txbCorreoElectronico";
            txbCorreoElectronico.Size = new Size(293, 23);
            txbCorreoElectronico.TabIndex = 14;
            // 
            // chkCambioContraseñaObligatorio
            // 
            chkCambioContraseñaObligatorio.Anchor = AnchorStyles.None;
            chkCambioContraseñaObligatorio.AutoSize = true;
            chkCambioContraseñaObligatorio.Location = new Point(292, 218);
            chkCambioContraseñaObligatorio.Name = "chkCambioContraseñaObligatorio";
            chkCambioContraseñaObligatorio.Size = new Size(15, 14);
            chkCambioContraseñaObligatorio.TabIndex = 16;
            chkCambioContraseñaObligatorio.UseVisualStyleBackColor = true;
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
            // lblContraseñaProvisional
            // 
            lblContraseñaProvisional.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContraseñaProvisional.AutoSize = true;
            lblContraseñaProvisional.Location = new Point(3, 240);
            lblContraseñaProvisional.Name = "lblContraseñaProvisional";
            lblContraseñaProvisional.Size = new Size(144, 30);
            lblContraseñaProvisional.TabIndex = 19;
            lblContraseñaProvisional.Text = "Contraseña Provisional";
            lblContraseñaProvisional.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbContraseñaProvisional
            // 
            txbContraseñaProvisional.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbContraseñaProvisional.Location = new Point(153, 243);
            txbContraseñaProvisional.Name = "txbContraseñaProvisional";
            txbContraseñaProvisional.Size = new Size(293, 23);
            txbContraseñaProvisional.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 100);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(153, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(44, 23);
            textBox1.TabIndex = 1;
            // 
            // formABMUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 399);
            Controls.Add(tlpEstudiante);
            MinimumSize = new Size(645, 438);
            Name = "formABMUsuario";
            Text = "formEstudiante";
            Load += formABMEstudiante_Load;
            tlpEstudiante.ResumeLayout(false);
            tlpDatosPersonales.ResumeLayout(false);
            tlpDatosPersonales.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpEstudiante;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnResetearContrasenia;
        private TableLayoutPanel tlpDatosPersonales;
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
        private Label label1;
        private Label lblContraseñaProvisional;
        private TextBox txbContraseñaProvisional;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox textBox1;
    }
}