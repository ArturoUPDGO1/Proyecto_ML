﻿
namespace Proyecto_ML
{
    partial class FormConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dateCOT_buscar = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtID_buscar = new System.Windows.Forms.TextBox();
            this.txtOT_buscar = new System.Windows.Forms.TextBox();
            this.cboxCIUDAD_buscar = new System.Windows.Forms.ComboBox();
            this.txtMON_buscar = new System.Windows.Forms.TextBox();
            this.cboxRS_buscar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtECO_buscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMCI_buscar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCON_buscar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNFAC_buscar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelConsulta);
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.MinimumSize = new System.Drawing.Size(900, 600);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(900, 600);
            this.panelContenedor.TabIndex = 11;
            // 
            // panelConsulta
            // 
            this.panelConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConsulta.BackColor = System.Drawing.Color.White;
            this.panelConsulta.Controls.Add(this.button1);
            this.panelConsulta.Controls.Add(this.dgvDatos);
            this.panelConsulta.Controls.Add(this.dateCOT_buscar);
            this.panelConsulta.Controls.Add(this.label8);
            this.panelConsulta.Controls.Add(this.button2);
            this.panelConsulta.Controls.Add(this.label19);
            this.panelConsulta.Controls.Add(this.txtID_buscar);
            this.panelConsulta.Controls.Add(this.txtOT_buscar);
            this.panelConsulta.Controls.Add(this.cboxCIUDAD_buscar);
            this.panelConsulta.Controls.Add(this.txtMON_buscar);
            this.panelConsulta.Controls.Add(this.cboxRS_buscar);
            this.panelConsulta.Controls.Add(this.label11);
            this.panelConsulta.Controls.Add(this.txtECO_buscar);
            this.panelConsulta.Controls.Add(this.label12);
            this.panelConsulta.Controls.Add(this.txtMCI_buscar);
            this.panelConsulta.Controls.Add(this.label13);
            this.panelConsulta.Controls.Add(this.txtCON_buscar);
            this.panelConsulta.Controls.Add(this.label14);
            this.panelConsulta.Controls.Add(this.txtNFAC_buscar);
            this.panelConsulta.Controls.Add(this.label15);
            this.panelConsulta.Controls.Add(this.label16);
            this.panelConsulta.Controls.Add(this.label17);
            this.panelConsulta.Controls.Add(this.label18);
            this.panelConsulta.Controls.Add(this.label21);
            this.panelConsulta.Location = new System.Drawing.Point(0, 0);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(900, 560);
            this.panelConsulta.TabIndex = 43;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.Location = new System.Drawing.Point(366, 20);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDatos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvDatos.Size = new System.Drawing.Size(522, 510);
            this.dgvDatos.TabIndex = 42;
            // 
            // dateCOT_buscar
            // 
            this.dateCOT_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateCOT_buscar.CustomFormat = "dd/MM/yyyy";
            this.dateCOT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCOT_buscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCOT_buscar.Location = new System.Drawing.Point(175, 214);
            this.dateCOT_buscar.Name = "dateCOT_buscar";
            this.dateCOT_buscar.Size = new System.Drawing.Size(185, 26);
            this.dateCOT_buscar.TabIndex = 41;
            this.dateCOT_buscar.Value = new System.DateTime(2022, 6, 2, 15, 43, 53, 0);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "PANEL DE BUSQUEDA";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(270, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(74, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 20);
            this.label19.TabIndex = 40;
            this.label19.Text = "ID Principal";
            // 
            // txtID_buscar
            // 
            this.txtID_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtID_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_buscar.Location = new System.Drawing.Point(175, 68);
            this.txtID_buscar.Name = "txtID_buscar";
            this.txtID_buscar.Size = new System.Drawing.Size(185, 26);
            this.txtID_buscar.TabIndex = 39;
            // 
            // txtOT_buscar
            // 
            this.txtOT_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOT_buscar.Location = new System.Drawing.Point(175, 105);
            this.txtOT_buscar.Name = "txtOT_buscar";
            this.txtOT_buscar.Size = new System.Drawing.Size(185, 26);
            this.txtOT_buscar.TabIndex = 0;
            // 
            // cboxCIUDAD_buscar
            // 
            this.cboxCIUDAD_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxCIUDAD_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCIUDAD_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCIUDAD_buscar.FormattingEnabled = true;
            this.cboxCIUDAD_buscar.Items.AddRange(new object[] {
            "Chihuahua",
            "Monterrey",
            "Durango"});
            this.cboxCIUDAD_buscar.Location = new System.Drawing.Point(175, 409);
            this.cboxCIUDAD_buscar.Name = "cboxCIUDAD_buscar";
            this.cboxCIUDAD_buscar.Size = new System.Drawing.Size(185, 28);
            this.cboxCIUDAD_buscar.TabIndex = 20;
            // 
            // txtMON_buscar
            // 
            this.txtMON_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMON_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMON_buscar.Location = new System.Drawing.Point(175, 179);
            this.txtMON_buscar.Name = "txtMON_buscar";
            this.txtMON_buscar.Size = new System.Drawing.Size(185, 26);
            this.txtMON_buscar.TabIndex = 5;
            // 
            // cboxRS_buscar
            // 
            this.cboxRS_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxRS_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRS_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRS_buscar.FormattingEnabled = true;
            this.cboxRS_buscar.Items.AddRange(new object[] {
            "General Carriers",
            "Enlaces Terrestres Next"});
            this.cboxRS_buscar.Location = new System.Drawing.Point(175, 253);
            this.cboxRS_buscar.Name = "cboxRS_buscar";
            this.cboxRS_buscar.Size = new System.Drawing.Size(185, 28);
            this.cboxRS_buscar.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Fecha de cotización";
            // 
            // txtECO_buscar
            // 
            this.txtECO_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtECO_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtECO_buscar.Location = new System.Drawing.Point(175, 142);
            this.txtECO_buscar.Name = "txtECO_buscar";
            this.txtECO_buscar.Size = new System.Drawing.Size(185, 26);
            this.txtECO_buscar.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Razón social";
            // 
            // txtMCI_buscar
            // 
            this.txtMCI_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMCI_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCI_buscar.Location = new System.Drawing.Point(175, 448);
            this.txtMCI_buscar.Name = "txtMCI_buscar";
            this.txtMCI_buscar.Size = new System.Drawing.Size(185, 26);
            this.txtMCI_buscar.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Monto con Impuesto";
            // 
            // txtCON_buscar
            // 
            this.txtCON_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCON_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCON_buscar.Location = new System.Drawing.Point(175, 329);
            this.txtCON_buscar.Multiline = true;
            this.txtCON_buscar.Name = "txtCON_buscar";
            this.txtCON_buscar.Size = new System.Drawing.Size(185, 69);
            this.txtCON_buscar.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(104, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Ciudad";
            // 
            // txtNFAC_buscar
            // 
            this.txtNFAC_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNFAC_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFAC_buscar.Location = new System.Drawing.Point(175, 294);
            this.txtNFAC_buscar.Name = "txtNFAC_buscar";
            this.txtNFAC_buscar.Size = new System.Drawing.Size(185, 26);
            this.txtNFAC_buscar.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(77, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Conceptos";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "Orden de Trabajo";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(58, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 20);
            this.label17.TabIndex = 12;
            this.label17.Text = "Num. Factura";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(109, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 20);
            this.label18.TabIndex = 10;
            this.label18.Text = "Monto";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(34, 145);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(129, 20);
            this.label21.TabIndex = 11;
            this.label21.Text = "Num. Económico";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "FormConsulta";
            this.Text = "Buscar Registro";
            this.panelContenedor.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.DateTimePicker dateCOT_buscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtID_buscar;
        private System.Windows.Forms.TextBox txtOT_buscar;
        private System.Windows.Forms.ComboBox cboxCIUDAD_buscar;
        private System.Windows.Forms.TextBox txtMON_buscar;
        private System.Windows.Forms.ComboBox cboxRS_buscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtECO_buscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMCI_buscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCON_buscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNFAC_buscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button button1;
    }
}

