namespace ProyectoFinalCsharBiblioteca
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegAlum = new System.Windows.Forms.TabPage();
            this.btnBuscarAl = new System.Windows.Forms.Button();
            this.btnCancelarAl = new System.Windows.Forms.Button();
            this.btnGuardarAl = new System.Windows.Forms.Button();
            this.btnNuevoAl = new System.Windows.Forms.Button();
            this.cbCarreraAl = new System.Windows.Forms.ComboBox();
            this.cbOpcionAl = new System.Windows.Forms.ComboBox();
            this.lblCarreraAl = new System.Windows.Forms.Label();
            this.txtEmailAl = new System.Windows.Forms.TextBox();
            this.lblEmailAl = new System.Windows.Forms.Label();
            this.txtNombreAl = new System.Windows.Forms.TextBox();
            this.lblNombreAl = new System.Windows.Forms.Label();
            this.txtDatoAl = new System.Windows.Forms.TextBox();
            this.lblOpcionAl = new System.Windows.Forms.Label();
            this.lblDatoAl = new System.Windows.Forms.Label();
            this.txtCodigoAl = new System.Windows.Forms.TextBox();
            this.lblCodigoAl = new System.Windows.Forms.Label();
            this.tabRegLibros = new System.Windows.Forms.TabPage();
            this.btnBuscarLb = new System.Windows.Forms.Button();
            this.btnCancelarLb = new System.Windows.Forms.Button();
            this.btnGuardarLb = new System.Windows.Forms.Button();
            this.btnNuevoLb = new System.Windows.Forms.Button();
            this.cbClasificacionLb = new System.Windows.Forms.ComboBox();
            this.cbOpcionLb = new System.Windows.Forms.ComboBox();
            this.lblClasificacionLb = new System.Windows.Forms.Label();
            this.txtAutorLb = new System.Windows.Forms.TextBox();
            this.lblAutorLb = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTituloLb = new System.Windows.Forms.Label();
            this.txtDatoLb = new System.Windows.Forms.TextBox();
            this.lblOpcionLb = new System.Windows.Forms.Label();
            this.lblDatoLb = new System.Windows.Forms.Label();
            this.txtRegistroLb = new System.Windows.Forms.TextBox();
            this.lblRegistroLb = new System.Windows.Forms.Label();
            this.tabPrestamos = new System.Windows.Forms.TabPage();
            this.dtpFechaRg = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPrestamoRg = new System.Windows.Forms.Label();
            this.lblEstadoLibroRg = new System.Windows.Forms.Label();
            this.btnBuscarRg = new System.Windows.Forms.Button();
            this.btnCancelarRg = new System.Windows.Forms.Button();
            this.btnGuardarRg = new System.Windows.Forms.Button();
            this.btnNuevoRg = new System.Windows.Forms.Button();
            this.cbRegistroLibroRg = new System.Windows.Forms.ComboBox();
            this.cbCodigoAlumnoRg = new System.Windows.Forms.ComboBox();
            this.cbEstadoLibroRg = new System.Windows.Forms.ComboBox();
            this.lblTituloRg = new System.Windows.Forms.Label();
            this.txtTituloRg = new System.Windows.Forms.TextBox();
            this.lblRegistroLibroRg = new System.Windows.Forms.Label();
            this.lblCodigoAlumnoRg = new System.Windows.Forms.Label();
            this.txtDatoRg = new System.Windows.Forms.TextBox();
            this.lblDatoRg = new System.Windows.Forms.Label();
            this.txtRestroRg = new System.Windows.Forms.TextBox();
            this.lblRegistroRg = new System.Windows.Forms.Label();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabRegAlum.SuspendLayout();
            this.tabRegLibros.SuspendLayout();
            this.tabPrestamos.SuspendLayout();
            this.tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegAlum);
            this.tabControl1.Controls.Add(this.tabRegLibros);
            this.tabControl1.Controls.Add(this.tabPrestamos);
            this.tabControl1.Controls.Add(this.tabHistorial);
            this.tabControl1.Location = new System.Drawing.Point(14, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1392, 765);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRegAlum
            // 
            this.tabRegAlum.Controls.Add(this.btnBuscarAl);
            this.tabRegAlum.Controls.Add(this.btnCancelarAl);
            this.tabRegAlum.Controls.Add(this.btnGuardarAl);
            this.tabRegAlum.Controls.Add(this.btnNuevoAl);
            this.tabRegAlum.Controls.Add(this.cbCarreraAl);
            this.tabRegAlum.Controls.Add(this.cbOpcionAl);
            this.tabRegAlum.Controls.Add(this.lblCarreraAl);
            this.tabRegAlum.Controls.Add(this.txtEmailAl);
            this.tabRegAlum.Controls.Add(this.lblEmailAl);
            this.tabRegAlum.Controls.Add(this.txtNombreAl);
            this.tabRegAlum.Controls.Add(this.lblNombreAl);
            this.tabRegAlum.Controls.Add(this.txtDatoAl);
            this.tabRegAlum.Controls.Add(this.lblOpcionAl);
            this.tabRegAlum.Controls.Add(this.lblDatoAl);
            this.tabRegAlum.Controls.Add(this.txtCodigoAl);
            this.tabRegAlum.Controls.Add(this.lblCodigoAl);
            this.tabRegAlum.Location = new System.Drawing.Point(8, 39);
            this.tabRegAlum.Margin = new System.Windows.Forms.Padding(6);
            this.tabRegAlum.Name = "tabRegAlum";
            this.tabRegAlum.Padding = new System.Windows.Forms.Padding(6);
            this.tabRegAlum.Size = new System.Drawing.Size(1376, 718);
            this.tabRegAlum.TabIndex = 0;
            this.tabRegAlum.Text = "Registro Alumnos";
            this.tabRegAlum.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAl
            // 
            this.btnBuscarAl.Location = new System.Drawing.Point(1012, 181);
            this.btnBuscarAl.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarAl.Name = "btnBuscarAl";
            this.btnBuscarAl.Size = new System.Drawing.Size(186, 73);
            this.btnBuscarAl.TabIndex = 3;
            this.btnBuscarAl.Text = "Buscar";
            this.btnBuscarAl.UseVisualStyleBackColor = true;
            this.btnBuscarAl.Click += new System.EventHandler(this.btnBuscarAl_Click);
            // 
            // btnCancelarAl
            // 
            this.btnCancelarAl.Location = new System.Drawing.Point(570, 554);
            this.btnCancelarAl.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelarAl.Name = "btnCancelarAl";
            this.btnCancelarAl.Size = new System.Drawing.Size(186, 73);
            this.btnCancelarAl.TabIndex = 3;
            this.btnCancelarAl.Text = "Cancelar";
            this.btnCancelarAl.UseVisualStyleBackColor = true;
            this.btnCancelarAl.Click += new System.EventHandler(this.btnCancelarAl_Click);
            // 
            // btnGuardarAl
            // 
            this.btnGuardarAl.Location = new System.Drawing.Point(372, 554);
            this.btnGuardarAl.Margin = new System.Windows.Forms.Padding(6);
            this.btnGuardarAl.Name = "btnGuardarAl";
            this.btnGuardarAl.Size = new System.Drawing.Size(186, 73);
            this.btnGuardarAl.TabIndex = 3;
            this.btnGuardarAl.Text = "Guardar";
            this.btnGuardarAl.UseVisualStyleBackColor = true;
            this.btnGuardarAl.Click += new System.EventHandler(this.btnGuardarAl_Click);
            // 
            // btnNuevoAl
            // 
            this.btnNuevoAl.Location = new System.Drawing.Point(174, 554);
            this.btnNuevoAl.Margin = new System.Windows.Forms.Padding(6);
            this.btnNuevoAl.Name = "btnNuevoAl";
            this.btnNuevoAl.Size = new System.Drawing.Size(186, 73);
            this.btnNuevoAl.TabIndex = 3;
            this.btnNuevoAl.Text = "Nuevo";
            this.btnNuevoAl.UseVisualStyleBackColor = true;
            this.btnNuevoAl.Click += new System.EventHandler(this.btnNuevoAl_Click);
            // 
            // cbCarreraAl
            // 
            this.cbCarreraAl.FormattingEnabled = true;
            this.cbCarreraAl.Items.AddRange(new object[] {
            "BIOMEDICA",
            "ROBOTICA",
            "COMPUTACION",
            "DERECHO",
            "QUIMICA",
            "MECATRONICA"});
            this.cbCarreraAl.Location = new System.Drawing.Point(258, 415);
            this.cbCarreraAl.Margin = new System.Windows.Forms.Padding(6);
            this.cbCarreraAl.Name = "cbCarreraAl";
            this.cbCarreraAl.Size = new System.Drawing.Size(494, 33);
            this.cbCarreraAl.TabIndex = 2;
            // 
            // cbOpcionAl
            // 
            this.cbOpcionAl.FormattingEnabled = true;
            this.cbOpcionAl.Items.AddRange(new object[] {
            "CODIGO",
            "NOMBRE"});
            this.cbOpcionAl.Location = new System.Drawing.Point(732, 81);
            this.cbOpcionAl.Margin = new System.Windows.Forms.Padding(6);
            this.cbOpcionAl.Name = "cbOpcionAl";
            this.cbOpcionAl.Size = new System.Drawing.Size(462, 33);
            this.cbOpcionAl.TabIndex = 2;
            // 
            // lblCarreraAl
            // 
            this.lblCarreraAl.AutoSize = true;
            this.lblCarreraAl.Location = new System.Drawing.Point(156, 415);
            this.lblCarreraAl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarreraAl.Name = "lblCarreraAl";
            this.lblCarreraAl.Size = new System.Drawing.Size(90, 25);
            this.lblCarreraAl.TabIndex = 0;
            this.lblCarreraAl.Text = "Carrera:";
            // 
            // txtEmailAl
            // 
            this.txtEmailAl.Location = new System.Drawing.Point(258, 362);
            this.txtEmailAl.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmailAl.Name = "txtEmailAl";
            this.txtEmailAl.Size = new System.Drawing.Size(662, 31);
            this.txtEmailAl.TabIndex = 1;
            // 
            // lblEmailAl
            // 
            this.lblEmailAl.AutoSize = true;
            this.lblEmailAl.Location = new System.Drawing.Point(168, 367);
            this.lblEmailAl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmailAl.Name = "lblEmailAl";
            this.lblEmailAl.Size = new System.Drawing.Size(71, 25);
            this.lblEmailAl.TabIndex = 0;
            this.lblEmailAl.Text = "Email:";
            // 
            // txtNombreAl
            // 
            this.txtNombreAl.Location = new System.Drawing.Point(258, 312);
            this.txtNombreAl.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreAl.Name = "txtNombreAl";
            this.txtNombreAl.Size = new System.Drawing.Size(662, 31);
            this.txtNombreAl.TabIndex = 1;
            // 
            // lblNombreAl
            // 
            this.lblNombreAl.AutoSize = true;
            this.lblNombreAl.Location = new System.Drawing.Point(72, 317);
            this.lblNombreAl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreAl.Name = "lblNombreAl";
            this.lblNombreAl.Size = new System.Drawing.Size(171, 25);
            this.lblNombreAl.TabIndex = 0;
            this.lblNombreAl.Text = "Nombre Alumno:";
            // 
            // txtDatoAl
            // 
            this.txtDatoAl.Location = new System.Drawing.Point(732, 131);
            this.txtDatoAl.Margin = new System.Windows.Forms.Padding(6);
            this.txtDatoAl.Name = "txtDatoAl";
            this.txtDatoAl.Size = new System.Drawing.Size(464, 31);
            this.txtDatoAl.TabIndex = 1;
            // 
            // lblOpcionAl
            // 
            this.lblOpcionAl.AutoSize = true;
            this.lblOpcionAl.Location = new System.Drawing.Point(490, 87);
            this.lblOpcionAl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOpcionAl.Name = "lblOpcionAl";
            this.lblOpcionAl.Size = new System.Drawing.Size(228, 25);
            this.lblOpcionAl.TabIndex = 0;
            this.lblOpcionAl.Text = "Seleccion una Opcion:";
            // 
            // lblDatoAl
            // 
            this.lblDatoAl.AutoSize = true;
            this.lblDatoAl.Location = new System.Drawing.Point(514, 137);
            this.lblDatoAl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDatoAl.Name = "lblDatoAl";
            this.lblDatoAl.Size = new System.Drawing.Size(206, 25);
            this.lblDatoAl.TabIndex = 0;
            this.lblDatoAl.Text = "Ingrese Informacion:";
            // 
            // txtCodigoAl
            // 
            this.txtCodigoAl.Enabled = false;
            this.txtCodigoAl.Location = new System.Drawing.Point(258, 262);
            this.txtCodigoAl.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigoAl.Name = "txtCodigoAl";
            this.txtCodigoAl.Size = new System.Drawing.Size(264, 31);
            this.txtCodigoAl.TabIndex = 1;
            // 
            // lblCodigoAl
            // 
            this.lblCodigoAl.AutoSize = true;
            this.lblCodigoAl.Location = new System.Drawing.Point(156, 265);
            this.lblCodigoAl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigoAl.Name = "lblCodigoAl";
            this.lblCodigoAl.Size = new System.Drawing.Size(86, 25);
            this.lblCodigoAl.TabIndex = 0;
            this.lblCodigoAl.Text = "Codigo:";
            // 
            // tabRegLibros
            // 
            this.tabRegLibros.Controls.Add(this.btnBuscarLb);
            this.tabRegLibros.Controls.Add(this.btnCancelarLb);
            this.tabRegLibros.Controls.Add(this.btnGuardarLb);
            this.tabRegLibros.Controls.Add(this.btnNuevoLb);
            this.tabRegLibros.Controls.Add(this.cbClasificacionLb);
            this.tabRegLibros.Controls.Add(this.cbOpcionLb);
            this.tabRegLibros.Controls.Add(this.lblClasificacionLb);
            this.tabRegLibros.Controls.Add(this.txtAutorLb);
            this.tabRegLibros.Controls.Add(this.lblAutorLb);
            this.tabRegLibros.Controls.Add(this.txtTitulo);
            this.tabRegLibros.Controls.Add(this.lblTituloLb);
            this.tabRegLibros.Controls.Add(this.txtDatoLb);
            this.tabRegLibros.Controls.Add(this.lblOpcionLb);
            this.tabRegLibros.Controls.Add(this.lblDatoLb);
            this.tabRegLibros.Controls.Add(this.txtRegistroLb);
            this.tabRegLibros.Controls.Add(this.lblRegistroLb);
            this.tabRegLibros.Location = new System.Drawing.Point(8, 39);
            this.tabRegLibros.Margin = new System.Windows.Forms.Padding(6);
            this.tabRegLibros.Name = "tabRegLibros";
            this.tabRegLibros.Padding = new System.Windows.Forms.Padding(6);
            this.tabRegLibros.Size = new System.Drawing.Size(1376, 718);
            this.tabRegLibros.TabIndex = 1;
            this.tabRegLibros.Text = "Registro Libros";
            this.tabRegLibros.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLb
            // 
            this.btnBuscarLb.Location = new System.Drawing.Point(1038, 171);
            this.btnBuscarLb.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarLb.Name = "btnBuscarLb";
            this.btnBuscarLb.Size = new System.Drawing.Size(186, 73);
            this.btnBuscarLb.TabIndex = 16;
            this.btnBuscarLb.Text = "Buscar";
            this.btnBuscarLb.UseVisualStyleBackColor = true;
            this.btnBuscarLb.Click += new System.EventHandler(this.btnBuscarLb_Click);
            // 
            // btnCancelarLb
            // 
            this.btnCancelarLb.Location = new System.Drawing.Point(568, 552);
            this.btnCancelarLb.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelarLb.Name = "btnCancelarLb";
            this.btnCancelarLb.Size = new System.Drawing.Size(186, 73);
            this.btnCancelarLb.TabIndex = 17;
            this.btnCancelarLb.Text = "Cancelar";
            this.btnCancelarLb.UseVisualStyleBackColor = true;
            this.btnCancelarLb.Click += new System.EventHandler(this.btnCancelarLb_Click);
            // 
            // btnGuardarLb
            // 
            this.btnGuardarLb.Location = new System.Drawing.Point(370, 552);
            this.btnGuardarLb.Margin = new System.Windows.Forms.Padding(6);
            this.btnGuardarLb.Name = "btnGuardarLb";
            this.btnGuardarLb.Size = new System.Drawing.Size(186, 73);
            this.btnGuardarLb.TabIndex = 18;
            this.btnGuardarLb.Text = "Guardar";
            this.btnGuardarLb.UseVisualStyleBackColor = true;
            this.btnGuardarLb.Click += new System.EventHandler(this.btnGuardarLb_Click);
            // 
            // btnNuevoLb
            // 
            this.btnNuevoLb.Location = new System.Drawing.Point(172, 552);
            this.btnNuevoLb.Margin = new System.Windows.Forms.Padding(6);
            this.btnNuevoLb.Name = "btnNuevoLb";
            this.btnNuevoLb.Size = new System.Drawing.Size(186, 73);
            this.btnNuevoLb.TabIndex = 19;
            this.btnNuevoLb.Text = "Nuevo";
            this.btnNuevoLb.UseVisualStyleBackColor = true;
            this.btnNuevoLb.Click += new System.EventHandler(this.btnNuevoLb_Click);
            // 
            // cbClasificacionLb
            // 
            this.cbClasificacionLb.FormattingEnabled = true;
            this.cbClasificacionLb.Items.AddRange(new object[] {
            "HISTORIA",
            "CIENCIA",
            "TECNOLOGIA",
            "NOVELA"});
            this.cbClasificacionLb.Location = new System.Drawing.Point(316, 413);
            this.cbClasificacionLb.Margin = new System.Windows.Forms.Padding(6);
            this.cbClasificacionLb.Name = "cbClasificacionLb";
            this.cbClasificacionLb.Size = new System.Drawing.Size(296, 33);
            this.cbClasificacionLb.TabIndex = 14;
            // 
            // cbOpcionLb
            // 
            this.cbOpcionLb.FormattingEnabled = true;
            this.cbOpcionLb.Items.AddRange(new object[] {
            "REGISTRO"});
            this.cbOpcionLb.Location = new System.Drawing.Point(756, 71);
            this.cbOpcionLb.Margin = new System.Windows.Forms.Padding(6);
            this.cbOpcionLb.Name = "cbOpcionLb";
            this.cbOpcionLb.Size = new System.Drawing.Size(462, 33);
            this.cbOpcionLb.TabIndex = 15;
            // 
            // lblClasificacionLb
            // 
            this.lblClasificacionLb.AutoSize = true;
            this.lblClasificacionLb.Location = new System.Drawing.Point(166, 419);
            this.lblClasificacionLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClasificacionLb.Name = "lblClasificacionLb";
            this.lblClasificacionLb.Size = new System.Drawing.Size(140, 25);
            this.lblClasificacionLb.TabIndex = 4;
            this.lblClasificacionLb.Text = "Clasificacion:";
            // 
            // txtAutorLb
            // 
            this.txtAutorLb.Location = new System.Drawing.Point(316, 363);
            this.txtAutorLb.Margin = new System.Windows.Forms.Padding(6);
            this.txtAutorLb.Name = "txtAutorLb";
            this.txtAutorLb.Size = new System.Drawing.Size(382, 31);
            this.txtAutorLb.TabIndex = 10;
            // 
            // lblAutorLb
            // 
            this.lblAutorLb.AutoSize = true;
            this.lblAutorLb.Location = new System.Drawing.Point(234, 369);
            this.lblAutorLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAutorLb.Name = "lblAutorLb";
            this.lblAutorLb.Size = new System.Drawing.Size(69, 25);
            this.lblAutorLb.TabIndex = 5;
            this.lblAutorLb.Text = "Autor:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(316, 308);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(6);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(442, 31);
            this.txtTitulo.TabIndex = 11;
            // 
            // lblTituloLb
            // 
            this.lblTituloLb.AutoSize = true;
            this.lblTituloLb.Location = new System.Drawing.Point(128, 313);
            this.lblTituloLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloLb.Name = "lblTituloLb";
            this.lblTituloLb.Size = new System.Drawing.Size(177, 25);
            this.lblTituloLb.TabIndex = 6;
            this.lblTituloLb.Text = "Titulo de la Obra:";
            // 
            // txtDatoLb
            // 
            this.txtDatoLb.Location = new System.Drawing.Point(756, 121);
            this.txtDatoLb.Margin = new System.Windows.Forms.Padding(6);
            this.txtDatoLb.Name = "txtDatoLb";
            this.txtDatoLb.Size = new System.Drawing.Size(464, 31);
            this.txtDatoLb.TabIndex = 12;
            // 
            // lblOpcionLb
            // 
            this.lblOpcionLb.AutoSize = true;
            this.lblOpcionLb.Location = new System.Drawing.Point(502, 77);
            this.lblOpcionLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOpcionLb.Name = "lblOpcionLb";
            this.lblOpcionLb.Size = new System.Drawing.Size(240, 25);
            this.lblOpcionLb.TabIndex = 7;
            this.lblOpcionLb.Text = "Seleccione una Opcion:";
            // 
            // lblDatoLb
            // 
            this.lblDatoLb.AutoSize = true;
            this.lblDatoLb.Location = new System.Drawing.Point(538, 127);
            this.lblDatoLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDatoLb.Name = "lblDatoLb";
            this.lblDatoLb.Size = new System.Drawing.Size(206, 25);
            this.lblDatoLb.TabIndex = 8;
            this.lblDatoLb.Text = "Ingrese Informacion:";
            // 
            // txtRegistroLb
            // 
            this.txtRegistroLb.Enabled = false;
            this.txtRegistroLb.Location = new System.Drawing.Point(316, 258);
            this.txtRegistroLb.Margin = new System.Windows.Forms.Padding(6);
            this.txtRegistroLb.Name = "txtRegistroLb";
            this.txtRegistroLb.Size = new System.Drawing.Size(264, 31);
            this.txtRegistroLb.TabIndex = 13;
            // 
            // lblRegistroLb
            // 
            this.lblRegistroLb.AutoSize = true;
            this.lblRegistroLb.Location = new System.Drawing.Point(154, 263);
            this.lblRegistroLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegistroLb.Name = "lblRegistroLb";
            this.lblRegistroLb.Size = new System.Drawing.Size(152, 25);
            this.lblRegistroLb.TabIndex = 9;
            this.lblRegistroLb.Text = "Registro Libro:";
            // 
            // tabPrestamos
            // 
            this.tabPrestamos.Controls.Add(this.dtpFechaRg);
            this.tabPrestamos.Controls.Add(this.lblFechaPrestamoRg);
            this.tabPrestamos.Controls.Add(this.lblEstadoLibroRg);
            this.tabPrestamos.Controls.Add(this.btnBuscarRg);
            this.tabPrestamos.Controls.Add(this.btnCancelarRg);
            this.tabPrestamos.Controls.Add(this.btnGuardarRg);
            this.tabPrestamos.Controls.Add(this.btnNuevoRg);
            this.tabPrestamos.Controls.Add(this.cbRegistroLibroRg);
            this.tabPrestamos.Controls.Add(this.cbCodigoAlumnoRg);
            this.tabPrestamos.Controls.Add(this.cbEstadoLibroRg);
            this.tabPrestamos.Controls.Add(this.lblTituloRg);
            this.tabPrestamos.Controls.Add(this.txtTituloRg);
            this.tabPrestamos.Controls.Add(this.lblRegistroLibroRg);
            this.tabPrestamos.Controls.Add(this.lblCodigoAlumnoRg);
            this.tabPrestamos.Controls.Add(this.txtDatoRg);
            this.tabPrestamos.Controls.Add(this.lblDatoRg);
            this.tabPrestamos.Controls.Add(this.txtRestroRg);
            this.tabPrestamos.Controls.Add(this.lblRegistroRg);
            this.tabPrestamos.Location = new System.Drawing.Point(8, 39);
            this.tabPrestamos.Margin = new System.Windows.Forms.Padding(6);
            this.tabPrestamos.Name = "tabPrestamos";
            this.tabPrestamos.Size = new System.Drawing.Size(1376, 718);
            this.tabPrestamos.TabIndex = 2;
            this.tabPrestamos.Text = "Prestamos";
            this.tabPrestamos.UseVisualStyleBackColor = true;
            // 
            // dtpFechaRg
            // 
            this.dtpFechaRg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRg.Location = new System.Drawing.Point(936, 313);
            this.dtpFechaRg.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFechaRg.Name = "dtpFechaRg";
            this.dtpFechaRg.Size = new System.Drawing.Size(232, 31);
            this.dtpFechaRg.TabIndex = 22;
            // 
            // lblFechaPrestamoRg
            // 
            this.lblFechaPrestamoRg.AutoSize = true;
            this.lblFechaPrestamoRg.Location = new System.Drawing.Point(756, 317);
            this.lblFechaPrestamoRg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaPrestamoRg.Name = "lblFechaPrestamoRg";
            this.lblFechaPrestamoRg.Size = new System.Drawing.Size(169, 25);
            this.lblFechaPrestamoRg.TabIndex = 21;
            this.lblFechaPrestamoRg.Text = "Fecha Prestamo";
            // 
            // lblEstadoLibroRg
            // 
            this.lblEstadoLibroRg.AutoSize = true;
            this.lblEstadoLibroRg.Location = new System.Drawing.Point(106, 469);
            this.lblEstadoLibroRg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstadoLibroRg.Name = "lblEstadoLibroRg";
            this.lblEstadoLibroRg.Size = new System.Drawing.Size(139, 25);
            this.lblEstadoLibroRg.TabIndex = 20;
            this.lblEstadoLibroRg.Text = "Estado Libro:";
            // 
            // btnBuscarRg
            // 
            this.btnBuscarRg.Location = new System.Drawing.Point(986, 169);
            this.btnBuscarRg.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarRg.Name = "btnBuscarRg";
            this.btnBuscarRg.Size = new System.Drawing.Size(186, 73);
            this.btnBuscarRg.TabIndex = 16;
            this.btnBuscarRg.Text = "Buscar";
            this.btnBuscarRg.UseVisualStyleBackColor = true;
            this.btnBuscarRg.Click += new System.EventHandler(this.btnBuscarRg_Click);
            // 
            // btnCancelarRg
            // 
            this.btnCancelarRg.Location = new System.Drawing.Point(568, 552);
            this.btnCancelarRg.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelarRg.Name = "btnCancelarRg";
            this.btnCancelarRg.Size = new System.Drawing.Size(186, 73);
            this.btnCancelarRg.TabIndex = 17;
            this.btnCancelarRg.Text = "Cancelar";
            this.btnCancelarRg.UseVisualStyleBackColor = true;
            this.btnCancelarRg.Click += new System.EventHandler(this.btnCancelarRg_Click);
            // 
            // btnGuardarRg
            // 
            this.btnGuardarRg.Location = new System.Drawing.Point(370, 552);
            this.btnGuardarRg.Margin = new System.Windows.Forms.Padding(6);
            this.btnGuardarRg.Name = "btnGuardarRg";
            this.btnGuardarRg.Size = new System.Drawing.Size(186, 73);
            this.btnGuardarRg.TabIndex = 18;
            this.btnGuardarRg.Text = "Guardar";
            this.btnGuardarRg.UseVisualStyleBackColor = true;
            this.btnGuardarRg.Click += new System.EventHandler(this.btnGuardarRg_Click);
            // 
            // btnNuevoRg
            // 
            this.btnNuevoRg.Location = new System.Drawing.Point(172, 552);
            this.btnNuevoRg.Margin = new System.Windows.Forms.Padding(6);
            this.btnNuevoRg.Name = "btnNuevoRg";
            this.btnNuevoRg.Size = new System.Drawing.Size(186, 73);
            this.btnNuevoRg.TabIndex = 19;
            this.btnNuevoRg.Text = "Nuevo";
            this.btnNuevoRg.UseVisualStyleBackColor = true;
            this.btnNuevoRg.Click += new System.EventHandler(this.btnNuevoRg_Click);
            // 
            // cbRegistroLibroRg
            // 
            this.cbRegistroLibroRg.FormattingEnabled = true;
            this.cbRegistroLibroRg.Location = new System.Drawing.Point(256, 362);
            this.cbRegistroLibroRg.Margin = new System.Windows.Forms.Padding(6);
            this.cbRegistroLibroRg.Name = "cbRegistroLibroRg";
            this.cbRegistroLibroRg.Size = new System.Drawing.Size(432, 33);
            this.cbRegistroLibroRg.TabIndex = 14;
            this.cbRegistroLibroRg.SelectedIndexChanged += new System.EventHandler(this.cbRegistroLibroRg_SelectedIndexChanged);
            // 
            // cbCodigoAlumnoRg
            // 
            this.cbCodigoAlumnoRg.FormattingEnabled = true;
            this.cbCodigoAlumnoRg.Location = new System.Drawing.Point(256, 312);
            this.cbCodigoAlumnoRg.Margin = new System.Windows.Forms.Padding(6);
            this.cbCodigoAlumnoRg.Name = "cbCodigoAlumnoRg";
            this.cbCodigoAlumnoRg.Size = new System.Drawing.Size(432, 33);
            this.cbCodigoAlumnoRg.TabIndex = 14;
            this.cbCodigoAlumnoRg.SelectedIndexChanged += new System.EventHandler(this.cbCodigoAlumnoRg_SelectedIndexChanged);
            // 
            // cbEstadoLibroRg
            // 
            this.cbEstadoLibroRg.FormattingEnabled = true;
            this.cbEstadoLibroRg.Items.AddRange(new object[] {
            "PRESTADO",
            "DISPONIBLE"});
            this.cbEstadoLibroRg.Location = new System.Drawing.Point(256, 463);
            this.cbEstadoLibroRg.Margin = new System.Windows.Forms.Padding(6);
            this.cbEstadoLibroRg.Name = "cbEstadoLibroRg";
            this.cbEstadoLibroRg.Size = new System.Drawing.Size(296, 33);
            this.cbEstadoLibroRg.TabIndex = 14;
            // 
            // lblTituloRg
            // 
            this.lblTituloRg.AutoSize = true;
            this.lblTituloRg.Location = new System.Drawing.Point(68, 419);
            this.lblTituloRg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloRg.Name = "lblTituloRg";
            this.lblTituloRg.Size = new System.Drawing.Size(177, 25);
            this.lblTituloRg.TabIndex = 4;
            this.lblTituloRg.Text = "Titulo de la Obra:";
            // 
            // txtTituloRg
            // 
            this.txtTituloRg.Location = new System.Drawing.Point(256, 413);
            this.txtTituloRg.Margin = new System.Windows.Forms.Padding(6);
            this.txtTituloRg.Name = "txtTituloRg";
            this.txtTituloRg.Size = new System.Drawing.Size(694, 31);
            this.txtTituloRg.TabIndex = 10;
            // 
            // lblRegistroLibroRg
            // 
            this.lblRegistroLibroRg.AutoSize = true;
            this.lblRegistroLibroRg.Location = new System.Drawing.Point(94, 365);
            this.lblRegistroLibroRg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegistroLibroRg.Name = "lblRegistroLibroRg";
            this.lblRegistroLibroRg.Size = new System.Drawing.Size(152, 25);
            this.lblRegistroLibroRg.TabIndex = 5;
            this.lblRegistroLibroRg.Text = "Registro Libro:";
            // 
            // lblCodigoAlumnoRg
            // 
            this.lblCodigoAlumnoRg.AutoSize = true;
            this.lblCodigoAlumnoRg.Location = new System.Drawing.Point(82, 315);
            this.lblCodigoAlumnoRg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigoAlumnoRg.Name = "lblCodigoAlumnoRg";
            this.lblCodigoAlumnoRg.Size = new System.Drawing.Size(164, 25);
            this.lblCodigoAlumnoRg.TabIndex = 6;
            this.lblCodigoAlumnoRg.Text = "Codigo Alumno:";
            // 
            // txtDatoRg
            // 
            this.txtDatoRg.Location = new System.Drawing.Point(704, 119);
            this.txtDatoRg.Margin = new System.Windows.Forms.Padding(6);
            this.txtDatoRg.Name = "txtDatoRg";
            this.txtDatoRg.Size = new System.Drawing.Size(464, 31);
            this.txtDatoRg.TabIndex = 12;
            // 
            // lblDatoRg
            // 
            this.lblDatoRg.AutoSize = true;
            this.lblDatoRg.Location = new System.Drawing.Point(428, 125);
            this.lblDatoRg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDatoRg.Name = "lblDatoRg";
            this.lblDatoRg.Size = new System.Drawing.Size(266, 25);
            this.lblDatoRg.TabIndex = 8;
            this.lblDatoRg.Text = "Ingrese Registro a Buscar:";
            // 
            // txtRestroRg
            // 
            this.txtRestroRg.Enabled = false;
            this.txtRestroRg.Location = new System.Drawing.Point(256, 260);
            this.txtRestroRg.Margin = new System.Windows.Forms.Padding(6);
            this.txtRestroRg.Name = "txtRestroRg";
            this.txtRestroRg.Size = new System.Drawing.Size(148, 31);
            this.txtRestroRg.TabIndex = 13;
            // 
            // lblRegistroRg
            // 
            this.lblRegistroRg.AutoSize = true;
            this.lblRegistroRg.Location = new System.Drawing.Point(58, 265);
            this.lblRegistroRg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegistroRg.Name = "lblRegistroRg";
            this.lblRegistroRg.Size = new System.Drawing.Size(189, 25);
            this.lblRegistroRg.TabIndex = 9;
            this.lblRegistroRg.Text = "Registro Prestamo";
            // 
            // tabHistorial
            // 
            this.tabHistorial.Controls.Add(this.chart1);
            this.tabHistorial.Location = new System.Drawing.Point(8, 39);
            this.tabHistorial.Margin = new System.Windows.Forms.Padding(6);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Size = new System.Drawing.Size(1376, 718);
            this.tabHistorial.TabIndex = 3;
            this.tabHistorial.Text = "Historial Prestamos";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(64, 58);
            this.chart1.Margin = new System.Windows.Forms.Padding(6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1082, 625);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 796);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.tabControl1.ResumeLayout(false);
            this.tabRegAlum.ResumeLayout(false);
            this.tabRegAlum.PerformLayout();
            this.tabRegLibros.ResumeLayout(false);
            this.tabRegLibros.PerformLayout();
            this.tabPrestamos.ResumeLayout(false);
            this.tabPrestamos.PerformLayout();
            this.tabHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegAlum;
        private System.Windows.Forms.Button btnBuscarAl;
        private System.Windows.Forms.Button btnCancelarAl;
        private System.Windows.Forms.Button btnGuardarAl;
        private System.Windows.Forms.Button btnNuevoAl;
        private System.Windows.Forms.ComboBox cbCarreraAl;
        private System.Windows.Forms.ComboBox cbOpcionAl;
        private System.Windows.Forms.Label lblCarreraAl;
        private System.Windows.Forms.TextBox txtEmailAl;
        private System.Windows.Forms.Label lblEmailAl;
        private System.Windows.Forms.TextBox txtNombreAl;
        private System.Windows.Forms.Label lblNombreAl;
        private System.Windows.Forms.TextBox txtDatoAl;
        private System.Windows.Forms.Label lblOpcionAl;
        private System.Windows.Forms.Label lblDatoAl;
        private System.Windows.Forms.TextBox txtCodigoAl;
        private System.Windows.Forms.Label lblCodigoAl;
        private System.Windows.Forms.TabPage tabRegLibros;
        private System.Windows.Forms.Button btnBuscarLb;
        private System.Windows.Forms.Button btnCancelarLb;
        private System.Windows.Forms.Button btnGuardarLb;
        private System.Windows.Forms.Button btnNuevoLb;
        private System.Windows.Forms.ComboBox cbClasificacionLb;
        private System.Windows.Forms.ComboBox cbOpcionLb;
        private System.Windows.Forms.Label lblClasificacionLb;
        private System.Windows.Forms.TextBox txtAutorLb;
        private System.Windows.Forms.Label lblAutorLb;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTituloLb;
        private System.Windows.Forms.TextBox txtDatoLb;
        private System.Windows.Forms.Label lblOpcionLb;
        private System.Windows.Forms.Label lblDatoLb;
        private System.Windows.Forms.TextBox txtRegistroLb;
        private System.Windows.Forms.Label lblRegistroLb;
        private System.Windows.Forms.TabPage tabPrestamos;
        private System.Windows.Forms.Button btnBuscarRg;
        private System.Windows.Forms.Button btnCancelarRg;
        private System.Windows.Forms.Button btnGuardarRg;
        private System.Windows.Forms.Button btnNuevoRg;
        private System.Windows.Forms.ComboBox cbEstadoLibroRg;
        private System.Windows.Forms.Label lblTituloRg;
        private System.Windows.Forms.TextBox txtTituloRg;
        private System.Windows.Forms.Label lblRegistroLibroRg;
        private System.Windows.Forms.Label lblCodigoAlumnoRg;
        private System.Windows.Forms.TextBox txtDatoRg;
        private System.Windows.Forms.Label lblDatoRg;
        private System.Windows.Forms.TextBox txtRestroRg;
        private System.Windows.Forms.Label lblRegistroRg;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cbCodigoAlumnoRg;
        private System.Windows.Forms.ComboBox cbRegistroLibroRg;
        private System.Windows.Forms.Label lblEstadoLibroRg;
        private System.Windows.Forms.DateTimePicker dtpFechaRg;
        private System.Windows.Forms.Label lblFechaPrestamoRg;
    }
}