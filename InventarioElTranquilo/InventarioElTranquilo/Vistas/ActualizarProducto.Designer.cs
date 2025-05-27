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
            this.panelActualizarProducto = new System.Windows.Forms.Panel();
            this.panelActualizarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.BackColor = System.Drawing.Color.PowderBlue;
            this.btRegresar.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(964, 560);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(256, 78);
            this.btRegresar.TabIndex = 42;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = false;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btActualizarProducto
            // 
            this.btActualizarProducto.BackColor = System.Drawing.Color.PowderBlue;
            this.btActualizarProducto.Enabled = false;
            this.btActualizarProducto.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizarProducto.Location = new System.Drawing.Point(964, 246);
            this.btActualizarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizarProducto.Name = "btActualizarProducto";
            this.btActualizarProducto.Size = new System.Drawing.Size(256, 121);
            this.btActualizarProducto.TabIndex = 41;
            this.btActualizarProducto.Text = "Actualizar Producto";
            this.btActualizarProducto.UseVisualStyleBackColor = false;
            this.btActualizarProducto.Click += new System.EventHandler(this.btActualizarProducto_Click);
            // 
            // txStock
            // 
            this.txStock.Enabled = false;
            this.txStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txStock.Location = new System.Drawing.Point(359, 519);
            this.txStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txStock.Name = "txStock";
            this.txStock.Size = new System.Drawing.Size(545, 32);
            this.txStock.TabIndex = 39;
            // 
            // txPrecio
            // 
            this.txPrecio.Enabled = false;
            this.txPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrecio.Location = new System.Drawing.Point(359, 430);
            this.txPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(545, 32);
            this.txPrecio.TabIndex = 38;
            // 
            // txNombre
            // 
            this.txNombre.Enabled = false;
            this.txNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombre.Location = new System.Drawing.Point(359, 342);
            this.txNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(545, 32);
            this.txNombre.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 612);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 34);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nit Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 34);
            this.label5.TabIndex = 34;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 34);
            this.label4.TabIndex = 33;
            this.label4.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 34);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 34);
            this.label3.TabIndex = 31;
            this.label3.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 41);
            this.label1.TabIndex = 30;
            this.label1.Text = "Actualizar Producto";
            // 
            // cbCodigo
            // 
            this.cbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(359, 246);
            this.cbCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(545, 34);
            this.cbCodigo.TabIndex = 44;
            this.cbCodigo.SelectedValueChanged += new System.EventHandler(this.btConsultar_Click);
            // 
            // cbNit
            // 
            this.cbNit.Enabled = false;
            this.cbNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNit.FormattingEnabled = true;
            this.cbNit.Location = new System.Drawing.Point(359, 612);
            this.cbNit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNit.Name = "cbNit";
            this.cbNit.Size = new System.Drawing.Size(545, 34);
            this.cbNit.TabIndex = 45;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.PowderBlue;
            this.btCancelar.Enabled = false;
            this.btCancelar.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(964, 395);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(256, 121);
            this.btCancelar.TabIndex = 47;
            this.btCancelar.Text = "Cancelar Actualizacion";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // panelActualizarProducto
            // 
            this.panelActualizarProducto.Controls.Add(this.label1);
            this.panelActualizarProducto.Controls.Add(this.btCancelar);
            this.panelActualizarProducto.Controls.Add(this.label3);
            this.panelActualizarProducto.Controls.Add(this.cbNit);
            this.panelActualizarProducto.Controls.Add(this.label2);
            this.panelActualizarProducto.Controls.Add(this.cbCodigo);
            this.panelActualizarProducto.Controls.Add(this.label4);
            this.panelActualizarProducto.Controls.Add(this.btRegresar);
            this.panelActualizarProducto.Controls.Add(this.label5);
            this.panelActualizarProducto.Controls.Add(this.btActualizarProducto);
            this.panelActualizarProducto.Controls.Add(this.label6);
            this.panelActualizarProducto.Controls.Add(this.txStock);
            this.panelActualizarProducto.Controls.Add(this.txNombre);
            this.panelActualizarProducto.Controls.Add(this.txPrecio);
            this.panelActualizarProducto.Location = new System.Drawing.Point(30, 29);
            this.panelActualizarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelActualizarProducto.Name = "panelActualizarProducto";
            this.panelActualizarProducto.Size = new System.Drawing.Size(1286, 861);
            this.panelActualizarProducto.TabIndex = 48;
            // 
            // ActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.panelActualizarProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ActualizarProducto";
            this.Text = "ActualizarProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.panelActualizarProductoAjustar);
            this.panelActualizarProducto.ResumeLayout(false);
            this.panelActualizarProducto.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelActualizarProducto;
    }
}