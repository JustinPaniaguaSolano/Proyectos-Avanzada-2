namespace CapaPresentacion
{
    partial class FrmTiposArticulos
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
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtID = new TextBox();
            TxtNombre = new TextBox();
            TxtDescripcion = new TextBox();
            BttGuardar = new Button();
            label2 = new Label();
            DgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // BttMenu
            // 
            BttMenu.BackColor = Color.OrangeRed;
            BttMenu.Font = new Font("Segoe UI", 15F);
            BttMenu.ForeColor = SystemColors.ButtonHighlight;
            BttMenu.Location = new Point(237, 276);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(115, 38);
            BttMenu.TabIndex = 8;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = false;
            BttMenu.Click += BttMenu_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(37, 151);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 9;
            label3.Text = "Digite el ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(273, 101);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 11;
            label1.Text = "Registro Tipos Articulos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(444, 151);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 12;
            label4.Text = "Digite el Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(37, 201);
            label5.Name = "label5";
            label5.Size = new Size(194, 25);
            label5.TabIndex = 13;
            label5.Text = "Digite la Descripcion:";
            // 
            // TxtID
            // 
            TxtID.BackColor = SystemColors.ActiveBorder;
            TxtID.Font = new Font("Segoe UI", 14F);
            TxtID.Location = new Point(237, 151);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(138, 32);
            TxtID.TabIndex = 14;
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = SystemColors.ActiveBorder;
            TxtNombre.Font = new Font("Segoe UI", 14F);
            TxtNombre.Location = new Point(633, 148);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(138, 32);
            TxtNombre.TabIndex = 15;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.BackColor = SystemColors.ActiveBorder;
            TxtDescripcion.Font = new Font("Segoe UI", 14F);
            TxtDescripcion.Location = new Point(237, 201);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(534, 32);
            TxtDescripcion.TabIndex = 16;
            // 
            // BttGuardar
            // 
            BttGuardar.BackColor = Color.DarkGreen;
            BttGuardar.Font = new Font("Segoe UI", 15F);
            BttGuardar.ForeColor = SystemColors.ButtonHighlight;
            BttGuardar.Location = new Point(494, 267);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(115, 38);
            BttGuardar.TabIndex = 17;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = false;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(194, 32);
            label2.Name = "label2";
            label2.Size = new Size(361, 59);
            label2.TabIndex = 18;
            label2.Text = "Entregas S.A";
            // 
            // DgvConsulta
            // 
            DgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsulta.Location = new Point(12, 331);
            DgvConsulta.Name = "DgvConsulta";
            DgvConsulta.ReadOnly = true;
            DgvConsulta.Size = new Size(844, 210);
            DgvConsulta.TabIndex = 20;
            // 
            // FrmTiposArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(868, 553);
            Controls.Add(DgvConsulta);
            Controls.Add(label2);
            Controls.Add(BttGuardar);
            Controls.Add(TxtDescripcion);
            Controls.Add(TxtNombre);
            Controls.Add(TxtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BttMenu);
            Name = "FrmTiposArticulos";
            Text = "Registro Tipos Articulos Entregas S.A";
            Load += FrmTiposArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BttMenu;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox TxtID;
        private TextBox TxtNombre;
        private TextBox TxtDescripcion;
        private Button BttGuardar;
        private Label label2;
        private DataGridView DgvConsulta;
    }
}