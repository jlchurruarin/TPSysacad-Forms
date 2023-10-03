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
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblDia = new Label();
            lblCargaHoraria = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            lblDosPuntos = new Label();
            numericUpDown2 = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDia, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCargaHoraria, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCancelar, 4, 1);
            tableLayoutPanel1.Controls.Add(btnGuardar, 4, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDosPuntos, 2, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 3, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(369, 121);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(274, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(274, 48);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDia
            // 
            lblDia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDia.AutoSize = true;
            lblDia.Location = new Point(3, 0);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(144, 40);
            lblDia.TabIndex = 5;
            lblDia.Text = "Día:";
            lblDia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCargaHoraria
            // 
            lblCargaHoraria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCargaHoraria.AutoSize = true;
            lblCargaHoraria.Location = new Point(3, 40);
            lblCargaHoraria.Name = "lblCargaHoraria";
            lblCargaHoraria.Size = new Size(144, 40);
            lblCargaHoraria.TabIndex = 6;
            lblCargaHoraria.Text = "Horario:";
            lblCargaHoraria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(144, 41);
            label2.TabIndex = 7;
            label2.Text = "Carga Horaría:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(comboBox1, 3);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(153, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 23);
            comboBox1.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(textBox4, 3);
            textBox4.Location = new Point(153, 89);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(99, 23);
            textBox4.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Location = new Point(153, 48);
            numericUpDown1.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(38, 23);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDosPuntos
            // 
            lblDosPuntos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDosPuntos.AutoSize = true;
            lblDosPuntos.Location = new Point(197, 40);
            lblDosPuntos.Name = "lblDosPuntos";
            lblDosPuntos.Size = new Size(13, 40);
            lblDosPuntos.TabIndex = 16;
            lblDosPuntos.Text = ":";
            lblDosPuntos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.None;
            numericUpDown2.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown2.Location = new Point(216, 48);
            numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(36, 23);
            numericUpDown2.TabIndex = 17;
            numericUpDown2.TextAlign = HorizontalAlignment.Right;
            // 
            // formHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 145);
            Controls.Add(tableLayoutPanel1);
            Name = "formHorario";
            Text = "Agregar Horario";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label2;
        private Label lblDia;
        private Label lblCargaHoraria;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private Label lblDosPuntos;
        private NumericUpDown numericUpDown2;
    }
}