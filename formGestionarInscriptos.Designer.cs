namespace TPSysacad___Forms
{
    partial class formGestionarInscriptos
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
            btnAgregarInscripción = new Button();
            btnEliminarEnListaDeEspera = new TabControl();
            tabCursando = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnEliminarCursando = new Button();
            lsbCursando = new ListBox();
            btnModificarCursando = new Button();
            tabLibre = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnEliminarLibre = new Button();
            lsbLibres = new ListBox();
            btnModificarLibre = new Button();
            tabCursadaAprobada = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnEliminarCursadaAprobada = new Button();
            btnModificarCursadaAprobada = new Button();
            lsbCursadaAprobada = new ListBox();
            tabFinalAprobado = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnEliminarFinalAprobado = new Button();
            lsbFinalAprobado = new ListBox();
            btnModificarFinalAprobado = new Button();
            tabEnListaDeEspera = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            bntEliminarEnEspera = new Button();
            lsbEnListaDeEspera = new ListBox();
            btnModificarEnListaDeEspera = new Button();
            tableLayoutPanel1.SuspendLayout();
            btnEliminarEnListaDeEspera.SuspendLayout();
            tabCursando.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabLibre.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabCursadaAprobada.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabFinalAprobado.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tabEnListaDeEspera.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(btnAgregarInscripción, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEliminarEnListaDeEspera, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(960, 547);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAgregarInscripción
            // 
            btnAgregarInscripción.Anchor = AnchorStyles.None;
            btnAgregarInscripción.Location = new Point(820, 254);
            btnAgregarInscripción.Name = "btnAgregarInscripción";
            btnAgregarInscripción.Size = new Size(130, 39);
            btnAgregarInscripción.TabIndex = 2;
            btnAgregarInscripción.Text = "Agregar Inscripción";
            btnAgregarInscripción.UseVisualStyleBackColor = true;
            btnAgregarInscripción.Click += btnAgregarInscripción_Click;
            // 
            // btnEliminarEnListaDeEspera
            // 
            btnEliminarEnListaDeEspera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminarEnListaDeEspera.Controls.Add(tabCursando);
            btnEliminarEnListaDeEspera.Controls.Add(tabLibre);
            btnEliminarEnListaDeEspera.Controls.Add(tabCursadaAprobada);
            btnEliminarEnListaDeEspera.Controls.Add(tabFinalAprobado);
            btnEliminarEnListaDeEspera.Controls.Add(tabEnListaDeEspera);
            btnEliminarEnListaDeEspera.Location = new Point(3, 3);
            btnEliminarEnListaDeEspera.Name = "btnEliminarEnListaDeEspera";
            btnEliminarEnListaDeEspera.SelectedIndex = 0;
            btnEliminarEnListaDeEspera.Size = new Size(804, 541);
            btnEliminarEnListaDeEspera.TabIndex = 0;
            // 
            // tabCursando
            // 
            tabCursando.Controls.Add(tableLayoutPanel2);
            tabCursando.Location = new Point(4, 24);
            tabCursando.Name = "tabCursando";
            tabCursando.Padding = new Padding(3);
            tabCursando.Size = new Size(796, 513);
            tabCursando.TabIndex = 0;
            tabCursando.Text = "Estudiantes Cursando";
            tabCursando.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.Controls.Add(btnEliminarCursando, 1, 1);
            tableLayoutPanel2.Controls.Add(lsbCursando, 0, 0);
            tableLayoutPanel2.Controls.Add(btnModificarCursando, 1, 0);
            tableLayoutPanel2.Location = new Point(6, 6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(784, 501);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnEliminarCursando
            // 
            btnEliminarCursando.Anchor = AnchorStyles.None;
            btnEliminarCursando.Location = new Point(644, 356);
            btnEliminarCursando.Name = "btnEliminarCursando";
            btnEliminarCursando.Size = new Size(130, 39);
            btnEliminarCursando.TabIndex = 2;
            btnEliminarCursando.Text = "Eliminar Inscripción";
            btnEliminarCursando.UseVisualStyleBackColor = true;
            btnEliminarCursando.Click += btnEliminarCursando_Click;
            // 
            // lsbCursando
            // 
            lsbCursando.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsbCursando.FormattingEnabled = true;
            lsbCursando.ItemHeight = 15;
            lsbCursando.Location = new Point(3, 3);
            lsbCursando.Name = "lsbCursando";
            tableLayoutPanel2.SetRowSpan(lsbCursando, 2);
            lsbCursando.Size = new Size(628, 484);
            lsbCursando.TabIndex = 0;
            // 
            // btnModificarCursando
            // 
            btnModificarCursando.Anchor = AnchorStyles.None;
            btnModificarCursando.Location = new Point(644, 105);
            btnModificarCursando.Name = "btnModificarCursando";
            btnModificarCursando.Size = new Size(130, 39);
            btnModificarCursando.TabIndex = 1;
            btnModificarCursando.Text = "Modificar inscripción";
            btnModificarCursando.UseVisualStyleBackColor = true;
            btnModificarCursando.Click += btnModificarCursando_Click;
            // 
            // tabLibre
            // 
            tabLibre.Controls.Add(tableLayoutPanel3);
            tabLibre.Location = new Point(4, 24);
            tabLibre.Name = "tabLibre";
            tabLibre.Padding = new Padding(3);
            tabLibre.Size = new Size(796, 513);
            tabLibre.TabIndex = 1;
            tabLibre.Text = "Libres";
            tabLibre.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.Controls.Add(btnEliminarLibre, 1, 1);
            tableLayoutPanel3.Controls.Add(lsbLibres, 0, 0);
            tableLayoutPanel3.Controls.Add(btnModificarLibre, 1, 0);
            tableLayoutPanel3.Location = new Point(6, 6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(784, 501);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnEliminarLibre
            // 
            btnEliminarLibre.Anchor = AnchorStyles.None;
            btnEliminarLibre.Location = new Point(644, 356);
            btnEliminarLibre.Name = "btnEliminarLibre";
            btnEliminarLibre.Size = new Size(130, 39);
            btnEliminarLibre.TabIndex = 2;
            btnEliminarLibre.Text = "Eliminar Inscripción";
            btnEliminarLibre.UseVisualStyleBackColor = true;
            btnEliminarLibre.Click += btnEliminarLibre_Click;
            // 
            // lsbLibres
            // 
            lsbLibres.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsbLibres.FormattingEnabled = true;
            lsbLibres.ItemHeight = 15;
            lsbLibres.Location = new Point(3, 3);
            lsbLibres.Name = "lsbLibres";
            tableLayoutPanel3.SetRowSpan(lsbLibres, 2);
            lsbLibres.Size = new Size(628, 484);
            lsbLibres.TabIndex = 0;
            // 
            // btnModificarLibre
            // 
            btnModificarLibre.Anchor = AnchorStyles.None;
            btnModificarLibre.Location = new Point(644, 105);
            btnModificarLibre.Name = "btnModificarLibre";
            btnModificarLibre.Size = new Size(130, 39);
            btnModificarLibre.TabIndex = 1;
            btnModificarLibre.Text = "Modificar inscripción";
            btnModificarLibre.UseVisualStyleBackColor = true;
            btnModificarLibre.Click += btnModificarLibre_Click;
            // 
            // tabCursadaAprobada
            // 
            tabCursadaAprobada.Controls.Add(tableLayoutPanel4);
            tabCursadaAprobada.Location = new Point(4, 24);
            tabCursadaAprobada.Name = "tabCursadaAprobada";
            tabCursadaAprobada.Size = new Size(796, 513);
            tabCursadaAprobada.TabIndex = 2;
            tabCursadaAprobada.Text = "Cursada Aprobada";
            tabCursadaAprobada.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(btnEliminarCursadaAprobada, 1, 1);
            tableLayoutPanel4.Controls.Add(btnModificarCursadaAprobada, 1, 0);
            tableLayoutPanel4.Controls.Add(lsbCursadaAprobada, 0, 0);
            tableLayoutPanel4.Location = new Point(6, 6);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(784, 501);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnEliminarCursadaAprobada
            // 
            btnEliminarCursadaAprobada.Anchor = AnchorStyles.None;
            btnEliminarCursadaAprobada.Location = new Point(644, 356);
            btnEliminarCursadaAprobada.Name = "btnEliminarCursadaAprobada";
            btnEliminarCursadaAprobada.Size = new Size(130, 39);
            btnEliminarCursadaAprobada.TabIndex = 2;
            btnEliminarCursadaAprobada.Text = "Eliminar Inscripción";
            btnEliminarCursadaAprobada.UseVisualStyleBackColor = true;
            btnEliminarCursadaAprobada.Click += btnEliminarCursadaAprobada_Click;
            // 
            // btnModificarCursadaAprobada
            // 
            btnModificarCursadaAprobada.Anchor = AnchorStyles.None;
            btnModificarCursadaAprobada.Location = new Point(644, 105);
            btnModificarCursadaAprobada.Name = "btnModificarCursadaAprobada";
            btnModificarCursadaAprobada.Size = new Size(130, 39);
            btnModificarCursadaAprobada.TabIndex = 1;
            btnModificarCursadaAprobada.Text = "Modificar inscripción";
            btnModificarCursadaAprobada.UseVisualStyleBackColor = true;
            btnModificarCursadaAprobada.Click += btnModificarCursadaAprobada_Click;
            // 
            // lsbCursadaAprobada
            // 
            lsbCursadaAprobada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsbCursadaAprobada.FormattingEnabled = true;
            lsbCursadaAprobada.ItemHeight = 15;
            lsbCursadaAprobada.Location = new Point(3, 3);
            lsbCursadaAprobada.Name = "lsbCursadaAprobada";
            tableLayoutPanel4.SetRowSpan(lsbCursadaAprobada, 2);
            lsbCursadaAprobada.Size = new Size(628, 484);
            lsbCursadaAprobada.TabIndex = 0;
            // 
            // tabFinalAprobado
            // 
            tabFinalAprobado.Controls.Add(tableLayoutPanel5);
            tabFinalAprobado.Location = new Point(4, 24);
            tabFinalAprobado.Name = "tabFinalAprobado";
            tabFinalAprobado.Size = new Size(796, 513);
            tabFinalAprobado.TabIndex = 3;
            tabFinalAprobado.Text = "Final Aprobado";
            tabFinalAprobado.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel5.Controls.Add(btnEliminarFinalAprobado, 1, 1);
            tableLayoutPanel5.Controls.Add(lsbFinalAprobado, 0, 0);
            tableLayoutPanel5.Controls.Add(btnModificarFinalAprobado, 1, 0);
            tableLayoutPanel5.Location = new Point(6, 6);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(784, 501);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // btnEliminarFinalAprobado
            // 
            btnEliminarFinalAprobado.Anchor = AnchorStyles.None;
            btnEliminarFinalAprobado.Location = new Point(644, 356);
            btnEliminarFinalAprobado.Name = "btnEliminarFinalAprobado";
            btnEliminarFinalAprobado.Size = new Size(130, 39);
            btnEliminarFinalAprobado.TabIndex = 2;
            btnEliminarFinalAprobado.Text = "Eliminar Inscripción";
            btnEliminarFinalAprobado.UseVisualStyleBackColor = true;
            btnEliminarFinalAprobado.Click += btnEliminarFinalAprobado_Click;
            // 
            // lsbFinalAprobado
            // 
            lsbFinalAprobado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsbFinalAprobado.FormattingEnabled = true;
            lsbFinalAprobado.ItemHeight = 15;
            lsbFinalAprobado.Location = new Point(3, 3);
            lsbFinalAprobado.Name = "lsbFinalAprobado";
            tableLayoutPanel5.SetRowSpan(lsbFinalAprobado, 2);
            lsbFinalAprobado.Size = new Size(628, 484);
            lsbFinalAprobado.TabIndex = 0;
            // 
            // btnModificarFinalAprobado
            // 
            btnModificarFinalAprobado.Anchor = AnchorStyles.None;
            btnModificarFinalAprobado.Location = new Point(644, 105);
            btnModificarFinalAprobado.Name = "btnModificarFinalAprobado";
            btnModificarFinalAprobado.Size = new Size(130, 39);
            btnModificarFinalAprobado.TabIndex = 1;
            btnModificarFinalAprobado.Text = "Modificar inscripción";
            btnModificarFinalAprobado.UseVisualStyleBackColor = true;
            btnModificarFinalAprobado.Click += btnModificarFinalAprobado_Click;
            // 
            // tabEnListaDeEspera
            // 
            tabEnListaDeEspera.Controls.Add(tableLayoutPanel6);
            tabEnListaDeEspera.Location = new Point(4, 24);
            tabEnListaDeEspera.Name = "tabEnListaDeEspera";
            tabEnListaDeEspera.Size = new Size(796, 513);
            tabEnListaDeEspera.TabIndex = 4;
            tabEnListaDeEspera.Text = "En lista de espera";
            tabEnListaDeEspera.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel6.Controls.Add(bntEliminarEnEspera, 1, 1);
            tableLayoutPanel6.Controls.Add(lsbEnListaDeEspera, 0, 0);
            tableLayoutPanel6.Controls.Add(btnModificarEnListaDeEspera, 1, 0);
            tableLayoutPanel6.Location = new Point(6, 6);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(784, 501);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // bntEliminarEnEspera
            // 
            bntEliminarEnEspera.Anchor = AnchorStyles.None;
            bntEliminarEnEspera.Location = new Point(644, 356);
            bntEliminarEnEspera.Name = "bntEliminarEnEspera";
            bntEliminarEnEspera.Size = new Size(130, 39);
            bntEliminarEnEspera.TabIndex = 2;
            bntEliminarEnEspera.Text = "Eliminar Inscripción";
            bntEliminarEnEspera.UseVisualStyleBackColor = true;
            bntEliminarEnEspera.Click += btnEliminarEnEspera_Click;
            // 
            // lsbEnListaDeEspera
            // 
            lsbEnListaDeEspera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsbEnListaDeEspera.FormattingEnabled = true;
            lsbEnListaDeEspera.ItemHeight = 15;
            lsbEnListaDeEspera.Location = new Point(3, 3);
            lsbEnListaDeEspera.Name = "lsbEnListaDeEspera";
            tableLayoutPanel6.SetRowSpan(lsbEnListaDeEspera, 2);
            lsbEnListaDeEspera.Size = new Size(628, 484);
            lsbEnListaDeEspera.TabIndex = 0;
            // 
            // btnModificarEnListaDeEspera
            // 
            btnModificarEnListaDeEspera.Anchor = AnchorStyles.None;
            btnModificarEnListaDeEspera.Location = new Point(644, 105);
            btnModificarEnListaDeEspera.Name = "btnModificarEnListaDeEspera";
            btnModificarEnListaDeEspera.Size = new Size(130, 39);
            btnModificarEnListaDeEspera.TabIndex = 1;
            btnModificarEnListaDeEspera.Text = "Modificar inscripción";
            btnModificarEnListaDeEspera.UseVisualStyleBackColor = true;
            btnModificarEnListaDeEspera.Click += btnModificarEnListaDeEspera_Click;
            // 
            // formGestionarInscriptos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 571);
            Controls.Add(tableLayoutPanel1);
            Name = "formGestionarInscriptos";
            Text = "formGestionarInscriptos";
            Load += formGestionarInscriptos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            btnEliminarEnListaDeEspera.ResumeLayout(false);
            tabCursando.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tabLibre.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tabCursadaAprobada.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tabFinalAprobado.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tabEnListaDeEspera.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl btnEliminarEnListaDeEspera;
        private TabPage tabCursando;
        private TabPage tabLibre;
        private TabPage tabCursadaAprobada;
        private TabPage tabFinalAprobado;
        private TabPage tabEnListaDeEspera;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnEliminarCursando;
        private ListBox lsbCursando;
        private Button btnModificarCursando;
        private Button btnAgregarInscripción;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnEliminarLibre;
        private ListBox lsbLibres;
        private Button btnModificarLibre;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnEliminarCursadaAprobada;
        private ListBox lsbCursadaAprobada;
        private Button btnModificarCursadaAprobada;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnEliminarFinalAprobado;
        private ListBox lsbFinalAprobado;
        private Button btnModificarFinalAprobado;
        private TableLayoutPanel tableLayoutPanel6;
        private Button bntEliminarEnEspera;
        private ListBox lsbEnListaDeEspera;
        private Button btnModificarEnListaDeEspera;
    }
}