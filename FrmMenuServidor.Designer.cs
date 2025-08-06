namespace ServidorCapaPresentacion
{
    partial class FrmMenuServidor
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BttIniciarServidor = new Button();
            BttDetenerServidor = new Button();
            TxtClientes = new ListBox();
            TxtBitacora = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            Btt_Cons_Pedidos = new Button();
            Btt_Regis_Pedidos = new Button();
            BttRegis_Cons_Repartidores = new Button();
            Btt_Regis_Cons_Clientes = new Button();
            Btt_Regis_Cons_Articulos = new Button();
            BttRegis_Cons_TiposArticulos = new Button();
            label6 = new Label();
            LblEstadoServidor = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(270, 7);
            label1.Name = "label1";
            label1.Size = new Size(183, 36);
            label1.TabIndex = 0;
            label1.Text = "Menu Servidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(-1, 18);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 1;
            label2.Text = "Estado Servidor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F);
            label3.Location = new Point(270, 53);
            label3.Name = "label3";
            label3.Size = new Size(158, 36);
            label3.TabIndex = 2;
            label3.Text = "Entregas S.A";
            // 
            // BttIniciarServidor
            // 
            BttIniciarServidor.Location = new Point(26, 53);
            BttIniciarServidor.Name = "BttIniciarServidor";
            BttIniciarServidor.Size = new Size(75, 23);
            BttIniciarServidor.TabIndex = 3;
            BttIniciarServidor.Text = "Iniciar";
            BttIniciarServidor.UseVisualStyleBackColor = true;
            BttIniciarServidor.Click += BttIniciarServidor_Click;
            // 
            // BttDetenerServidor
            // 
            BttDetenerServidor.Location = new Point(118, 53);
            BttDetenerServidor.Name = "BttDetenerServidor";
            BttDetenerServidor.Size = new Size(75, 23);
            BttDetenerServidor.TabIndex = 4;
            BttDetenerServidor.Text = "Detener";
            BttDetenerServidor.UseVisualStyleBackColor = true;
            BttDetenerServidor.Click += BttDetenerServidor_Click;
            // 
            // TxtClientes
            // 
            TxtClientes.FormattingEnabled = true;
            TxtClientes.ItemHeight = 15;
            TxtClientes.Location = new Point(23, 115);
            TxtClientes.Name = "TxtClientes";
            TxtClientes.Size = new Size(58, 169);
            TxtClientes.TabIndex = 5;
            // 
            // TxtBitacora
            // 
            TxtBitacora.Location = new Point(134, 115);
            TxtBitacora.Multiline = true;
            TxtBitacora.Name = "TxtBitacora";
            TxtBitacora.Size = new Size(308, 169);
            TxtBitacora.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-1, 97);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 7;
            label4.Text = "Clientes Conectados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 97);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 8;
            label5.Text = "Bitacora";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(Btt_Cons_Pedidos);
            panel1.Controls.Add(Btt_Regis_Pedidos);
            panel1.Controls.Add(BttRegis_Cons_Repartidores);
            panel1.Controls.Add(Btt_Regis_Cons_Clientes);
            panel1.Controls.Add(Btt_Regis_Cons_Articulos);
            panel1.Controls.Add(BttRegis_Cons_TiposArticulos);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(448, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 230);
            panel1.TabIndex = 9;
            // 
            // Btt_Cons_Pedidos
            // 
            Btt_Cons_Pedidos.BackColor = Color.LightGray;
            Btt_Cons_Pedidos.ForeColor = Color.Green;
            Btt_Cons_Pedidos.Location = new Point(146, 158);
            Btt_Cons_Pedidos.Name = "Btt_Cons_Pedidos";
            Btt_Cons_Pedidos.Size = new Size(114, 45);
            Btt_Cons_Pedidos.TabIndex = 6;
            Btt_Cons_Pedidos.Text = "Consulta Pedidos";
            Btt_Cons_Pedidos.UseVisualStyleBackColor = false;
            Btt_Cons_Pedidos.Click += Btt_Cons_Pedidos_Click;
            // 
            // Btt_Regis_Pedidos
            // 
            Btt_Regis_Pedidos.BackColor = Color.LightGray;
            Btt_Regis_Pedidos.ForeColor = Color.Green;
            Btt_Regis_Pedidos.Location = new Point(20, 158);
            Btt_Regis_Pedidos.Name = "Btt_Regis_Pedidos";
            Btt_Regis_Pedidos.Size = new Size(114, 45);
            Btt_Regis_Pedidos.TabIndex = 5;
            Btt_Regis_Pedidos.Text = "Registro Pedidos";
            Btt_Regis_Pedidos.UseVisualStyleBackColor = false;
            Btt_Regis_Pedidos.Click += Btt_Regis_Pedidos_Click;
            // 
            // BttRegis_Cons_Repartidores
            // 
            BttRegis_Cons_Repartidores.BackColor = Color.LightGray;
            BttRegis_Cons_Repartidores.ForeColor = Color.Green;
            BttRegis_Cons_Repartidores.Location = new Point(146, 91);
            BttRegis_Cons_Repartidores.Name = "BttRegis_Cons_Repartidores";
            BttRegis_Cons_Repartidores.Size = new Size(114, 49);
            BttRegis_Cons_Repartidores.TabIndex = 4;
            BttRegis_Cons_Repartidores.Text = "Registro-Consulta Repartidores";
            BttRegis_Cons_Repartidores.UseVisualStyleBackColor = false;
            BttRegis_Cons_Repartidores.Click += BttRegis_Cons_Repartidores_Click;
            // 
            // Btt_Regis_Cons_Clientes
            // 
            Btt_Regis_Cons_Clientes.BackColor = Color.LightGray;
            Btt_Regis_Cons_Clientes.ForeColor = Color.Green;
            Btt_Regis_Cons_Clientes.Location = new Point(20, 90);
            Btt_Regis_Cons_Clientes.Name = "Btt_Regis_Cons_Clientes";
            Btt_Regis_Cons_Clientes.Size = new Size(114, 50);
            Btt_Regis_Cons_Clientes.TabIndex = 3;
            Btt_Regis_Cons_Clientes.Text = "Registro-Consulta Clientes";
            Btt_Regis_Cons_Clientes.UseVisualStyleBackColor = false;
            Btt_Regis_Cons_Clientes.Click += Btt_Regis_Cons_Clientes_Click;
            // 
            // Btt_Regis_Cons_Articulos
            // 
            Btt_Regis_Cons_Articulos.BackColor = Color.LightGray;
            Btt_Regis_Cons_Articulos.ForeColor = Color.Green;
            Btt_Regis_Cons_Articulos.Location = new Point(146, 34);
            Btt_Regis_Cons_Articulos.Name = "Btt_Regis_Cons_Articulos";
            Btt_Regis_Cons_Articulos.Size = new Size(114, 38);
            Btt_Regis_Cons_Articulos.TabIndex = 2;
            Btt_Regis_Cons_Articulos.Text = "Registro-Consulta Articulos";
            Btt_Regis_Cons_Articulos.UseVisualStyleBackColor = false;
            Btt_Regis_Cons_Articulos.Click += Btt_Regis_Cons_Articulos_Click;
            // 
            // BttRegis_Cons_TiposArticulos
            // 
            BttRegis_Cons_TiposArticulos.BackColor = Color.LightGray;
            BttRegis_Cons_TiposArticulos.Font = new Font("Segoe UI", 9F);
            BttRegis_Cons_TiposArticulos.ForeColor = Color.Green;
            BttRegis_Cons_TiposArticulos.Location = new Point(20, 31);
            BttRegis_Cons_TiposArticulos.Name = "BttRegis_Cons_TiposArticulos";
            BttRegis_Cons_TiposArticulos.Size = new Size(114, 41);
            BttRegis_Cons_TiposArticulos.TabIndex = 1;
            BttRegis_Cons_TiposArticulos.Text = "Registro - consulta  Tipos Articulos";
            BttRegis_Cons_TiposArticulos.UseVisualStyleBackColor = false;
            BttRegis_Cons_TiposArticulos.Click += BttRegis_Cons_TiposArticulos_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.ForeColor = Color.Green;
            label6.Location = new Point(96, 8);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 0;
            label6.Text = "Zona Mantenimiento";
            // 
            // LblEstadoServidor
            // 
            LblEstadoServidor.AutoSize = true;
            LblEstadoServidor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEstadoServidor.Location = new Point(123, 20);
            LblEstadoServidor.Name = "LblEstadoServidor";
            LblEstadoServidor.Size = new Size(86, 15);
            LblEstadoServidor.TabIndex = 10;
            LblEstadoServidor.Text = "Desconectado";
            // 
            // FrmMenuServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(734, 295);
            Controls.Add(LblEstadoServidor);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtBitacora);
            Controls.Add(TxtClientes);
            Controls.Add(BttDetenerServidor);
            Controls.Add(BttIniciarServidor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMenuServidor";
            Text = "Menu Principal Servidor Entregas S.A";
            Load += FrmMenuServidor_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BttIniciarServidor;
        private Button BttDetenerServidor;
        private ListBox TxtClientes;
        private TextBox TxtBitacora;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Label LblEstadoServidor;
        private Button BttRegis_Cons_TiposArticulos;
        private Button Btt_Regis_Cons_Articulos;
        private Button BttRegis_Cons_Repartidores;
        private Button Btt_Regis_Cons_Clientes;
        private Button Btt_Cons_Pedidos;
        private Button Btt_Regis_Pedidos;
    }
}