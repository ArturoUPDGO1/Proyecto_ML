
namespace Proyecto_ML
{
    partial class FormUpdateDelete
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelRegistrar = new System.Windows.Forms.Panel();
            this.cboxEst_update = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtID_update = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.dateCOT_update = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtOT_update = new System.Windows.Forms.TextBox();
            this.cboxCIUDAD_update = new System.Windows.Forms.ComboBox();
            this.txtMON_update = new System.Windows.Forms.TextBox();
            this.cboxRS_update = new System.Windows.Forms.ComboBox();
            this.txtNFAC_update = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtECO_update = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMCI_update = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCON_update = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.panelRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelRegistrar);
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.MinimumSize = new System.Drawing.Size(530, 500);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(530, 500);
            this.panelContenedor.TabIndex = 11;
            // 
            // panelRegistrar
            // 
            this.panelRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRegistrar.BackColor = System.Drawing.Color.White;
            this.panelRegistrar.Controls.Add(this.cboxEst_update);
            this.panelRegistrar.Controls.Add(this.label8);
            this.panelRegistrar.Controls.Add(this.label19);
            this.panelRegistrar.Controls.Add(this.txtID_update);
            this.panelRegistrar.Controls.Add(this.btnPreview);
            this.panelRegistrar.Controls.Add(this.dateCOT_update);
            this.panelRegistrar.Controls.Add(this.btnGuardar);
            this.panelRegistrar.Controls.Add(this.txtOT_update);
            this.panelRegistrar.Controls.Add(this.cboxCIUDAD_update);
            this.panelRegistrar.Controls.Add(this.txtMON_update);
            this.panelRegistrar.Controls.Add(this.cboxRS_update);
            this.panelRegistrar.Controls.Add(this.txtNFAC_update);
            this.panelRegistrar.Controls.Add(this.label10);
            this.panelRegistrar.Controls.Add(this.txtECO_update);
            this.panelRegistrar.Controls.Add(this.label9);
            this.panelRegistrar.Controls.Add(this.txtMCI_update);
            this.panelRegistrar.Controls.Add(this.label7);
            this.panelRegistrar.Controls.Add(this.txtCON_update);
            this.panelRegistrar.Controls.Add(this.label6);
            this.panelRegistrar.Controls.Add(this.label5);
            this.panelRegistrar.Controls.Add(this.label1);
            this.panelRegistrar.Controls.Add(this.label4);
            this.panelRegistrar.Controls.Add(this.label2);
            this.panelRegistrar.Controls.Add(this.label3);
            this.panelRegistrar.Location = new System.Drawing.Point(0, 0);
            this.panelRegistrar.MinimumSize = new System.Drawing.Size(420, 500);
            this.panelRegistrar.Name = "panelRegistrar";
            this.panelRegistrar.Size = new System.Drawing.Size(420, 500);
            this.panelRegistrar.TabIndex = 23;
            // 
            // cboxEst_update
            // 
            this.cboxEst_update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxEst_update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEst_update.Enabled = false;
            this.cboxEst_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEst_update.FormattingEnabled = true;
            this.cboxEst_update.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Mostrar todos"});
            this.cboxEst_update.Location = new System.Drawing.Point(196, 418);
            this.cboxEst_update.Name = "cboxEst_update";
            this.cboxEst_update.Size = new System.Drawing.Size(185, 28);
            this.cboxEst_update.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Estatus del Registro";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(98, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 20);
            this.label19.TabIndex = 45;
            this.label19.Text = "ID Principal";
            // 
            // txtID_update
            // 
            this.txtID_update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtID_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_update.Location = new System.Drawing.Point(196, 20);
            this.txtID_update.Name = "txtID_update";
            this.txtID_update.Size = new System.Drawing.Size(185, 26);
            this.txtID_update.TabIndex = 44;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPreview.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreview.Location = new System.Drawing.Point(36, 456);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(149, 35);
            this.btnPreview.TabIndex = 43;
            this.btnPreview.Text = "PREVISUALIZAR";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dateCOT_update
            // 
            this.dateCOT_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateCOT_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateCOT_update.Enabled = false;
            this.dateCOT_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCOT_update.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCOT_update.Location = new System.Drawing.Point(196, 168);
            this.dateCOT_update.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateCOT_update.Name = "dateCOT_update";
            this.dateCOT_update.Size = new System.Drawing.Size(185, 26);
            this.dateCOT_update.TabIndex = 42;
            this.dateCOT_update.Value = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dateCOT_update.ValueChanged += new System.EventHandler(this.dateCOT_updel_ValueChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(259, 456);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 35);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "ACTUALIZAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtOT_update
            // 
            this.txtOT_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtOT_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOT_update.Location = new System.Drawing.Point(196, 57);
            this.txtOT_update.Name = "txtOT_update";
            this.txtOT_update.Size = new System.Drawing.Size(185, 26);
            this.txtOT_update.TabIndex = 0;
            this.txtOT_update.TextChanged += new System.EventHandler(this.txtOT_updel_TextChanged);
            // 
            // cboxCIUDAD_update
            // 
            this.cboxCIUDAD_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboxCIUDAD_update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCIUDAD_update.Enabled = false;
            this.cboxCIUDAD_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCIUDAD_update.FormattingEnabled = true;
            this.cboxCIUDAD_update.Items.AddRange(new object[] {
            "Chihuahua",
            "Monterrey",
            "Durango"});
            this.cboxCIUDAD_update.Location = new System.Drawing.Point(196, 344);
            this.cboxCIUDAD_update.Name = "cboxCIUDAD_update";
            this.cboxCIUDAD_update.Size = new System.Drawing.Size(185, 28);
            this.cboxCIUDAD_update.TabIndex = 20;
            // 
            // txtMON_update
            // 
            this.txtMON_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMON_update.Enabled = false;
            this.txtMON_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMON_update.Location = new System.Drawing.Point(196, 131);
            this.txtMON_update.Name = "txtMON_update";
            this.txtMON_update.Size = new System.Drawing.Size(185, 26);
            this.txtMON_update.TabIndex = 5;
            this.txtMON_update.TextChanged += new System.EventHandler(this.txtMON_updel_TextChanged);
            // 
            // cboxRS_update
            // 
            this.cboxRS_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboxRS_update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRS_update.Enabled = false;
            this.cboxRS_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRS_update.FormattingEnabled = true;
            this.cboxRS_update.Items.AddRange(new object[] {
            "General Carriers",
            "Enlaces Terrestres Next"});
            this.cboxRS_update.Location = new System.Drawing.Point(196, 205);
            this.cboxRS_update.Name = "cboxRS_update";
            this.cboxRS_update.Size = new System.Drawing.Size(185, 28);
            this.cboxRS_update.TabIndex = 19;
            this.cboxRS_update.SelectedIndexChanged += new System.EventHandler(this.cboxRS_reg_SelectedIndexChanged);
            // 
            // txtNFAC_update
            // 
            this.txtNFAC_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNFAC_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFAC_update.Location = new System.Drawing.Point(196, 244);
            this.txtNFAC_update.Name = "txtNFAC_update";
            this.txtNFAC_update.Size = new System.Drawing.Size(185, 26);
            this.txtNFAC_update.TabIndex = 3;
            this.txtNFAC_update.TextChanged += new System.EventHandler(this.txtNFAC_reg_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha de cotización";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtECO_update
            // 
            this.txtECO_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtECO_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtECO_update.Location = new System.Drawing.Point(196, 94);
            this.txtECO_update.Name = "txtECO_update";
            this.txtECO_update.Size = new System.Drawing.Size(185, 26);
            this.txtECO_update.TabIndex = 6;
            this.txtECO_update.TextChanged += new System.EventHandler(this.txtECO_updel_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Razón social";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // txtMCI_update
            // 
            this.txtMCI_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMCI_update.Enabled = false;
            this.txtMCI_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCI_update.Location = new System.Drawing.Point(196, 383);
            this.txtMCI_update.Name = "txtMCI_update";
            this.txtMCI_update.Size = new System.Drawing.Size(185, 26);
            this.txtMCI_update.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Monto con Impuesto";
            // 
            // txtCON_update
            // 
            this.txtCON_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCON_update.Enabled = false;
            this.txtCON_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCON_update.Location = new System.Drawing.Point(196, 281);
            this.txtCON_update.Multiline = true;
            this.txtCON_update.Name = "txtCON_update";
            this.txtCON_update.Size = new System.Drawing.Size(185, 52);
            this.txtCON_update.TabIndex = 8;
            this.txtCON_update.TextChanged += new System.EventHandler(this.txtCON_reg_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Conceptos";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Orden de Trabajo";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Num. Factura";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Monto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Num. Económico";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // FormUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 500);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "FormUpdateDelete";
            this.Text = "Agregar Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelRegistrar.ResumeLayout(false);
            this.panelRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelRegistrar;
        private System.Windows.Forms.DateTimePicker dateCOT_update;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtOT_update;
        private System.Windows.Forms.ComboBox cboxCIUDAD_update;
        private System.Windows.Forms.TextBox txtMON_update;
        private System.Windows.Forms.ComboBox cboxRS_update;
        private System.Windows.Forms.TextBox txtNFAC_update;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtECO_update;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMCI_update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCON_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtID_update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxEst_update;
    }
}

