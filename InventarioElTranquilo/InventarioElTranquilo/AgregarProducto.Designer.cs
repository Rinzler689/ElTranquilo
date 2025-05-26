namespace InventarioElTranquilo
{
    partial class AgregarProducto
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
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.btAgregarProducto = new System.Windows.Forms.Button();
            this.txStock = new System.Windows.Forms.TextBox();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNit = new System.Windows.Forms.ComboBox();
            this.panelAgregarProducto = new System.Windows.Forms.Panel();
            this.panelAgregarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(758, 407);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(121, 33);
            this.btLimpiar.TabIndex = 43;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(747, 344);
            this.btRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(121, 37);
            this.btRegresar.TabIndex = 42;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btAgregarProducto
            // 
            this.btAgregarProducto.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarProducto.Location = new System.Drawing.Point(747, 277);
            this.btAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAgregarProducto.Name = "btAgregarProducto";
            this.btAgregarProducto.Size = new System.Drawing.Size(169, 41);
            this.btAgregarProducto.TabIndex = 41;
            this.btAgregarProducto.Text = "Agregar Producto";
            this.btAgregarProducto.UseVisualStyleBackColor = true;
            this.btAgregarProducto.Click += new System.EventHandler(this.btAgregarProducto_Click);
            // 
            // txStock
            // 
            this.txStock.Location = new System.Drawing.Point(266, 392);
            this.txStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txStock.Name = "txStock";
            this.txStock.Size = new System.Drawing.Size(132, 22);
            this.txStock.TabIndex = 39;
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(274, 334);
            this.txPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(132, 22);
            this.txPrecio.TabIndex = 38;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(284, 274);
            this.txNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(217, 22);
            this.txNombre.TabIndex = 37;
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(284, 222);
            this.txCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(132, 22);
            this.txCodigo.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nit Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Agregar Producto";
            // 
            // cbNit
            // 
            this.cbNit.FormattingEnabled = true;
            this.cbNit.Location = new System.Drawing.Point(342, 441);
            this.cbNit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNit.Name = "cbNit";
            this.cbNit.Size = new System.Drawing.Size(160, 24);
            this.cbNit.TabIndex = 44;
            // 
            // panelAgregarProducto
            // 
            this.panelAgregarProducto.Controls.Add(this.label1);
            this.panelAgregarProducto.Controls.Add(this.cbNit);
            this.panelAgregarProducto.Controls.Add(this.label3);
            this.panelAgregarProducto.Controls.Add(this.btLimpiar);
            this.panelAgregarProducto.Controls.Add(this.label2);
            this.panelAgregarProducto.Controls.Add(this.btRegresar);
            this.panelAgregarProducto.Controls.Add(this.label4);
            this.panelAgregarProducto.Controls.Add(this.btAgregarProducto);
            this.panelAgregarProducto.Controls.Add(this.label5);
            this.panelAgregarProducto.Controls.Add(this.txStock);
            this.panelAgregarProducto.Controls.Add(this.label6);
            this.panelAgregarProducto.Controls.Add(this.txPrecio);
            this.panelAgregarProducto.Controls.Add(this.txCodigo);
            this.panelAgregarProducto.Controls.Add(this.txNombre);
            this.panelAgregarProducto.Location = new System.Drawing.Point(26, 22);
            this.panelAgregarProducto.Name = "panelAgregarProducto";
            this.panelAgregarProducto.Size = new System.Drawing.Size(1055, 671);
            this.panelAgregarProducto.TabIndex = 45;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panelAgregarProducto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.panelAgregarProductoAjustar);
            this.panelAgregarProducto.ResumeLayout(false);
            this.panelAgregarProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btAgregarProducto;
        private System.Windows.Forms.TextBox txStock;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNit;
        private System.Windows.Forms.Panel panelAgregarProducto;
    }
}