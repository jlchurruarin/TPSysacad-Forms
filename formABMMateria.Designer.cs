namespace TPSysacad___Forms
{
    partial class formABMMateria
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
            btnGuardar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txbDescripcion = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            txbNombre = new TextBox();
            lblCreditosBrindados = new Label();
            lblCreditosNecesarios = new Label();
            nudCreditosBrindados = new NumericUpDown();
            nudCreditosNecesarios = new NumericUpDown();
            tlpEstudiante.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCreditosBrindados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCreditosNecesarios).BeginInit();
            SuspendLayout();
            // 
            // tlpEstudiante
            // 
            tlpEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpEstudiante.ColumnCount = 2;
            tlpEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpEstudiante.Controls.Add(btnCancelar, 1, 1);
            tlpEstudiante.Controls.Add(btnGuardar, 1, 0);
            tlpEstudiante.Controls.Add(tableLayoutPanel1, 0, 0);
            tlpEstudiante.Location = new Point(12, 12);
            tlpEstudiante.Name = "tlpEstudiante";
            tlpEstudiante.RowCount = 3;
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEstudiante.Size = new Size(597, 227);
            tlpEstudiante.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(484, 138);
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
            btnGuardar.Location = new Point(484, 38);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txbDescripcion, 1, 1);
            tableLayoutPanel1.Controls.Add(lblNombre, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDescripcion, 0, 1);
            tableLayoutPanel1.Controls.Add(txbNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(lblCreditosBrindados, 0, 2);
            tableLayoutPanel1.Controls.Add(lblCreditosNecesarios, 0, 3);
            tableLayoutPanel1.Controls.Add(nudCreditosBrindados, 1, 2);
            tableLayoutPanel1.Controls.Add(nudCreditosNecesarios, 1, 3);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tlpEstudiante.SetRowSpan(tableLayoutPanel1, 3);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(441, 221);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // txbDescripcion
            // 
            txbDescripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbDescripcion.Location = new Point(153, 63);
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(285, 23);
            txbDescripcion.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(144, 50);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(3, 50);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(144, 50);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbNombre
            // 
            txbNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbNombre.Location = new Point(153, 13);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(285, 23);
            txbNombre.TabIndex = 2;
            // 
            // lblCreditosBrindados
            // 
            lblCreditosBrindados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCreditosBrindados.AutoSize = true;
            lblCreditosBrindados.Location = new Point(3, 100);
            lblCreditosBrindados.Name = "lblCreditosBrindados";
            lblCreditosBrindados.Size = new Size(144, 50);
            lblCreditosBrindados.TabIndex = 4;
            lblCreditosBrindados.Text = "Creditos Brindados:";
            lblCreditosBrindados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCreditosNecesarios
            // 
            lblCreditosNecesarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCreditosNecesarios.AutoSize = true;
            lblCreditosNecesarios.Location = new Point(3, 150);
            lblCreditosNecesarios.Name = "lblCreditosNecesarios";
            lblCreditosNecesarios.Size = new Size(144, 50);
            lblCreditosNecesarios.TabIndex = 5;
            lblCreditosNecesarios.Text = "Creditos Necesarios:";
            lblCreditosNecesarios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudCreditosBrindados
            // 
            nudCreditosBrindados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudCreditosBrindados.Location = new Point(153, 113);
            nudCreditosBrindados.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            nudCreditosBrindados.Name = "nudCreditosBrindados";
            nudCreditosBrindados.Size = new Size(285, 23);
            nudCreditosBrindados.TabIndex = 18;
            nudCreditosBrindados.TextAlign = HorizontalAlignment.Right;
            // 
            // nudCreditosNecesarios
            // 
            nudCreditosNecesarios.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudCreditosNecesarios.Location = new Point(153, 163);
            nudCreditosNecesarios.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            nudCreditosNecesarios.Name = "nudCreditosNecesarios";
            nudCreditosNecesarios.Size = new Size(285, 23);
            nudCreditosNecesarios.TabIndex = 19;
            nudCreditosNecesarios.TextAlign = HorizontalAlignment.Right;
            // 
            // formABMMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 251);
            Controls.Add(tlpEstudiante);
            Name = "formABMMateria";
            Text = "formABMMateria";
            Load += formABMMateria_Load;
            tlpEstudiante.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCreditosBrindados).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCreditosNecesarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpEstudiante;
        private Button btnCancelar;
        private Button btnGuardar;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txbDescripcion;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txbNombre;
        private Label lblCreditosBrindados;
        private Label lblCreditosNecesarios;
        private NumericUpDown nudCreditosBrindados;
        private NumericUpDown nudCreditosNecesarios;
    }
}