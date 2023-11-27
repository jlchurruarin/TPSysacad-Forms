namespace TPSysacad___Forms
{
    partial class formABMInscripcion
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
            tlpInscripcion = new TableLayoutPanel();
            txbCurso = new TextBox();
            label1 = new Label();
            lblEstudiante = new Label();
            txbEstudiante = new TextBox();
            btnBuscarEstudiante = new Button();
            lblEstadoDeInscripcion = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbbEstadoDeInscripción = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            tlpInscripcion.SuspendLayout();
            SuspendLayout();
            // 
            // tlpInscripcion
            // 
            tlpInscripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpInscripcion.ColumnCount = 4;
            tlpInscripcion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpInscripcion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tlpInscripcion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tlpInscripcion.ColumnStyles.Add(new ColumnStyle());
            tlpInscripcion.Controls.Add(txbCurso, 1, 0);
            tlpInscripcion.Controls.Add(label1, 0, 0);
            tlpInscripcion.Controls.Add(lblEstudiante, 0, 1);
            tlpInscripcion.Controls.Add(txbEstudiante, 1, 1);
            tlpInscripcion.Controls.Add(btnBuscarEstudiante, 2, 1);
            tlpInscripcion.Controls.Add(lblEstadoDeInscripcion, 0, 2);
            tlpInscripcion.Controls.Add(label2, 0, 3);
            tlpInscripcion.Controls.Add(dateTimePicker1, 1, 3);
            tlpInscripcion.Controls.Add(cbbEstadoDeInscripción, 1, 2);
            tlpInscripcion.Controls.Add(btnAceptar, 3, 0);
            tlpInscripcion.Controls.Add(btnCancelar, 3, 1);
            tlpInscripcion.Location = new Point(12, 12);
            tlpInscripcion.Name = "tlpInscripcion";
            tlpInscripcion.RowCount = 4;
            tlpInscripcion.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpInscripcion.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpInscripcion.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpInscripcion.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpInscripcion.Size = new Size(776, 426);
            tlpInscripcion.TabIndex = 0;
            // 
            // txbCurso
            // 
            txbCurso.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbCurso.Enabled = false;
            txbCurso.Location = new Point(203, 13);
            txbCurso.Name = "txbCurso";
            txbCurso.Size = new Size(244, 23);
            txbCurso.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(79, 17);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Curso:";
            // 
            // lblEstudiante
            // 
            lblEstudiante.Anchor = AnchorStyles.None;
            lblEstudiante.AutoSize = true;
            lblEstudiante.Location = new Point(67, 67);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(65, 15);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante:";
            // 
            // txbEstudiante
            // 
            txbEstudiante.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbEstudiante.Enabled = false;
            txbEstudiante.Location = new Point(203, 63);
            txbEstudiante.Name = "txbEstudiante";
            txbEstudiante.Size = new Size(244, 23);
            txbEstudiante.TabIndex = 1;
            // 
            // btnBuscarEstudiante
            // 
            btnBuscarEstudiante.Anchor = AnchorStyles.None;
            btnBuscarEstudiante.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarEstudiante.Location = new Point(461, 57);
            btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            btnBuscarEstudiante.Size = new Size(28, 35);
            btnBuscarEstudiante.TabIndex = 2;
            btnBuscarEstudiante.Text = "🔎";
            btnBuscarEstudiante.UseVisualStyleBackColor = true;
            btnBuscarEstudiante.Click += btnBuscarEstudiante_Click;
            // 
            // lblEstadoDeInscripcion
            // 
            lblEstadoDeInscripcion.Anchor = AnchorStyles.None;
            lblEstadoDeInscripcion.AutoSize = true;
            lblEstadoDeInscripcion.Location = new Point(40, 117);
            lblEstadoDeInscripcion.Name = "lblEstadoDeInscripcion";
            lblEstadoDeInscripcion.Size = new Size(119, 15);
            lblEstadoDeInscripcion.TabIndex = 5;
            lblEstadoDeInscripcion.Text = "Estado de inscripción";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(42, 280);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha de Inscripción";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(203, 276);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // cbbEstadoDeInscripción
            // 
            cbbEstadoDeInscripción.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbbEstadoDeInscripción.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEstadoDeInscripción.FormattingEnabled = true;
            cbbEstadoDeInscripción.Location = new Point(203, 113);
            cbbEstadoDeInscripción.Name = "cbbEstadoDeInscripción";
            cbbEstadoDeInscripción.Size = new Size(244, 23);
            cbbEstadoDeInscripción.TabIndex = 8;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Location = new Point(592, 12);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(91, 26);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(592, 62);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 26);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // formABMInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpInscripcion);
            Name = "formABMInscripcion";
            Text = "formABMInscripcion";
            Load += formABMInscripcion_Load;
            tlpInscripcion.ResumeLayout(false);
            tlpInscripcion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpInscripcion;
        private Label lblEstudiante;
        private TextBox txbEstudiante;
        private Button btnBuscarEstudiante;
        private Label label1;
        private TextBox txbCurso;
        private Label lblEstadoDeInscripcion;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbbEstadoDeInscripción;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}