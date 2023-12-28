namespace Inventarios_Movil
{
    partial class FrmUbicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUbicacion));
            this.cmbUbicacion = new System.Windows.Forms.ComboBox();
            this.cmbConteo = new System.Windows.Forms.ComboBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.cmdComenzar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            this.rbExistente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // cmbUbicacion
            // 
            this.cmbUbicacion.Location = new System.Drawing.Point(80, 27);
            this.cmbUbicacion.Name = "cmbUbicacion";
            this.cmbUbicacion.Size = new System.Drawing.Size(118, 23);
            this.cmbUbicacion.TabIndex = 0;
            // 
            // cmbConteo
            // 
            this.cmbConteo.Items.Add("Conteo 1");
            this.cmbConteo.Items.Add("Conteo 2");
            this.cmbConteo.Location = new System.Drawing.Point(72, 85);
            this.cmbConteo.Name = "cmbConteo";
            this.cmbConteo.Size = new System.Drawing.Size(151, 23);
            this.cmbConteo.TabIndex = 1;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(201, 26);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(27, 23);
            this.cmdCargar.TabIndex = 2;
            this.cmdCargar.Text = "...";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // cmdComenzar
            // 
            this.cmdComenzar.Location = new System.Drawing.Point(32, 119);
            this.cmdComenzar.Name = "cmdComenzar";
            this.cmdComenzar.Size = new System.Drawing.Size(75, 35);
            this.cmdComenzar.TabIndex = 3;
            this.cmdComenzar.Text = "Comenzar";
            this.cmdComenzar.Click += new System.EventHandler(this.cmdComenzar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(120, 119);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(76, 35);
            this.cmdSalir.TabIndex = 4;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // rbNuevo
            // 
            this.rbNuevo.Location = new System.Drawing.Point(3, 56);
            this.rbNuevo.Name = "rbNuevo";
            this.rbNuevo.Size = new System.Drawing.Size(60, 16);
            this.rbNuevo.TabIndex = 5;
            this.rbNuevo.TabStop = false;
            this.rbNuevo.Text = "Nuevo";
            this.rbNuevo.Click += new System.EventHandler(this.rbNuevo_Click);
            // 
            // rbExistente
            // 
            this.rbExistente.Checked = true;
            this.rbExistente.Location = new System.Drawing.Point(3, 34);
            this.rbExistente.Name = "rbExistente";
            this.rbExistente.Size = new System.Drawing.Size(77, 16);
            this.rbExistente.TabIndex = 6;
            this.rbExistente.Text = "Existente";
            this.rbExistente.Click += new System.EventHandler(this.rbExistente_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(62, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.Text = "UBICACIONES";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Enabled = false;
            this.txtUbicacion.Location = new System.Drawing.Point(69, 56);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(151, 23);
            this.txtUbicacion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.Text = "Conteo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // FrmUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(233, 285);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbExistente);
            this.Controls.Add(this.rbNuevo);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdComenzar);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.cmbConteo);
            this.Controls.Add(this.cmbUbicacion);
            this.Name = "FrmUbicacion";
            this.Text = "FrmUbicacion";
            this.Load += new System.EventHandler(this.FrmUbicacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUbicacion;
        private System.Windows.Forms.ComboBox cmbConteo;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdComenzar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.RadioButton rbNuevo;
        private System.Windows.Forms.RadioButton rbExistente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}