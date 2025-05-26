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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(527, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 60;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btSalida
            // 
            this.btSalida.Enabled = false;
            this.btSalida.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalida.Location = new System.Drawing.Point(405, 268);
            this.btSalida.Margin = new System.Windows.Forms.Padding(2);
            this.btSalida.Name = "btSalida";
            this.btSalida.Size = new System.Drawing.Size(91, 33);
            this.btSalida.TabIndex = 59;
            this.btSalida.Text = "Salida";
            this.btSalida.UseVisualStyleBackColor = true;
            this.btSalida.Click += new System.EventHandler(this.btSalida_Click);
            // 
            // txCantUnidades
            // 
            this.txCantUnidades.Location = new System.Drawing.Point(250, 275);
            this.txCantUnidades.Name = "txCantUnidades";
            this.txCantUnidades.Size = new System.Drawing.Size(100, 20);
            this.txCantUnidades.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 30);
            this.label7.TabIndex = 57;
            this.label7.Text = "Salida Unidades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 30);
            this.label6.TabIndex = 56;
            this.label6.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 55;
            this.label5.Text = "Unidades";
            // 
            // txProveedor
            // 
            this.txProveedor.Location = new System.Drawing.Point(531, 214);
            this.txProveedor.Name = "txProveedor";
            this.txProveedor.ReadOnly = true;
            this.txProveedor.Size = new System.Drawing.Size(108, 20);
            this.txProveedor.TabIndex = 54;
            // 
            // txUnidades
            // 
            this.txUnidades.Location = new System.Drawing.Point(407, 214);
            this.txUnidades.Name = "txUnidades";
            this.txUnidades.ReadOnly = true;
            this.txUnidades.Size = new System.Drawing.Size(100, 20);
            this.txUnidades.TabIndex = 53;
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(292, 214);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.ReadOnly = true;
            this.txPrecio.Size = new System.Drawing.Size(100, 20);
            this.txPrecio.TabIndex = 52;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(99, 214);
            this.txNombre.Name = "txNombre";
            this.txNombre.ReadOnly = true;
            this.txNombre.Size = new System.Drawing.Size(170, 20);
            this.txNombre.TabIndex = 51;
            // 
            // cbCodigo
            // 
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(250, 129);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(173, 21);
            this.cbCodigo.TabIndex = 50;
            this.cbCodigo.SelectedIndexChanged += new System.EventHandler(this.buscarProducto);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 30);
            this.label4.TabIndex = 49;
            this.label4.Text = "Seleccionar Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 48;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nombre ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Salida de Producto";
            // 
            // NovedadesSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSalida);
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
            this.Name = "NovedadesSalida";
            this.Text = "NovedadesSalida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}