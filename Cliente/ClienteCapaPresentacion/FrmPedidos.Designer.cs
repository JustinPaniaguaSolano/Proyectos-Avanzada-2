namespace CapaPresentacion
{
    partial class FrmPedidos
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
            label8 = new Label();
            label6 = new Label();
            BttGuardar = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            BttMenu = new Button();
            DtpFechaPedido = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            CmbArticulos = new ComboBox();
            DvgDetallesArticulos = new DataGridView();
            BttMostrarInformacion = new Button();
            TxtCantidad = new TextBox();
            label9 = new Label();
            LblCliente = new Label();
            label10 = new Label();
            LblIdentificacion = new Label();
            TxtDireccion = new TextBox();
            CmbRepartidor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DvgDetallesArticulos).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label8.Location = new Point(12, 292);
            label8.Name = "label8";
            label8.Size = new Size(177, 25);
            label8.TabIndex = 61;
            label8.Text = "Escoja el repartidor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label6.Location = new Point(12, 332);
            label6.Name = "label6";
            label6.Size = new Size(172, 25);
            label6.TabIndex = 62;
            label6.Text = "Digite la direccion:";
            // 
            // BttGuardar
            // 
            BttGuardar.BackColor = Color.ForestGreen;
            BttGuardar.Font = new Font("Segoe UI", 15F);
            BttGuardar.ForeColor = SystemColors.ButtonHighlight;
            BttGuardar.Location = new Point(579, 390);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(115, 38);
            BttGuardar.TabIndex = 60;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = false;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(12, 251);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 56;
            label5.Text = "Digite la cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Size = new Size(236, 25);
            label4.TabIndex = 55;
            label4.Text = "Digite la fecha del pedido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(301, 82);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 54;
            label1.Text = "Registro pedidos";
            // 
            // BttMenu
            // 
            BttMenu.BackColor = Color.OrangeRed;
            BttMenu.Font = new Font("Segoe UI", 15F);
            BttMenu.ForeColor = SystemColors.ButtonHighlight;
            BttMenu.Location = new Point(176, 390);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(115, 38);
            BttMenu.TabIndex = 51;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = false;
            BttMenu.Click += BttMenu_Click;
            // 
            // DtpFechaPedido
            // 
            DtpFechaPedido.CalendarMonthBackground = SystemColors.ControlDarkDark;
            DtpFechaPedido.CalendarTitleBackColor = SystemColors.ControlDarkDark;
            DtpFechaPedido.Location = new Point(242, 210);
            DtpFechaPedido.Name = "DtpFechaPedido";
            DtpFechaPedido.Size = new Size(212, 23);
            DtpFechaPedido.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(205, 9);
            label2.Name = "label2";
            label2.Size = new Size(361, 59);
            label2.TabIndex = 71;
            label2.Text = "Entregas S.A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(12, 170);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 52;
            label3.Text = "Escoja el articulo :";
            // 
            // CmbArticulos
            // 
            CmbArticulos.BackColor = SystemColors.Info;
            CmbArticulos.FormattingEnabled = true;
            CmbArticulos.Location = new Point(242, 175);
            CmbArticulos.Name = "CmbArticulos";
            CmbArticulos.Size = new Size(212, 23);
            CmbArticulos.TabIndex = 72;
            // 
            // DvgDetallesArticulos
            // 
            DvgDetallesArticulos.BackgroundColor = SystemColors.Info;
            DvgDetallesArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DvgDetallesArticulos.Location = new Point(469, 170);
            DvgDetallesArticulos.Name = "DvgDetallesArticulos";
            DvgDetallesArticulos.Size = new Size(319, 78);
            DvgDetallesArticulos.TabIndex = 73;
            // 
            // BttMostrarInformacion
            // 
            BttMostrarInformacion.BackColor = Color.Tomato;
            BttMostrarInformacion.Location = new Point(330, 390);
            BttMostrarInformacion.Name = "BttMostrarInformacion";
            BttMostrarInformacion.Size = new Size(190, 38);
            BttMostrarInformacion.TabIndex = 74;
            BttMostrarInformacion.Text = "Mostrar la Informacion articulo";
            BttMostrarInformacion.UseVisualStyleBackColor = false;
            BttMostrarInformacion.Click += BttAgregarArticulo_Click;
            // 
            // TxtCantidad
            // 
            TxtCantidad.BackColor = SystemColors.Info;
            TxtCantidad.Location = new Point(242, 251);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(100, 23);
            TxtCantidad.TabIndex = 75;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label9.Location = new Point(12, 145);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 76;
            label9.Text = "Cliente:";
            // 
            // LblCliente
            // 
            LblCliente.AutoSize = true;
            LblCliente.BackColor = SystemColors.ActiveCaption;
            LblCliente.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            LblCliente.Location = new Point(242, 147);
            LblCliente.Name = "LblCliente";
            LblCliente.Size = new Size(72, 25);
            LblCliente.TabIndex = 77;
            LblCliente.Text = "label10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label10.Location = new Point(12, 114);
            label10.Name = "label10";
            label10.Size = new Size(194, 25);
            label10.TabIndex = 78;
            label10.Text = "Identificacion Cliente";
            // 
            // LblIdentificacion
            // 
            LblIdentificacion.AutoSize = true;
            LblIdentificacion.BackColor = SystemColors.ActiveCaption;
            LblIdentificacion.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            LblIdentificacion.Location = new Point(245, 114);
            LblIdentificacion.Name = "LblIdentificacion";
            LblIdentificacion.Size = new Size(69, 25);
            LblIdentificacion.TabIndex = 79;
            LblIdentificacion.Text = "label11";
            // 
            // TxtDireccion
            // 
            TxtDireccion.BackColor = SystemColors.Info;
            TxtDireccion.Font = new Font("Segoe UI", 14F);
            TxtDireccion.ForeColor = SystemColors.InfoText;
            TxtDireccion.Location = new Point(242, 329);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(212, 32);
            TxtDireccion.TabIndex = 69;
            // 
            // CmbRepartidor
            // 
            CmbRepartidor.BackColor = SystemColors.Info;
            CmbRepartidor.Font = new Font("Segoe UI", 14F);
            CmbRepartidor.ForeColor = SystemColors.InfoText;
            CmbRepartidor.FormattingEnabled = true;
            CmbRepartidor.Location = new Point(242, 289);
            CmbRepartidor.Name = "CmbRepartidor";
            CmbRepartidor.Size = new Size(212, 33);
            CmbRepartidor.TabIndex = 68;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(LblIdentificacion);
            Controls.Add(label10);
            Controls.Add(LblCliente);
            Controls.Add(label9);
            Controls.Add(TxtCantidad);
            Controls.Add(BttMostrarInformacion);
            Controls.Add(DvgDetallesArticulos);
            Controls.Add(CmbArticulos);
            Controls.Add(label2);
            Controls.Add(DtpFechaPedido);
            Controls.Add(TxtDireccion);
            Controls.Add(CmbRepartidor);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(BttGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BttMenu);
            Name = "FrmPedidos";
            Text = "Registrar Pedidos Entregas S.A";
            Load += FrmPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)DvgDetallesArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtpFechaNacimiento;
        private TextBox TxtPrimerApellido;
        private ComboBox CmbActivo;
        private Label label7;
        private Label label8;
        private Label label6;
        private Button BttGuardar;
        private TextBox TxtSegundoApellido;
        private TextBox TxtNombre;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button BttMenu;
        private DateTimePicker DtpFechaPedido;
        private Label label2;
        private Label label3;
        private ComboBox CmbArticulos;
        private DataGridView DvgDetallesArticulos;
        private Button BttMostrarInformacion;
        private TextBox TxtCantidad;
        private Label label9;
        private Label LblCliente;
        private Label label10;
        private Label LblIdentificacion;
        private TextBox TxtDireccion;
        private ComboBox CmbRepartidor;
    }
}