
namespace Proyecto_ML
{
    partial class FormPricipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.chrtRazonSocial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtFechaCantidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalFacturas = new System.Windows.Forms.Label();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.btn_design = new Proyecto_ML.btn_design();
            this.btn_design_MostrarAll = new Proyecto_ML.btn_design();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFechaCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 618);
            this.panelMenu.TabIndex = 12;
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 200);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(220, 60);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Buscar registro";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 140);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(220, 60);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Agregar registro";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.Location = new System.Drawing.Point(73, 40);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(71, 62);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelBarraTitulo.Controls.Add(this.btnMin);
            this.panelBarraTitulo.Controls.Add(this.btnMax);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.lblTitleChildForm);
            this.panelBarraTitulo.Controls.Add(this.iconCurrentChildForm);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(804, 70);
            this.panelBarraTitulo.TabIndex = 13;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMin.IconSize = 20;
            this.btnMin.Location = new System.Drawing.Point(714, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnMin.Size = new System.Drawing.Size(30, 20);
            this.btnMin.TabIndex = 5;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMax.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMax.IconSize = 20;
            this.btnMax.Location = new System.Drawing.Point(744, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnMax.Size = new System.Drawing.Size(30, 20);
            this.btnMax.TabIndex = 4;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(774, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(30, 20);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(71, 17);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(265, 42);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Menú Principal";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 42;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(19, 20);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(49, 42);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelDesktop.BackgroundImage = global::Proyecto_ML.Properties.Resources.bgImage1;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Controls.Add(this.lblFecha);
            this.panelDesktop.Controls.Add(this.chrtRazonSocial);
            this.panelDesktop.Controls.Add(this.chrtFechaCantidad);
            this.panelDesktop.Controls.Add(this.lblTotalFacturas);
            this.panelDesktop.Controls.Add(this.lblPlainText);
            this.panelDesktop.Controls.Add(this.btn_design);
            this.panelDesktop.Controls.Add(this.btn_design_MostrarAll);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(220, 79);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(804, 539);
            this.panelDesktop.TabIndex = 15;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(592, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(196, 18);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "domingo, 10 de agosto 2000";
            // 
            // chrtRazonSocial
            // 
            this.chrtRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chrtRazonSocial.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chrtRazonSocial.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chrtRazonSocial.Legends.Add(legend1);
            this.chrtRazonSocial.Location = new System.Drawing.Point(457, 244);
            this.chrtRazonSocial.Name = "chrtRazonSocial";
            this.chrtRazonSocial.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chrtRazonSocial.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(69))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(20)))), ((int)(((byte)(44))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(66)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(112)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(141)))), ((int)(((byte)(204)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Transparent;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtRazonSocial.Series.Add(series1);
            this.chrtRazonSocial.Size = new System.Drawing.Size(350, 239);
            this.chrtRazonSocial.TabIndex = 8;
            this.chrtRazonSocial.Text = "chart1";
            // 
            // chrtFechaCantidad
            // 
            this.chrtFechaCantidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chrtFechaCantidad.BackColor = System.Drawing.Color.Transparent;
            this.chrtFechaCantidad.BorderlineColor = System.Drawing.Color.Transparent;
            this.chrtFechaCantidad.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chrtFechaCantidad.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chrtFechaCantidad.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chrtFechaCantidad.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Gray;
            this.chrtFechaCantidad.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.chrtFechaCantidad.Legends.Add(legend2);
            this.chrtFechaCantidad.Location = new System.Drawing.Point(45, 244);
            this.chrtFechaCantidad.Name = "chrtFechaCantidad";
            this.chrtFechaCantidad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.DarkCyan;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Transparent;
            series2.Name = "Facturas por día";
            this.chrtFechaCantidad.Series.Add(series2);
            this.chrtFechaCantidad.Size = new System.Drawing.Size(393, 239);
            this.chrtFechaCantidad.TabIndex = 7;
            // 
            // lblTotalFacturas
            // 
            this.lblTotalFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalFacturas.AutoSize = true;
            this.lblTotalFacturas.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFacturas.ForeColor = System.Drawing.Color.White;
            this.lblTotalFacturas.Location = new System.Drawing.Point(142, 502);
            this.lblTotalFacturas.Name = "lblTotalFacturas";
            this.lblTotalFacturas.Size = new System.Drawing.Size(16, 18);
            this.lblTotalFacturas.TabIndex = 6;
            this.lblTotalFacturas.Text = "..";
            // 
            // lblPlainText
            // 
            this.lblPlainText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.BackColor = System.Drawing.Color.Transparent;
            this.lblPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainText.ForeColor = System.Drawing.Color.White;
            this.lblPlainText.Location = new System.Drawing.Point(16, 502);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(126, 18);
            this.lblPlainText.TabIndex = 5;
            this.lblPlainText.Text = "Total de facturas: ";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelShadow.Location = new System.Drawing.Point(220, 70);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(804, 9);
            this.panelShadow.TabIndex = 14;
            // 
            // btn_design
            // 
            this.btn_design.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_design.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.btn_design.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.btn_design.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_design.BorderRadius = 0;
            this.btn_design.BorderSize = 0;
            this.btn_design.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_design.FlatAppearance.BorderSize = 0;
            this.btn_design.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_design.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_design.ForeColor = System.Drawing.Color.White;
            this.btn_design.Location = new System.Drawing.Point(471, 97);
            this.btn_design.Name = "btn_design";
            this.btn_design.Size = new System.Drawing.Size(247, 127);
            this.btn_design.TabIndex = 2;
            this.btn_design.Text = "AJUSTES";
            this.btn_design.TextColor = System.Drawing.Color.White;
            this.btn_design.UseVisualStyleBackColor = false;
            this.btn_design.Click += new System.EventHandler(this.btn_design_Click);
            // 
            // btn_design_MostrarAll
            // 
            this.btn_design_MostrarAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_design_MostrarAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.btn_design_MostrarAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.btn_design_MostrarAll.BorderColor = System.Drawing.Color.Black;
            this.btn_design_MostrarAll.BorderRadius = 0;
            this.btn_design_MostrarAll.BorderSize = 0;
            this.btn_design_MostrarAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_design_MostrarAll.FlatAppearance.BorderSize = 0;
            this.btn_design_MostrarAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_design_MostrarAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_design_MostrarAll.ForeColor = System.Drawing.Color.White;
            this.btn_design_MostrarAll.Location = new System.Drawing.Point(112, 97);
            this.btn_design_MostrarAll.Name = "btn_design_MostrarAll";
            this.btn_design_MostrarAll.Size = new System.Drawing.Size(247, 127);
            this.btn_design_MostrarAll.TabIndex = 0;
            this.btn_design_MostrarAll.Text = "MOSTRAR TODOS";
            this.btn_design_MostrarAll.TextColor = System.Drawing.Color.White;
            this.btn_design_MostrarAll.UseVisualStyleBackColor = false;
            this.btn_design_MostrarAll.Click += new System.EventHandler(this.btn_design1_Click);
            // 
            // FormPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 618);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(907, 474);
            this.Name = "FormPricipal";
            this.Text = "Form Principal";
            this.Load += new System.EventHandler(this.FormPricipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFechaCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnMax;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelShadow;
        private btn_design btn_design_MostrarAll;
        private btn_design btn_design;
        private System.Windows.Forms.Label lblTotalFacturas;
        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtFechaCantidad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtRazonSocial;
        private System.Windows.Forms.Label lblFecha;
    }
}