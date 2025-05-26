namespace InventarioElTranquilo
{
    partial class NovedadesIngreso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.txUnidades = new System.Windows.Forms.TextBox();
            this.txProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txCantUnidades = new System.Windows.Forms.TextBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ingreso de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "Seleccionar Producto:";
            // 
            // cbCodigo
            // 
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(325, 156);
            this.cbCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(229, 24);
            this.cbCodigo.TabIndex = 35;
            this.cbCodigo.SelectedValueChanged += new System.EventHandler(this.buscarProducto);
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(124, 261);
            this.txNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txNombre.Name = "txNombre";
            this.txNombre.ReadOnly = true;
            this.txNombre.Size = new System.Drawing.Size(225, 22);
            this.txNombre.TabIndex = 36;
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(381, 261);
            this.txPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.ReadOnly = true;
            this.txPrecio.Size = new System.Drawing.Size(132, 22);
            this.txPrecio.TabIndex = 37;
            // 
            // txUnidades
            // 
            this.txUnidades.Location = new System.Drawing.Point(535, 261);
            this.txUnidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txUnidades.Name = "txUnidades";
            this.txUnidades.ReadOnly = true;
            this.txUnidades.Size = new System.Drawing.Size(132, 22);
            this.txUnidades.TabIndex = 38;
            // 
            // txProveedor
            // 
            this.txProveedor.Location = new System.Drawing.Point(700, 261);
            this.txProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txProveedor.Name = "txProveedor";
            this.txProveedor.ReadOnly = true;
            this.txProveedor.Size = new System.Drawing.Size(143, 22);
            this.txProveedor.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(528, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 40;
            this.label5.Text = "Unidades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(707, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 30);
            this.label6.TabIndex = 41;
            this.label6.Text = "Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 30);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ingresar Unidades";
            // 
            // txCantUnidades
            // 
            this.txCantUnidades.Location = new System.Drawing.Point(325, 336);
            this.txCantUnidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txCantUnidades.Name = "txCantUnidades";
            this.txCantUnidades.Size = new System.Drawing.Size(132, 22);
            this.txCantUnidades.TabIndex = 43;
            // 
            // btIngresar
            // 
            this.btIngresar.Enabled = false;
            this.btIngresar.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngresar.Location = new System.Drawing.Point(532, 327);
            this.btIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(121, 41);
            this.btIngresar.TabIndex = 44;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(695, 327);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(121, 41);
            this.btRegresar.TabIndex = 45;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // NovedadesIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.txCantUnidades);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txProveedor);
            this.Controls.Add(this.txUnidades);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.cbCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NovedadesIngreso";
            this.Text = "NovedadesIngreso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.TextBox txUnidades;
        private System.Windows.Forms.TextBox txProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txCantUnidades;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Button btRegresar;
    }
}