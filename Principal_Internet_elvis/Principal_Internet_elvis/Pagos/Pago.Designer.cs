namespace Principal_Internet_elvis.Pagos
{
    partial class Pago
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
            this.gDatosCli = new System.Windows.Forms.GroupBox();
            this.btnbusCLI = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBusCliente = new System.Windows.Forms.GroupBox();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbDni = new System.Windows.Forms.RadioButton();
            this.btnAtrasCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gBusConcep = new System.Windows.Forms.GroupBox();
            this.txtbuscarConcepto = new System.Windows.Forms.TextBox();
            this.btnAtrasConcepto = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gDatosCon = new System.Windows.Forms.GroupBox();
            this.dtpMesPago = new System.Windows.Forms.DateTimePicker();
            this.btnBusCON = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNCON = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNoboleta = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpFechaEmicion = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gDatosCli.SuspendLayout();
            this.gBusCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBusConcep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gDatosCon.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gDatosCli
            // 
            this.gDatosCli.BackColor = System.Drawing.Color.White;
            this.gDatosCli.Controls.Add(this.btnbusCLI);
            this.gDatosCli.Controls.Add(this.label4);
            this.gDatosCli.Controls.Add(this.txtDirec);
            this.gDatosCli.Controls.Add(this.txtDni);
            this.gDatosCli.Controls.Add(this.label3);
            this.gDatosCli.Controls.Add(this.txtNombre);
            this.gDatosCli.Controls.Add(this.label2);
            this.gDatosCli.Controls.Add(this.txtId);
            this.gDatosCli.Controls.Add(this.label1);
            this.gDatosCli.Location = new System.Drawing.Point(231, 12);
            this.gDatosCli.Name = "gDatosCli";
            this.gDatosCli.Size = new System.Drawing.Size(485, 135);
            this.gDatosCli.TabIndex = 0;
            this.gDatosCli.TabStop = false;
            this.gDatosCli.Text = "DATOS DEL CLIENTE";
            // 
            // btnbusCLI
            // 
            this.btnbusCLI.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.btnbusCLI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbusCLI.Location = new System.Drawing.Point(371, 14);
            this.btnbusCLI.Name = "btnbusCLI";
            this.btnbusCLI.Size = new System.Drawing.Size(108, 47);
            this.btnbusCLI.TabIndex = 8;
            this.btnbusCLI.Text = "Buscar";
            this.btnbusCLI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbusCLI.UseVisualStyleBackColor = true;
            this.btnbusCLI.Click += new System.EventHandler(this.btnbusCLI_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion:";
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(260, 93);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(219, 20);
            this.txtDirec.TabIndex = 6;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(75, 93);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(118, 20);
            this.txtDni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(404, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(75, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No° Cliente:";
            // 
            // gBusCliente
            // 
            this.gBusCliente.BackColor = System.Drawing.Color.White;
            this.gBusCliente.Controls.Add(this.txtBuscaCliente);
            this.gBusCliente.Controls.Add(this.rbNombre);
            this.gBusCliente.Controls.Add(this.rbDni);
            this.gBusCliente.Controls.Add(this.btnAtrasCliente);
            this.gBusCliente.Controls.Add(this.dataGridView1);
            this.gBusCliente.Location = new System.Drawing.Point(231, 12);
            this.gBusCliente.Name = "gBusCliente";
            this.gBusCliente.Size = new System.Drawing.Size(485, 135);
            this.gBusCliente.TabIndex = 1;
            this.gBusCliente.TabStop = false;
            this.gBusCliente.Text = "BUSCAR CLIENTE";
            // 
            // txtBuscaCliente
            // 
            this.txtBuscaCliente.Location = new System.Drawing.Point(124, 17);
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(274, 20);
            this.txtBuscaCliente.TabIndex = 4;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(56, 20);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(62, 17);
            this.rbNombre.TabIndex = 3;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbDni
            // 
            this.rbDni.AutoSize = true;
            this.rbDni.Location = new System.Drawing.Point(6, 20);
            this.rbDni.Name = "rbDni";
            this.rbDni.Size = new System.Drawing.Size(44, 17);
            this.rbDni.TabIndex = 2;
            this.rbDni.TabStop = true;
            this.rbDni.Text = "DNI";
            this.rbDni.UseVisualStyleBackColor = true;
            // 
            // btnAtrasCliente
            // 
            this.btnAtrasCliente.Location = new System.Drawing.Point(404, 14);
            this.btnAtrasCliente.Name = "btnAtrasCliente";
            this.btnAtrasCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAtrasCliente.TabIndex = 1;
            this.btnAtrasCliente.Text = "Atras";
            this.btnAtrasCliente.UseVisualStyleBackColor = true;
            this.btnAtrasCliente.Click += new System.EventHandler(this.btnAtrasCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 88);
            this.dataGridView1.TabIndex = 0;
            // 
            // gBusConcep
            // 
            this.gBusConcep.BackColor = System.Drawing.Color.White;
            this.gBusConcep.Controls.Add(this.txtbuscarConcepto);
            this.gBusConcep.Controls.Add(this.btnAtrasConcepto);
            this.gBusConcep.Controls.Add(this.dataGridView2);
            this.gBusConcep.Location = new System.Drawing.Point(231, 153);
            this.gBusConcep.Name = "gBusConcep";
            this.gBusConcep.Size = new System.Drawing.Size(485, 135);
            this.gBusConcep.TabIndex = 6;
            this.gBusConcep.TabStop = false;
            this.gBusConcep.Text = "BUSCAR CONCEPTO";
            // 
            // txtbuscarConcepto
            // 
            this.txtbuscarConcepto.Location = new System.Drawing.Point(9, 17);
            this.txtbuscarConcepto.Name = "txtbuscarConcepto";
            this.txtbuscarConcepto.Size = new System.Drawing.Size(389, 20);
            this.txtbuscarConcepto.TabIndex = 4;
            // 
            // btnAtrasConcepto
            // 
            this.btnAtrasConcepto.Location = new System.Drawing.Point(404, 14);
            this.btnAtrasConcepto.Name = "btnAtrasConcepto";
            this.btnAtrasConcepto.Size = new System.Drawing.Size(75, 23);
            this.btnAtrasConcepto.TabIndex = 1;
            this.btnAtrasConcepto.Text = "Atras";
            this.btnAtrasConcepto.UseVisualStyleBackColor = true;
            this.btnAtrasConcepto.Click += new System.EventHandler(this.btnAtrasConcepto_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(473, 88);
            this.dataGridView2.TabIndex = 0;
            // 
            // gDatosCon
            // 
            this.gDatosCon.BackColor = System.Drawing.Color.White;
            this.gDatosCon.Controls.Add(this.dtpMesPago);
            this.gDatosCon.Controls.Add(this.btnBusCON);
            this.gDatosCon.Controls.Add(this.label5);
            this.gDatosCon.Controls.Add(this.txtMonto);
            this.gDatosCon.Controls.Add(this.label6);
            this.gDatosCon.Controls.Add(this.txtDescripcion);
            this.gDatosCon.Controls.Add(this.label7);
            this.gDatosCon.Controls.Add(this.txtNCON);
            this.gDatosCon.Controls.Add(this.label8);
            this.gDatosCon.Location = new System.Drawing.Point(231, 153);
            this.gDatosCon.Name = "gDatosCon";
            this.gDatosCon.Size = new System.Drawing.Size(485, 135);
            this.gDatosCon.TabIndex = 5;
            this.gDatosCon.TabStop = false;
            this.gDatosCon.Text = "DATOS DEL CONCEPTO";
            // 
            // dtpMesPago
            // 
            this.dtpMesPago.Location = new System.Drawing.Point(277, 92);
            this.dtpMesPago.Name = "dtpMesPago";
            this.dtpMesPago.Size = new System.Drawing.Size(200, 20);
            this.dtpMesPago.TabIndex = 7;
            // 
            // btnBusCON
            // 
            this.btnBusCON.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.btnBusCON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusCON.Location = new System.Drawing.Point(371, 14);
            this.btnBusCON.Name = "btnBusCON";
            this.btnBusCON.Size = new System.Drawing.Size(108, 47);
            this.btnBusCON.TabIndex = 8;
            this.btnBusCON.Text = "Buscar";
            this.btnBusCON.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusCON.UseVisualStyleBackColor = true;
            this.btnBusCON.Click += new System.EventHandler(this.btnBusCON_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mes de pago:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(94, 93);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(99, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Monto:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(94, 67);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(385, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descripcion:";
            // 
            // txtNCON
            // 
            this.txtNCON.Location = new System.Drawing.Point(94, 42);
            this.txtNCON.Name = "txtNCON";
            this.txtNCON.Size = new System.Drawing.Size(100, 20);
            this.txtNCON.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "No° Concepto:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNoboleta);
            this.groupBox5.Location = new System.Drawing.Point(722, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 64);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "No° DE BOLETA";
            // 
            // txtNoboleta
            // 
            this.txtNoboleta.Location = new System.Drawing.Point(6, 28);
            this.txtNoboleta.Name = "txtNoboleta";
            this.txtNoboleta.Size = new System.Drawing.Size(200, 20);
            this.txtNoboleta.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtpFechaEmicion);
            this.groupBox6.Location = new System.Drawing.Point(722, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 65);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "FECHA DE EMICION";
            // 
            // dtpFechaEmicion
            // 
            this.dtpFechaEmicion.Location = new System.Drawing.Point(6, 26);
            this.dtpFechaEmicion.Name = "dtpFechaEmicion";
            this.dtpFechaEmicion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEmicion.TabIndex = 9;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView3);
            this.groupBox7.Location = new System.Drawing.Point(12, 294);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(923, 114);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DETALLE DEL COMPROBANTE DE PAGO";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(910, 89);
            this.dataGridView3.TabIndex = 0;
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(822, 427);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(108, 20);
            this.txtPago.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(695, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total a Pagar:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Principal_Internet_elvis.Properties.Resources.emblemunreadable_93487;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(234, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 55);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Principal_Internet_elvis.Properties.Resources.Print_icon_icons_com_55835;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(123, 410);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(108, 55);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Principal_Internet_elvis.Properties.Resources.savetheapplication_guardar_2958_1_;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 410);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 55);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Principal_Internet_elvis.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Principal_Internet_elvis.Properties.Resources.rounded_add_button_icon_icons_com_72592;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(722, 159);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(213, 41);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::Principal_Internet_elvis.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(722, 204);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(213, 41);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Principal_Internet_elvis.Properties.Resources.cancel_86054;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(722, 249);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(213, 39);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 497);
            this.ControlBox = false;
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gDatosCon);
            this.Controls.Add(this.gBusConcep);
            this.Controls.Add(this.gDatosCli);
            this.Controls.Add(this.gBusCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAGO";
            this.Load += new System.EventHandler(this.Pago_Load);
            this.gDatosCli.ResumeLayout(false);
            this.gDatosCli.PerformLayout();
            this.gBusCliente.ResumeLayout(false);
            this.gBusCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBusConcep.ResumeLayout(false);
            this.gBusConcep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gDatosCon.ResumeLayout(false);
            this.gDatosCon.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gDatosCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbusCLI;
        private System.Windows.Forms.GroupBox gBusCliente;
        private System.Windows.Forms.TextBox txtBuscaCliente;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbDni;
        private System.Windows.Forms.Button btnAtrasCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gBusConcep;
        private System.Windows.Forms.TextBox txtbuscarConcepto;
        private System.Windows.Forms.Button btnAtrasConcepto;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gDatosCon;
        private System.Windows.Forms.DateTimePicker dtpMesPago;
        private System.Windows.Forms.Button btnBusCON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNCON;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNoboleta;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtpFechaEmicion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label9;
    }
}