namespace Clase1404
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.cmdComida = new System.Windows.Forms.PictureBox();
            this.cmdLimpieza = new System.Windows.Forms.PictureBox();
            this.cmdFrio = new System.Windows.Forms.PictureBox();
            this.cmdBano = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdVerTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cmdComida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdLimpieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdFrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBano)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdComida
            // 
            this.cmdComida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdComida.Image = ((System.Drawing.Image)(resources.GetObject("cmdComida.Image")));
            this.cmdComida.Location = new System.Drawing.Point(2, 77);
            this.cmdComida.Name = "cmdComida";
            this.cmdComida.Size = new System.Drawing.Size(179, 164);
            this.cmdComida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdComida.TabIndex = 0;
            this.cmdComida.TabStop = false;
            this.cmdComida.Click += new System.EventHandler(this.cmdComida_Click);
            // 
            // cmdLimpieza
            // 
            this.cmdLimpieza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLimpieza.Image = ((System.Drawing.Image)(resources.GetObject("cmdLimpieza.Image")));
            this.cmdLimpieza.Location = new System.Drawing.Point(2, 247);
            this.cmdLimpieza.Name = "cmdLimpieza";
            this.cmdLimpieza.Size = new System.Drawing.Size(179, 164);
            this.cmdLimpieza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdLimpieza.TabIndex = 1;
            this.cmdLimpieza.TabStop = false;
            this.cmdLimpieza.Click += new System.EventHandler(this.cmdLimpieza_Click);
            // 
            // cmdFrio
            // 
            this.cmdFrio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdFrio.Image = ((System.Drawing.Image)(resources.GetObject("cmdFrio.Image")));
            this.cmdFrio.Location = new System.Drawing.Point(187, 77);
            this.cmdFrio.Name = "cmdFrio";
            this.cmdFrio.Size = new System.Drawing.Size(179, 164);
            this.cmdFrio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdFrio.TabIndex = 2;
            this.cmdFrio.TabStop = false;
            this.cmdFrio.Click += new System.EventHandler(this.cmdFrio_Click);
            // 
            // cmdBano
            // 
            this.cmdBano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBano.Image = ((System.Drawing.Image)(resources.GetObject("cmdBano.Image")));
            this.cmdBano.Location = new System.Drawing.Point(187, 248);
            this.cmdBano.Name = "cmdBano";
            this.cmdBano.Size = new System.Drawing.Size(179, 164);
            this.cmdBano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdBano.TabIndex = 3;
            this.cmdBano.TabStop = false;
            this.cmdBano.Click += new System.EventHandler(this.cmdBano_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "ALMACEN";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(147, 446);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 5;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdVerTodo
            // 
            this.cmdVerTodo.Location = new System.Drawing.Point(147, 417);
            this.cmdVerTodo.Name = "cmdVerTodo";
            this.cmdVerTodo.Size = new System.Drawing.Size(75, 23);
            this.cmdVerTodo.TabIndex = 6;
            this.cmdVerTodo.Text = "Ver Todo";
            this.cmdVerTodo.UseVisualStyleBackColor = true;
            this.cmdVerTodo.Click += new System.EventHandler(this.cmdVerTodo_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 474);
            this.Controls.Add(this.cmdVerTodo);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.cmdBano);
            this.Controls.Add(this.cmdFrio);
            this.Controls.Add(this.cmdLimpieza);
            this.Controls.Add(this.cmdComida);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.cmdComida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdLimpieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdFrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cmdComida;
        private System.Windows.Forms.PictureBox cmdLimpieza;
        private System.Windows.Forms.PictureBox cmdFrio;
        private System.Windows.Forms.PictureBox cmdBano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdVerTodo;
    }
}