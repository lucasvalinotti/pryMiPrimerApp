namespace Clase1404
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmdFinanzas = new System.Windows.Forms.Button();
            this.cmdAlmacen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdFinanzas
            // 
            this.cmdFinanzas.Location = new System.Drawing.Point(30, 137);
            this.cmdFinanzas.Name = "cmdFinanzas";
            this.cmdFinanzas.Size = new System.Drawing.Size(168, 301);
            this.cmdFinanzas.TabIndex = 0;
            this.cmdFinanzas.Text = "Finanzas";
            this.cmdFinanzas.UseVisualStyleBackColor = true;
            this.cmdFinanzas.Click += new System.EventHandler(this.cmdFinanzas_Click);
            // 
            // cmdAlmacen
            // 
            this.cmdAlmacen.Location = new System.Drawing.Point(219, 137);
            this.cmdAlmacen.Name = "cmdAlmacen";
            this.cmdAlmacen.Size = new System.Drawing.Size(168, 301);
            this.cmdAlmacen.TabIndex = 1;
            this.cmdAlmacen.Text = "Almacen";
            this.cmdAlmacen.UseVisualStyleBackColor = true;
            this.cmdAlmacen.Click += new System.EventHandler(this.cmdAlmacen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion Personal";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAlmacen);
            this.Controls.Add(this.cmdFinanzas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdFinanzas;
        private System.Windows.Forms.Button cmdAlmacen;
        private System.Windows.Forms.Label label1;
    }
}