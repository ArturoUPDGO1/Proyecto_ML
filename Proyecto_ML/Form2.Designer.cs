
namespace Proyecto_ML
{
    partial class Form2
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.cerrarBtn = new System.Windows.Forms.Button();
            this.miniBtn = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1100, 600);
            this.panelContenedor.TabIndex = 0;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelBarraTitulo.Controls.Add(this.miniBtn);
            this.panelBarraTitulo.Controls.Add(this.cerrarBtn);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1100, 40);
            this.panelBarraTitulo.TabIndex = 1;
            // 
            // cerrarBtn
            // 
            this.cerrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarBtn.BackColor = System.Drawing.Color.Red;
            this.cerrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarBtn.FlatAppearance.BorderSize = 0;
            this.cerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarBtn.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold);
            this.cerrarBtn.ForeColor = System.Drawing.Color.White;
            this.cerrarBtn.Location = new System.Drawing.Point(1075, 9);
            this.cerrarBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cerrarBtn.Name = "cerrarBtn";
            this.cerrarBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cerrarBtn.Size = new System.Drawing.Size(16, 16);
            this.cerrarBtn.TabIndex = 0;
            this.cerrarBtn.Text = "X";
            this.cerrarBtn.UseVisualStyleBackColor = false;
            this.cerrarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // miniBtn
            // 
            this.miniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBtn.BackColor = System.Drawing.Color.Gray;
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miniBtn.FlatAppearance.BorderSize = 0;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.miniBtn.ForeColor = System.Drawing.Color.White;
            this.miniBtn.Location = new System.Drawing.Point(1054, 9);
            this.miniBtn.Margin = new System.Windows.Forms.Padding(0);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.miniBtn.Size = new System.Drawing.Size(16, 16);
            this.miniBtn.TabIndex = 1;
            this.miniBtn.Text = "-";
            this.miniBtn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panelContenedor.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button cerrarBtn;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Button miniBtn;
    }
}