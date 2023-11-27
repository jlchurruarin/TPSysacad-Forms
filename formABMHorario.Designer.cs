namespace TPSysacad___Forms
{
    partial class formABMHorario
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
            lblDia = new Label();
            lblHorarioInicio = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbDia = new ComboBox();
            nudHoraInicio = new NumericUpDown();
            lblDosPuntos1 = new Label();
            nudMinutoInicio = new NumericUpDown();
            lblHorarioFin = new Label();
            nudHoraFin = new NumericUpDown();
            nudMinutoFin = new NumericUpDown();
            lblDosPuntos2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHoraInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutoInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHoraFin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutoFin).BeginInit();
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
            tableLayoutPanel1.Controls.Add(lblDia, 0, 0);
            tableLayoutPanel1.Controls.Add(lblHorarioInicio, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCancelar, 4, 1);
            tableLayoutPanel1.Controls.Add(btnGuardar, 4, 0);
            tableLayoutPanel1.Controls.Add(cmbDia, 1, 0);
            tableLayoutPanel1.Controls.Add(nudHoraInicio, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDosPuntos1, 2, 1);
            tableLayoutPanel1.Controls.Add(nudMinutoInicio, 3, 1);
            tableLayoutPanel1.Controls.Add(lblHorarioFin, 0, 2);
            tableLayoutPanel1.Controls.Add(nudHoraFin, 1, 2);
            tableLayoutPanel1.Controls.Add(nudMinutoFin, 3, 2);
            tableLayoutPanel1.Controls.Add(lblDosPuntos2, 2, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(363, 159);
            tableLayoutPanel1.TabIndex = 0;
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
            // lblHorarioInicio
            // 
            lblHorarioInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHorarioInicio.AutoSize = true;
            lblHorarioInicio.Location = new Point(3, 40);
            lblHorarioInicio.Name = "lblHorarioInicio";
            lblHorarioInicio.Size = new Size(97, 40);
            lblHorarioInicio.TabIndex = 6;
            lblHorarioInicio.Text = "Horario Inicio:";
            lblHorarioInicio.TextAlign = ContentAlignment.MiddleCenter;
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
            // nudHoraInicio
            // 
            nudHoraInicio.Anchor = AnchorStyles.None;
            nudHoraInicio.Location = new Point(106, 48);
            nudHoraInicio.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudHoraInicio.Name = "nudHoraInicio";
            nudHoraInicio.Size = new Size(51, 23);
            nudHoraInicio.TabIndex = 14;
            nudHoraInicio.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDosPuntos1
            // 
            lblDosPuntos1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDosPuntos1.AutoSize = true;
            lblDosPuntos1.Location = new Point(163, 40);
            lblDosPuntos1.Name = "lblDosPuntos1";
            lblDosPuntos1.Size = new Size(14, 40);
            lblDosPuntos1.TabIndex = 16;
            lblDosPuntos1.Text = ":";
            lblDosPuntos1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudMinutoInicio
            // 
            nudMinutoInicio.Anchor = AnchorStyles.None;
            nudMinutoInicio.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            nudMinutoInicio.Location = new Point(183, 48);
            nudMinutoInicio.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinutoInicio.Name = "nudMinutoInicio";
            nudMinutoInicio.Size = new Size(42, 23);
            nudMinutoInicio.TabIndex = 17;
            nudMinutoInicio.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHorarioFin
            // 
            lblHorarioFin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHorarioFin.AutoSize = true;
            lblHorarioFin.Location = new Point(3, 80);
            lblHorarioFin.Name = "lblHorarioFin";
            lblHorarioFin.Size = new Size(97, 40);
            lblHorarioFin.TabIndex = 18;
            lblHorarioFin.Text = "Horario Fin:";
            lblHorarioFin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudHoraFin
            // 
            nudHoraFin.Anchor = AnchorStyles.None;
            nudHoraFin.Location = new Point(106, 88);
            nudHoraFin.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudHoraFin.Name = "nudHoraFin";
            nudHoraFin.Size = new Size(51, 23);
            nudHoraFin.TabIndex = 19;
            nudHoraFin.TextAlign = HorizontalAlignment.Right;
            // 
            // nudMinutoFin
            // 
            nudMinutoFin.Anchor = AnchorStyles.None;
            nudMinutoFin.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            nudMinutoFin.Location = new Point(183, 88);
            nudMinutoFin.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinutoFin.Name = "nudMinutoFin";
            nudMinutoFin.Size = new Size(42, 23);
            nudMinutoFin.TabIndex = 20;
            nudMinutoFin.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDosPuntos2
            // 
            lblDosPuntos2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDosPuntos2.AutoSize = true;
            lblDosPuntos2.Location = new Point(163, 80);
            lblDosPuntos2.Name = "lblDosPuntos2";
            lblDosPuntos2.Size = new Size(14, 40);
            lblDosPuntos2.TabIndex = 21;
            lblDosPuntos2.Text = ":";
            lblDosPuntos2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formABMHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 183);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(403, 222);
            MinimumSize = new Size(403, 222);
            Name = "formABMHorario";
            Text = "Agregar Horario";
            Load += formHorario_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHoraInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutoInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHoraFin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutoFin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblDia;
        private Label lblHorarioInicio;
        private Label lblHorarioFin;
        private ComboBox cmbDia;
        private Label lblDosPuntos1;
        private Label lblDosPuntos2;
        private NumericUpDown nudMinutoInicio;
        private NumericUpDown nudMinutoFin;
        private NumericUpDown nudHoraInicio;
        private NumericUpDown nudHoraFin;
        private NumericUpDown nudCargaHoraria;
    }
}