﻿namespace TPSysacad___Forms
{
    partial class formABMPago
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
            lblEstadoDePago = new Label();
            lblConceptoDePago = new Label();
            lblHorario = new Label();
            cmbConceptosDePago = new ComboBox();
            nudMonto = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cmbEstadoDePago = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 146F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Controls.Add(lblEstadoDePago, 0, 2);
            tableLayoutPanel1.Controls.Add(lblConceptoDePago, 0, 0);
            tableLayoutPanel1.Controls.Add(lblHorario, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbConceptosDePago, 1, 0);
            tableLayoutPanel1.Controls.Add(nudMonto, 1, 1);
            tableLayoutPanel1.Controls.Add(btnGuardar, 2, 0);
            tableLayoutPanel1.Controls.Add(btnCancelar, 2, 1);
            tableLayoutPanel1.Controls.Add(cmbEstadoDePago, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(448, 120);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblEstadoDePago
            // 
            lblEstadoDePago.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEstadoDePago.AutoSize = true;
            lblEstadoDePago.Location = new Point(3, 80);
            lblEstadoDePago.Name = "lblEstadoDePago";
            lblEstadoDePago.Size = new Size(140, 40);
            lblEstadoDePago.TabIndex = 7;
            lblEstadoDePago.Text = "Estado De Pago:";
            lblEstadoDePago.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConceptoDePago
            // 
            lblConceptoDePago.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblConceptoDePago.AutoSize = true;
            lblConceptoDePago.Location = new Point(3, 0);
            lblConceptoDePago.Name = "lblConceptoDePago";
            lblConceptoDePago.Size = new Size(140, 40);
            lblConceptoDePago.TabIndex = 5;
            lblConceptoDePago.Text = "Concepto de Pago:";
            lblConceptoDePago.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario
            // 
            lblHorario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(3, 40);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(140, 40);
            lblHorario.TabIndex = 6;
            lblHorario.Text = "Monto:";
            lblHorario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbConceptosDePago
            // 
            cmbConceptosDePago.Anchor = AnchorStyles.None;
            cmbConceptosDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConceptosDePago.FormattingEnabled = true;
            cmbConceptosDePago.Location = new Point(149, 8);
            cmbConceptosDePago.Name = "cmbConceptosDePago";
            cmbConceptosDePago.Size = new Size(142, 23);
            cmbConceptosDePago.TabIndex = 9;
            // 
            // nudMonto
            // 
            nudMonto.Anchor = AnchorStyles.None;
            nudMonto.DecimalPlaces = 2;
            nudMonto.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudMonto.Location = new Point(149, 48);
            nudMonto.Maximum = new decimal(new int[] { 3000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(142, 23);
            nudMonto.TabIndex = 14;
            nudMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(333, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(333, 48);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbEstadoDePago
            // 
            cmbEstadoDePago.Anchor = AnchorStyles.None;
            cmbEstadoDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoDePago.FormattingEnabled = true;
            cmbEstadoDePago.Location = new Point(149, 88);
            cmbEstadoDePago.Name = "cmbEstadoDePago";
            cmbEstadoDePago.Size = new Size(142, 23);
            cmbEstadoDePago.TabIndex = 15;
            // 
            // formABMPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 144);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(488, 183);
            Name = "formABMPago";
            Text = "formABMPago";
            Load += formABMPago_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblEstadoDePago;
        private Label lblConceptoDePago;
        private Label lblHorario;
        private ComboBox cmbConceptosDePago;
        private NumericUpDown nudMonto;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox cmbEstadoDePago;
    }
}