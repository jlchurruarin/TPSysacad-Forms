namespace TPSysacad___Forms
{
    partial class formSeleccionarMateria
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
            tlpCurso = new TableLayoutPanel();
            lblBuscarEstudiante = new Label();
            txbBuscarMateria = new TextBox();
            lsbMateria = new ListBox();
            btnAgregarMateria = new Button();
            btnCancelar = new Button();
            tlpCurso.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCurso
            // 
            tlpCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCurso.ColumnCount = 3;
            tlpCurso.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpCurso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCurso.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tlpCurso.Controls.Add(lblBuscarEstudiante, 0, 0);
            tlpCurso.Controls.Add(txbBuscarMateria, 0, 1);
            tlpCurso.Controls.Add(lsbMateria, 0, 2);
            tlpCurso.Controls.Add(btnAgregarMateria, 2, 2);
            tlpCurso.Controls.Add(btnCancelar, 2, 3);
            tlpCurso.Location = new Point(12, 12);
            tlpCurso.Name = "tlpCurso";
            tlpCurso.RowCount = 6;
            tlpCurso.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpCurso.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpCurso.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpCurso.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpCurso.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpCurso.RowStyles.Add(new RowStyle());
            tlpCurso.Size = new Size(391, 413);
            tlpCurso.TabIndex = 3;
            // 
            // lblBuscarEstudiante
            // 
            lblBuscarEstudiante.AutoSize = true;
            lblBuscarEstudiante.Location = new Point(3, 0);
            lblBuscarEstudiante.Name = "lblBuscarEstudiante";
            lblBuscarEstudiante.Size = new Size(88, 15);
            lblBuscarEstudiante.TabIndex = 0;
            lblBuscarEstudiante.Text = "Buscar Materia:";
            // 
            // txbBuscarMateria
            // 
            txbBuscarMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbBuscarMateria.Location = new Point(3, 28);
            txbBuscarMateria.Name = "txbBuscarMateria";
            txbBuscarMateria.Size = new Size(194, 23);
            txbBuscarMateria.TabIndex = 1;
            // 
            // lsbMateria
            // 
            lsbMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCurso.SetColumnSpan(lsbMateria, 2);
            lsbMateria.FormattingEnabled = true;
            lsbMateria.ItemHeight = 15;
            lsbMateria.Location = new Point(3, 53);
            lsbMateria.Name = "lsbMateria";
            tlpCurso.SetRowSpan(lsbMateria, 4);
            lsbMateria.Size = new Size(232, 364);
            lsbMateria.TabIndex = 5;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Anchor = AnchorStyles.None;
            btnAgregarMateria.Location = new Point(248, 53);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(133, 34);
            btnAgregarMateria.TabIndex = 2;
            btnAgregarMateria.Text = "Agregar Materia";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(248, 93);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // formSeleccionarMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 437);
            Controls.Add(tlpCurso);
            Name = "formSeleccionarMateria";
            Text = "formSeleccionarMateria";
            tlpCurso.ResumeLayout(false);
            tlpCurso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCurso;
        private Label lblBuscarEstudiante;
        private TextBox txbBuscarMateria;
        private ListBox lsbMateria;
        private Button btnAgregarMateria;
        private Button btnCancelar;
    }
}