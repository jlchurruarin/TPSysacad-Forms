namespace TPSysacad___Forms
{
    partial class formInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEstudiante = new Button();
            btnProfesor = new Button();
            btnAdministrador = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnEstudiante
            // 
            btnEstudiante.Location = new Point(12, 12);
            btnEstudiante.Name = "btnEstudiante";
            btnEstudiante.Size = new Size(141, 30);
            btnEstudiante.TabIndex = 0;
            btnEstudiante.Text = "Acceso a Estudiantes";
            btnEstudiante.UseVisualStyleBackColor = true;
            btnEstudiante.Click += btnEstudiante_Click;
            // 
            // btnProfesor
            // 
            btnProfesor.Location = new Point(12, 48);
            btnProfesor.Name = "btnProfesor";
            btnProfesor.Size = new Size(141, 30);
            btnProfesor.TabIndex = 1;
            btnProfesor.Text = "Acceso a Profesores";
            btnProfesor.UseVisualStyleBackColor = true;
            btnProfesor.Click += btnProfesor_Click;
            // 
            // btnAdministrador
            // 
            btnAdministrador.Location = new Point(14, 84);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(141, 30);
            btnAdministrador.TabIndex = 2;
            btnAdministrador.Text = "Acceso Administrativo";
            btnAdministrador.UseVisualStyleBackColor = true;
            btnAdministrador.Click += btnAdministrador_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(43, 120);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(83, 34);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // formInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(167, 160);
            Controls.Add(btnSalir);
            Controls.Add(btnAdministrador);
            Controls.Add(btnProfesor);
            Controls.Add(btnEstudiante);
            Name = "formInicio";
            Text = "Syscad";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEstudiante;
        private Button btnProfesor;
        private Button btnAdministrador;
        private Button btnSalir;
    }
}