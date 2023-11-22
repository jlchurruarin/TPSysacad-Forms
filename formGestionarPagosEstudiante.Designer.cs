namespace TPSysacad___Forms
{
    partial class formGestionarPagosEstudiante
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
            lsbPagos = new ListBox();
            btnAgregarPago = new Button();
            btnEliminarPago = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(lsbPagos, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarPago, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEliminarPago, 2, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(710, 437);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lsbPagos
            // 
            lsbPagos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(lsbPagos, 2);
            lsbPagos.FormattingEnabled = true;
            lsbPagos.ItemHeight = 15;
            lsbPagos.Location = new Point(3, 3);
            lsbPagos.Name = "lsbPagos";
            tableLayoutPanel1.SetRowSpan(lsbPagos, 3);
            lsbPagos.Size = new Size(554, 424);
            lsbPagos.TabIndex = 6;
            // 
            // btnAgregarPago
            // 
            btnAgregarPago.Anchor = AnchorStyles.None;
            btnAgregarPago.Location = new Point(584, 11);
            btnAgregarPago.Name = "btnAgregarPago";
            btnAgregarPago.Size = new Size(102, 28);
            btnAgregarPago.TabIndex = 2;
            btnAgregarPago.Text = "Agregar Pago";
            btnAgregarPago.UseVisualStyleBackColor = true;
            btnAgregarPago.Click += btnAgregarPago_Click;
            // 
            // btnEliminarPago
            // 
            btnEliminarPago.Anchor = AnchorStyles.None;
            btnEliminarPago.Location = new Point(584, 61);
            btnEliminarPago.Name = "btnEliminarPago";
            btnEliminarPago.Size = new Size(102, 28);
            btnEliminarPago.TabIndex = 3;
            btnEliminarPago.Text = "Eliminar Pago";
            btnEliminarPago.UseVisualStyleBackColor = true;
            btnEliminarPago.Click += btnEliminarPago_Click;
            // 
            // formGestionarPagosEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(750, 500);
            Name = "formGestionarPagosEstudiante";
            Text = "formGestionarPagosEstudiante";
            Load += formGestionarPagosEstudiante_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEliminarPago;
        private Button btnAgregarPago;
        private ListBox lsbPagos;
    }
}