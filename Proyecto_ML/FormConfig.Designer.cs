
namespace Proyecto_ML
{
    partial class FormConfig
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
            this.panelConfig = new System.Windows.Forms.Panel();
            this.btnConfirmAll = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.panelConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConfig
            // 
            this.panelConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConfig.Controls.Add(this.btnConfirmAll);
            this.panelConfig.Controls.Add(this.btnSelectFolder);
            this.panelConfig.Controls.Add(this.label1);
            this.panelConfig.Controls.Add(this.txtFilePath);
            this.panelConfig.Location = new System.Drawing.Point(0, 0);
            this.panelConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(533, 292);
            this.panelConfig.TabIndex = 0;
            // 
            // btnConfirmAll
            // 
            this.btnConfirmAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmAll.AutoSize = true;
            this.btnConfirmAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnConfirmAll.FlatAppearance.BorderSize = 0;
            this.btnConfirmAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btnConfirmAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnConfirmAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAll.ForeColor = System.Drawing.Color.White;
            this.btnConfirmAll.Location = new System.Drawing.Point(397, 248);
            this.btnConfirmAll.MaximumSize = new System.Drawing.Size(128, 35);
            this.btnConfirmAll.MinimumSize = new System.Drawing.Size(128, 35);
            this.btnConfirmAll.Name = "btnConfirmAll";
            this.btnConfirmAll.Size = new System.Drawing.Size(128, 35);
            this.btnConfirmAll.TabIndex = 47;
            this.btnConfirmAll.Text = "Confirmar Todo";
            this.btnConfirmAll.UseVisualStyleBackColor = false;
            this.btnConfirmAll.Click += new System.EventHandler(this.btnConfirmAll_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.AutoSize = true;
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnSelectFolder.FlatAppearance.BorderSize = 0;
            this.btnSelectFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btnSelectFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.ForeColor = System.Drawing.Color.White;
            this.btnSelectFolder.Location = new System.Drawing.Point(347, 45);
            this.btnSelectFolder.MinimumSize = new System.Drawing.Size(158, 25);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(160, 34);
            this.btnSelectFolder.TabIndex = 46;
            this.btnSelectFolder.Text = "Seleccionar carpeta";
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directorio de archivos";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(33, 49);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(309, 26);
            this.txtFilePath.TabIndex = 0;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panelConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormConfig";
            this.Text = "Ajustes";
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnConfirmAll;
        private System.Windows.Forms.Button btnSelectFolder;
    }
}