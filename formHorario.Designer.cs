namespace TPSysacad___Forms
{
    partial class formHorario
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCargaHoraria = new Label();
            lblDia = new Label();
            lblHorario = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbDia = new ComboBox();
            nudHora = new NumericUpDown();
            lblDosPuntos = new Label();
            nudMinuto = new NumericUpDown();
            nudCargaHoraria = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCargaHoraria).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblCargaHoraria, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDia, 0, 0);
            tableLayoutPanel1.Controls.Add(lblHorario, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCancelar, 4, 1);
            tableLayoutPanel1.Controls.Add(btnGuardar, 4, 0);
            tableLayoutPanel1.Controls.Add(cmbDia, 1, 0);
            tableLayoutPanel1.Controls.Add(nudHora, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDosPuntos, 2, 1);
            tableLayoutPanel1.Controls.Add(nudMinuto, 3, 1);
            tableLayoutPanel1.Controls.Add(nudCargaHoraria, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(363, 119);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCargaHoraria
            // 
            lblCargaHoraria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCargaHoraria.AutoSize = true;
            lblCargaHoraria.Location = new Point(3, 80);
            lblCargaHoraria.Name = "lblCargaHoraria";
            lblCargaHoraria.Size = new Size(97, 40);
            lblCargaHoraria.TabIndex = 7;
            lblCargaHoraria.Text = "Carga Horaría:";
            lblCargaHoraria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDia
            // 
            lblDia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDia.AutoSize = true;
            lblDia.Location = new Point(3, 0);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(97, 40);
            lblDia.TabIndex = 5;
            lblDia.Text = "Día:";
            lblDia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario
            // 
            lblHorario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(3, 40);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(97, 40);
            lblHorario.TabIndex = 6;
            lblHorario.Text = "Horario:";
            lblHorario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(258, 48);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(258, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbDia
            // 
            cmbDia.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(cmbDia, 3);
            cmbDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDia.FormattingEnabled = true;
            cmbDia.Location = new Point(116, 8);
            cmbDia.Name = "cmbDia";
            cmbDia.Size = new Size(99, 23);
            cmbDia.TabIndex = 9;
            // 
            // nudHora
            // 
            nudHora.Anchor = AnchorStyles.None;
            nudHora.Location = new Point(106, 48);
            nudHora.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudHora.Name = "nudHora";
            nudHora.Size = new Size(51, 23);
            nudHora.TabIndex = 14;
            nudHora.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDosPuntos
            // 
            lblDosPuntos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDosPuntos.AutoSize = true;
            lblDosPuntos.Location = new Point(163, 40);
            lblDosPuntos.Name = "lblDosPuntos";
            lblDosPuntos.Size = new Size(14, 40);
            lblDosPuntos.TabIndex = 16;
            lblDosPuntos.Text = ":";
            lblDosPuntos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudMinuto
            // 
            nudMinuto.Anchor = AnchorStyles.None;
            nudMinuto.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            nudMinuto.Location = new Point(183, 48);
            nudMinuto.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinuto.Name = "nudMinuto";
            nudMinuto.Size = new Size(42, 23);
            nudMinuto.TabIndex = 17;
            nudMinuto.TextAlign = HorizontalAlignment.Right;
            // 
            // nudCargaHoraria
            // 
            nudCargaHoraria.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(nudCargaHoraria, 3);
            nudCargaHoraria.Location = new Point(133, 88);
            nudCargaHoraria.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudCargaHoraria.Name = "nudCargaHoraria";
            nudCargaHoraria.Size = new Size(64, 23);
            nudCargaHoraria.TabIndex = 18;
            nudCargaHoraria.TextAlign = HorizontalAlignment.Right;
            // 
            // formHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 143);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(403, 182);
            MinimumSize = new Size(403, 182);
            Name = "formHorario";
            Text = "Agregar Horario";
            FormClosing += formHorario_FormClosing;
            Load += formHorario_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCargaHoraria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblCargaHoraria;
        private Label lblDia;
        private Label lblHorario;
        private ComboBox cmbDia;
        private NumericUpDown nudHora;
        private Label lblDosPuntos;
        private NumericUpDown nudMinuto;
        private NumericUpDown nudCargaHoraria;
    }
}