namespace TPSysacad___Forms
{
    partial class formReportViewer
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
            btnExportarAExcel = new Button();
            lblTitulo = new Label();
            dgvDatos = new DataGridView();
            btnExportarAPDF = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnExportarAExcel, 1, 2);
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDatos, 0, 1);
            tableLayoutPanel1.Controls.Add(btnExportarAPDF, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.59536552F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.40463F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(777, 582);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExportarAExcel
            // 
            btnExportarAExcel.Anchor = AnchorStyles.None;
            btnExportarAExcel.Location = new Point(523, 549);
            btnExportarAExcel.Name = "btnExportarAExcel";
            btnExportarAExcel.Size = new Size(118, 23);
            btnExportarAExcel.TabIndex = 3;
            btnExportarAExcel.Text = "Exportar a Excel";
            btnExportarAExcel.UseVisualStyleBackColor = true;
            btnExportarAExcel.Click += btnExportarAExcel_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitulo, 2);
            lblTitulo.Location = new Point(388, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 15);
            lblTitulo.TabIndex = 0;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AllowUserToOrderColumns = true;
            dgvDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvDatos, 2);
            dgvDatos.Location = new Point(3, 38);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(771, 499);
            dgvDatos.TabIndex = 1;
            // 
            // btnExportarAPDF
            // 
            btnExportarAPDF.Anchor = AnchorStyles.None;
            btnExportarAPDF.Location = new Point(135, 549);
            btnExportarAPDF.Name = "btnExportarAPDF";
            btnExportarAPDF.Size = new Size(118, 23);
            btnExportarAPDF.TabIndex = 2;
            btnExportarAPDF.Text = "Exportar a PDF";
            btnExportarAPDF.UseVisualStyleBackColor = true;
            btnExportarAPDF.Click += btnExportarAPDF_Click;
            // 
            // formReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 606);
            Controls.Add(tableLayoutPanel1);
            Name = "formReportViewer";
            Text = "formReportViewer";
            Load += formReportViewer_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Button btnExportarAExcel;
        private DataGridView dgvDatos;
        private Button btnExportarAPDF;
    }
}