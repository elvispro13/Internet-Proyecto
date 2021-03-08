
namespace Principal_Internet_elvis
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.lb_pendiente = new System.Windows.Forms.Label();
            this.dgv_pendientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_actualizar.Location = new System.Drawing.Point(908, 290);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(144, 33);
            this.bt_actualizar.TabIndex = 8;
            this.bt_actualizar.Text = "ACTUALIZAR";
            this.bt_actualizar.UseVisualStyleBackColor = true;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // lb_pendiente
            // 
            this.lb_pendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_pendiente.AutoSize = true;
            this.lb_pendiente.ForeColor = System.Drawing.Color.White;
            this.lb_pendiente.Location = new System.Drawing.Point(557, 7);
            this.lb_pendiente.Name = "lb_pendiente";
            this.lb_pendiente.Size = new System.Drawing.Size(161, 13);
            this.lb_pendiente.TabIndex = 7;
            this.lb_pendiente.Text = "PENDIENTE DE INSTALACION";
            // 
            // dgv_pendientes
            // 
            this.dgv_pendientes.AllowUserToAddRows = false;
            this.dgv_pendientes.AllowUserToDeleteRows = false;
            this.dgv_pendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_pendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_pendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pendientes.Location = new System.Drawing.Point(560, 26);
            this.dgv_pendientes.Name = "dgv_pendientes";
            this.dgv_pendientes.ReadOnly = true;
            this.dgv_pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pendientes.Size = new System.Drawing.Size(492, 258);
            this.dgv_pendientes.TabIndex = 6;
            this.dgv_pendientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pendientes_CellDoubleClick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.lb_pendiente);
            this.Controls.Add(this.dgv_pendientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_actualizar;
        private System.Windows.Forms.Label lb_pendiente;
        private System.Windows.Forms.DataGridView dgv_pendientes;
    }
}