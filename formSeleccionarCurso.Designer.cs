namespace TPSysacad___Forms
{
    partial class formSeleccionarCurso
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
            txbBuscarCurso = new TextBox();
            lsbCursos = new ListBox();
            btnAgregarCurso = new Button();
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
            tlpCurso.Controls.Add(txbBuscarCurso, 0, 1);
            tlpCurso.Controls.Add(lsbCursos, 0, 2);
            tlpCurso.Controls.Add(btnAgregarCurso, 2, 2);
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
            tlpCurso.Size = new Size(401, 418);
            tlpCurso.TabIndex = 2;
            // 
            // lblBuscarEstudiante
            // 
            lblBuscarEstudiante.AutoSize = true;
            lblBuscarEstudiante.Location = new Point(3, 0);
            lblBuscarEstudiante.Name = "lblBuscarEstudiante";
            lblBuscarEstudiante.Size = new Size(79, 15);
            lblBuscarEstudiante.TabIndex = 0;
            lblBuscarEstudiante.Text = "Buscar Curso:";
            lblBuscarEstudiante.Visible = false;
            // 
            // txbBuscarCurso
            // 
            txbBuscarCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbBuscarCurso.Location = new Point(3, 28);
            txbBuscarCurso.Name = "txbBuscarCurso";
            txbBuscarCurso.Size = new Size(194, 23);
            txbBuscarCurso.TabIndex = 1;
            txbBuscarCurso.Visible = false;
            // 
            // lsbCursos
            // 
            lsbCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCurso.SetColumnSpan(lsbCursos, 2);
            lsbCursos.FormattingEnabled = true;
            lsbCursos.ItemHeight = 15;
            lsbCursos.Location = new Point(3, 53);
            lsbCursos.Name = "lsbCursos";
            tlpCurso.SetRowSpan(lsbCursos, 4);
            lsbCursos.Size = new Size(242, 364);
            lsbCursos.TabIndex = 5;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Anchor = AnchorStyles.None;
            btnAgregarCurso.Location = new Point(258, 53);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(133, 34);
            btnAgregarCurso.TabIndex = 2;
            btnAgregarCurso.Text = "Agregar Curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
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
            btnCancelar.Click += btnCancelar_Click;
            // 
            // formSeleccionarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 442);
            Controls.Add(tlpCurso);
            MinimumSize = new Size(441, 481);
            Name = "formSeleccionarCurso";
            Text = "formSeleccionarCurso";
            FormClosing += formSeleccionarCurso_FormClosing;
            Load += formSeleccionarCurso_Load;
            tlpCurso.ResumeLayout(false);
            tlpCurso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCurso;
        private Label lblBuscarEstudiante;
        private TextBox txbBuscarCurso;
        private ListBox lsbCursos;
        private Button btnAgregarCurso;
        private Button btnCancelar;
    }
}