namespace ClienteCapaPresentacion
{
    partial class FrmConsultas
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
            BttMenu = new Button();
            BttConsultasTodos = new Button();
            BttConsularNumeroPedido = new Button();
            DgvConsulta = new DataGridView();
            LblNombre = new Label();
            TxtNumeroPedido = new TextBox();
            LblIdentificacion = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // BttMenu
            // 
            BttMenu.BackColor = Color.FromArgb(255, 128, 0);
            BttMenu.Location = new Point(53, 351);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(136, 34);
            BttMenu.TabIndex = 0;
            BttMenu.Text = "Menu principal";
            BttMenu.UseVisualStyleBackColor = false;
            BttMenu.Click += button1_Click;
            // 
            // BttConsultasTodos
            // 
            BttConsultasTodos.BackColor = Color.Brown;
            BttConsultasTodos.Location = new Point(245, 355);
            BttConsultasTodos.Name = "BttConsultasTodos";
            BttConsultasTodos.Size = new Size(204, 30);
            BttConsultasTodos.TabIndex = 1;
            BttConsultasTodos.Text = "Consultar todos los pedidos";
            BttConsultasTodos.UseVisualStyleBackColor = false;
            BttConsultasTodos.Click += BttConsultasTodos_Click;
            // 
            // BttConsularNumeroPedido
            // 
            BttConsularNumeroPedido.BackColor = Color.Coral;
            BttConsularNumeroPedido.Location = new Point(566, 355);
            BttConsularNumeroPedido.Name = "BttConsularNumeroPedido";
            BttConsularNumeroPedido.Size = new Size(154, 30);
            BttConsularNumeroPedido.TabIndex = 2;
            BttConsularNumeroPedido.Text = "Consultar por numero";
            BttConsularNumeroPedido.UseVisualStyleBackColor = false;
            BttConsularNumeroPedido.Click += BttConsularNumeroPedido_Click;
            // 
            // DgvConsulta
            // 
            DgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsulta.BackgroundColor = SystemColors.ActiveCaption;
            DgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsulta.Location = new Point(27, 65);
            DgvConsulta.Name = "DgvConsulta";
            DgvConsulta.Size = new Size(731, 219);
            DgvConsulta.TabIndex = 3;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Location = new Point(53, 18);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(38, 15);
            LblNombre.TabIndex = 4;
            LblNombre.Text = "label1";
            // 
            // TxtNumeroPedido
            // 
            TxtNumeroPedido.BackColor = Color.Coral;
            TxtNumeroPedido.Location = new Point(566, 391);
            TxtNumeroPedido.Name = "TxtNumeroPedido";
            TxtNumeroPedido.Size = new Size(154, 23);
            TxtNumeroPedido.TabIndex = 5;
            // 
            // LblIdentificacion
            // 
            LblIdentificacion.AutoSize = true;
            LblIdentificacion.Location = new Point(55, 45);
            LblIdentificacion.Name = "LblIdentificacion";
            LblIdentificacion.Size = new Size(38, 15);
            LblIdentificacion.TabIndex = 6;
            LblIdentificacion.Text = "label1";
            // 
            // FrmConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(LblIdentificacion);
            Controls.Add(TxtNumeroPedido);
            Controls.Add(LblNombre);
            Controls.Add(DgvConsulta);
            Controls.Add(BttConsularNumeroPedido);
            Controls.Add(BttConsultasTodos);
            Controls.Add(BttMenu);
            Name = "FrmConsultas";
            Text = "Consultas pedidos cliente";
            Load += FrmConsultas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BttMenu;
        private Button BttConsultasTodos;
        private Button BttConsularNumeroPedido;
        private DataGridView DgvConsulta;
        private Label LblNombre;
        private TextBox TxtNumeroPedido;
        private Label LblIdentificacion;
    }
}