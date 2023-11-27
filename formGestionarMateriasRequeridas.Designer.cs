namespace TPSysacad___Forms
{
    partial class formGestionarMateriasRequeridas
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
            lsbMateriasRequeridas = new ListBox();
            btnAgregarMateriaRequerida = new Button();
            btnEliminarCurso = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(lsbMateriasRequeridas, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarMateriaRequerida, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEliminarCurso, 2, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(710, 437);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // lsbMateriasRequeridas
            // 
            lsbMateriasRequeridas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(lsbMateriasRequeridas, 2);
            lsbMateriasRequeridas.FormattingEnabled = true;
            lsbMateriasRequeridas.ItemHeight = 15;
            lsbMateriasRequeridas.Location = new Point(3, 3);
            lsbMateriasRequeridas.Name = "lsbMateriasRequeridas";
            tableLayoutPanel1.SetRowSpan(lsbMateriasRequeridas, 3);
            lsbMateriasRequeridas.Size = new Size(504, 424);
            lsbMateriasRequeridas.TabIndex = 6;
            // 
            // btnAgregarMateriaRequerida
            // 
            btnAgregarMateriaRequerida.Anchor = AnchorStyles.None;
            btnAgregarMateriaRequerida.Location = new Point(521, 11);
            btnAgregarMateriaRequerida.Name = "btnAgregarMateriaRequerida";
            btnAgregarMateriaRequerida.Size = new Size(178, 28);
            btnAgregarMateriaRequerida.TabIndex = 2;
            btnAgregarMateriaRequerida.Text = "Agregar Materia Requerida";
            btnAgregarMateriaRequerida.UseVisualStyleBackColor = true;
            btnAgregarMateriaRequerida.Click += btnAgregarMateriaRequerida_Click;
            // 
            // btnEliminarCurso
            // 
            btnEliminarCurso.Anchor = AnchorStyles.None;
            btnEliminarCurso.Location = new Point(521, 61);
            btnEliminarCurso.Name = "btnEliminarCurso";
            btnEliminarCurso.Size = new Size(178, 28);
            btnEliminarCurso.TabIndex = 3;
            btnEliminarCurso.Text = "Eliminar Materia Requerida";
            btnEliminarCurso.UseVisualStyleBackColor = true;
            btnEliminarCurso.Click += btnEliminarCurso_Click;
            // 
            // formGestionarMateriasRequeridas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(750, 500);
            Name = "formGestionarMateriasRequeridas";
            Text = "formGestionarMateriasRequeridas";
            Load += formGestionarMateriasRequeridas_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lsbMateriasRequeridas;
        private Button btnAgregarMateriaRequerida;
        private Button btnEliminarCurso;
    }
}