namespace Clase1404
{
    partial class frmAgregar
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
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.mrcAgregar = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.lstCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmcCantidad = new System.Windows.Forms.NumericUpDown();
            this.mrcAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(108, 43);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(152, 20);
            this.txtProducto.TabIndex = 0;
            // 
            // mrcAgregar
            // 
            this.mrcAgregar.Controls.Add(this.nmcCantidad);
            this.mrcAgregar.Controls.Add(this.cmdAgregar);
            this.mrcAgregar.Controls.Add(this.lstCategoria);
            this.mrcAgregar.Controls.Add(this.label3);
            this.mrcAgregar.Controls.Add(this.label2);
            this.mrcAgregar.Controls.Add(this.label1);
            this.mrcAgregar.Controls.Add(this.txtProducto);
            this.mrcAgregar.Location = new System.Drawing.Point(12, 12);
            this.mrcAgregar.Name = "mrcAgregar";
            this.mrcAgregar.Size = new System.Drawing.Size(271, 161);
            this.mrcAgregar.TabIndex = 1;
            this.mrcAgregar.TabStop = false;
            this.mrcAgregar.Text = "Agregar";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(91, 122);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // lstCategoria
            // 
            this.lstCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCategoria.FormattingEnabled = true;
            this.lstCategoria.Items.AddRange(new object[] {
            "Cocina",
            "Frio",
            "Limpieza",
            "Baño"});
            this.lstCategoria.Location = new System.Drawing.Point(108, 69);
            this.lstCategoria.Name = "lstCategoria";
            this.lstCategoria.Size = new System.Drawing.Size(152, 21);
            this.lstCategoria.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // nmcCantidad
            // 
            this.nmcCantidad.Location = new System.Drawing.Point(108, 97);
            this.nmcCantidad.Name = "nmcCantidad";
            this.nmcCantidad.Size = new System.Drawing.Size(152, 20);
            this.nmcCantidad.TabIndex = 7;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 182);
            this.Controls.Add(this.mrcAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen";
            this.mrcAgregar.ResumeLayout(false);
            this.mrcAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.GroupBox mrcAgregar;
        private System.Windows.Forms.ComboBox lstCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.NumericUpDown nmcCantidad;
    }
}