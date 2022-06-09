
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
            this.graphFechaCantidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalFacturas = new System.Windows.Forms.Label();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.btn_design1 = new Proyecto_ML.btn_design();
            this.btn_design = new Proyecto_ML.btn_design();
            this.btn_design_MostrarAll = new Proyecto_ML.btn_design();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphFechaCantidad)).BeginInit();
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
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(330, 1001);
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
            this.iconButton2.Location = new System.Drawing.Point(0, 307);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.iconButton2.Size = new System.Drawing.Size(330, 92);
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
            this.iconButton1.Location = new System.Drawing.Point(0, 215);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.iconButton1.Size = new System.Drawing.Size(330, 92);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 215);
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
            this.btnHome.Location = new System.Drawing.Point(110, 62);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(106, 95);
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
            this.panelBarraTitulo.Location = new System.Drawing.Point(330, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1293, 108);
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
            this.btnMin.Location = new System.Drawing.Point(1158, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMin.Size = new System.Drawing.Size(45, 31);
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
            this.btnMax.Location = new System.Drawing.Point(1203, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMax.Name = "btnMax";
            this.btnMax.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMax.Size = new System.Drawing.Size(45, 31);
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
            this.btnCerrar.Location = new System.Drawing.Point(1248, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(45, 31);
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
            this.lblTitleChildForm.Location = new System.Drawing.Point(106, 26);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(177, 64);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 65;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(28, 31);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(74, 65);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Controls.Add(this.graphFechaCantidad);
            this.panelDesktop.Controls.Add(this.lblTotalFacturas);
            this.panelDesktop.Controls.Add(this.lblPlainText);
            this.panelDesktop.Controls.Add(this.btn_design1);
            this.panelDesktop.Controls.Add(this.btn_design);
            this.panelDesktop.Controls.Add(this.btn_design_MostrarAll);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(330, 122);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1293, 879);
            this.panelDesktop.TabIndex = 15;
            // 
            // graphFechaCantidad
            // 
            this.graphFechaCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.graphFechaCantidad.BackColor = System.Drawing.Color.Transparent;
            this.graphFechaCantidad.BorderlineColor = System.Drawing.Color.Transparent;
            this.graphFechaCantidad.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.graphFechaCantidad.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.graphFechaCantidad.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.graphFechaCantidad.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Gray;
            this.graphFechaCantidad.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.graphFechaCantidad.Legends.Add(legend2);
            this.graphFechaCantidad.Location = new System.Drawing.Point(62, 432);
            this.graphFechaCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graphFechaCantidad.Name = "graphFechaCantidad";
            this.graphFechaCantidad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.MediumPurple;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Transparent;
            series2.Name = "Facturas por día";
            this.graphFechaCantidad.Series.Add(series2);
            this.graphFechaCantidad.Size = new System.Drawing.Size(561, 314);
            this.graphFechaCantidad.TabIndex = 7;
            // 
            // lblTotalFacturas
            // 
            this.lblTotalFacturas.AutoSize = true;
            this.lblTotalFacturas.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFacturas.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFacturas.Location = new System.Drawing.Point(213, 31);
            this.lblTotalFacturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFacturas.Name = "lblTotalFacturas";
            this.lblTotalFacturas.Size = new System.Drawing.Size(25, 29);
            this.lblTotalFacturas.TabIndex = 6;
            this.lblTotalFacturas.Text = "..";
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.BackColor = System.Drawing.Color.Transparent;
            this.lblPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainText.ForeColor = System.Drawing.Color.Black;
            this.lblPlainText.Location = new System.Drawing.Point(24, 31);
            this.lblPlainText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(203, 29);
            this.lblPlainText.TabIndex = 5;
            this.lblPlainText.Text = "Total de facturas: ";
            // 
            // btn_design1
            // 
            this.btn_design1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_design1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_design1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_design1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_design1.BorderRadius = 0;
            this.btn_design1.BorderSize = 0;
            this.btn_design1.FlatAppearance.BorderSize = 0;
            this.btn_design1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_design1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_design1.ForeColor = System.Drawing.Color.White;
            this.btn_design1.Location = new System.Drawing.Point(904, 149);
            this.btn_design1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_design1.Name = "btn_design1";
            this.btn_design1.Size = new System.Drawing.Size(370, 154);
            this.btn_design1.TabIndex = 3;
            this.btn_design1.Text = "NOSE AYUDA";
            this.btn_design1.TextColor = System.Drawing.Color.White;
            this.btn_design1.UseVisualStyleBackColor = false;
            // 
            // btn_design
            // 
            this.btn_design.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_design.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_design.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_design.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_design.BorderRadius = 0;
            this.btn_design.BorderSize = 0;
            this.btn_design.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_design.FlatAppearance.BorderSize = 0;
            this.btn_design.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_design.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_design.ForeColor = System.Drawing.Color.White;
            this.btn_design.Location = new System.Drawing.Point(486, 149);
            this.btn_design.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_design.Name = "btn_design";
            this.btn_design.Size = new System.Drawing.Size(370, 154);
            this.btn_design.TabIndex = 2;
            this.btn_design.Text = "AJUSTES";
            this.btn_design.TextColor = System.Drawing.Color.White;
            this.btn_design.UseVisualStyleBackColor = false;
            this.btn_design.Click += new System.EventHandler(this.btn_design_Click);
            // 
            // btn_design_MostrarAll
            // 
            this.btn_design_MostrarAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_design_MostrarAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_design_MostrarAll.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_design_MostrarAll.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_design_MostrarAll.BorderRadius = 0;
            this.btn_design_MostrarAll.BorderSize = 0;
            this.btn_design_MostrarAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_design_MostrarAll.FlatAppearance.BorderSize = 0;
            this.btn_design_MostrarAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_design_MostrarAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_design_MostrarAll.ForeColor = System.Drawing.Color.White;
            this.btn_design_MostrarAll.Location = new System.Drawing.Point(62, 149);
            this.btn_design_MostrarAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_design_MostrarAll.Name = "btn_design_MostrarAll";
            this.btn_design_MostrarAll.Size = new System.Drawing.Size(370, 154);
            this.btn_design_MostrarAll.TabIndex = 0;
            this.btn_design_MostrarAll.Text = "MOSTRAR TODOS";
            this.btn_design_MostrarAll.TextColor = System.Drawing.Color.White;
            this.btn_design_MostrarAll.UseVisualStyleBackColor = false;
            this.btn_design_MostrarAll.Click += new System.EventHandler(this.btn_design1_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelShadow.Location = new System.Drawing.Point(330, 108);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1293, 14);
            this.panelShadow.TabIndex = 14;
            // 
            // FormPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 1001);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1356, 718);
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
            ((System.ComponentModel.ISupportInitialize)(this.graphFechaCantidad)).EndInit();
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
        private btn_design btn_design1;
        private btn_design btn_design;
        private System.Windows.Forms.Label lblTotalFacturas;
        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphFechaCantidad;
    }
}