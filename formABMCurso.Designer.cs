namespace TPSysacad___Forms
{
    partial class formABMCurso
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
            tlpDetalle = new TableLayoutPanel();
            nudCupoMaximo = new NumericUpDown();
            txbAula = new TextBox();
            cbbProfesor = new ComboBox();
            lblNombreCurso = new Label();
            txbNombreCurso = new TextBox();
            lblMateria = new Label();
            lblProfesor = new Label();
            lblAula = new Label();
            lblCupoMaximo = new Label();
            cbbMateria = new ComboBox();
            tlpCursosInscriptos = new TableLayoutPanel();
            lsbCursosInscriptos = new ListBox();
            btnAgregarCurso = new Button();
            tabCursosInscriptos = new TabPage();
            tlpEstudiante.SuspendLayout();
            tlpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCupoMaximo).BeginInit();
            tlpCursosInscriptos.SuspendLayout();
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
            tlpEstudiante.Controls.Add(tlpDetalle, 0, 0);
            tlpEstudiante.Location = new Point(12, 12);
            tlpEstudiante.Name = "tlpEstudiante";
            tlpEstudiante.RowCount = 3;
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEstudiante.Size = new Size(603, 361);
            tlpEstudiante.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(490, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(490, 38);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tlpDetalle
            // 
            tlpDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpDetalle.ColumnCount = 2;
            tlpDetalle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpDetalle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetalle.Controls.Add(nudCupoMaximo, 1, 4);
            tlpDetalle.Controls.Add(txbAula, 1, 3);
            tlpDetalle.Controls.Add(cbbProfesor, 1, 2);
            tlpDetalle.Controls.Add(lblNombreCurso, 0, 1);
            tlpDetalle.Controls.Add(txbNombreCurso, 1, 1);
            tlpDetalle.Controls.Add(lblMateria, 0, 0);
            tlpDetalle.Controls.Add(lblProfesor, 0, 2);
            tlpDetalle.Controls.Add(lblAula, 0, 3);
            tlpDetalle.Controls.Add(lblCupoMaximo, 0, 4);
            tlpDetalle.Controls.Add(cbbMateria, 1, 0);
            tlpDetalle.Location = new Point(3, 3);
            tlpDetalle.Name = "tlpDetalle";
            tlpDetalle.RowCount = 6;
            tlpEstudiante.SetRowSpan(tlpDetalle, 3);
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDetalle.Size = new Size(447, 355);
            tlpDetalle.TabIndex = 4;
            // 
            // nudCupoMaximo
            // 
            nudCupoMaximo.Anchor = AnchorStyles.None;
            nudCupoMaximo.Location = new Point(157, 168);
            nudCupoMaximo.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCupoMaximo.Name = "nudCupoMaximo";
            nudCupoMaximo.Size = new Size(283, 23);
            nudCupoMaximo.TabIndex = 15;
            nudCupoMaximo.TextAlign = HorizontalAlignment.Right;
            // 
            // txbAula
            // 
            txbAula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbAula.Location = new Point(153, 123);
            txbAula.Name = "txbAula";
            txbAula.Size = new Size(291, 23);
            txbAula.TabIndex = 10;
            // 
            // cbbProfesor
            // 
            cbbProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbProfesor.FormattingEnabled = true;
            cbbProfesor.Location = new Point(153, 83);
            cbbProfesor.Name = "cbbProfesor";
            cbbProfesor.Size = new Size(291, 23);
            cbbProfesor.TabIndex = 9;
            // 
            // lblNombreCurso
            // 
            lblNombreCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombreCurso.AutoSize = true;
            lblNombreCurso.Location = new Point(3, 40);
            lblNombreCurso.Name = "lblNombreCurso";
            lblNombreCurso.Size = new Size(144, 40);
            lblNombreCurso.TabIndex = 1;
            lblNombreCurso.Text = "Denominación:";
            lblNombreCurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbNombreCurso
            // 
            txbNombreCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNombreCurso.Location = new Point(153, 43);
            txbNombreCurso.Name = "txbNombreCurso";
            txbNombreCurso.Size = new Size(291, 23);
            txbNombreCurso.TabIndex = 3;
            // 
            // lblMateria
            // 
            lblMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(3, 0);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(144, 40);
            lblMateria.TabIndex = 4;
            lblMateria.Text = "Materia:";
            lblMateria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProfesor
            // 
            lblProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(3, 80);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(144, 40);
            lblProfesor.TabIndex = 5;
            lblProfesor.Text = "Profesor:";
            lblProfesor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAula
            // 
            lblAula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAula.AutoSize = true;
            lblAula.Location = new Point(3, 120);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(144, 40);
            lblAula.TabIndex = 6;
            lblAula.Text = "Aula:";
            lblAula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCupoMaximo
            // 
            lblCupoMaximo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCupoMaximo.AutoSize = true;
            lblCupoMaximo.Location = new Point(3, 160);
            lblCupoMaximo.Name = "lblCupoMaximo";
            lblCupoMaximo.Size = new Size(144, 40);
            lblCupoMaximo.TabIndex = 7;
            lblCupoMaximo.Text = "Cupo Máximo:";
            lblCupoMaximo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbMateria
            // 
            cbbMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMateria.FormattingEnabled = true;
            cbbMateria.Location = new Point(153, 3);
            cbbMateria.Name = "cbbMateria";
            cbbMateria.Size = new Size(291, 23);
            cbbMateria.TabIndex = 8;
            // 
            // tlpCursosInscriptos
            // 
            tlpCursosInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCursosInscriptos.ColumnCount = 3;
            tlpCursosInscriptos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCursosInscriptos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpCursosInscriptos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpCursosInscriptos.Controls.Add(lsbCursosInscriptos, 0, 0);
            tlpCursosInscriptos.Location = new Point(0, 0);
            tlpCursosInscriptos.Name = "tlpCursosInscriptos";
            tlpCursosInscriptos.RowCount = 1;
            tlpCursosInscriptos.Size = new Size(200, 100);
            tlpCursosInscriptos.TabIndex = 0;
            // 
            // lsbCursosInscriptos
            // 
            lsbCursosInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCursosInscriptos.SetColumnSpan(lsbCursosInscriptos, 3);
            lsbCursosInscriptos.FormattingEnabled = true;
            lsbCursosInscriptos.ItemHeight = 15;
            lsbCursosInscriptos.Location = new Point(3, 3);
            lsbCursosInscriptos.Name = "lsbCursosInscriptos";
            lsbCursosInscriptos.Size = new Size(194, 364);
            lsbCursosInscriptos.TabIndex = 0;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Anchor = AnchorStyles.None;
            btnAgregarCurso.Location = new Point(3, 373);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(60, 23);
            btnAgregarCurso.TabIndex = 3;
            btnAgregarCurso.Text = "Agregar Curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            // 
            // tabCursosInscriptos
            // 
            tabCursosInscriptos.Location = new Point(0, 0);
            tabCursosInscriptos.Name = "tabCursosInscriptos";
            tabCursosInscriptos.Size = new Size(200, 100);
            tabCursosInscriptos.TabIndex = 0;
            // 
            // formABMCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 385);
            Controls.Add(tlpEstudiante);
            Name = "formABMCurso";
            Text = "formABMCurso";
            Load += formABMCurso_Load;
            tlpEstudiante.ResumeLayout(false);
            tlpDetalle.ResumeLayout(false);
            tlpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCupoMaximo).EndInit();
            tlpCursosInscriptos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpEstudiante;
        private Button btnCancelar;
        private Button btnGuardar;
        private TableLayoutPanel tlpCursosInscriptos;
        private ListBox lsbCursosInscriptos;
        private Button btnAgregarCurso;
        private TabPage tabCursosInscriptos;
        private TableLayoutPanel tlpDetalle;
        private NumericUpDown nudCupoMaximo;
        private TextBox txbAula;
        private ComboBox cbbProfesor;
        private Label lblNombreCurso;
        private TextBox txbNombreCurso;
        private Label lblMateria;
        private Label lblProfesor;
        private Label lblAula;
        private Label lblCupoMaximo;
        private ComboBox cbbMateria;
    }
}