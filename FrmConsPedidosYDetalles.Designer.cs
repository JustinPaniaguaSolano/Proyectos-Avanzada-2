namespace CapaPresentacion
{
    partial class FrmConsPedidosYDetalles
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
            DgvDetallesPedidos = new DataGridView();
            DgvConsultaPedidos = new DataGridView();
            BttMenu = new Button();
            BttMostrarDetalles = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvDetallesPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvConsultaPedidos).BeginInit();
            SuspendLayout();
            // 
            // DgvDetallesPedidos
            // 
            DgvDetallesPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDetallesPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDetallesPedidos.Location = new Point(36, 425);
            DgvDetallesPedidos.Name = "DgvDetallesPedidos";
            DgvDetallesPedidos.Size = new Size(863, 150);
            DgvDetallesPedidos.TabIndex = 3;
            // 
            // DgvConsultaPedidos
            // 
            DgvConsultaPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsultaPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsultaPedidos.Location = new Point(36, 126);
            DgvConsultaPedidos.Name = "DgvConsultaPedidos";
            DgvConsultaPedidos.Size = new Size(863, 150);
            DgvConsultaPedidos.TabIndex = 2;
            // 
            // BttMenu
            // 
            BttMenu.BackColor = Color.OrangeRed;
            BttMenu.Font = new Font("Segoe UI", 15F);
            BttMenu.ForeColor = SystemColors.ButtonHighlight;
            BttMenu.Location = new Point(237, 345);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(115, 38);
            BttMenu.TabIndex = 43;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = false;
            BttMenu.Click += BttMenu_Click;
            // 
            // BttMostrarDetalles
            // 
            BttMostrarDetalles.BackColor = Color.DarkGreen;
            BttMostrarDetalles.Font = new Font("Segoe UI", 15F);
            BttMostrarDetalles.ForeColor = SystemColors.ButtonHighlight;
            BttMostrarDetalles.Location = new Point(439, 345);
            BttMostrarDetalles.Name = "BttMostrarDetalles";
            BttMostrarDetalles.Size = new Size(171, 38);
            BttMostrarDetalles.TabIndex = 44;
            BttMostrarDetalles.Text = "Mostrar Detalles";
            BttMostrarDetalles.UseVisualStyleBackColor = false;
            BttMostrarDetalles.Click += BttMostrarDetalles_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(304, 73);
            label1.Name = "label1";
            label1.Size = new Size(306, 28);
            label1.TabIndex = 46;
            label1.Text = "Consulta De Pedidos Y Detalles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(271, 9);
            label2.Name = "label2";
            label2.Size = new Size(361, 59);
            label2.TabIndex = 47;
            label2.Text = "Entregas S.A";
            // 
            // FrmConsPedidosYDetalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(925, 587);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BttMostrarDetalles);
            Controls.Add(BttMenu);
            Controls.Add(DgvDetallesPedidos);
            Controls.Add(DgvConsultaPedidos);
            Name = "FrmConsPedidosYDetalles";
            Text = "Consulta Pedidos Y Detalles Entregas S.A";
            Load += FrmConsPedidosYDetalles_Load;
            ((System.ComponentModel.ISupportInitialize)DgvDetallesPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvConsultaPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvDetallesPedidos;
        private DataGridView DgvConsultaPedidos;
        private Button BttMenu;
        private Button BttMostrarDetalles;
        private Label label1;
        private Label label2;
    }
}