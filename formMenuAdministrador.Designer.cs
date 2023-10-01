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
            btnAgregarEstudiante = new Button();
            btnEditarEstudiante = new Button();
            btnEliminarEstudiante = new Button();
            lsbEstudiantes = new ListBox();
            tabProfesores = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            tabAdministradores = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            listBox2 = new ListBox();
            tabMaterias = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            textBox4 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            listBox3 = new ListBox();
            tabCursos = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            label5 = new Label();
            textBox5 = new TextBox();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            listBox4 = new ListBox();
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
            tableLayoutPanel1.Controls.Add(btnAgregarEstudiante, 2, 2);
            tableLayoutPanel1.Controls.Add(btnEditarEstudiante, 2, 3);
            tableLayoutPanel1.Controls.Add(btnEliminarEstudiante, 2, 4);
            tableLayoutPanel1.Controls.Add(lsbEstudiantes, 0, 2);
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
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
            // 
            // txbBuscarEstudiante
            // 
            txbBuscarEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbBuscarEstudiante.Location = new Point(3, 28);
            txbBuscarEstudiante.Name = "txbBuscarEstudiante";
            txbBuscarEstudiante.Size = new Size(194, 23);
            txbBuscarEstudiante.TabIndex = 1;
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
            // 
            // lsbEstudiantes
            // 
            lsbEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(lsbEstudiantes, 2);
            lsbEstudiantes.FormattingEnabled = true;
            lsbEstudiantes.ItemHeight = 15;
            lsbEstudiantes.Location = new Point(3, 53);
            lsbEstudiantes.Name = "lsbEstudiantes";
            tableLayoutPanel1.SetRowSpan(lsbEstudiantes, 4);
            lsbEstudiantes.Size = new Size(507, 484);
            lsbEstudiantes.TabIndex = 5;
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
            tableLayoutPanel3.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel3.Controls.Add(button1, 2, 2);
            tableLayoutPanel3.Controls.Add(button2, 2, 3);
            tableLayoutPanel3.Controls.Add(button3, 2, 4);
            tableLayoutPanel3.Controls.Add(listBox1, 0, 2);
            tableLayoutPanel3.Location = new Point(6, 6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
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
            label2.Size = new Size(103, 15);
            label2.TabIndex = 0;
            label2.Text = "Buscar Estudiante:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(3, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(546, 53);
            button1.Name = "button1";
            button1.Size = new Size(133, 34);
            button1.TabIndex = 2;
            button1.Text = "Agregar Estudiante";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(546, 93);
            button2.Name = "button2";
            button2.Size = new Size(133, 34);
            button2.TabIndex = 3;
            button2.Text = "Editar Seleccionado";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(546, 133);
            button3.Name = "button3";
            button3.Size = new Size(133, 34);
            button3.TabIndex = 4;
            button3.Text = "Eliminar Seleccionado";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.SetColumnSpan(listBox1, 2);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 53);
            listBox1.Name = "listBox1";
            tableLayoutPanel3.SetRowSpan(listBox1, 4);
            listBox1.Size = new Size(507, 484);
            listBox1.TabIndex = 5;
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
            tableLayoutPanel4.Controls.Add(textBox3, 0, 1);
            tableLayoutPanel4.Controls.Add(button4, 2, 2);
            tableLayoutPanel4.Controls.Add(button5, 2, 3);
            tableLayoutPanel4.Controls.Add(button6, 2, 4);
            tableLayoutPanel4.Controls.Add(listBox2, 0, 2);
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
            label3.Size = new Size(103, 15);
            label3.TabIndex = 0;
            label3.Text = "Buscar Estudiante:";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(3, 28);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 23);
            textBox3.TabIndex = 1;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(546, 53);
            button4.Name = "button4";
            button4.Size = new Size(133, 34);
            button4.TabIndex = 2;
            button4.Text = "Agregar Estudiante";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(546, 93);
            button5.Name = "button5";
            button5.Size = new Size(133, 34);
            button5.TabIndex = 3;
            button5.Text = "Editar Seleccionado";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Location = new Point(546, 133);
            button6.Name = "button6";
            button6.Size = new Size(133, 34);
            button6.TabIndex = 4;
            button6.Text = "Eliminar Seleccionado";
            button6.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.SetColumnSpan(listBox2, 2);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(3, 53);
            listBox2.Name = "listBox2";
            tableLayoutPanel4.SetRowSpan(listBox2, 4);
            listBox2.Size = new Size(507, 484);
            listBox2.TabIndex = 5;
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
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox4, 0, 1);
            tableLayoutPanel5.Controls.Add(button7, 2, 2);
            tableLayoutPanel5.Controls.Add(button8, 2, 3);
            tableLayoutPanel5.Controls.Add(button9, 2, 4);
            tableLayoutPanel5.Controls.Add(listBox3, 0, 2);
            tableLayoutPanel5.Location = new Point(6, 6);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(713, 551);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 0;
            label4.Text = "Buscar Estudiante:";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(3, 28);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(194, 23);
            textBox4.TabIndex = 1;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.Location = new Point(546, 53);
            button7.Name = "button7";
            button7.Size = new Size(133, 34);
            button7.TabIndex = 2;
            button7.Text = "Agregar Estudiante";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.Location = new Point(546, 93);
            button8.Name = "button8";
            button8.Size = new Size(133, 34);
            button8.TabIndex = 3;
            button8.Text = "Editar Seleccionado";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.Location = new Point(546, 133);
            button9.Name = "button9";
            button9.Size = new Size(133, 34);
            button9.TabIndex = 4;
            button9.Text = "Eliminar Seleccionado";
            button9.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.SetColumnSpan(listBox3, 2);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(3, 53);
            listBox3.Name = "listBox3";
            tableLayoutPanel5.SetRowSpan(listBox3, 4);
            listBox3.Size = new Size(507, 484);
            listBox3.TabIndex = 5;
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
            tableLayoutPanel6.Controls.Add(label5, 0, 0);
            tableLayoutPanel6.Controls.Add(textBox5, 0, 1);
            tableLayoutPanel6.Controls.Add(button10, 2, 2);
            tableLayoutPanel6.Controls.Add(button11, 2, 3);
            tableLayoutPanel6.Controls.Add(button12, 2, 4);
            tableLayoutPanel6.Controls.Add(listBox4, 0, 2);
            tableLayoutPanel6.Location = new Point(6, 6);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 6;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.Size = new Size(713, 551);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 0;
            label5.Text = "Buscar Estudiante:";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(3, 28);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(194, 23);
            textBox5.TabIndex = 1;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.None;
            button10.Location = new Point(546, 53);
            button10.Name = "button10";
            button10.Size = new Size(133, 34);
            button10.TabIndex = 2;
            button10.Text = "Agregar Estudiante";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.None;
            button11.Location = new Point(546, 93);
            button11.Name = "button11";
            button11.Size = new Size(133, 34);
            button11.TabIndex = 3;
            button11.Text = "Editar Seleccionado";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.None;
            button12.Location = new Point(546, 133);
            button12.Name = "button12";
            button12.Size = new Size(133, 34);
            button12.TabIndex = 4;
            button12.Text = "Eliminar Seleccionado";
            button12.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            listBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.SetColumnSpan(listBox4, 2);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(3, 53);
            listBox4.Name = "listBox4";
            tableLayoutPanel6.SetRowSpan(listBox4, 4);
            listBox4.Size = new Size(507, 484);
            listBox4.TabIndex = 5;
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
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private TextBox textBox3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ListBox listBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private TextBox textBox4;
        private Button button7;
        private Button button8;
        private Button button9;
        private ListBox listBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label5;
        private TextBox textBox5;
        private Button button10;
        private Button button11;
        private Button button12;
        private ListBox listBox4;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox textBox1;
        private TabPage tabPage1;
    }
}