namespace InventarioElTranquilo
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btConsultarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btConsultarCodigo = new System.Windows.Forms.ToolStripMenuItem();
            this.btConsultaNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.btAgregarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btActualizarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btEliminarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btNovedades = new System.Windows.Forms.ToolStripMenuItem();
            this.btIngresoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btSalidaProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btConsultarProducto,
            this.btAgregarProducto,
            this.btActualizarProducto,
            this.btEliminarProducto,
            this.btNovedades,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(865, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btConsultarProducto
            // 
            this.btConsultarProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btConsultarCodigo,
            this.btConsultaNombre});
            this.btConsultarProducto.Name = "btConsultarProducto";
            this.btConsultarProducto.Size = new System.Drawing.Size(149, 24);
            this.btConsultarProducto.Text = "Consultar Producto";
            this.btConsultarProducto.Visible = false;
            // 
            // btConsultarCodigo
            // 
            this.btConsultarCodigo.Name = "btConsultarCodigo";
            this.btConsultarCodigo.Size = new System.Drawing.Size(224, 26);
            this.btConsultarCodigo.Text = "Por Codigo";
            this.btConsultarCodigo.Click += new System.EventHandler(this.btConsultarCodigo_Click);
            // 
            // btConsultaNombre
            // 
            this.btConsultaNombre.Name = "btConsultaNombre";
            this.btConsultaNombre.Size = new System.Drawing.Size(224, 26);
            this.btConsultaNombre.Text = "Por Nombre";
            this.btConsultaNombre.Click += new System.EventHandler(this.btConsultaNombre_Click);
            // 
            // btAgregarProducto
            // 
            this.btAgregarProducto.Name = "btAgregarProducto";
            this.btAgregarProducto.Size = new System.Drawing.Size(141, 24);
            this.btAgregarProducto.Text = "Agregar Producto";
            this.btAgregarProducto.Visible = false;
            this.btAgregarProducto.Click += new System.EventHandler(this.btAgregarProducto_Click);
            // 
            // btActualizarProducto
            // 
            this.btActualizarProducto.Name = "btActualizarProducto";
            this.btActualizarProducto.Size = new System.Drawing.Size(153, 24);
            this.btActualizarProducto.Text = "Actualizar Producto";
            this.btActualizarProducto.Visible = false;
            // 
            // btEliminarProducto
            // 
            this.btEliminarProducto.Name = "btEliminarProducto";
            this.btEliminarProducto.Size = new System.Drawing.Size(141, 24);
            this.btEliminarProducto.Text = "Eliminar Producto";
            this.btEliminarProducto.Visible = false;
            // 
            // btNovedades
            // 
            this.btNovedades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btIngresoProducto,
            this.btSalidaProducto});
            this.btNovedades.Name = "btNovedades";
            this.btNovedades.Size = new System.Drawing.Size(98, 24);
            this.btNovedades.Text = "Novedades";
            this.btNovedades.Visible = false;
            // 
            // btIngresoProducto
            // 
            this.btIngresoProducto.Name = "btIngresoProducto";
            this.btIngresoProducto.Size = new System.Drawing.Size(226, 26);
            this.btIngresoProducto.Text = "Ingreso de Producto";
            // 
            // btSalidaProducto
            // 
            this.btSalidaProducto.Name = "btSalidaProducto";
            this.btSalidaProducto.Size = new System.Drawing.Size(226, 26);
            this.btSalidaProducto.Text = "Salida de Producto";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 449);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btConsultarProducto;
        private System.Windows.Forms.ToolStripMenuItem btConsultarCodigo;
        private System.Windows.Forms.ToolStripMenuItem btConsultaNombre;
        private System.Windows.Forms.ToolStripMenuItem btAgregarProducto;
        private System.Windows.Forms.ToolStripMenuItem btActualizarProducto;
        private System.Windows.Forms.ToolStripMenuItem btNovedades;
        private System.Windows.Forms.ToolStripMenuItem btIngresoProducto;
        private System.Windows.Forms.ToolStripMenuItem btSalidaProducto;
        private System.Windows.Forms.ToolStripMenuItem btEliminarProducto;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

