namespace TPSysacad___Forms
{
    partial class formMenuAdministrador
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
            tabControl1 = new TabControl();
            tabEstudiantes = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblBuscarEstudiante = new Label();
            txbBuscarEstudiante = new TextBox();
            btnEditarEstudiante = new Button();
            btnEliminarEstudiante = new Button();
            lsbEstudiantes = new ListBox();
            btnAgregarEstudiante = new Button();
            btnGestionarCursosEstudiante = new Button();
            btnGestionarPagosEstudiante = new Button();
            tabProfesores = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            txbBuscarProfesor = new TextBox();
            btnAgregarProfesor = new Button();
            btnEditarProfesor = new Button();
            btnEliminarProfesor = new Button();
            lsbProfesores = new ListBox();
            tabAdministradores = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            txbBuscarAdministrador = new TextBox();
            btnAgregarAdministrador = new Button();
            btnEditarAdministrador = new Button();
            btnEliminarAdministrador = new Button();
            lsbAdministradores = new ListBox();
            tabMaterias = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            lblBuscarMateria = new Label();
            txbBuscarMateria = new TextBox();
            btnAgregarMateria = new Button();
            btnEditarMateria = new Button();
            btnEliminarMateria = new Button();
            lsbMaterias = new ListBox();
            btnGestionarMateriasRequeridas = new Button();
            tabCursos = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblBuscarCurso = new Label();
            txbBuscarCurso = new TextBox();
            btnAgregarCurso = new Button();
            btnEditarCurso = new Button();
            btnEliminarCurso = new Button();
            lsbCursos = new ListBox();
            btnGestionarHorariosCurso = new Button();
            btnGestionarInscriptosCurso = new Button();
            tabReportes = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            dpFechaFinal = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dpFechaInicial = new DateTimePicker();
            btnInformeInscripciones = new Button();
            btnInformePagos = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPage1 = new TabPage();
            tabControl1.SuspendLayout();
            tabEstudiantes.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabProfesores.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabAdministradores.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabMaterias.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tabCursos.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tabReportes.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabEstudiantes);
            tabControl1.Controls.Add(tabProfesores);
            tabControl1.Controls.Add(tabAdministradores);
            tabControl1.Controls.Add(tabMaterias);
            tabControl1.Controls.Add(tabCursos);
            tabControl1.Controls.Add(tabReportes);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(733, 591);
            tabControl1.TabIndex = 0;
            // 
            // tabEstudiantes
            // 
            tabEstudiantes.Controls.Add(tableLayoutPanel1);
            tabEstudiantes.Location = new Point(4, 24);
            tabEstudiantes.Name = "tabEstudiantes";
            tabEstudiantes.Padding = new Padding(3);
            tabEstudiantes.Size = new Size(725, 563);
            tabEstudiantes.TabIndex = 1;
            tabEstudiantes.Text = "Estudiantes";
            tabEstudiantes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(lblBuscarEstudiante, 0, 0);
            tableLayoutPanel1.Controls.Add(txbBuscarEstudiante, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEditarEstudiante, 2, 3);
            tableLayoutPanel1.Controls.Add(btnEliminarEstudiante, 2, 4);
            tableLayoutPanel1.Controls.Add(lsbEstudiantes, 0, 2);
            tableLayoutPanel1.Controls.Add(btnAgregarEstudiante, 2, 2);
            tableLayoutPanel1.Controls.Add(btnGestionarCursosEstudiante, 2, 7);
            tableLayoutPanel1.Controls.Add(btnGestionarPagosEstudiante, 2, 6);
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(713, 551);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBuscarEstudiante
            // 
            lblBuscarEstudiante.AutoSize = true;
            lblBuscarEstudiante.Location = new Point(3, 0);
            lblBuscarEstudiante.Name = "lblBuscarEstudiante";
            lblBuscarEstudiante.Size = new Size(103, 15);
            lblBuscarEstudiante.TabIndex = 0;
            lblBuscarEstudiante.Text = "Buscar Estudiante:";
            lblBuscarEstudiante.Visible = false;
            // 
            // txbBuscarEstudiante
            // 
            txbBuscarEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbBuscarEstudiante.Location = new Point(3, 28);
            txbBuscarEstudiante.Name = "txbBuscarEstudiante";
            txbBuscarEstudiante.Size = new Size(194, 23);
            txbBuscarEstudiante.TabIndex = 1;
            txbBuscarEstudiante.Visible = false;
            // 
            // btnEditarEstudiante
            // 
            btnEditarEstudiante.Anchor = AnchorStyles.None;
            btnEditarEstudiante.Location = new Point(546, 93);
            btnEditarEstudiante.Name = "btnEditarEstudiante";
            btnEditarEstudiante.Size = new Size(133, 34);
            btnEditarEstudiante.TabIndex = 3;
            btnEditarEstudiante.Text = "Editar Seleccionado";
            btnEditarEstudiante.UseVisualStyleBackColor = true;
            btnEditarEstudiante.Click += btnEditarEstudiante_Click;
            // 
            // btnEliminarEstudiante
            // 
            btnEliminarEstudiante.Anchor = AnchorStyles.None;
            btnEliminarEstudiante.Location = new Point(546, 133);
            btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            btnEliminarEstudiante.Size = new Size(133, 34);
            btnEliminarEstudiante.TabIndex = 4;
            btnEliminarEstudiante.Text = "Eliminar Seleccionado";
            btnEliminarEstudiante.UseVisualStyleBackColor = true;
            btnEliminarEstudiante.Click += btnEliminarEstudiante_Click;
            // 
            // lsbEstudiantes
            // 
            lsbEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(lsbEstudiantes, 2);
            lsbEstudiantes.FormattingEnabled = true;
            lsbEstudiantes.ItemHeight = 15;
            lsbEstudiantes.Location = new Point(3, 53);
            lsbEstudiantes.Name = "lsbEstudiantes";
            tableLayoutPanel1.SetRowSpan(lsbEstudiantes, 7);
            lsbEstudiantes.Size = new Size(507, 484);
            lsbEstudiantes.TabIndex = 5;
            lsbEstudiantes.SelectedValueChanged += lsbEstudiantes_SelectedValueChanged;
            // 
            // btnAgregarEstudiante
            // 
            btnAgregarEstudiante.Anchor = AnchorStyles.None;
            btnAgregarEstudiante.Location = new Point(546, 53);
            btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            btnAgregarEstudiante.Size = new Size(133, 34);
            btnAgregarEstudiante.TabIndex = 2;
            btnAgregarEstudiante.Text = "Agregar Estudiante";
            btnAgregarEstudiante.UseVisualStyleBackColor = true;
            btnAgregarEstudiante.Click += btnAgregarEstudiante_Click;
            // 
            // btnGestionarCursosEstudiante
            // 
            btnGestionarCursosEstudiante.Anchor = AnchorStyles.None;
            btnGestionarCursosEstudiante.Location = new Point(546, 253);
            btnGestionarCursosEstudiante.Name = "btnGestionarCursosEstudiante";
            btnGestionarCursosEstudiante.Size = new Size(133, 34);
            btnGestionarCursosEstudiante.TabIndex = 7;
            btnGestionarCursosEstudiante.Text = "Gestionar Cursos";
            btnGestionarCursosEstudiante.UseVisualStyleBackColor = true;
            btnGestionarCursosEstudiante.Click += btnGestionarCursosEstudiante_Click;
            // 
            // btnGestionarPagosEstudiante
            // 
            btnGestionarPagosEstudiante.Anchor = AnchorStyles.None;
            btnGestionarPagosEstudiante.Location = new Point(546, 213);
            btnGestionarPagosEstudiante.Name = "btnGestionarPagosEstudiante";
            btnGestionarPagosEstudiante.Size = new Size(133, 34);
            btnGestionarPagosEstudiante.TabIndex = 6;
            btnGestionarPagosEstudiante.Text = "Gestionar Pagos";
            btnGestionarPagosEstudiante.UseVisualStyleBackColor = true;
            btnGestionarPagosEstudiante.Click += btnGestionarPagosEstudiante_Click;
            // 
            // tabProfesores
            // 
            tabProfesores.Controls.Add(tableLayoutPanel3);
            tabProfesores.Location = new Point(4, 24);
            tabProfesores.Name = "tabProfesores";
            tabProfesores.Padding = new Padding(3);
            tabProfesores.Size = new Size(725, 563);
            tabProfesores.TabIndex = 2;
            tabProfesores.Text = "Profesores";
            tabProfesores.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(txbBuscarProfesor, 0, 1);
            tableLayoutPanel3.Controls.Add(btnAgregarProfesor, 2, 2);
            tableLayoutPanel3.Controls.Add(btnEditarProfesor, 2, 3);
            tableLayoutPanel3.Controls.Add(btnEliminarProfesor, 2, 4);
            tableLayoutPanel3.Controls.Add(lsbProfesores, 0, 2);
            tableLayoutPanel3.Location = new Point(6, 6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(713, 551);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Buscar Profesor:";
            label2.Visible = false;
            // 
            // txbBuscarProfesor
            // 
            txbBuscarProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbBuscarProfesor.Location = new Point(3, 28);
            txbBuscarProfesor.Name = "txbBuscarProfesor";
            txbBuscarProfesor.Size = new Size(194, 23);
            txbBuscarProfesor.TabIndex = 1;
            txbBuscarProfesor.Visible = false;
            // 
            // btnAgregarProfesor
            // 
            btnAgregarProfesor.Anchor = AnchorStyles.None;
            btnAgregarProfesor.Location = new Point(546, 53);
            btnAgregarProfesor.Name = "btnAgregarProfesor";
            btnAgregarProfesor.Size = new Size(133, 34);
            btnAgregarProfesor.TabIndex = 2;
            btnAgregarProfesor.Text = "Agregar Profesor";
            btnAgregarProfesor.UseVisualStyleBackColor = true;
            btnAgregarProfesor.Click += btnAgregarProfesor_Click;
            // 
            // btnEditarProfesor
            // 
            btnEditarProfesor.Anchor = AnchorStyles.None;
            btnEditarProfesor.Location = new Point(546, 93);
            btnEditarProfesor.Name = "btnEditarProfesor";
            btnEditarProfesor.Size = new Size(133, 34);
            btnEditarProfesor.TabIndex = 3;
            btnEditarProfesor.Text = "Editar Seleccionado";
            btnEditarProfesor.UseVisualStyleBackColor = true;
            btnEditarProfesor.Click += btnEditarProfesor_Click;
            // 
            // btnEliminarProfesor
            // 
            btnEliminarProfesor.Anchor = AnchorStyles.None;
            btnEliminarProfesor.Location = new Point(546, 133);
            btnEliminarProfesor.Name = "btnEliminarProfesor";
            btnEliminarProfesor.Size = new Size(133, 34);
            btnEliminarProfesor.TabIndex = 4;
            btnEliminarProfesor.Text = "Eliminar Seleccionado";
            btnEliminarProfesor.UseVisualStyleBackColor = true;
            btnEliminarProfesor.Click += btnEliminarProfesor_Click;
            // 
            // lsbProfesores
            // 
            lsbProfesores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.SetColumnSpan(lsbProfesores, 2);
            lsbProfesores.FormattingEnabled = true;
            lsbProfesores.ItemHeight = 15;
            lsbProfesores.Location = new Point(3, 53);
            lsbProfesores.Name = "lsbProfesores";
            tableLayoutPanel3.SetRowSpan(lsbProfesores, 6);
            lsbProfesores.Size = new Size(507, 484);
            lsbProfesores.TabIndex = 5;
            // 
            // tabAdministradores
            // 
            tabAdministradores.Controls.Add(tableLayoutPanel4);
            tabAdministradores.Location = new Point(4, 24);
            tabAdministradores.Name = "tabAdministradores";
            tabAdministradores.Size = new Size(725, 563);
            tabAdministradores.TabIndex = 3;
            tabAdministradores.Text = "Administradores";
            tabAdministradores.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(txbBuscarAdministrador, 0, 1);
            tableLayoutPanel4.Controls.Add(btnAgregarAdministrador, 2, 2);
            tableLayoutPanel4.Controls.Add(btnEditarAdministrador, 2, 3);
            tableLayoutPanel4.Controls.Add(btnEliminarAdministrador, 2, 4);
            tableLayoutPanel4.Controls.Add(lsbAdministradores, 0, 2);
            tableLayoutPanel4.Location = new Point(6, 6);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(713, 551);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 0;
            label3.Text = "Buscar Administrador:";
            label3.Visible = false;
            // 
            // txbBuscarAdministrador
            // 
            txbBuscarAdministrador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbBuscarAdministrador.Location = new Point(3, 28);
            txbBuscarAdministrador.Name = "txbBuscarAdministrador";
            txbBuscarAdministrador.Size = new Size(194, 23);
            txbBuscarAdministrador.TabIndex = 1;
            txbBuscarAdministrador.Visible = false;
            // 
            // btnAgregarAdministrador
            // 
            btnAgregarAdministrador.Anchor = AnchorStyles.None;
            btnAgregarAdministrador.Location = new Point(538, 53);
            btnAgregarAdministrador.Name = "btnAgregarAdministrador";
            btnAgregarAdministrador.Size = new Size(149, 34);
            btnAgregarAdministrador.TabIndex = 2;
            btnAgregarAdministrador.Text = "Agregar Administrador";
            btnAgregarAdministrador.UseVisualStyleBackColor = true;
            btnAgregarAdministrador.Click += btnAgregarAdministrador_Click;
            // 
            // btnEditarAdministrador
            // 
            btnEditarAdministrador.Anchor = AnchorStyles.None;
            btnEditarAdministrador.Location = new Point(538, 93);
            btnEditarAdministrador.Name = "btnEditarAdministrador";
            btnEditarAdministrador.Size = new Size(149, 34);
            btnEditarAdministrador.TabIndex = 3;
            btnEditarAdministrador.Text = "Editar Seleccionado";
            btnEditarAdministrador.UseVisualStyleBackColor = true;
            btnEditarAdministrador.Click += btnEditarAdministrador_Click;
            // 
            // btnEliminarAdministrador
            // 
            btnEliminarAdministrador.Anchor = AnchorStyles.None;
            btnEliminarAdministrador.Location = new Point(538, 133);
            btnEliminarAdministrador.Name = "btnEliminarAdministrador";
            btnEliminarAdministrador.Size = new Size(149, 34);
            btnEliminarAdministrador.TabIndex = 4;
            btnEliminarAdministrador.Text = "Eliminar Seleccionado";
            btnEliminarAdministrador.UseVisualStyleBackColor = true;
            btnEliminarAdministrador.Click += btnEliminarAdministrador_Click;
            // 
            // lsbAdministradores
            // 
            lsbAdministradores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.SetColumnSpan(lsbAdministradores, 2);
            lsbAdministradores.FormattingEnabled = true;
            lsbAdministradores.ItemHeight = 15;
            lsbAdministradores.Location = new Point(3, 53);
            lsbAdministradores.Name = "lsbAdministradores";
            tableLayoutPanel4.SetRowSpan(lsbAdministradores, 4);
            lsbAdministradores.Size = new Size(507, 484);
            lsbAdministradores.TabIndex = 5;
            // 
            // tabMaterias
            // 
            tabMaterias.Controls.Add(tableLayoutPanel5);
            tabMaterias.Location = new Point(4, 24);
            tabMaterias.Name = "tabMaterias";
            tabMaterias.Size = new Size(725, 563);
            tabMaterias.TabIndex = 4;
            tabMaterias.Text = "Materias";
            tabMaterias.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel5.Controls.Add(lblBuscarMateria, 0, 0);
            tableLayoutPanel5.Controls.Add(txbBuscarMateria, 0, 1);
            tableLayoutPanel5.Controls.Add(btnAgregarMateria, 2, 2);
            tableLayoutPanel5.Controls.Add(btnEditarMateria, 2, 3);
            tableLayoutPanel5.Controls.Add(btnEliminarMateria, 2, 4);
            tableLayoutPanel5.Controls.Add(lsbMaterias, 0, 2);
            tableLayoutPanel5.Controls.Add(btnGestionarMateriasRequeridas, 2, 6);
            tableLayoutPanel5.Location = new Point(6, 6);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 8;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(713, 551);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // lblBuscarMateria
            // 
            lblBuscarMateria.AutoSize = true;
            lblBuscarMateria.Location = new Point(3, 0);
            lblBuscarMateria.Name = "lblBuscarMateria";
            lblBuscarMateria.Size = new Size(88, 15);
            lblBuscarMateria.TabIndex = 0;
            lblBuscarMateria.Text = "Buscar Materia:";
            lblBuscarMateria.Visible = false;
            // 
            // txbBuscarMateria
            // 
            txbBuscarMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbBuscarMateria.Location = new Point(3, 28);
            txbBuscarMateria.Name = "txbBuscarMateria";
            txbBuscarMateria.Size = new Size(194, 23);
            txbBuscarMateria.TabIndex = 1;
            txbBuscarMateria.Visible = false;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Anchor = AnchorStyles.None;
            btnAgregarMateria.Location = new Point(546, 53);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(133, 34);
            btnAgregarMateria.TabIndex = 2;
            btnAgregarMateria.Text = "Agregar Materia";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // btnEditarMateria
            // 
            btnEditarMateria.Anchor = AnchorStyles.None;
            btnEditarMateria.Location = new Point(546, 93);
            btnEditarMateria.Name = "btnEditarMateria";
            btnEditarMateria.Size = new Size(133, 34);
            btnEditarMateria.TabIndex = 3;
            btnEditarMateria.Text = "Editar Seleccionada";
            btnEditarMateria.UseVisualStyleBackColor = true;
            btnEditarMateria.Click += btnEditarMateria_Click;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.Anchor = AnchorStyles.None;
            btnEliminarMateria.Location = new Point(546, 133);
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.Size = new Size(133, 34);
            btnEliminarMateria.TabIndex = 4;
            btnEliminarMateria.Text = "Eliminar Seleccionada";
            btnEliminarMateria.UseVisualStyleBackColor = true;
            btnEliminarMateria.Click += btnEliminarMateria_Click;
            // 
            // lsbMaterias
            // 
            lsbMaterias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.SetColumnSpan(lsbMaterias, 2);
            lsbMaterias.FormattingEnabled = true;
            lsbMaterias.ItemHeight = 15;
            lsbMaterias.Location = new Point(3, 53);
            lsbMaterias.Name = "lsbMaterias";
            tableLayoutPanel5.SetRowSpan(lsbMaterias, 6);
            lsbMaterias.Size = new Size(507, 484);
            lsbMaterias.TabIndex = 5;
            lsbMaterias.SelectedIndexChanged += lsbMaterias_SelectedIndexChanged;
            // 
            // btnGestionarMateriasRequeridas
            // 
            btnGestionarMateriasRequeridas.Anchor = AnchorStyles.None;
            btnGestionarMateriasRequeridas.Location = new Point(521, 213);
            btnGestionarMateriasRequeridas.Name = "btnGestionarMateriasRequeridas";
            btnGestionarMateriasRequeridas.Size = new Size(184, 34);
            btnGestionarMateriasRequeridas.TabIndex = 6;
            btnGestionarMateriasRequeridas.Text = "Gestionar Materias Requeridas";
            btnGestionarMateriasRequeridas.UseVisualStyleBackColor = true;
            btnGestionarMateriasRequeridas.Click += btnGestionarMateriasRequeridas_Click;
            // 
            // tabCursos
            // 
            tabCursos.Controls.Add(tableLayoutPanel6);
            tabCursos.Location = new Point(4, 24);
            tabCursos.Name = "tabCursos";
            tabCursos.Size = new Size(725, 563);
            tabCursos.TabIndex = 5;
            tabCursos.Text = "Cursos";
            tabCursos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel6.Controls.Add(lblBuscarCurso, 0, 0);
            tableLayoutPanel6.Controls.Add(txbBuscarCurso, 0, 1);
            tableLayoutPanel6.Controls.Add(btnAgregarCurso, 2, 2);
            tableLayoutPanel6.Controls.Add(btnEditarCurso, 2, 3);
            tableLayoutPanel6.Controls.Add(btnEliminarCurso, 2, 4);
            tableLayoutPanel6.Controls.Add(lsbCursos, 0, 2);
            tableLayoutPanel6.Controls.Add(btnGestionarHorariosCurso, 2, 6);
            tableLayoutPanel6.Controls.Add(btnGestionarInscriptosCurso, 2, 7);
            tableLayoutPanel6.Location = new Point(6, 6);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 10;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(713, 551);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // lblBuscarCurso
            // 
            lblBuscarCurso.AutoSize = true;
            lblBuscarCurso.Location = new Point(3, 0);
            lblBuscarCurso.Name = "lblBuscarCurso";
            lblBuscarCurso.Size = new Size(79, 15);
            lblBuscarCurso.TabIndex = 0;
            lblBuscarCurso.Text = "Buscar Curso:";
            lblBuscarCurso.Visible = false;
            // 
            // txbBuscarCurso
            // 
            txbBuscarCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbBuscarCurso.Location = new Point(3, 28);
            txbBuscarCurso.Name = "txbBuscarCurso";
            txbBuscarCurso.Size = new Size(194, 23);
            txbBuscarCurso.TabIndex = 1;
            txbBuscarCurso.Visible = false;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Anchor = AnchorStyles.None;
            btnAgregarCurso.Location = new Point(546, 53);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(133, 34);
            btnAgregarCurso.TabIndex = 2;
            btnAgregarCurso.Text = "Agregar Curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
            // 
            // btnEditarCurso
            // 
            btnEditarCurso.Anchor = AnchorStyles.None;
            btnEditarCurso.Location = new Point(546, 93);
            btnEditarCurso.Name = "btnEditarCurso";
            btnEditarCurso.Size = new Size(133, 34);
            btnEditarCurso.TabIndex = 3;
            btnEditarCurso.Text = "Editar Seleccionado";
            btnEditarCurso.UseVisualStyleBackColor = true;
            btnEditarCurso.Click += btnEditarCurso_Click;
            // 
            // btnEliminarCurso
            // 
            btnEliminarCurso.Anchor = AnchorStyles.None;
            btnEliminarCurso.Location = new Point(546, 133);
            btnEliminarCurso.Name = "btnEliminarCurso";
            btnEliminarCurso.Size = new Size(133, 34);
            btnEliminarCurso.TabIndex = 4;
            btnEliminarCurso.Text = "Eliminar Seleccionado";
            btnEliminarCurso.UseVisualStyleBackColor = true;
            btnEliminarCurso.Click += btnEliminarCurso_Click;
            // 
            // lsbCursos
            // 
            lsbCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.SetColumnSpan(lsbCursos, 2);
            lsbCursos.FormattingEnabled = true;
            lsbCursos.ItemHeight = 15;
            lsbCursos.Location = new Point(3, 53);
            lsbCursos.Name = "lsbCursos";
            tableLayoutPanel6.SetRowSpan(lsbCursos, 8);
            lsbCursos.Size = new Size(507, 484);
            lsbCursos.TabIndex = 5;
            lsbCursos.SelectedIndexChanged += lsbCursos_SelectedIndexChanged;
            // 
            // btnGestionarHorariosCurso
            // 
            btnGestionarHorariosCurso.Anchor = AnchorStyles.None;
            btnGestionarHorariosCurso.Location = new Point(529, 213);
            btnGestionarHorariosCurso.Name = "btnGestionarHorariosCurso";
            btnGestionarHorariosCurso.Size = new Size(167, 34);
            btnGestionarHorariosCurso.TabIndex = 6;
            btnGestionarHorariosCurso.Text = "Gestionar Horarios";
            btnGestionarHorariosCurso.UseVisualStyleBackColor = true;
            btnGestionarHorariosCurso.Click += btnGestionarHorariosCurso_Click;
            // 
            // btnGestionarInscriptosCurso
            // 
            btnGestionarInscriptosCurso.Anchor = AnchorStyles.None;
            btnGestionarInscriptosCurso.Location = new Point(529, 253);
            btnGestionarInscriptosCurso.Name = "btnGestionarInscriptosCurso";
            btnGestionarInscriptosCurso.Size = new Size(167, 34);
            btnGestionarInscriptosCurso.TabIndex = 7;
            btnGestionarInscriptosCurso.Text = "Gestionar Inscripciones";
            btnGestionarInscriptosCurso.UseVisualStyleBackColor = true;
            btnGestionarInscriptosCurso.Click += btnGestionarInscriptosCurso_Click;
            // 
            // tabReportes
            // 
            tabReportes.Controls.Add(tableLayoutPanel7);
            tabReportes.Location = new Point(4, 24);
            tabReportes.Name = "tabReportes";
            tabReportes.Size = new Size(725, 563);
            tabReportes.TabIndex = 6;
            tabReportes.Text = "Reportes";
            tabReportes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(dpFechaFinal, 1, 1);
            tableLayoutPanel7.Controls.Add(label4, 0, 0);
            tableLayoutPanel7.Controls.Add(label5, 0, 1);
            tableLayoutPanel7.Controls.Add(dpFechaInicial, 1, 0);
            tableLayoutPanel7.Controls.Add(btnInformeInscripciones, 0, 3);
            tableLayoutPanel7.Controls.Add(btnInformePagos, 1, 3);
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 5;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.Size = new Size(719, 557);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // dpFechaFinal
            // 
            dpFechaFinal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dpFechaFinal.Format = DateTimePickerFormat.Short;
            dpFechaFinal.Location = new Point(362, 63);
            dpFechaFinal.Name = "dpFechaFinal";
            dpFechaFinal.Size = new Size(354, 23);
            dpFechaFinal.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(353, 15);
            label4.TabIndex = 0;
            label4.Text = "Fecha Inicial";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 67);
            label5.Name = "label5";
            label5.Size = new Size(353, 15);
            label5.TabIndex = 1;
            label5.Text = "Fecha final";
            // 
            // dpFechaInicial
            // 
            dpFechaInicial.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dpFechaInicial.Format = DateTimePickerFormat.Short;
            dpFechaInicial.Location = new Point(362, 13);
            dpFechaInicial.Name = "dpFechaInicial";
            dpFechaInicial.Size = new Size(354, 23);
            dpFechaInicial.TabIndex = 2;
            // 
            // btnInformeInscripciones
            // 
            btnInformeInscripciones.Anchor = AnchorStyles.None;
            btnInformeInscripciones.Location = new Point(101, 199);
            btnInformeInscripciones.Name = "btnInformeInscripciones";
            btnInformeInscripciones.Size = new Size(156, 42);
            btnInformeInscripciones.TabIndex = 4;
            btnInformeInscripciones.Text = "Reporte de Inscripciones";
            btnInformeInscripciones.UseVisualStyleBackColor = true;
            btnInformeInscripciones.Click += btnInformeInscripciones_Click;
            // 
            // btnInformePagos
            // 
            btnInformePagos.Anchor = AnchorStyles.None;
            btnInformePagos.Location = new Point(461, 199);
            btnInformePagos.Name = "btnInformePagos";
            btnInformePagos.Size = new Size(156, 42);
            btnInformePagos.TabIndex = 5;
            btnInformePagos.Text = "Reporte de Pagos";
            btnInformePagos.UseVisualStyleBackColor = true;
            btnInformePagos.Click += btnInformePagos_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar Estudiante:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 100);
            tabPage1.TabIndex = 0;
            // 
            // formMenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 615);
            Controls.Add(tabControl1);
            Name = "formMenuAdministrador";
            Text = "formMenuAdministrador";
            FormClosed += formMenuAdministrador_FormClosed;
            Load += formMenuAdministrador_Load;
            tabControl1.ResumeLayout(false);
            tabEstudiantes.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabProfesores.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tabAdministradores.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tabMaterias.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tabCursos.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tabReportes.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabEstudiantes;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabProfesores;
        private TabPage tabAdministradores;
        private TabPage tabMaterias;
        private TabPage tabCursos;
        private Label lblBuscarEstudiante;
        private TextBox txbBuscarEstudiante;
        private Button btnAgregarEstudiante;
        private Button btnEditarEstudiante;
        private Button btnEliminarEstudiante;
        private ListBox lsbEstudiantes;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox txbBuscarProfesor;
        private Button btnAgregarProfesor;
        private Button btnEditarProfesor;
        private Button btnEliminarProfesor;
        private ListBox lsbProfesores;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private TextBox txbBuscarAdministrador;
        private Button btnAgregarAdministrador;
        private Button btnEditarAdministrador;
        private Button btnEliminarAdministrador;
        private ListBox lsbAdministradores;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblBuscarMateria;
        private TextBox txbBuscarMateria;
        private Button btnAgregarMateria;
        private Button btnEditarMateria;
        private Button btnEliminarMateria;
        private ListBox lsbMaterias;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblBuscarCurso;
        private TextBox txbBuscarCurso;
        private Button btnAgregarCurso;
        private Button btnEditarCurso;
        private Button btnEliminarCurso;
        private ListBox lsbCursos;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox textBox1;
        private TabPage tabPage1;
        private Button btnGestionarCursosEstudiante;
        private Button btnGestionarPagosEstudiante;
        private Button btnGestionarMateriasRequeridas;
        private Button btnGestionarHorariosCurso;
        private Button btnGestionarInscriptosCurso;
        private TabPage tabReportes;
        private TableLayoutPanel tableLayoutPanel7;
        private DateTimePicker dpFechaFinal;
        private Label label4;
        private Label label5;
        private DateTimePicker dpFechaInicial;
        private Button btnInformeInscripciones;
        private Button btnInformePagos;
    }
}