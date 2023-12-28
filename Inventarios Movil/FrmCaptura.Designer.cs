namespace Inventarios_Movil
{
    partial class FrmCaptura
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmdTerminar = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.Text = "Producto:";
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(3, 39);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(207, 53);
            this.lblProducto.Text = "DATOS DEL PRODUCTO";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.Text = "Cantidad:";
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Location = new System.Drawing.Point(3, 182);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(177, 36);
            this.lblRegistros.Text = "REGISTROS TOTALES DE LA UBICACION";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(62, 12);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(124, 23);
            this.txtProducto.TabIndex = 7;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(64, 148);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(124, 23);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cmdTerminar
            // 
            this.cmdTerminar.Location = new System.Drawing.Point(51, 228);
            this.cmdTerminar.Name = "cmdTerminar";
            this.cmdTerminar.Size = new System.Drawing.Size(108, 44);
            this.cmdTerminar.TabIndex = 9;
            this.cmdTerminar.Text = "Terminar";
            this.cmdTerminar.Click += new System.EventHandler(this.cmdTerminar_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.Location = new System.Drawing.Point(3, 92);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(177, 19);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(3, 116);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(185, 19);
            // 
            // FrmCaptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(213, 310);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.cmdTerminar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.label1);
            this.Name = "FrmCaptura";
            this.Text = "FrmCaptura";
            this.Load += new System.EventHandler(this.FrmCaptura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button cmdTerminar;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblPrecio;
    }
}