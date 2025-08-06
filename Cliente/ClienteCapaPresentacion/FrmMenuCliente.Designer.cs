namespace ClienteCapaPresentacion
{
    partial class FrmMenuCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BttAgregarPedidos = new Button();
            BttConsultarPedidos = new Button();
            TxtIdentificacion = new TextBox();
            BttConectar = new Button();
            BttDesconectar = new Button();
            LblEstado = new Label();
            LblCliente = new Label();
            label6 = new Label();
            LblIdentificacion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(228, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 0;
            label1.Text = "Menu Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(243, 30);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 1;
            label2.Text = "Entregas S.A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(11, 57);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 84);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 151);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "Identificacion:";
            // 
            // BttAgregarPedidos
            // 
            BttAgregarPedidos.Location = new Point(78, 294);
            BttAgregarPedidos.Name = "BttAgregarPedidos";
            BttAgregarPedidos.Size = new Size(177, 31);
            BttAgregarPedidos.TabIndex = 5;
            BttAgregarPedidos.Text = "Agregar Pedidos";
            BttAgregarPedidos.UseVisualStyleBackColor = true;
            BttAgregarPedidos.Click += BttAgregarPedidos_Click;
            // 
            // BttConsultarPedidos
            // 
            BttConsultarPedidos.Location = new Point(280, 294);
            BttConsultarPedidos.Name = "BttConsultarPedidos";
            BttConsultarPedidos.Size = new Size(164, 31);
            BttConsultarPedidos.TabIndex = 6;
            BttConsultarPedidos.Text = "Consultar mis pedidos";
            BttConsultarPedidos.UseVisualStyleBackColor = true;
            BttConsultarPedidos.Click += BttConsultarPedidos_Click;
            // 
            // TxtIdentificacion
            // 
            TxtIdentificacion.Location = new Point(99, 148);
            TxtIdentificacion.Name = "TxtIdentificacion";
            TxtIdentificacion.Size = new Size(100, 23);
            TxtIdentificacion.TabIndex = 7;
            // 
            // BttConectar
            // 
            BttConectar.Location = new Point(206, 179);
            BttConectar.Name = "BttConectar";
            BttConectar.Size = new Size(103, 23);
            BttConectar.TabIndex = 8;
            BttConectar.Text = "Conectar";
            BttConectar.UseVisualStyleBackColor = true;
            BttConectar.Click += BttConectar_Click;
            // 
            // BttDesconectar
            // 
            BttDesconectar.Location = new Point(315, 179);
            BttDesconectar.Name = "BttDesconectar";
            BttDesconectar.Size = new Size(111, 23);
            BttDesconectar.TabIndex = 9;
            BttDesconectar.Text = "Desconectar";
            BttDesconectar.UseVisualStyleBackColor = true;
            BttDesconectar.Click += BttDesconectar_Click;
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LblEstado.Location = new Point(62, 57);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(83, 15);
            LblEstado.TabIndex = 10;
            LblEstado.Text = "Desconectado";
            // 
            // LblCliente
            // 
            LblCliente.AutoSize = true;
            LblCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LblCliente.Location = new Point(99, 84);
            LblCliente.Name = "LblCliente";
            LblCliente.Size = new Size(13, 15);
            LblCliente.TabIndex = 11;
            LblCliente.Text = "..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(11, 108);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 12;
            label6.Text = "Identificacion:";
            // 
            // LblIdentificacion
            // 
            LblIdentificacion.AutoSize = true;
            LblIdentificacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LblIdentificacion.Location = new Point(99, 108);
            LblIdentificacion.Name = "LblIdentificacion";
            LblIdentificacion.Size = new Size(13, 15);
            LblIdentificacion.TabIndex = 13;
            LblIdentificacion.Text = "..";
            // 
            // FrmMenuCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(506, 450);
            Controls.Add(LblIdentificacion);
            Controls.Add(label6);
            Controls.Add(LblCliente);
            Controls.Add(LblEstado);
            Controls.Add(BttDesconectar);
            Controls.Add(BttConectar);
            Controls.Add(TxtIdentificacion);
            Controls.Add(BttConsultarPedidos);
            Controls.Add(BttAgregarPedidos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmMenuCliente";
            Text = "Menu Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BttAgregarPedidos;
        private Button BttConsultarPedidos;
        private TextBox TxtIdentificacion;
        private Button BttConectar;
        private Button BttDesconectar;
        private Label LblEstado;
        private Label LblCliente;
        private Label label6;
        private Label LblIdentificacion;
    }
}