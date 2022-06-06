
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
            this.btn_design2 = new Proyecto_ML.btn_design();
            this.btn_design1 = new Proyecto_ML.btn_design();
            this.btn_design = new Proyecto_ML.btn_design();
            this.btn_design_MostrarAll = new Proyecto_ML.btn_design();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
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
            this.panelMenu.Size = new System.Drawing.Size(220, 678);
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(916, 70);
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
            this.btnMin.Location = new System.Drawing.Point(826, 0);
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
            this.btnMax.Location = new System.Drawing.Point(856, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(886, 0);
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
            this.lblTitleChildForm.Location = new System.Drawing.Point(73, 20);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(117, 42);
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
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(27, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktop.BackgroundImage = global::Proyecto_ML.Properties.Resources.fondo_prin_figures;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Controls.Add(this.btn_design2);
            this.panelDesktop.Controls.Add(this.btn_design1);
            this.panelDesktop.Controls.Add(this.btn_design);
            this.panelDesktop.Controls.Add(this.btn_design_MostrarAll);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 79);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(916, 599);
            this.panelDesktop.TabIndex = 15;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // btn_design2
            // 
            this.btn_design2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_design2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_design2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_design2.BorderRadius = 10;
            this.btn_design2.BorderSize = 0;
            this.btn_design2.FlatAppearance.BorderSize = 0;
            this.btn_design2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_design2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_design2.ForeColor = System.Drawing.Color.White;
            this.btn_design2.Location = new System.Drawing.Point(106, 267);
            this.btn_design2.Name = "btn_design2";
            this.btn_design2.Size = new System.Drawing.Size(247, 128);
            this.btn_design2.TabIndex = 4;
            this.btn_design2.Text = "NOSE AYUDA";
            this.btn_design2.TextColor = System.Drawing.Color.White;
            this.btn_design2.UseVisualStyleBackColor = false;
            this.btn_design2.Visible = false;
            // 
            // btn_design1
            // 
            this.btn_design1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_design1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_design1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_design1.BorderRadius = 10;
            this.btn_design1.BorderSize = 0;
            this.btn_design1.FlatAppearance.BorderSize = 0;
            this.btn_design1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_design1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_design1.ForeColor = System.Drawing.Color.White;
            this.btn_design1.Location = new System.Drawing.Point(428, 267);
            this.btn_design1.Name = "btn_design1";
            this.btn_design1.Size = new System.Drawing.Size(247, 128);
            this.btn_design1.TabIndex = 3;
            this.btn_design1.Text = "NOSE AYUDA";
            this.btn_design1.TextColor = System.Drawing.Color.White;
            this.btn_design1.UseVisualStyleBackColor = false;
            this.btn_design1.Visible = false;
            // 
            // btn_design
            // 
            this.btn_design.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_design.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_design.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_design.BorderRadius = 10;
            this.btn_design.BorderSize = 0;
            this.btn_design.FlatAppearance.BorderSize = 0;
            this.btn_design.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_design.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_design.ForeColor = System.Drawing.Color.White;
            this.btn_design.Location = new System.Drawing.Point(428, 88);
            this.btn_design.Name = "btn_design";
            this.btn_design.Size = new System.Drawing.Size(247, 128);
            this.btn_design.TabIndex = 2;
            this.btn_design.Text = "NOSE AYUDA";
            this.btn_design.TextColor = System.Drawing.Color.White;
            this.btn_design.UseVisualStyleBackColor = false;
            this.btn_design.Visible = false;
            // 
            // btn_design_MostrarAll
            // 
            this.btn_design_MostrarAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_design_MostrarAll.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_design_MostrarAll.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_design_MostrarAll.BorderRadius = 10;
            this.btn_design_MostrarAll.BorderSize = 0;
            this.btn_design_MostrarAll.FlatAppearance.BorderSize = 0;
            this.btn_design_MostrarAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_design_MostrarAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_design_MostrarAll.ForeColor = System.Drawing.Color.White;
            this.btn_design_MostrarAll.Location = new System.Drawing.Point(106, 88);
            this.btn_design_MostrarAll.Name = "btn_design_MostrarAll";
            this.btn_design_MostrarAll.Size = new System.Drawing.Size(247, 128);
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
            this.panelShadow.Location = new System.Drawing.Point(220, 70);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(916, 9);
            this.panelShadow.TabIndex = 14;
            // 
            // FormPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 678);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1136, 678);
            this.Name = "FormPricipal";
            this.Text = "Form Principal";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
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
        private btn_design btn_design2;
        private btn_design btn_design1;
        private btn_design btn_design;
    }
}