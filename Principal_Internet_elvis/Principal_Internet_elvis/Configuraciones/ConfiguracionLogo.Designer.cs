namespace Principal_Internet_elvis.Configuraciones
{
    partial class ConfiguracionLogo
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
            this.txt_logo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_logo = new System.Windows.Forms.Button();
            this.pfd_logo = new System.Windows.Forms.OpenFileDialog();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_eslogan = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_logo
            // 
            this.txt_logo.Location = new System.Drawing.Point(6, 19);
            this.txt_logo.Name = "txt_logo";
            this.txt_logo.Size = new System.Drawing.Size(188, 20);
            this.txt_logo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_logo);
            this.groupBox1.Controls.Add(this.bt_logo);
            this.groupBox1.Controls.Add(this.txt_logo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGO";
            // 
            // bt_logo
            // 
            this.bt_logo.Location = new System.Drawing.Point(200, 17);
            this.bt_logo.Name = "bt_logo";
            this.bt_logo.Size = new System.Drawing.Size(28, 23);
            this.bt_logo.TabIndex = 1;
            this.bt_logo.Text = "...";
            this.bt_logo.UseVisualStyleBackColor = true;
            this.bt_logo.Click += new System.EventHandler(this.bt_logo_Click);
            // 
            // pfd_logo
            // 
            this.pfd_logo.FileName = "openFileDialog1";
            // 
            // pb_logo
            // 
            this.pb_logo.Location = new System.Drawing.Point(6, 46);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(217, 212);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 2;
            this.pb_logo.TabStop = false;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Image = global::Principal_Internet_elvis.Properties.Resources.savetheapplication_guardar_2958;
            this.bt_aceptar.Location = new System.Drawing.Point(18, 355);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(123, 55);
            this.bt_aceptar.TabIndex = 2;
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Image = global::Principal_Internet_elvis.Properties.Resources.emblemunreadable_93487;
            this.bt_cancelar.Location = new System.Drawing.Point(147, 355);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(123, 55);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Location = new System.Drawing.Point(260, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 50);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOMBRE";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(6, 19);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(155, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_eslogan);
            this.groupBox3.Location = new System.Drawing.Point(260, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 50);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ESLOGAN";
            // 
            // txt_eslogan
            // 
            this.txt_eslogan.Location = new System.Drawing.Point(6, 19);
            this.txt_eslogan.Name = "txt_eslogan";
            this.txt_eslogan.Size = new System.Drawing.Size(155, 20);
            this.txt_eslogan.TabIndex = 0;
            // 
            // ConfiguracionLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 420);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfiguracionLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguracionLogo";
            this.Load += new System.EventHandler(this.ConfiguracionLogo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_logo;
        private System.Windows.Forms.OpenFileDialog pfd_logo;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_eslogan;
    }
}