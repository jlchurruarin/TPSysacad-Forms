namespace TPSysacad___Forms
{
    partial class formABMCurso
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
            tlpEstudiante = new TableLayoutPanel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            tabCurso = new TabControl();
            tabDetalle = new TabPage();
            tlpDetalle = new TableLayoutPanel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            lblDenominacion = new Label();
            txbNombre = new TextBox();
            lblMateria = new Label();
            lblProfesor = new Label();
            lblAula = new Label();
            lblCupoMaximo = new Label();
            comboBox1 = new ComboBox();
            tabHorarios = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            lsbHorarios = new ListBox();
            btnAgregarHorario = new Button();
            btnEliminarHorario = new Button();
            tabEstudiantesInscriptos = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAgregarEstudianteInscripto = new Button();
            lsbEstudiantesInscriptos = new ListBox();
            btnEliminarEstudianteInscripto = new Button();
            tabEstudiantesEnEspera = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAgregarEstudianteEspera = new Button();
            lsbEstudiantesEnEspera = new ListBox();
            btnEliminarEstudianteEspera = new Button();
            tlpCursosInscriptos = new TableLayoutPanel();
            lsbCursosInscriptos = new ListBox();
            btnAgregarCurso = new Button();
            tabCursosInscriptos = new TabPage();
            tlpEstudiante.SuspendLayout();
            tabCurso.SuspendLayout();
            tabDetalle.SuspendLayout();
            tlpDetalle.SuspendLayout();
            tabHorarios.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabEstudiantesInscriptos.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabEstudiantesEnEspera.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tlpCursosInscriptos.SuspendLayout();
            SuspendLayout();
            // 
            // tlpEstudiante
            // 
            tlpEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpEstudiante.ColumnCount = 2;
            tlpEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpEstudiante.Controls.Add(btnCancelar, 1, 1);
            tlpEstudiante.Controls.Add(btnGuardar, 1, 0);
            tlpEstudiante.Controls.Add(tabCurso, 0, 0);
            tlpEstudiante.Location = new Point(12, 12);
            tlpEstudiante.Name = "tlpEstudiante";
            tlpEstudiante.RowCount = 3;
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstudiante.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEstudiante.Size = new Size(603, 361);
            tlpEstudiante.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(490, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(490, 38);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tabCurso
            // 
            tabCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabCurso.Controls.Add(tabDetalle);
            tabCurso.Controls.Add(tabHorarios);
            tabCurso.Controls.Add(tabEstudiantesInscriptos);
            tabCurso.Controls.Add(tabEstudiantesEnEspera);
            tabCurso.Location = new Point(3, 3);
            tabCurso.MinimumSize = new Size(447, 355);
            tabCurso.Name = "tabCurso";
            tlpEstudiante.SetRowSpan(tabCurso, 3);
            tabCurso.SelectedIndex = 0;
            tabCurso.Size = new Size(447, 355);
            tabCurso.TabIndex = 3;
            // 
            // tabDetalle
            // 
            tabDetalle.Controls.Add(tlpDetalle);
            tabDetalle.Location = new Point(4, 24);
            tabDetalle.Name = "tabDetalle";
            tabDetalle.Padding = new Padding(3);
            tabDetalle.Size = new Size(439, 327);
            tabDetalle.TabIndex = 0;
            tabDetalle.Text = "Detalle";
            tabDetalle.UseVisualStyleBackColor = true;
            // 
            // tlpDetalle
            // 
            tlpDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpDetalle.ColumnCount = 2;
            tlpDetalle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tlpDetalle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetalle.Controls.Add(textBox2, 1, 4);
            tlpDetalle.Controls.Add(textBox1, 1, 3);
            tlpDetalle.Controls.Add(comboBox2, 1, 2);
            tlpDetalle.Controls.Add(lblDenominacion, 0, 1);
            tlpDetalle.Controls.Add(txbNombre, 1, 1);
            tlpDetalle.Controls.Add(lblMateria, 0, 0);
            tlpDetalle.Controls.Add(lblProfesor, 0, 2);
            tlpDetalle.Controls.Add(lblAula, 0, 3);
            tlpDetalle.Controls.Add(lblCupoMaximo, 0, 4);
            tlpDetalle.Controls.Add(comboBox1, 1, 0);
            tlpDetalle.Location = new Point(0, 0);
            tlpDetalle.Name = "tlpDetalle";
            tlpDetalle.RowCount = 6;
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDetalle.Size = new Size(439, 327);
            tlpDetalle.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(153, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(153, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 23);
            textBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(153, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(283, 23);
            comboBox2.TabIndex = 9;
            // 
            // lblDenominacion
            // 
            lblDenominacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDenominacion.AutoSize = true;
            lblDenominacion.Location = new Point(3, 40);
            lblDenominacion.Name = "lblDenominacion";
            lblDenominacion.Size = new Size(144, 40);
            lblDenominacion.TabIndex = 1;
            lblDenominacion.Text = "Denominación:";
            lblDenominacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbNombre
            // 
            txbNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNombre.Location = new Point(153, 43);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(283, 23);
            txbNombre.TabIndex = 3;
            // 
            // lblMateria
            // 
            lblMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(3, 0);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(144, 40);
            lblMateria.TabIndex = 4;
            lblMateria.Text = "Materia:";
            lblMateria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProfesor
            // 
            lblProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(3, 80);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(144, 40);
            lblProfesor.TabIndex = 5;
            lblProfesor.Text = "Profesor:";
            lblProfesor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAula
            // 
            lblAula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAula.AutoSize = true;
            lblAula.Location = new Point(3, 120);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(144, 40);
            lblAula.TabIndex = 6;
            lblAula.Text = "Aula:";
            lblAula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCupoMaximo
            // 
            lblCupoMaximo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCupoMaximo.AutoSize = true;
            lblCupoMaximo.Location = new Point(3, 160);
            lblCupoMaximo.Name = "lblCupoMaximo";
            lblCupoMaximo.Size = new Size(144, 40);
            lblCupoMaximo.TabIndex = 7;
            lblCupoMaximo.Text = "Cupo Máximo:";
            lblCupoMaximo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(153, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 23);
            comboBox1.TabIndex = 8;
            // 
            // tabHorarios
            // 
            tabHorarios.Controls.Add(tableLayoutPanel1);
            tabHorarios.Location = new Point(4, 24);
            tabHorarios.Name = "tabHorarios";
            tabHorarios.Padding = new Padding(3);
            tabHorarios.Size = new Size(439, 327);
            tabHorarios.TabIndex = 1;
            tabHorarios.Text = "Horarios";
            tabHorarios.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(lsbHorarios, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarHorario, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEliminarHorario, 2, 1);
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(427, 315);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lsbHorarios
            // 
            lsbHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(lsbHorarios, 3);
            lsbHorarios.FormattingEnabled = true;
            lsbHorarios.ItemHeight = 15;
            lsbHorarios.Location = new Point(3, 3);
            lsbHorarios.Name = "lsbHorarios";
            lsbHorarios.Size = new Size(421, 274);
            lsbHorarios.TabIndex = 0;
            // 
            // btnAgregarHorario
            // 
            btnAgregarHorario.Anchor = AnchorStyles.None;
            btnAgregarHorario.Location = new Point(12, 288);
            btnAgregarHorario.Name = "btnAgregarHorario";
            btnAgregarHorario.Size = new Size(117, 23);
            btnAgregarHorario.TabIndex = 3;
            btnAgregarHorario.Text = "Agregar Horario";
            btnAgregarHorario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarHorario
            // 
            btnEliminarHorario.Anchor = AnchorStyles.None;
            btnEliminarHorario.Location = new Point(297, 288);
            btnEliminarHorario.Name = "btnEliminarHorario";
            btnEliminarHorario.Size = new Size(117, 23);
            btnEliminarHorario.TabIndex = 4;
            btnEliminarHorario.Text = "Eliminar Horario";
            btnEliminarHorario.UseVisualStyleBackColor = true;
            // 
            // tabEstudiantesInscriptos
            // 
            tabEstudiantesInscriptos.Controls.Add(tableLayoutPanel2);
            tabEstudiantesInscriptos.Location = new Point(4, 24);
            tabEstudiantesInscriptos.Name = "tabEstudiantesInscriptos";
            tabEstudiantesInscriptos.Size = new Size(439, 327);
            tabEstudiantesInscriptos.TabIndex = 2;
            tabEstudiantesInscriptos.Text = "Estudiantes Inscriptos";
            tabEstudiantesInscriptos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(btnAgregarEstudianteInscripto, 0, 1);
            tableLayoutPanel2.Controls.Add(lsbEstudiantesInscriptos, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEliminarEstudianteInscripto, 2, 1);
            tableLayoutPanel2.Location = new Point(6, 6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(427, 315);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnAgregarEstudianteInscripto
            // 
            btnAgregarEstudianteInscripto.Anchor = AnchorStyles.None;
            btnAgregarEstudianteInscripto.Location = new Point(12, 288);
            btnAgregarEstudianteInscripto.Name = "btnAgregarEstudianteInscripto";
            btnAgregarEstudianteInscripto.Size = new Size(117, 23);
            btnAgregarEstudianteInscripto.TabIndex = 3;
            btnAgregarEstudianteInscripto.Text = "Agregar Estudiante";
            btnAgregarEstudianteInscripto.UseVisualStyleBackColor = true;
            // 
            // lsbEstudiantesInscriptos
            // 
            lsbEstudiantesInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(lsbEstudiantesInscriptos, 3);
            lsbEstudiantesInscriptos.FormattingEnabled = true;
            lsbEstudiantesInscriptos.ItemHeight = 15;
            lsbEstudiantesInscriptos.Location = new Point(3, 3);
            lsbEstudiantesInscriptos.Name = "lsbEstudiantesInscriptos";
            lsbEstudiantesInscriptos.Size = new Size(421, 274);
            lsbEstudiantesInscriptos.TabIndex = 0;
            // 
            // btnEliminarEstudianteInscripto
            // 
            btnEliminarEstudianteInscripto.Anchor = AnchorStyles.None;
            btnEliminarEstudianteInscripto.Location = new Point(297, 288);
            btnEliminarEstudianteInscripto.Name = "btnEliminarEstudianteInscripto";
            btnEliminarEstudianteInscripto.Size = new Size(117, 23);
            btnEliminarEstudianteInscripto.TabIndex = 4;
            btnEliminarEstudianteInscripto.Text = "Eliminar Estudiante";
            btnEliminarEstudianteInscripto.UseVisualStyleBackColor = true;
            // 
            // tabEstudiantesEnEspera
            // 
            tabEstudiantesEnEspera.Controls.Add(tableLayoutPanel3);
            tabEstudiantesEnEspera.Location = new Point(4, 24);
            tabEstudiantesEnEspera.Name = "tabEstudiantesEnEspera";
            tabEstudiantesEnEspera.Size = new Size(439, 327);
            tabEstudiantesEnEspera.TabIndex = 3;
            tabEstudiantesEnEspera.Text = "Estudiantes En Espera";
            tabEstudiantesEnEspera.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Controls.Add(btnAgregarEstudianteEspera, 0, 1);
            tableLayoutPanel3.Controls.Add(lsbEstudiantesEnEspera, 0, 0);
            tableLayoutPanel3.Controls.Add(btnEliminarEstudianteEspera, 2, 1);
            tableLayoutPanel3.Location = new Point(6, 6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.Size = new Size(427, 315);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnAgregarEstudianteEspera
            // 
            btnAgregarEstudianteEspera.Anchor = AnchorStyles.None;
            btnAgregarEstudianteEspera.Location = new Point(12, 288);
            btnAgregarEstudianteEspera.Name = "btnAgregarEstudianteEspera";
            btnAgregarEstudianteEspera.Size = new Size(117, 23);
            btnAgregarEstudianteEspera.TabIndex = 5;
            btnAgregarEstudianteEspera.Text = "Agregar Estudiante";
            btnAgregarEstudianteEspera.UseVisualStyleBackColor = true;
            // 
            // lsbEstudiantesEnEspera
            // 
            lsbEstudiantesEnEspera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.SetColumnSpan(lsbEstudiantesEnEspera, 3);
            lsbEstudiantesEnEspera.FormattingEnabled = true;
            lsbEstudiantesEnEspera.ItemHeight = 15;
            lsbEstudiantesEnEspera.Location = new Point(3, 3);
            lsbEstudiantesEnEspera.Name = "lsbEstudiantesEnEspera";
            lsbEstudiantesEnEspera.Size = new Size(421, 274);
            lsbEstudiantesEnEspera.TabIndex = 0;
            // 
            // btnEliminarEstudianteEspera
            // 
            btnEliminarEstudianteEspera.Anchor = AnchorStyles.None;
            btnEliminarEstudianteEspera.Location = new Point(297, 288);
            btnEliminarEstudianteEspera.Name = "btnEliminarEstudianteEspera";
            btnEliminarEstudianteEspera.Size = new Size(117, 23);
            btnEliminarEstudianteEspera.TabIndex = 6;
            btnEliminarEstudianteEspera.Text = "Eliminar Estudiante";
            btnEliminarEstudianteEspera.UseVisualStyleBackColor = true;
            // 
            // tlpCursosInscriptos
            // 
            tlpCursosInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCursosInscriptos.ColumnCount = 3;
            tlpCursosInscriptos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCursosInscriptos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpCursosInscriptos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpCursosInscriptos.Controls.Add(lsbCursosInscriptos, 0, 0);
            tlpCursosInscriptos.Location = new Point(0, 0);
            tlpCursosInscriptos.Name = "tlpCursosInscriptos";
            tlpCursosInscriptos.RowCount = 1;
            tlpCursosInscriptos.Size = new Size(200, 100);
            tlpCursosInscriptos.TabIndex = 0;
            // 
            // lsbCursosInscriptos
            // 
            lsbCursosInscriptos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpCursosInscriptos.SetColumnSpan(lsbCursosInscriptos, 3);
            lsbCursosInscriptos.FormattingEnabled = true;
            lsbCursosInscriptos.ItemHeight = 15;
            lsbCursosInscriptos.Location = new Point(3, 3);
            lsbCursosInscriptos.Name = "lsbCursosInscriptos";
            lsbCursosInscriptos.Size = new Size(194, 364);
            lsbCursosInscriptos.TabIndex = 0;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Anchor = AnchorStyles.None;
            btnAgregarCurso.Location = new Point(3, 373);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(60, 23);
            btnAgregarCurso.TabIndex = 3;
            btnAgregarCurso.Text = "Agregar Curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            // 
            // tabCursosInscriptos
            // 
            tabCursosInscriptos.Location = new Point(0, 0);
            tabCursosInscriptos.Name = "tabCursosInscriptos";
            tabCursosInscriptos.Size = new Size(200, 100);
            tabCursosInscriptos.TabIndex = 0;
            // 
            // formABMCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 385);
            Controls.Add(tlpEstudiante);
            Name = "formABMCurso";
            Text = "formABMCurso";
            Load += formABMCurso_Load;
            tlpEstudiante.ResumeLayout(false);
            tabCurso.ResumeLayout(false);
            tabDetalle.ResumeLayout(false);
            tlpDetalle.ResumeLayout(false);
            tlpDetalle.PerformLayout();
            tabHorarios.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabEstudiantesInscriptos.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tabEstudiantesEnEspera.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tlpCursosInscriptos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpEstudiante;
        private Button btnCancelar;
        private Button btnGuardar;
        private TabControl tabCurso;
        private TabPage tabDetalle;
        private TableLayoutPanel tlpDetalle;
        private TabPage tabHorarios;
        private Label lblDenominacion;
        private TextBox txbNombre;
        private Label lblMateria;
        private Label lblProfesor;
        private Label lblAula;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label lblCupoMaximo;
        private TableLayoutPanel tlpCursosInscriptos;
        private ListBox lsbCursosInscriptos;
        private Button btnAgregarCurso;
        private TabPage tabCursosInscriptos;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lsbHorarios;
        private Button btnAgregarHorario;
        private TabPage tabEstudiantesInscriptos;
        private TableLayoutPanel tableLayoutPanel2;
        private ListBox lsbEstudiantesInscriptos;
        private Button btnAgregarEstudianteInscripto;
        private TabPage tabEstudiantesEnEspera;
        private TableLayoutPanel tableLayoutPanel3;
        private ListBox lsbEstudiantesEnEspera;
        private Button btnEliminarHorario;
        private Button btnEliminarEstudianteInscripto;
        private Button btnAgregarEstudianteEspera;
        private Button btnEliminarEstudianteEspera;
    }
}