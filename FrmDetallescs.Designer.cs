namespace CapaPresentacion
{
    partial class FrmDetallescs
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
            CmbArticulo = new ComboBox();
            BttGuardar = new Button();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            LbNumeroPedido = new Label();
            label8 = new Label();
            TxtCantidad = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // CmbArticulo
            // 
            CmbArticulo.BackColor = SystemColors.ScrollBar;
            CmbArticulo.Font = new Font("Segoe UI", 14F);
            CmbArticulo.FormattingEnabled = true;
            CmbArticulo.Location = new Point(419, 208);
            CmbArticulo.Name = "CmbArticulo";
            CmbArticulo.Size = new Size(300, 33);
            CmbArticulo.TabIndex = 82;
            // 
            // BttGuardar
            // 
            BttGuardar.BackColor = Color.ForestGreen;
            BttGuardar.Font = new Font("Segoe UI", 15F);
            BttGuardar.ForeColor = SystemColors.ButtonHighlight;
            BttGuardar.Location = new Point(337, 381);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(115, 38);
            BttGuardar.TabIndex = 79;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = false;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(80, 216);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 77;
            label5.Text = "Escoja el Articulo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(269, 97);
            label1.Name = "label1";
            label1.Size = new Size(244, 28);
            label1.TabIndex = 75;
            label1.Text = "Registro Detalles Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(80, 152);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 73;
            label3.Text = "Numero Pedido:";
            // 
            // LbNumeroPedido
            // 
            LbNumeroPedido.AutoSize = true;
            LbNumeroPedido.Font = new Font("Segoe UI", 14F);
            LbNumeroPedido.Location = new Point(429, 154);
            LbNumeroPedido.Name = "LbNumeroPedido";
            LbNumeroPedido.Size = new Size(63, 25);
            LbNumeroPedido.TabIndex = 87;
            LbNumeroPedido.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label8.Location = new Point(76, 273);
            label8.Name = "label8";
            label8.Size = new Size(168, 25);
            label8.TabIndex = 80;
            label8.Text = "Digite la cantidad:";
            // 
            // TxtCantidad
            // 
            TxtCantidad.BackColor = SystemColors.ActiveBorder;
            TxtCantidad.Font = new Font("Segoe UI", 14F);
            TxtCantidad.Location = new Point(421, 273);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(298, 32);
            TxtCantidad.TabIndex = 88;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(215, 27);
            label2.Name = "label2";
            label2.Size = new Size(361, 59);
            label2.TabIndex = 89;
            label2.Text = "Entregas S.A";
            // 
            // FrmDetallescs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(TxtCantidad);
            Controls.Add(LbNumeroPedido);
            Controls.Add(CmbArticulo);
            Controls.Add(label8);
            Controls.Add(BttGuardar);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "FrmDetallescs";
            Text = "Registro de Detalles Pedido Entregas S.A";
            Load += FrmDetallescs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CmbArticulo;
        private Button BttGuardar;
        private Label label5;
        private Label label1;
        private Label label3;
        private Label LbNumeroPedido;
        private Label label8;
        private TextBox TxtCantidad;
        private Label label2;
    }
}