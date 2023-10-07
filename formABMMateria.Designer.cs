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
            tabMateria = new TabControl();
            tabDetalles = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            txbDescripcion = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            txbNombre = new TextBox();
            tabMateriasRequeridas = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnEliminarMateria = new Button();
            btnAgregarMateria = new Button();
            lsbMateriasRequeridas = new ListBox();
            tlpEstudiante.SuspendLayout();
            tabMateria.SuspendLayout();
            tabDetalles.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabMateriasRequeridas.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tlpEstudiante.Controls.Add(tabMateria, 0, 0);
            tlpEstudiante.Location = new Point(12, 12);
            tlpEstudiante.Name = "tlpEstudiante";
            tlpEstudiante.RowCount = 3;
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEstudiante.Size = new Size(593, 440);
            tlpEstudiante.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(480, 138);
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
            btnGuardar.Location = new Point(480, 38);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tabMateria
            // 
            tabMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabMateria.Controls.Add(tabDetalles);
            tabMateria.Controls.Add(tabMateriasRequeridas);
            tabMateria.Location = new Point(3, 3);
            tabMateria.Name = "tabMateria";
            tlpEstudiante.SetRowSpan(tabMateria, 3);
            tabMateria.SelectedIndex = 0;
            tabMateria.Size = new Size(437, 434);
            tabMateria.TabIndex = 3;
            // 
            // tabDetalles
            // 
            tabDetalles.Controls.Add(tableLayoutPanel1);
            tabDetalles.Location = new Point(4, 24);
            tabDetalles.Name = "tabDetalles";
            tabDetalles.Padding = new Padding(3);
            tabDetalles.Size = new Size(429, 406);
            tabDetalles.TabIndex = 0;
            tabDetalles.Text = "Detalles";
            tabDetalles.UseVisualStyleBackColor = true;
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
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(417, 394);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txbDescripcion
            // 
            txbDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbDescripcion.Location = new Point(153, 33);
            txbDescripcion.Multiline = true;
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(261, 358);
            txbDescripcion.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(144, 30);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(3, 30);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(144, 364);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbNombre
            // 
            txbNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNombre.Location = new Point(153, 3);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(261, 23);
            txbNombre.TabIndex = 2;
            // 
            // tabMateriasRequeridas
            // 
            tabMateriasRequeridas.Controls.Add(tableLayoutPanel2);
            tabMateriasRequeridas.Location = new Point(4, 24);
            tabMateriasRequeridas.Name = "tabMateriasRequeridas";
            tabMateriasRequeridas.Size = new Size(429, 406);
            tabMateriasRequeridas.TabIndex = 1;
            tabMateriasRequeridas.Text = "Materias requeridas";
            tabMateriasRequeridas.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnEliminarMateria, 1, 1);
            tableLayoutPanel2.Controls.Add(btnAgregarMateria, 0, 1);
            tableLayoutPanel2.Controls.Add(lsbMateriasRequeridas, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 86.14958F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8504152F));
            tableLayoutPanel2.Size = new Size(423, 400);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.Anchor = AnchorStyles.None;
            btnEliminarMateria.Location = new Point(263, 360);
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.Size = new Size(108, 23);
            btnEliminarMateria.TabIndex = 5;
            btnEliminarMateria.Text = "Eliminar Materia";
            btnEliminarMateria.UseVisualStyleBackColor = true;
            btnEliminarMateria.Click += btnEliminarMateria_Click;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Anchor = AnchorStyles.None;
            btnAgregarMateria.Location = new Point(51, 360);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(108, 23);
            btnAgregarMateria.TabIndex = 3;
            btnAgregarMateria.Text = "Agregar Materia";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // lsbMateriasRequeridas
            // 
            lsbMateriasRequeridas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(lsbMateriasRequeridas, 2);
            lsbMateriasRequeridas.FormattingEnabled = true;
            lsbMateriasRequeridas.ItemHeight = 15;
            lsbMateriasRequeridas.Location = new Point(3, 3);
            lsbMateriasRequeridas.Name = "lsbMateriasRequeridas";
            lsbMateriasRequeridas.Size = new Size(417, 334);
            lsbMateriasRequeridas.TabIndex = 4;
            // 
            // formABMMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 464);
            Controls.Add(tlpEstudiante);
            Name = "formABMMateria";
            Text = "formABMMateria";
            Load += formABMMateria_Load;
            tlpEstudiante.ResumeLayout(false);
            tabMateria.ResumeLayout(false);
            tabDetalles.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabMateriasRequeridas.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpEstudiante;
        private Button btnCancelar;
        private Button btnGuardar;
        private TabControl tabMateria;
        private TabPage tabDetalles;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblNombre;
        private TextBox txbDescripcion;
        private Label lblDescripcion;
        private TextBox txbNombre;
        private TabPage tabMateriasRequeridas;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnEliminarMateria;
        private Button btnAgregarMateria;
        private ListBox lsbMateriasRequeridas;
    }
}