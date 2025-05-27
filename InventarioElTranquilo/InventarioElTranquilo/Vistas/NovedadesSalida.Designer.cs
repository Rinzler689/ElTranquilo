namespace InventarioElTranquilo
{
    partial class NovedadesSalida
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
            this.button1 = new System.Windows.Forms.Button();
            this.btSalida = new System.Windows.Forms.Button();
            this.txCantUnidades = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txProveedor = new System.Windows.Forms.TextBox();
            this.txUnidades = new System.Windows.Forms.TextBox();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSalidaProducto = new System.Windows.Forms.Panel();
            this.panelSalidaProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(1062, 769);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 75);
            this.button1.TabIndex = 60;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btSalida
            // 
            this.btSalida.BackColor = System.Drawing.Color.PowderBlue;
            this.btSalida.Enabled = false;
            this.btSalida.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20F, System.Drawing.FontStyle.Italic);
            this.btSalida.Location = new System.Drawing.Point(776, 769);
            this.btSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalida.Name = "btSalida";
            this.btSalida.Size = new System.Drawing.Size(214, 75);
            this.btSalida.TabIndex = 59;
            this.btSalida.Text = "Salida";
            this.btSalida.UseVisualStyleBackColor = false;
            this.btSalida.Click += new System.EventHandler(this.btSalida_Click);
            // 
            // txCantUnidades
            // 
            this.txCantUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txCantUnidades.Location = new System.Drawing.Point(386, 555);
            this.txCantUnidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txCantUnidades.Name = "txCantUnidades";
            this.txCantUnidades.Size = new System.Drawing.Size(166, 32);
            this.txCantUnidades.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F);
            this.label7.Location = new System.Drawing.Point(80, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 34);
            this.label7.TabIndex = 57;
            this.label7.Text = "Cantidad Unidades:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F);
            this.label6.Location = new System.Drawing.Point(982, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 34);
            this.label6.TabIndex = 56;
            this.label6.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F);
            this.label5.Location = new System.Drawing.Point(784, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 34);
            this.label5.TabIndex = 55;
            this.label5.Text = "Unidades";
            // 
            // txProveedor
            // 
            this.txProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txProveedor.Location = new System.Drawing.Point(978, 412);
            this.txProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txProveedor.Name = "txProveedor";
            this.txProveedor.ReadOnly = true;
            this.txProveedor.Size = new System.Drawing.Size(327, 32);
            this.txProveedor.TabIndex = 54;
            // 
            // txUnidades
            // 
            this.txUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txUnidades.Location = new System.Drawing.Point(789, 412);
            this.txUnidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txUnidades.Name = "txUnidades";
            this.txUnidades.ReadOnly = true;
            this.txUnidades.Size = new System.Drawing.Size(156, 32);
            this.txUnidades.TabIndex = 53;
            // 
            // txPrecio
            // 
            this.txPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txPrecio.Location = new System.Drawing.Point(500, 412);
            this.txPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.ReadOnly = true;
            this.txPrecio.Size = new System.Drawing.Size(230, 32);
            this.txPrecio.TabIndex = 52;
            // 
            // txNombre
            // 
            this.txNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txNombre.Location = new System.Drawing.Point(39, 412);
            this.txNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txNombre.Name = "txNombre";
            this.txNombre.ReadOnly = true;
            this.txNombre.Size = new System.Drawing.Size(412, 32);
            this.txNombre.TabIndex = 51;
            // 
            // cbCodigo
            // 
            this.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(504, 220);
            this.cbCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(440, 33);
            this.cbCodigo.TabIndex = 50;
            this.cbCodigo.SelectedIndexChanged += new System.EventHandler(this.buscarProducto);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F);
            this.label4.Location = new System.Drawing.Point(161, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 34);
            this.label4.TabIndex = 49;
            this.label4.Text = "Seleccionar Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F);
            this.label3.Location = new System.Drawing.Point(492, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 34);
            this.label3.TabIndex = 48;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F);
            this.label2.Location = new System.Drawing.Point(43, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 34);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nombre ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 46;
            this.label1.Text = "Salida de Producto";
            // 
            // panelSalidaProducto
            // 
            this.panelSalidaProducto.Controls.Add(this.label1);
            this.panelSalidaProducto.Controls.Add(this.button1);
            this.panelSalidaProducto.Controls.Add(this.label2);
            this.panelSalidaProducto.Controls.Add(this.btSalida);
            this.panelSalidaProducto.Controls.Add(this.label3);
            this.panelSalidaProducto.Controls.Add(this.txCantUnidades);
            this.panelSalidaProducto.Controls.Add(this.label4);
            this.panelSalidaProducto.Controls.Add(this.label7);
            this.panelSalidaProducto.Controls.Add(this.cbCodigo);
            this.panelSalidaProducto.Controls.Add(this.label6);
            this.panelSalidaProducto.Controls.Add(this.txNombre);
            this.panelSalidaProducto.Controls.Add(this.label5);
            this.panelSalidaProducto.Controls.Add(this.txPrecio);
            this.panelSalidaProducto.Controls.Add(this.txProveedor);
            this.panelSalidaProducto.Controls.Add(this.txUnidades);
            this.panelSalidaProducto.Location = new System.Drawing.Point(34, 28);
            this.panelSalidaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSalidaProducto.Name = "panelSalidaProducto";
            this.panelSalidaProducto.Size = new System.Drawing.Size(1332, 888);
            this.panelSalidaProducto.TabIndex = 61;
            // 
            // NovedadesSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.panelSalidaProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovedadesSalida";
            this.Text = "NovedadesSalida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.panelSalidaProductoAjustar);
            this.panelSalidaProducto.ResumeLayout(false);
            this.panelSalidaProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSalida;
        private System.Windows.Forms.TextBox txCantUnidades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txProveedor;
        private System.Windows.Forms.TextBox txUnidades;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSalidaProducto;
    }
}