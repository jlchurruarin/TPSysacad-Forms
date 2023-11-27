namespace TPSysacad___Forms
{
    partial class formVerCronograma
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
            btnAceptar = new Button();
            dgvCronograma = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCronograma).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Location = new Point(227, 378);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(124, 36);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dgvCronograma
            // 
            dgvCronograma.AllowUserToAddRows = false;
            dgvCronograma.AllowUserToDeleteRows = false;
            dgvCronograma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCronograma.Location = new Point(12, 12);
            dgvCronograma.Name = "dgvCronograma";
            dgvCronograma.ReadOnly = true;
            dgvCronograma.RowTemplate.Height = 25;
            dgvCronograma.Size = new Size(553, 360);
            dgvCronograma.TabIndex = 2;
            // 
            // formVerCronograma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 426);
            Controls.Add(dgvCronograma);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "formVerCronograma";
            Text = "formVerCronograma";
            Load += formVerCronograma_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCronograma).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAceptar;
        private DataGridView dgvCronograma;
    }
}