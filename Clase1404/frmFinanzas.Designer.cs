namespace Clase1404
{
    partial class frmFinanzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanzas));
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mrcSaldo = new System.Windows.Forms.GroupBox();
            this.mrcGastosFijos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGastoFijo = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.mrcEgresos = new System.Windows.Forms.GroupBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtSalidas = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mrcIngresos = new System.Windows.Forms.GroupBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.mrcSaldo.SuspendLayout();
            this.mrcGastosFijos.SuspendLayout();
            this.mrcEgresos.SuspendLayout();
            this.mrcIngresos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGrabar.ForeColor = System.Drawing.Color.Black;
            this.cmdGrabar.Location = new System.Drawing.Point(35, 431);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(93, 33);
            this.cmdGrabar.TabIndex = 0;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deposito $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alquiler $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Impuestos $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salidas $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(106, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(177, 495);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 19);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "________";
            // 
            // mrcSaldo
            // 
            this.mrcSaldo.BackColor = System.Drawing.Color.Transparent;
            this.mrcSaldo.Controls.Add(this.mrcGastosFijos);
            this.mrcSaldo.Controls.Add(this.cmdCancelar);
            this.mrcSaldo.Controls.Add(this.mrcEgresos);
            this.mrcSaldo.Controls.Add(this.lblTotal);
            this.mrcSaldo.Controls.Add(this.mrcIngresos);
            this.mrcSaldo.Controls.Add(this.cmdGrabar);
            this.mrcSaldo.Controls.Add(this.label5);
            this.mrcSaldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcSaldo.ForeColor = System.Drawing.Color.Black;
            this.mrcSaldo.Location = new System.Drawing.Point(12, 12);
            this.mrcSaldo.Name = "mrcSaldo";
            this.mrcSaldo.Size = new System.Drawing.Size(324, 532);
            this.mrcSaldo.TabIndex = 11;
            this.mrcSaldo.TabStop = false;
            this.mrcSaldo.Text = "Saldo";
            // 
            // mrcGastosFijos
            // 
            this.mrcGastosFijos.BackColor = System.Drawing.Color.Transparent;
            this.mrcGastosFijos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mrcGastosFijos.Controls.Add(this.label6);
            this.mrcGastosFijos.Controls.Add(this.txtGastoFijo);
            this.mrcGastosFijos.ForeColor = System.Drawing.Color.Black;
            this.mrcGastosFijos.Location = new System.Drawing.Point(9, 325);
            this.mrcGastosFijos.Name = "mrcGastosFijos";
            this.mrcGastosFijos.Size = new System.Drawing.Size(304, 100);
            this.mrcGastosFijos.TabIndex = 18;
            this.mrcGastosFijos.TabStop = false;
            this.mrcGastosFijos.Text = "Gastos fijos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gastos $";
            // 
            // txtGastoFijo
            // 
            this.txtGastoFijo.BackColor = System.Drawing.Color.White;
            this.txtGastoFijo.Location = new System.Drawing.Point(117, 47);
            this.txtGastoFijo.Name = "txtGastoFijo";
            this.txtGastoFijo.Size = new System.Drawing.Size(181, 27);
            this.txtGastoFijo.TabIndex = 12;
            this.txtGastoFijo.Text = "0";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCancelar.ForeColor = System.Drawing.Color.Black;
            this.cmdCancelar.Location = new System.Drawing.Point(198, 431);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(93, 33);
            this.cmdCancelar.TabIndex = 19;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // mrcEgresos
            // 
            this.mrcEgresos.BackColor = System.Drawing.Color.Transparent;
            this.mrcEgresos.Controls.Add(this.txtComida);
            this.mrcEgresos.Controls.Add(this.label2);
            this.mrcEgresos.Controls.Add(this.txtSalidas);
            this.mrcEgresos.Controls.Add(this.label3);
            this.mrcEgresos.Controls.Add(this.txtImpuestos);
            this.mrcEgresos.Controls.Add(this.label4);
            this.mrcEgresos.Controls.Add(this.txtAlquiler);
            this.mrcEgresos.Controls.Add(this.label7);
            this.mrcEgresos.ForeColor = System.Drawing.Color.Black;
            this.mrcEgresos.Location = new System.Drawing.Point(9, 132);
            this.mrcEgresos.Name = "mrcEgresos";
            this.mrcEgresos.Size = new System.Drawing.Size(304, 187);
            this.mrcEgresos.TabIndex = 18;
            this.mrcEgresos.TabStop = false;
            this.mrcEgresos.Text = "Egresos";
            // 
            // txtComida
            // 
            this.txtComida.BackColor = System.Drawing.Color.White;
            this.txtComida.Location = new System.Drawing.Point(117, 143);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(181, 27);
            this.txtComida.TabIndex = 16;
            this.txtComida.Text = "0";
            // 
            // txtSalidas
            // 
            this.txtSalidas.BackColor = System.Drawing.Color.White;
            this.txtSalidas.Location = new System.Drawing.Point(116, 112);
            this.txtSalidas.Name = "txtSalidas";
            this.txtSalidas.Size = new System.Drawing.Size(181, 27);
            this.txtSalidas.TabIndex = 15;
            this.txtSalidas.Text = "0";
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.BackColor = System.Drawing.Color.White;
            this.txtImpuestos.Location = new System.Drawing.Point(117, 77);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(181, 27);
            this.txtImpuestos.TabIndex = 14;
            this.txtImpuestos.Text = "0";
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.BackColor = System.Drawing.Color.White;
            this.txtAlquiler.Location = new System.Drawing.Point(117, 42);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(181, 27);
            this.txtAlquiler.TabIndex = 13;
            this.txtAlquiler.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Comida $";
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.Controls.Add(this.label1);
            this.mrcIngresos.Controls.Add(this.txtDeposito);
            this.mrcIngresos.ForeColor = System.Drawing.Color.Black;
            this.mrcIngresos.Location = new System.Drawing.Point(9, 26);
            this.mrcIngresos.Name = "mrcIngresos";
            this.mrcIngresos.Size = new System.Drawing.Size(304, 100);
            this.mrcIngresos.TabIndex = 17;
            this.mrcIngresos.TabStop = false;
            this.mrcIngresos.Text = "Ingresos";
            // 
            // txtDeposito
            // 
            this.txtDeposito.BackColor = System.Drawing.Color.White;
            this.txtDeposito.Location = new System.Drawing.Point(117, 47);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(181, 27);
            this.txtDeposito.TabIndex = 12;
            this.txtDeposito.Text = "0";
            // 
            // frmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 553);
            this.Controls.Add(this.mrcSaldo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFinanzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Gastos Mensuales";
            this.mrcSaldo.ResumeLayout(false);
            this.mrcSaldo.PerformLayout();
            this.mrcGastosFijos.ResumeLayout(false);
            this.mrcGastosFijos.PerformLayout();
            this.mrcEgresos.ResumeLayout(false);
            this.mrcEgresos.PerformLayout();
            this.mrcIngresos.ResumeLayout(false);
            this.mrcIngresos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox mrcSaldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtSalidas;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.GroupBox mrcEgresos;
        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.GroupBox mrcGastosFijos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGastoFijo;
    }
}

