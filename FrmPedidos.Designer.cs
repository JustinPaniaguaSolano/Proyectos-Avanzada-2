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
            CmbCliente = new ComboBox();
            CmbRepartidor = new ComboBox();
            TxtDireccion = new TextBox();
            DtpFechaPedido = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label8.Location = new Point(104, 292);
            label8.Name = "label8";
            label8.Size = new Size(177, 25);
            label8.TabIndex = 61;
            label8.Text = "Escoja el repartidor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label6.Location = new Point(104, 343);
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
            BttGuardar.Location = new Point(445, 390);
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
            label5.Location = new Point(104, 248);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 56;
            label5.Text = "Escoja el cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(104, 207);
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
            label1.Location = new Point(330, 98);
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
            // CmbCliente
            // 
            CmbCliente.BackColor = SystemColors.ScrollBar;
            CmbCliente.Font = new Font("Segoe UI", 14F);
            CmbCliente.FormattingEnabled = true;
            CmbCliente.Location = new Point(445, 248);
            CmbCliente.Name = "CmbCliente";
            CmbCliente.Size = new Size(300, 33);
            CmbCliente.TabIndex = 67;
            // 
            // CmbRepartidor
            // 
            CmbRepartidor.BackColor = SystemColors.ScrollBar;
            CmbRepartidor.Font = new Font("Segoe UI", 14F);
            CmbRepartidor.FormattingEnabled = true;
            CmbRepartidor.Location = new Point(445, 292);
            CmbRepartidor.Name = "CmbRepartidor";
            CmbRepartidor.Size = new Size(300, 33);
            CmbRepartidor.TabIndex = 68;
            // 
            // TxtDireccion
            // 
            TxtDireccion.BackColor = SystemColors.ActiveBorder;
            TxtDireccion.Font = new Font("Segoe UI", 14F);
            TxtDireccion.Location = new Point(445, 343);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(298, 32);
            TxtDireccion.TabIndex = 69;
            // 
            // DtpFechaPedido
            // 
            DtpFechaPedido.CalendarMonthBackground = SystemColors.ScrollBar;
            DtpFechaPedido.Location = new Point(450, 210);
            DtpFechaPedido.Name = "DtpFechaPedido";
            DtpFechaPedido.Size = new Size(293, 23);
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
            label2.Location = new Point(211, 25);
            label2.Name = "label2";
            label2.Size = new Size(361, 59);
            label2.TabIndex = 71;
            label2.Text = "Entregas S.A";
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(DtpFechaPedido);
            Controls.Add(TxtDireccion);
            Controls.Add(CmbRepartidor);
            Controls.Add(CmbCliente);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(BttGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(BttMenu);
            Name = "FrmPedidos";
            Text = "Registrar Pedidos Entregas S.A";
            Load += FrmPedidos_Load;
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
        private ComboBox CmbCliente;
        private ComboBox CmbRepartidor;
        private TextBox TxtDireccion;
        private DateTimePicker DtpFechaPedido;
        private Label label2;
    }
}