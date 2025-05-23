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
            this.btConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.btConsultarCodigo = new System.Windows.Forms.ToolStripMenuItem();
            this.btConsultaNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.btAgregarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btActualizarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btNovedades = new System.Windows.Forms.ToolStripMenuItem();
            this.btIngresoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btSalidaProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btEliminarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btConsultar,
            this.btAgregarProducto,
            this.btActualizarProducto,
            this.btEliminarProducto,
            this.btNovedades});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btConsultar
            // 
            this.btConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btConsultarCodigo,
            this.btConsultaNombre});
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(73, 22);
            this.btConsultar.Text = "Consultar ";
            this.btConsultar.Visible = false;
            // 
            // btConsultarCodigo
            // 
            this.btConsultarCodigo.Name = "btConsultarCodigo";
            this.btConsultarCodigo.Size = new System.Drawing.Size(139, 22);
            this.btConsultarCodigo.Text = "Por Codigo";
            // 
            // btConsultaNombre
            // 
            this.btConsultaNombre.Name = "btConsultaNombre";
            this.btConsultaNombre.Size = new System.Drawing.Size(139, 22);
            this.btConsultaNombre.Text = "Por Nombre";
            // 
            // btAgregarProducto
            // 
            this.btAgregarProducto.Name = "btAgregarProducto";
            this.btAgregarProducto.Size = new System.Drawing.Size(113, 22);
            this.btAgregarProducto.Text = "Agregar Producto";
            this.btAgregarProducto.Visible = false;
            // 
            // btActualizarProducto
            // 
            this.btActualizarProducto.Name = "btActualizarProducto";
            this.btActualizarProducto.Size = new System.Drawing.Size(123, 22);
            this.btActualizarProducto.Text = "Actualizar Producto";
            this.btActualizarProducto.Visible = false;
            // 
            // btNovedades
            // 
            this.btNovedades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btIngresoProducto,
            this.btSalidaProducto});
            this.btNovedades.Name = "btNovedades";
            this.btNovedades.Size = new System.Drawing.Size(78, 22);
            this.btNovedades.Text = "Novedades";
            this.btNovedades.Visible = false;
            // 
            // btIngresoProducto
            // 
            this.btIngresoProducto.Name = "btIngresoProducto";
            this.btIngresoProducto.Size = new System.Drawing.Size(181, 22);
            this.btIngresoProducto.Text = "Ingreso de Producto";
            // 
            // btSalidaProducto
            // 
            this.btSalidaProducto.Name = "btSalidaProducto";
            this.btSalidaProducto.Size = new System.Drawing.Size(181, 22);
            this.btSalidaProducto.Text = "Salida de Producto";
            // 
            // btEliminarProducto
            // 
            this.btEliminarProducto.Name = "btEliminarProducto";
            this.btEliminarProducto.Size = new System.Drawing.Size(114, 22);
            this.btEliminarProducto.Text = "Eliminar Producto";
            this.btEliminarProducto.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.ToolStripMenuItem btConsultar;
        private System.Windows.Forms.ToolStripMenuItem btConsultarCodigo;
        private System.Windows.Forms.ToolStripMenuItem btConsultaNombre;
        private System.Windows.Forms.ToolStripMenuItem btAgregarProducto;
        private System.Windows.Forms.ToolStripMenuItem btActualizarProducto;
        private System.Windows.Forms.ToolStripMenuItem btNovedades;
        private System.Windows.Forms.ToolStripMenuItem btIngresoProducto;
        private System.Windows.Forms.ToolStripMenuItem btSalidaProducto;
        private System.Windows.Forms.ToolStripMenuItem btEliminarProducto;
    }
}

