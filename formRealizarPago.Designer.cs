namespace TPSysacad___Forms
{
    partial class formRealizarPago
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
            cmbMetodoDePago = new ComboBox();
            lblTipoDePago = new Label();
            txbNumeroTarjeta = new TextBox();
            lblNumeroTarjeta = new Label();
            gbPagoConTarjeta = new GroupBox();
            tlpPagoConTarjeta = new TableLayoutPanel();
            txbCCV = new TextBox();
            txbFechaVencimiento = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnRealizarPago = new Button();
            gbPagoTransferencia = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblCBUDestino = new Label();
            lblCBU = new Label();
            txbCBU = new TextBox();
            gbPagoEfectivo = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblPagoEfectivo = new Label();
            gbPagoConMP = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            QR = new PictureBox();
            label3 = new Label();
            lblTotalAPagar = new Label();
            txbMontoTotal = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            gbPagoConTarjeta.SuspendLayout();
            tlpPagoConTarjeta.SuspendLayout();
            gbPagoTransferencia.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            gbPagoEfectivo.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            gbPagoConMP.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QR).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.71963F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.28037F));
            tableLayoutPanel1.Controls.Add(cmbMetodoDePago, 1, 0);
            tableLayoutPanel1.Controls.Add(lblTipoDePago, 0, 0);
            tableLayoutPanel1.Location = new Point(18, 11);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(461, 48);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbMetodoDePago
            // 
            cmbMetodoDePago.Anchor = AnchorStyles.None;
            cmbMetodoDePago.FormattingEnabled = true;
            cmbMetodoDePago.Location = new Point(140, 12);
            cmbMetodoDePago.Name = "cmbMetodoDePago";
            cmbMetodoDePago.Size = new Size(318, 23);
            cmbMetodoDePago.TabIndex = 0;
            cmbMetodoDePago.SelectedIndexChanged += cmbMetodoDePago_SelectedIndexChanged;
            // 
            // lblTipoDePago
            // 
            lblTipoDePago.Anchor = AnchorStyles.None;
            lblTipoDePago.AutoSize = true;
            lblTipoDePago.Location = new Point(19, 16);
            lblTipoDePago.Name = "lblTipoDePago";
            lblTipoDePago.Size = new Size(98, 15);
            lblTipoDePago.TabIndex = 1;
            lblTipoDePago.Text = "Metodo de Pago:";
            // 
            // txbNumeroTarjeta
            // 
            txbNumeroTarjeta.Anchor = AnchorStyles.None;
            txbNumeroTarjeta.Location = new Point(137, 8);
            txbNumeroTarjeta.Name = "txbNumeroTarjeta";
            txbNumeroTarjeta.Size = new Size(318, 23);
            txbNumeroTarjeta.TabIndex = 2;
            // 
            // lblNumeroTarjeta
            // 
            lblNumeroTarjeta.Anchor = AnchorStyles.None;
            lblNumeroTarjeta.AutoSize = true;
            lblNumeroTarjeta.Location = new Point(13, 12);
            lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            lblNumeroTarjeta.Size = new Size(107, 15);
            lblNumeroTarjeta.TabIndex = 3;
            lblNumeroTarjeta.Text = "Numero de Tarjeta:";
            // 
            // gbPagoConTarjeta
            // 
            gbPagoConTarjeta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPagoConTarjeta.Controls.Add(tlpPagoConTarjeta);
            gbPagoConTarjeta.Location = new Point(11, 71);
            gbPagoConTarjeta.Name = "gbPagoConTarjeta";
            gbPagoConTarjeta.Size = new Size(470, 154);
            gbPagoConTarjeta.TabIndex = 4;
            gbPagoConTarjeta.TabStop = false;
            gbPagoConTarjeta.Text = "Pago Con tarjeta";
            gbPagoConTarjeta.Visible = false;
            // 
            // tlpPagoConTarjeta
            // 
            tlpPagoConTarjeta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpPagoConTarjeta.ColumnCount = 2;
            tlpPagoConTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4326248F));
            tlpPagoConTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.5673752F));
            tlpPagoConTarjeta.Controls.Add(txbCCV, 1, 2);
            tlpPagoConTarjeta.Controls.Add(lblNumeroTarjeta, 0, 0);
            tlpPagoConTarjeta.Controls.Add(txbFechaVencimiento, 1, 1);
            tlpPagoConTarjeta.Controls.Add(label2, 0, 2);
            tlpPagoConTarjeta.Controls.Add(txbNumeroTarjeta, 1, 0);
            tlpPagoConTarjeta.Controls.Add(label1, 0, 1);
            tlpPagoConTarjeta.Location = new Point(6, 22);
            tlpPagoConTarjeta.Name = "tlpPagoConTarjeta";
            tlpPagoConTarjeta.RowCount = 4;
            tlpPagoConTarjeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpPagoConTarjeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpPagoConTarjeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpPagoConTarjeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpPagoConTarjeta.Size = new Size(458, 120);
            tlpPagoConTarjeta.TabIndex = 7;
            // 
            // txbCCV
            // 
            txbCCV.Anchor = AnchorStyles.None;
            txbCCV.Location = new Point(137, 88);
            txbCCV.Name = "txbCCV";
            txbCCV.Size = new Size(318, 23);
            txbCCV.TabIndex = 7;
            // 
            // txbFechaVencimiento
            // 
            txbFechaVencimiento.Anchor = AnchorStyles.None;
            txbFechaVencimiento.Location = new Point(137, 48);
            txbFechaVencimiento.Name = "txbFechaVencimiento";
            txbFechaVencimiento.Size = new Size(318, 23);
            txbFechaVencimiento.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(50, 92);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "CCV:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(4, 52);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 4;
            label1.Text = "Fecha de vencimiento:";
            // 
            // btnRealizarPago
            // 
            btnRealizarPago.Anchor = AnchorStyles.None;
            btnRealizarPago.Location = new Point(179, 263);
            btnRealizarPago.Name = "btnRealizarPago";
            btnRealizarPago.Size = new Size(119, 31);
            btnRealizarPago.TabIndex = 8;
            btnRealizarPago.Text = "Realizar Pago";
            btnRealizarPago.UseVisualStyleBackColor = true;
            btnRealizarPago.Click += btnRealizarPago_Click;
            // 
            // gbPagoTransferencia
            // 
            gbPagoTransferencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPagoTransferencia.Controls.Add(tableLayoutPanel2);
            gbPagoTransferencia.Location = new Point(11, 71);
            gbPagoTransferencia.Name = "gbPagoTransferencia";
            gbPagoTransferencia.Size = new Size(470, 154);
            gbPagoTransferencia.TabIndex = 8;
            gbPagoTransferencia.TabStop = false;
            gbPagoTransferencia.Text = "Pago con transferencia";
            gbPagoTransferencia.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4326248F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.5673752F));
            tableLayoutPanel2.Controls.Add(lblCBUDestino, 0, 1);
            tableLayoutPanel2.Controls.Add(lblCBU, 0, 0);
            tableLayoutPanel2.Controls.Add(txbCBU, 1, 0);
            tableLayoutPanel2.Location = new Point(7, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(457, 120);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // lblCBUDestino
            // 
            lblCBUDestino.Anchor = AnchorStyles.None;
            lblCBUDestino.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(lblCBUDestino, 2);
            lblCBUDestino.Location = new Point(111, 72);
            lblCBUDestino.Name = "lblCBUDestino";
            lblCBUDestino.Size = new Size(234, 15);
            lblCBUDestino.TabIndex = 4;
            lblCBUDestino.Text = "Realizar transferencia al CBU: 123412341234";
            // 
            // lblCBU
            // 
            lblCBU.Anchor = AnchorStyles.None;
            lblCBU.AutoSize = true;
            lblCBU.Location = new Point(42, 12);
            lblCBU.Name = "lblCBU";
            lblCBU.Size = new Size(49, 15);
            lblCBU.TabIndex = 3;
            lblCBU.Text = "Tu CBU:";
            // 
            // txbCBU
            // 
            txbCBU.Anchor = AnchorStyles.None;
            txbCBU.Location = new Point(137, 8);
            txbCBU.Name = "txbCBU";
            txbCBU.Size = new Size(317, 23);
            txbCBU.TabIndex = 2;
            // 
            // gbPagoEfectivo
            // 
            gbPagoEfectivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPagoEfectivo.Controls.Add(tableLayoutPanel3);
            gbPagoEfectivo.Location = new Point(11, 71);
            gbPagoEfectivo.Name = "gbPagoEfectivo";
            gbPagoEfectivo.Size = new Size(470, 154);
            gbPagoEfectivo.TabIndex = 9;
            gbPagoEfectivo.TabStop = false;
            gbPagoEfectivo.Text = "Pago con tarjeta";
            gbPagoEfectivo.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4326248F));
            tableLayoutPanel3.Controls.Add(lblPagoEfectivo, 0, 0);
            tableLayoutPanel3.Location = new Point(7, 22);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(457, 119);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // lblPagoEfectivo
            // 
            lblPagoEfectivo.Anchor = AnchorStyles.None;
            lblPagoEfectivo.AutoSize = true;
            lblPagoEfectivo.Location = new Point(97, 52);
            lblPagoEfectivo.Name = "lblPagoEfectivo";
            lblPagoEfectivo.Size = new Size(262, 15);
            lblPagoEfectivo.TabIndex = 4;
            lblPagoEfectivo.Text = "Realizar pago presencialmente en Calle Falsa 123";
            // 
            // gbPagoConMP
            // 
            gbPagoConMP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPagoConMP.Controls.Add(tableLayoutPanel4);
            gbPagoConMP.Location = new Point(11, 71);
            gbPagoConMP.Name = "gbPagoConMP";
            gbPagoConMP.Size = new Size(470, 154);
            gbPagoConMP.TabIndex = 10;
            gbPagoConMP.TabStop = false;
            gbPagoConMP.Text = "Pago con MercadoPago";
            gbPagoConMP.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(QR, 0, 1);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Location = new Point(7, 22);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(457, 120);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // QR
            // 
            QR.Anchor = AnchorStyles.None;
            QR.Image = Properties.Resources.licensed_image;
            QR.Location = new Point(191, 43);
            QR.Name = "QR";
            QR.Size = new Size(75, 74);
            QR.SizeMode = PictureBoxSizeMode.StretchImage;
            QR.TabIndex = 11;
            QR.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(451, 15);
            label3.TabIndex = 4;
            label3.Text = "Escanee el siguente QR y realice el pago, una vez finalizado precione en realizar pago";
            // 
            // lblTotalAPagar
            // 
            lblTotalAPagar.AutoSize = true;
            lblTotalAPagar.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAPagar.Location = new Point(67, 232);
            lblTotalAPagar.Name = "lblTotalAPagar";
            lblTotalAPagar.Size = new Size(145, 23);
            lblTotalAPagar.TabIndex = 9;
            lblTotalAPagar.Text = "Total a pagar:";
            // 
            // txbMontoTotal
            // 
            txbMontoTotal.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txbMontoTotal.Location = new Point(218, 229);
            txbMontoTotal.Name = "txbMontoTotal";
            txbMontoTotal.ReadOnly = true;
            txbMontoTotal.Size = new Size(195, 29);
            txbMontoTotal.TabIndex = 10;
            txbMontoTotal.Text = "$";
            txbMontoTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // formRealizarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 305);
            Controls.Add(txbMontoTotal);
            Controls.Add(lblTotalAPagar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnRealizarPago);
            Controls.Add(gbPagoEfectivo);
            Controls.Add(gbPagoConTarjeta);
            Controls.Add(gbPagoTransferencia);
            Controls.Add(gbPagoConMP);
            MaximumSize = new Size(510, 344);
            MinimumSize = new Size(510, 344);
            Name = "formRealizarPago";
            Text = "formRealizarPago";
            Load += formRealizarPago_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            gbPagoConTarjeta.ResumeLayout(false);
            tlpPagoConTarjeta.ResumeLayout(false);
            tlpPagoConTarjeta.PerformLayout();
            gbPagoTransferencia.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            gbPagoEfectivo.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            gbPagoConMP.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cmbMetodoDePago;
        private Label lblTipoDePago;
        private TextBox txbNumeroTarjeta;
        private Label lblNumeroTarjeta;
        private GroupBox gbPagoConTarjeta;
        private TextBox txbFechaVencimiento;
        private Label label1;
        private TableLayoutPanel tlpPagoConTarjeta;
        private TextBox txbCCV;
        private Label label2;
        private Button btnRealizarPago;
        private GroupBox gbPagoTransferencia;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblCBU;
        private TextBox txbCBU;
        private Label lblCBUDestino;
        private Label lblTotalAPagar;
        private TextBox txbMontoTotal;
        private GroupBox gbPagoEfectivo;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblPagoEfectivo;
        private GroupBox gbPagoConMP;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private PictureBox QR;
    }
}