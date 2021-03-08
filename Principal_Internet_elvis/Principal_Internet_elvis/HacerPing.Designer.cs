
namespace Principal_Internet_elvis
{
    partial class HacerPing
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
            this.components = new System.ComponentModel.Container();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.timer_ping = new System.Windows.Forms.Timer(this.components);
            this.bt_salir = new System.Windows.Forms.Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_log
            // 
            this.txt_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_log.BackColor = System.Drawing.Color.Black;
            this.txt_log.ForeColor = System.Drawing.Color.White;
            this.txt_log.Location = new System.Drawing.Point(12, 67);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(579, 315);
            this.txt_log.TabIndex = 0;
            // 
            // timer_ping
            // 
            this.timer_ping.Interval = 1000;
            this.timer_ping.Tick += new System.EventHandler(this.timer_ping_Tick);
            // 
            // bt_salir
            // 
            this.bt_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_salir.BackColor = System.Drawing.Color.Red;
            this.bt_salir.ForeColor = System.Drawing.Color.White;
            this.bt_salir.Location = new System.Drawing.Point(546, 12);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(45, 45);
            this.bt_salir.TabIndex = 1;
            this.bt_salir.Text = "X";
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Location = new System.Drawing.Point(12, 28);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(28, 13);
            this.lb_titulo.TabIndex = 2;
            this.lb_titulo.Text = "Ping";
            // 
            // HacerPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(603, 394);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.txt_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HacerPing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping";
            this.Load += new System.EventHandler(this.HacerPing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Timer timer_ping;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Label lb_titulo;
    }
}