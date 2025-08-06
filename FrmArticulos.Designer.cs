namespace CapaPresentacion
{
    partial class FrmArticulos
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
            BttGuardar = new Button();
            TxtValor = new TextBox();
            TxtNombre = new TextBox();
            TxtID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            BttMenu = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TxtInventario = new TextBox();
            CmbTipoArticulo = new ComboBox();
            CmbActivo = new ComboBox();
            label9 = new Label();
            DgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // BttGuardar
            // 
            BttGuardar.BackColor = Color.ForestGreen;
            BttGuardar.Font = new Font("Segoe UI", 15F);
            BttGuardar.ForeColor = SystemColors.ButtonHighlight;
            BttGuardar.Location = new Point(393, 336);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(115, 38);
            BttGuardar.TabIndex = 27;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = false;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // TxtValor
            // 
            TxtValor.BackColor = SystemColors.ActiveBorder;
            TxtValor.Font = new Font("Segoe UI", 14F);
            TxtValor.Location = new Point(599, 197);
            TxtValor.Name = "TxtValor";
            TxtValor.Size = new Size(174, 32);
            TxtValor.TabIndex = 26;
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = SystemColors.ActiveBorder;
            TxtNombre.Font = new Font("Segoe UI", 14F);
            TxtNombre.Location = new Point(599, 148);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(174, 32);
            TxtNombre.TabIndex = 25;
            // 
            // TxtID
            // 
            TxtID.BackColor = SystemColors.ActiveBorder;
            TxtID.Font = new Font("Segoe UI", 14F);
            TxtID.Location = new Point(242, 141);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(162, 32);
            TxtID.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(12, 192);
            label5.Name = "label5";
            label5.Size = new Size(226, 25);
            label5.TabIndex = 23;
            label5.Text = "Escoja el tipo de articulo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(417, 151);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 22;
            label4.Text = "Digite el Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(290, 90);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 21;
            label1.Text = "Registro Articulos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 19;
            label3.Text = "Digite el ID:";
            // 
            // BttMenu
            // 
            BttMenu.BackColor = Color.OrangeRed;
            BttMenu.Font = new Font("Segoe UI", 15F);
            BttMenu.ForeColor = SystemColors.ButtonHighlight;
            BttMenu.Location = new Point(228, 336);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(115, 38);
            BttMenu.TabIndex = 18;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = false;
            BttMenu.Click += BttMenu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label6.Location = new Point(12, 242);
            label6.Name = "label6";
            label6.Size = new Size(181, 25);
            label6.TabIndex = 28;
            label6.Text = "Digite el inventario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.Location = new Point(417, 249);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 29;
            label7.Text = "Esta Activo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label8.Location = new Point(417, 197);
            label8.Name = "label8";
            label8.Size = new Size(138, 25);
            label8.TabIndex = 28;
            label8.Text = "Digite el valor:";
            // 
            // TxtInventario
            // 
            TxtInventario.BackColor = SystemColors.ActiveBorder;
            TxtInventario.Font = new Font("Segoe UI", 14F);
            TxtInventario.Location = new Point(242, 239);
            TxtInventario.Name = "TxtInventario";
            TxtInventario.Size = new Size(164, 32);
            TxtInventario.TabIndex = 30;
            // 
            // CmbTipoArticulo
            // 
            CmbTipoArticulo.BackColor = SystemColors.ActiveBorder;
            CmbTipoArticulo.Font = new Font("Segoe UI", 14F);
            CmbTipoArticulo.FormattingEnabled = true;
            CmbTipoArticulo.Location = new Point(242, 189);
            CmbTipoArticulo.Name = "CmbTipoArticulo";
            CmbTipoArticulo.Size = new Size(162, 33);
            CmbTipoArticulo.TabIndex = 31;
            // 
            // CmbActivo
            // 
            CmbActivo.BackColor = SystemColors.ActiveBorder;
            CmbActivo.Font = new Font("Segoe UI", 14F);
            CmbActivo.FormattingEnabled = true;
            CmbActivo.Location = new Point(599, 249);
            CmbActivo.Name = "CmbActivo";
            CmbActivo.Size = new Size(174, 33);
            CmbActivo.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGray;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Verdana", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Tomato;
            label9.Location = new Point(203, 9);
            label9.Name = "label9";
            label9.Size = new Size(361, 59);
            label9.TabIndex = 33;
            label9.Text = "Entregas S.A";
            // 
            // DgvConsulta
            // 
            DgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsulta.Location = new Point(12, 380);
            DgvConsulta.Name = "DgvConsulta";
            DgvConsulta.Size = new Size(761, 207);
            DgvConsulta.TabIndex = 34;
            // 
            // FrmArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 599);
            Controls.Add(DgvConsulta);
            Controls.Add(label9);
            Controls.Add(CmbActivo);
            Controls.Add(CmbTipoArticulo);
            Controls.Add(TxtInventario);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(BttGuardar);
            Controls.Add(TxtValor);
            Controls.Add(TxtNombre);
            Controls.Add(TxtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BttMenu);
            Name = "FrmArticulos";
            Text = "Registrar Articulos Entregas S.A";
            Load += FrmArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BttGuardar;
        private TextBox TxtValor;
        private TextBox TxtNombre;
        private TextBox TxtID;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label3;
        private Button BttMenu;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TxtInventario;
        private ComboBox CmbTipoArticulo;
        private ComboBox CmbActivo;
        private Label label9;
        private DataGridView DvgConsulta;
        private DataGridView DgvConsulta;
    }
}