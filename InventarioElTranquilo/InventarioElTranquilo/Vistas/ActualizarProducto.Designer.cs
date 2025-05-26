namespace InventarioElTranquilo
{
    partial class ActualizarProducto
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
            this.btRegresar = new System.Windows.Forms.Button();
            this.btActualizarProducto = new System.Windows.Forms.Button();
            this.txStock = new System.Windows.Forms.TextBox();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.cbNit = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(613, 295);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(121, 37);
            this.btRegresar.TabIndex = 42;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btActualizarProducto
            // 
            this.btActualizarProducto.Enabled = false;
            this.btActualizarProducto.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizarProducto.Location = new System.Drawing.Point(613, 190);
            this.btActualizarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizarProducto.Name = "btActualizarProducto";
            this.btActualizarProducto.Size = new System.Drawing.Size(220, 41);
            this.btActualizarProducto.TabIndex = 41;
            this.btActualizarProducto.Text = "Actualizar Producto";
            this.btActualizarProducto.UseVisualStyleBackColor = true;
            this.btActualizarProducto.Click += new System.EventHandler(this.btActualizarProducto_Click);
            // 
            // txStock
            // 
            this.txStock.Enabled = false;
            this.txStock.Location = new System.Drawing.Point(132, 353);
            this.txStock.Margin = new System.Windows.Forms.Padding(4);
            this.txStock.Name = "txStock";
            this.txStock.Size = new System.Drawing.Size(132, 22);
            this.txStock.TabIndex = 39;
            // 
            // txPrecio
            // 
            this.txPrecio.Enabled = false;
            this.txPrecio.Location = new System.Drawing.Point(140, 295);
            this.txPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(132, 22);
            this.txPrecio.TabIndex = 38;
            // 
            // txNombre
            // 
            this.txNombre.Enabled = false;
            this.txNombre.Location = new System.Drawing.Point(152, 235);
            this.txNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(132, 22);
            this.txNombre.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nit Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Actualizar Producto";
            // 
            // cbCodigo
            // 
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(165, 180);
            this.cbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(160, 24);
            this.cbCodigo.TabIndex = 44;
            this.cbCodigo.SelectedValueChanged += new System.EventHandler(this.btConsultar_Click);
            // 
            // cbNit
            // 
            this.cbNit.Enabled = false;
            this.cbNit.FormattingEnabled = true;
            this.cbNit.Location = new System.Drawing.Point(212, 401);
            this.cbNit.Margin = new System.Windows.Forms.Padding(4);
            this.cbNit.Name = "cbNit";
            this.cbNit.Size = new System.Drawing.Size(160, 24);
            this.cbNit.TabIndex = 45;
            // 
            // btCancelar
            // 
            this.btCancelar.Enabled = false;
            this.btCancelar.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(613, 235);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(220, 41);
            this.btCancelar.TabIndex = 47;
            this.btCancelar.Text = "Cancelar Actualizacion";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.cbNit);
            this.Controls.Add(this.cbCodigo);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btActualizarProducto);
            this.Controls.Add(this.txStock);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActualizarProducto";
            this.Text = "ActualizarProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btActualizarProducto;
        private System.Windows.Forms.TextBox txStock;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.ComboBox cbNit;
        private System.Windows.Forms.Button btCancelar;
    }
}