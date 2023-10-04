namespace TPSysacad___Forms
{
    partial class formSeleccionarEstudiante
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
            lblBuscarEstudiante = new Label();
            txbBuscarEstudiante = new TextBox();
            lsbEstudiantes = new ListBox();
            btnAgregarEstudiante = new Button();
            btnCancelar = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.Controls.Add(lblBuscarEstudiante, 0, 0);
            tableLayoutPanel1.Controls.Add(txbBuscarEstudiante, 0, 1);
            tableLayoutPanel1.Controls.Add(lsbEstudiantes, 0, 2);
            tableLayoutPanel1.Controls.Add(btnAgregarEstudiante, 2, 2);
            tableLayoutPanel1.Controls.Add(btnCancelar, 2, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(401, 418);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblBuscarEstudiante
            // 
            lblBuscarEstudiante.AutoSize = true;
            lblBuscarEstudiante.Location = new Point(3, 0);
            lblBuscarEstudiante.Name = "lblBuscarEstudiante";
            lblBuscarEstudiante.Size = new Size(103, 15);
            lblBuscarEstudiante.TabIndex = 0;
            lblBuscarEstudiante.Text = "Buscar Estudiante:";
            // 
            // txbBuscarEstudiante
            // 
            txbBuscarEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbBuscarEstudiante.Location = new Point(3, 28);
            txbBuscarEstudiante.Name = "txbBuscarEstudiante";
            txbBuscarEstudiante.Size = new Size(194, 23);
            txbBuscarEstudiante.TabIndex = 1;
            // 
            // lsbEstudiantes
            // 
            lsbEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(lsbEstudiantes, 2);
            lsbEstudiantes.FormattingEnabled = true;
            lsbEstudiantes.ItemHeight = 15;
            lsbEstudiantes.Location = new Point(3, 53);
            lsbEstudiantes.Name = "lsbEstudiantes";
            tableLayoutPanel1.SetRowSpan(lsbEstudiantes, 4);
            lsbEstudiantes.Size = new Size(242, 364);
            lsbEstudiantes.TabIndex = 5;
            // 
            // btnAgregarEstudiante
            // 
            btnAgregarEstudiante.Anchor = AnchorStyles.None;
            btnAgregarEstudiante.Location = new Point(258, 53);
            btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            btnAgregarEstudiante.Size = new Size(133, 34);
            btnAgregarEstudiante.TabIndex = 2;
            btnAgregarEstudiante.Text = "Agregar Estudiante";
            btnAgregarEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(258, 93);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // formSeleccionarEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 442);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(441, 481);
            Name = "formSeleccionarEstudiante";
            Text = "formSeleccionarEstudiante";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblBuscarEstudiante;
        private TextBox txbBuscarEstudiante;
        private ListBox lsbEstudiantes;
        private Button btnAgregarEstudiante;
        private Button btnCancelar;
    }
}