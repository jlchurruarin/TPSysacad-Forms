namespace TPSysacad___Forms
{
    partial class formMenuEstudiante
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
            btnRealizarPagos = new Button();
            btnVerHorarios = new Button();
            btnInscripcion = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRealizarPagos, 0, 2);
            tableLayoutPanel1.Controls.Add(btnVerHorarios, 0, 1);
            tableLayoutPanel1.Controls.Add(btnInscripcion, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.Size = new Size(224, 218);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRealizarPagos
            // 
            btnRealizarPagos.Anchor = AnchorStyles.None;
            btnRealizarPagos.Location = new Point(24, 156);
            btnRealizarPagos.Name = "btnRealizarPagos";
            btnRealizarPagos.Size = new Size(176, 42);
            btnRealizarPagos.TabIndex = 2;
            btnRealizarPagos.Text = "Realizar Pagos";
            btnRealizarPagos.UseVisualStyleBackColor = true;
            btnRealizarPagos.Click += btnRealizarPagos_Click;
            // 
            // btnVerHorarios
            // 
            btnVerHorarios.Anchor = AnchorStyles.None;
            btnVerHorarios.Location = new Point(24, 81);
            btnVerHorarios.Name = "btnVerHorarios";
            btnVerHorarios.Size = new Size(176, 42);
            btnVerHorarios.TabIndex = 1;
            btnVerHorarios.Text = "Ver cursos inscriptos";
            btnVerHorarios.UseVisualStyleBackColor = true;
            btnVerHorarios.Click += btnVerHorarios_Click;
            // 
            // btnInscripcion
            // 
            btnInscripcion.Anchor = AnchorStyles.None;
            btnInscripcion.Location = new Point(24, 13);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(176, 42);
            btnInscripcion.TabIndex = 0;
            btnInscripcion.Text = "Inscripción a Cursos";
            btnInscripcion.UseVisualStyleBackColor = true;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // formMenuEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 242);
            Controls.Add(tableLayoutPanel1);
            Name = "formMenuEstudiante";
            Text = "fromMenuEstudiante";
            FormClosed += formMenuEstudiante_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnInscripcion;
        private Button btnRealizarPagos;
        private Button btnVerHorarios;
    }
}