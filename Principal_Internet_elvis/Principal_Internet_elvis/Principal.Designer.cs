namespace Proyecto_dawelin
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel_botones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPaquetes = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.panel_botones.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_botones
            // 
            this.panel_botones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_botones.Controls.Add(this.btnPago);
            this.panel_botones.Controls.Add(this.btnCliente);
            this.panel_botones.Controls.Add(this.btnPaquetes);
            this.panel_botones.Controls.Add(this.btnFactura);
            this.panel_botones.Controls.Add(this.btnUbicacion);
            this.panel_botones.Controls.Add(this.btnReportes);
            this.panel_botones.Controls.Add(this.btnConfiguracion);
            this.panel_botones.Controls.Add(this.btnSalir);
            this.panel_botones.Location = new System.Drawing.Point(12, 16);
            this.panel_botones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(267, 528);
            this.panel_botones.TabIndex = 1;
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.White;
            this.btnPago.Enabled = false;
            this.btnPago.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPago.Image = ((System.Drawing.Image)(resources.GetObject("btnPago.Image")));
            this.btnPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPago.Location = new System.Drawing.Point(4, 3);
            this.btnPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(259, 60);
            this.btnPago.TabIndex = 0;
            this.btnPago.Text = "Pagos";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.bntPago_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.White;
            this.btnCliente.Enabled = false;
            this.btnCliente.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = global::Principal_Internet_elvis.Properties.Resources._4;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(4, 69);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(259, 60);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPaquetes
            // 
            this.btnPaquetes.BackColor = System.Drawing.Color.White;
            this.btnPaquetes.Enabled = false;
            this.btnPaquetes.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaquetes.Image = global::Principal_Internet_elvis.Properties.Resources._6;
            this.btnPaquetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaquetes.Location = new System.Drawing.Point(4, 135);
            this.btnPaquetes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPaquetes.Name = "btnPaquetes";
            this.btnPaquetes.Size = new System.Drawing.Size(259, 60);
            this.btnPaquetes.TabIndex = 2;
            this.btnPaquetes.Text = "Paquetes";
            this.btnPaquetes.UseVisualStyleBackColor = false;
            this.btnPaquetes.Click += new System.EventHandler(this.btnPaquetes_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.White;
            this.btnFactura.Enabled = false;
            this.btnFactura.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Image = global::Principal_Internet_elvis.Properties.Resources._7;
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(4, 201);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(259, 60);
            this.btnFactura.TabIndex = 3;
            this.btnFactura.Text = "Facturas";
            this.btnFactura.UseVisualStyleBackColor = false;
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.BackColor = System.Drawing.Color.White;
            this.btnUbicacion.Enabled = false;
            this.btnUbicacion.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicacion.Image = global::Principal_Internet_elvis.Properties.Resources._3;
            this.btnUbicacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbicacion.Location = new System.Drawing.Point(4, 267);
            this.btnUbicacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(259, 60);
            this.btnUbicacion.TabIndex = 4;
            this.btnUbicacion.Text = "Ubicaion";
            this.btnUbicacion.UseVisualStyleBackColor = false;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.White;
            this.btnReportes.Enabled = false;
            this.btnReportes.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = global::Principal_Internet_elvis.Properties.Resources._5;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(4, 333);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(259, 60);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.White;
            this.btnConfiguracion.Enabled = false;
            this.btnConfiguracion.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.Image = global::Principal_Internet_elvis.Properties.Resources._2;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(4, 399);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(259, 60);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Enabled = false;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::Principal_Internet_elvis.Properties.Resources._8;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(4, 465);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(259, 59);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.White;
            this.panel_logo.Controls.Add(this.img_logo);
            this.panel_logo.Location = new System.Drawing.Point(528, 19);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 200);
            this.panel_logo.TabIndex = 2;
            // 
            // img_logo
            // 
            this.img_logo.Image = global::Principal_Internet_elvis.Properties.Resources.logo;
            this.img_logo.Location = new System.Drawing.Point(0, 0);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(200, 200);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logo.TabIndex = 0;
            this.img_logo.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(740, 563);
            this.Controls.Add(this.panel_logo);
            this.Controls.Add(this.panel_botones);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.panel_botones.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panel_botones;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPaquetes;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox img_logo;
    }
}

