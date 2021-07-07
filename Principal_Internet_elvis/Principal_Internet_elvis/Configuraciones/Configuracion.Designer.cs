namespace Principal_Internet_elvis
{
    partial class Configuracion
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.fd_fuente = new System.Windows.Forms.FontDialog();
            this.btnSelFue = new System.Windows.Forms.Button();
            this.gb_opciones = new System.Windows.Forms.GroupBox();
            this.bt_servidor = new System.Windows.Forms.Button();
            this.bt_socios = new System.Windows.Forms.Button();
            this.bt_provedores = new System.Windows.Forms.Button();
            this.bt_usuarios = new System.Windows.Forms.Button();
            this.bt_empresa = new System.Windows.Forms.Button();
            this.gb_opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::Principal_Internet_elvis.Properties.Resources._8;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(922, 442);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 60);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fd_fuente
            // 
            this.fd_fuente.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // btnSelFue
            // 
            this.btnSelFue.Location = new System.Drawing.Point(6, 94);
            this.btnSelFue.Name = "btnSelFue";
            this.btnSelFue.Size = new System.Drawing.Size(430, 56);
            this.btnSelFue.TabIndex = 4;
            this.btnSelFue.Text = "SELECCIONAR FUENTE";
            this.btnSelFue.UseVisualStyleBackColor = true;
            this.btnSelFue.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_opciones
            // 
            this.gb_opciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_opciones.Controls.Add(this.bt_servidor);
            this.gb_opciones.Controls.Add(this.bt_socios);
            this.gb_opciones.Controls.Add(this.bt_provedores);
            this.gb_opciones.Controls.Add(this.bt_usuarios);
            this.gb_opciones.Controls.Add(this.bt_empresa);
            this.gb_opciones.Controls.Add(this.btnSelFue);
            this.gb_opciones.Location = new System.Drawing.Point(12, 12);
            this.gb_opciones.Name = "gb_opciones";
            this.gb_opciones.Size = new System.Drawing.Size(442, 490);
            this.gb_opciones.TabIndex = 6;
            this.gb_opciones.TabStop = false;
            this.gb_opciones.Text = "OPCIONES";
            // 
            // bt_servidor
            // 
            this.bt_servidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_servidor.Location = new System.Drawing.Point(6, 428);
            this.bt_servidor.Name = "bt_servidor";
            this.bt_servidor.Size = new System.Drawing.Size(430, 56);
            this.bt_servidor.TabIndex = 10;
            this.bt_servidor.Text = "CONEXION CON SERVIDOR";
            this.bt_servidor.UseVisualStyleBackColor = true;
            this.bt_servidor.Click += new System.EventHandler(this.bt_servidor_Click);
            // 
            // bt_socios
            // 
            this.bt_socios.Enabled = false;
            this.bt_socios.Location = new System.Drawing.Point(6, 306);
            this.bt_socios.Name = "bt_socios";
            this.bt_socios.Size = new System.Drawing.Size(430, 56);
            this.bt_socios.TabIndex = 9;
            this.bt_socios.Text = "SOCIOS";
            this.bt_socios.UseVisualStyleBackColor = true;
            this.bt_socios.Visible = false;
            this.bt_socios.Click += new System.EventHandler(this.bt_socios_Click);
            // 
            // bt_provedores
            // 
            this.bt_provedores.Enabled = false;
            this.bt_provedores.Location = new System.Drawing.Point(6, 235);
            this.bt_provedores.Name = "bt_provedores";
            this.bt_provedores.Size = new System.Drawing.Size(430, 56);
            this.bt_provedores.TabIndex = 8;
            this.bt_provedores.Text = "PROVEEDORES";
            this.bt_provedores.UseVisualStyleBackColor = true;
            this.bt_provedores.Visible = false;
            this.bt_provedores.Click += new System.EventHandler(this.bt_provedores_Click);
            // 
            // bt_usuarios
            // 
            this.bt_usuarios.Location = new System.Drawing.Point(6, 164);
            this.bt_usuarios.Name = "bt_usuarios";
            this.bt_usuarios.Size = new System.Drawing.Size(430, 56);
            this.bt_usuarios.TabIndex = 7;
            this.bt_usuarios.Text = "USUARIOS";
            this.bt_usuarios.UseVisualStyleBackColor = true;
            this.bt_usuarios.Click += new System.EventHandler(this.bt_usuarios_Click);
            // 
            // bt_empresa
            // 
            this.bt_empresa.Location = new System.Drawing.Point(6, 24);
            this.bt_empresa.Name = "bt_empresa";
            this.bt_empresa.Size = new System.Drawing.Size(430, 56);
            this.bt_empresa.TabIndex = 5;
            this.bt_empresa.Text = "EMPRESA";
            this.bt_empresa.UseVisualStyleBackColor = true;
            this.bt_empresa.Click += new System.EventHandler(this.bt_empresa_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1064, 514);
            this.ControlBox = false;
            this.Controls.Add(this.gb_opciones);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.gb_opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.FontDialog fd_fuente;
        private System.Windows.Forms.Button btnSelFue;
        private System.Windows.Forms.GroupBox gb_opciones;
        private System.Windows.Forms.Button bt_empresa;
        private System.Windows.Forms.Button bt_provedores;
        private System.Windows.Forms.Button bt_usuarios;
        private System.Windows.Forms.Button bt_socios;
        private System.Windows.Forms.Button bt_servidor;
    }
}