﻿namespace TPSysacad___Forms
{
    partial class formSeleccionarPagos
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
            dataGridView1 = new DataGridView();
            btnRealizarPagosSeleccionados = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(543, 254);
            dataGridView1.TabIndex = 0;
            // 
            // btnRealizarPagosSeleccionados
            // 
            btnRealizarPagosSeleccionados.Location = new Point(187, 296);
            btnRealizarPagosSeleccionados.Name = "btnRealizarPagosSeleccionados";
            btnRealizarPagosSeleccionados.Size = new Size(183, 30);
            btnRealizarPagosSeleccionados.TabIndex = 1;
            btnRealizarPagosSeleccionados.Text = "Realizar pagos seleccionados";
            btnRealizarPagosSeleccionados.UseVisualStyleBackColor = true;
            btnRealizarPagosSeleccionados.Click += btnRealizarPagosSeleccionados_Click;
            // 
            // formSeleccionarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 350);
            Controls.Add(btnRealizarPagosSeleccionados);
            Controls.Add(dataGridView1);
            Name = "formSeleccionarPagos";
            Text = "formSeleccionarPagos";
            Load += formSeleccionarPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRealizarPagosSeleccionados;
    }
}