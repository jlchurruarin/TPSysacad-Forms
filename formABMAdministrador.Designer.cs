namespace TPSysacad___Forms
{
    partial class formABMAdministrador
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
            tlpDatosAdministdrador = new TableLayoutPanel();
            label2 = new Label();
            txbNombre = new TextBox();
            lblApellido = new Label();
            txbApellido = new TextBox();
            lblCorreoElectronico = new Label();
            txbCorreoElectronico = new TextBox();
            label3 = new Label();
            chkCambioContraseñaObligatorio = new CheckBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnResetearContrasenia = new Button();
            tlpDatosPersonales = new TableLayoutPanel();
            label1 = new Label();
            lblNombre = new Label();
            tabDatosPersonales = new TabPage();
            tlpEstudiante.SuspendLayout();
            tlpDatosAdministdrador.SuspendLayout();
            tlpDatosPersonales.SuspendLayout();
            SuspendLayout();
            // 
            // tlpEstudiante
            // 
            tlpEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpEstudiante.ColumnCount = 2;
            tlpEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpEstudiante.Controls.Add(tlpDatosAdministdrador, 0, 0);
            tlpEstudiante.Controls.Add(btnCancelar, 1, 1);
            tlpEstudiante.Controls.Add(btnGuardar, 1, 0);
            tlpEstudiante.Controls.Add(btnResetearContrasenia, 1, 2);
            tlpEstudiante.Location = new Point(12, 12);
            tlpEstudiante.Name = "tlpEstudiante";
            tlpEstudiante.RowCount = 3;
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEstudiante.Size = new Size(556, 272);
            tlpEstudiante.TabIndex = 2;
            // 
            // tlpDatosAdministdrador
            // 
            tlpDatosAdministdrador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpDatosAdministdrador.ColumnCount = 2;
            tlpDatosAdministdrador.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpDatosAdministdrador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDatosAdministdrador.Controls.Add(label2, 0, 0);
            tlpDatosAdministdrador.Controls.Add(txbNombre, 1, 0);
            tlpDatosAdministdrador.Controls.Add(lblApellido, 0, 1);
            tlpDatosAdministdrador.Controls.Add(txbApellido, 1, 1);
            tlpDatosAdministdrador.Controls.Add(lblCorreoElectronico, 0, 2);
            tlpDatosAdministdrador.Controls.Add(txbCorreoElectronico, 1, 2);
            tlpDatosAdministdrador.Controls.Add(label3, 0, 3);
            tlpDatosAdministdrador.Controls.Add(chkCambioContraseñaObligatorio, 1, 3);
            tlpDatosAdministdrador.Location = new Point(3, 3);
            tlpDatosAdministdrador.Name = "tlpDatosAdministdrador";
            tlpDatosAdministdrador.RowCount = 5;
            tlpEstudiante.SetRowSpan(tlpDatosAdministdrador, 3);
            tlpDatosAdministdrador.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosAdministdrador.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosAdministdrador.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosAdministdrador.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosAdministdrador.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDatosAdministdrador.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDatosAdministdrador.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDatosAdministdrador.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDatosAdministdrador.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDatosAdministdrador.Size = new Size(400, 266);
            tlpDatosAdministdrador.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbNombre
            // 
            txbNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNombre.Location = new Point(153, 3);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(244, 23);
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
            // txbApellido
            // 
            txbApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbApellido.Location = new Point(153, 33);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(244, 23);
            txbApellido.TabIndex = 9;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Location = new Point(3, 60);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(144, 30);
            lblCorreoElectronico.TabIndex = 7;
            lblCorreoElectronico.Text = "Correo Electronico:";
            lblCorreoElectronico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbCorreoElectronico
            // 
            txbCorreoElectronico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCorreoElectronico.Location = new Point(153, 63);
            txbCorreoElectronico.Name = "txbCorreoElectronico";
            txbCorreoElectronico.Size = new Size(244, 23);
            txbCorreoElectronico.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 18;
            label3.Text = "Cambio de contraseña obligatorio";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkCambioContraseñaObligatorio
            // 
            chkCambioContraseñaObligatorio.Anchor = AnchorStyles.None;
            chkCambioContraseñaObligatorio.AutoSize = true;
            chkCambioContraseñaObligatorio.Location = new Point(267, 98);
            chkCambioContraseñaObligatorio.Name = "chkCambioContraseñaObligatorio";
            chkCambioContraseñaObligatorio.Size = new Size(15, 14);
            chkCambioContraseñaObligatorio.TabIndex = 16;
            chkCambioContraseñaObligatorio.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(437, 129);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 42);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(437, 29);
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
            btnResetearContrasenia.Location = new Point(437, 215);
            btnResetearContrasenia.Name = "btnResetearContrasenia";
            btnResetearContrasenia.Size = new Size(87, 42);
            btnResetearContrasenia.TabIndex = 3;
            btnResetearContrasenia.Text = "Reestablecer contraseña";
            btnResetearContrasenia.UseVisualStyleBackColor = true;
            // 
            // tlpDatosPersonales
            // 
            tlpDatosPersonales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpDatosPersonales.ColumnCount = 2;
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpDatosPersonales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDatosPersonales.Controls.Add(label1, 0, 4);
            tlpDatosPersonales.Location = new Point(0, 0);
            tlpDatosPersonales.Name = "tlpDatosPersonales";
            tlpDatosPersonales.RowCount = 5;
            tlpDatosPersonales.Size = new Size(200, 100);
            tlpDatosPersonales.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 100);
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
            lblNombre.Size = new Size(144, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabDatosPersonales
            // 
            tabDatosPersonales.Location = new Point(0, 0);
            tabDatosPersonales.Name = "tabDatosPersonales";
            tabDatosPersonales.Size = new Size(200, 100);
            tabDatosPersonales.TabIndex = 0;
            // 
            // formABMAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 296);
            Controls.Add(tlpEstudiante);
            Name = "formABMAdministrador";
            Text = "formABMAdministrador";
            FormClosing += formABMAdministrador_FormClosing;
            Load += formABMAdministrador_Load;
            tlpEstudiante.ResumeLayout(false);
            tlpDatosAdministdrador.ResumeLayout(false);
            tlpDatosAdministdrador.PerformLayout();
            tlpDatosPersonales.ResumeLayout(false);
            tlpDatosPersonales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpEstudiante;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnResetearContrasenia;
        private TableLayoutPanel tlpDatosPersonales;
        private Label label1;
        private Label lblNombre;
        private TabPage tabDatosPersonales;
        private TableLayoutPanel tlpDatosAdministdrador;
        private Label label2;
        private TextBox txbNombre;
        private Label lblApellido;
        private Label lblCorreoElectronico;
        private TextBox txbApellido;
        private TextBox txbCorreoElectronico;
        private CheckBox chkCambioContraseñaObligatorio;
        private Label label3;
    }
}