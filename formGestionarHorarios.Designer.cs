namespace TPSysacad___Forms
{
    partial class formGestionarHorarios
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
            lsbHorarios = new ListBox();
            btnAgregarHorario = new Button();
            btnEliminarHorario = new Button();
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
            tableLayoutPanel1.Controls.Add(lsbHorarios, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarHorario, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEliminarHorario, 2, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(710, 437);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // lsbHorarios
            // 
            lsbHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(lsbHorarios, 2);
            lsbHorarios.FormattingEnabled = true;
            lsbHorarios.ItemHeight = 15;
            lsbHorarios.Location = new Point(3, 3);
            lsbHorarios.Name = "lsbHorarios";
            tableLayoutPanel1.SetRowSpan(lsbHorarios, 3);
            lsbHorarios.Size = new Size(504, 424);
            lsbHorarios.TabIndex = 6;
            // 
            // btnAgregarHorario
            // 
            btnAgregarHorario.Anchor = AnchorStyles.None;
            btnAgregarHorario.Location = new Point(554, 11);
            btnAgregarHorario.Name = "btnAgregarHorario";
            btnAgregarHorario.Size = new Size(111, 28);
            btnAgregarHorario.TabIndex = 2;
            btnAgregarHorario.Text = "Agregar Horario";
            btnAgregarHorario.UseVisualStyleBackColor = true;
            btnAgregarHorario.Click += btnAgregarHorario_Click;
            // 
            // btnEliminarHorario
            // 
            btnEliminarHorario.Anchor = AnchorStyles.None;
            btnEliminarHorario.Location = new Point(554, 61);
            btnEliminarHorario.Name = "btnEliminarHorario";
            btnEliminarHorario.Size = new Size(111, 28);
            btnEliminarHorario.TabIndex = 3;
            btnEliminarHorario.Text = "Eliminar Horario";
            btnEliminarHorario.UseVisualStyleBackColor = true;
            btnEliminarHorario.Click += btnEliminarHorario_Click;
            // 
            // formGestionarHorarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(750, 500);
            Name = "formGestionarHorarios";
            Text = "formGestionarHorarios";
            Load += formGestionarHorarios_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lsbHorarios;
        private Button btnAgregarHorario;
        private Button btnEliminarHorario;
    }
}