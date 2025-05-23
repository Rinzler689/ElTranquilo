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
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.agregarProductoToolStripMenuItem,
            this.actualizarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.novedadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCodigoToolStripMenuItem,
            this.porNombreToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(89, 34);
            this.consultarToolStripMenuItem.Text = "Consultar ";
            // 
            // porCodigoToolStripMenuItem
            // 
            this.porCodigoToolStripMenuItem.Name = "porCodigoToolStripMenuItem";
            this.porCodigoToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.porCodigoToolStripMenuItem.Text = "Por Codigo";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.porNombreToolStripMenuItem.Text = "Por Nombre";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            // 
            // actualizarProductoToolStripMenuItem
            // 
            this.actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            this.actualizarProductoToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.actualizarProductoToolStripMenuItem.Text = "Actualizar Producto";
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeProductoToolStripMenuItem,
            this.salidaDeProductoToolStripMenuItem});
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(98, 34);
            this.novedadesToolStripMenuItem.Text = "Novedades";
            // 
            // ingresoDeProductoToolStripMenuItem
            // 
            this.ingresoDeProductoToolStripMenuItem.Name = "ingresoDeProductoToolStripMenuItem";
            this.ingresoDeProductoToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.ingresoDeProductoToolStripMenuItem.Text = "Ingreso de Producto";
            // 
            // salidaDeProductoToolStripMenuItem
            // 
            this.salidaDeProductoToolStripMenuItem.Name = "salidaDeProductoToolStripMenuItem";
            this.salidaDeProductoToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.salidaDeProductoToolStripMenuItem.Text = "Salida de Producto";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaDeProductoToolStripMenuItem;
    }
}

