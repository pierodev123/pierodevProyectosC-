namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalProductos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.numINKA = new System.Windows.Forms.NumericUpDown();
            this.numCOCA = new System.Windows.Forms.NumericUpDown();
            this.numGloria = new System.Windows.Forms.NumericUpDown();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSinIGV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numINKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCOCA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGloria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bodega  X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inka Cola :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coca Cola :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Leche Gloria :";
            // 
            // txtTotalProductos
            // 
            this.txtTotalProductos.Location = new System.Drawing.Point(432, 105);
            this.txtTotalProductos.Name = "txtTotalProductos";
            this.txtTotalProductos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalProductos.TabIndex = 8;
            this.txtTotalProductos.TextChanged += new System.EventHandler(this.txtTotalProductos_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "N° Total de productos :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "IGV :";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(432, 166);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(100, 20);
            this.txtIGV.TabIndex = 10;
            this.txtIGV.TextChanged += new System.EventHandler(this.txtIGV_TextChanged);
            // 
            // numINKA
            // 
            this.numINKA.Location = new System.Drawing.Point(90, 109);
            this.numINKA.Name = "numINKA";
            this.numINKA.Size = new System.Drawing.Size(120, 20);
            this.numINKA.TabIndex = 11;
            this.numINKA.ValueChanged += new System.EventHandler(this.numINKA_ValueChanged);
            // 
            // numCOCA
            // 
            this.numCOCA.Location = new System.Drawing.Point(90, 147);
            this.numCOCA.Name = "numCOCA";
            this.numCOCA.Size = new System.Drawing.Size(120, 20);
            this.numCOCA.TabIndex = 12;
            this.numCOCA.ValueChanged += new System.EventHandler(this.numCOCA_ValueChanged);
            // 
            // numGloria
            // 
            this.numGloria.Location = new System.Drawing.Point(90, 191);
            this.numGloria.Name = "numGloria";
            this.numGloria.Size = new System.Drawing.Size(120, 20);
            this.numGloria.TabIndex = 13;
            this.numGloria.ValueChanged += new System.EventHandler(this.numGloria_ValueChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(432, 202);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descuento de\r\n  15.25% :";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(432, 251);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total a Pagar  + IGV + Decuento:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(90, 243);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 45);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Productos ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "S/ 10.00";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "S/ 8.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "S/ 15.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Total a Pagar  sin IGV:";
            // 
            // txtSinIGV
            // 
            this.txtSinIGV.Location = new System.Drawing.Point(432, 135);
            this.txtSinIGV.Name = "txtSinIGV";
            this.txtSinIGV.Size = new System.Drawing.Size(100, 20);
            this.txtSinIGV.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 316);
            this.Controls.Add(this.txtSinIGV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numGloria);
            this.Controls.Add(this.numCOCA);
            this.Controls.Add(this.numINKA);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numINKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCOCA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGloria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.NumericUpDown numINKA;
        private System.Windows.Forms.NumericUpDown numCOCA;
        private System.Windows.Forms.NumericUpDown numGloria;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSinIGV;
    }
}

