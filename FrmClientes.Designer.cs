namespace CapaPresentacion
{
    partial class FrmClientes
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
            CmbActivo = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            BttGuardar = new Button();
            TxtSegundoApellido = new TextBox();
            TxtNombre = new TextBox();
            TxtIdentificacion = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            BttMenu = new Button();
            TxtPrimerApellido = new TextBox();
            DtpFechaNacimiento = new DateTimePicker();
            label9 = new Label();
            DgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // CmbActivo
            // 
            CmbActivo.BackColor = SystemColors.ActiveBorder;
            CmbActivo.Font = new Font("Segoe UI", 14F);
            CmbActivo.FormattingEnabled = true;
            CmbActivo.Location = new Point(633, 255);
            CmbActivo.Name = "CmbActivo";
            CmbActivo.Size = new Size(128, 33);
            CmbActivo.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.Location = new Point(440, 245);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 45;
            label7.Text = "Esta Activo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label8.Location = new Point(437, 205);
            label8.Name = "label8";
            label8.Size = new Size(225, 25);
            label8.TabIndex = 43;
            label8.Text = "Digite Segundo Apellido:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label6.Location = new Point(21, 243);
            label6.Name = "label6";
            label6.Size = new Size(229, 25);
            label6.TabIndex = 44;
            label6.Text = "Digite Fecha Nacimiento:";
            // 
            // BttGuardar
            // 
            BttGuardar.BackColor = Color.ForestGreen;
            BttGuardar.Font = new Font("Segoe UI", 15F);
            BttGuardar.ForeColor = SystemColors.ButtonHighlight;
            BttGuardar.Location = new Point(437, 307);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(115, 38);
            BttGuardar.TabIndex = 42;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = false;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // TxtSegundoApellido
            // 
            TxtSegundoApellido.BackColor = SystemColors.ActiveBorder;
            TxtSegundoApellido.Font = new Font("Segoe UI", 14F);
            TxtSegundoApellido.Location = new Point(672, 201);
            TxtSegundoApellido.Name = "TxtSegundoApellido";
            TxtSegundoApellido.Size = new Size(116, 32);
            TxtSegundoApellido.TabIndex = 41;
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = SystemColors.ActiveBorder;
            TxtNombre.Font = new Font("Segoe UI", 14F);
            TxtNombre.Location = new Point(613, 145);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(161, 32);
            TxtNombre.TabIndex = 40;
            // 
            // TxtIdentificacion
            // 
            TxtIdentificacion.BackColor = SystemColors.ActiveBorder;
            TxtIdentificacion.Font = new Font("Segoe UI", 14F);
            TxtIdentificacion.Location = new Point(237, 142);
            TxtIdentificacion.Name = "TxtIdentificacion";
            TxtIdentificacion.Size = new Size(189, 32);
            TxtIdentificacion.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(21, 198);
            label5.Name = "label5";
            label5.Size = new Size(202, 25);
            label5.TabIndex = 38;
            label5.Text = "Digite Primer Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(437, 145);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 37;
            label4.Text = "Digite el Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(293, 95);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 36;
            label1.Text = "Registro Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(21, 145);
            label3.Name = "label3";
            label3.Size = new Size(210, 25);
            label3.TabIndex = 34;
            label3.Text = "Digite la identificacion:";
            // 
            // BttMenu
            // 
            BttMenu.BackColor = Color.OrangeRed;
            BttMenu.Font = new Font("Segoe UI", 15F);
            BttMenu.ForeColor = SystemColors.ButtonHighlight;
            BttMenu.Location = new Point(249, 307);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(115, 38);
            BttMenu.TabIndex = 33;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = false;
            BttMenu.Click += BttMenu_Click;
            // 
            // TxtPrimerApellido
            // 
            TxtPrimerApellido.BackColor = SystemColors.ActiveBorder;
            TxtPrimerApellido.Font = new Font("Segoe UI", 14F);
            TxtPrimerApellido.Location = new Point(237, 198);
            TxtPrimerApellido.Name = "TxtPrimerApellido";
            TxtPrimerApellido.Size = new Size(189, 32);
            TxtPrimerApellido.TabIndex = 49;
            // 
            // DtpFechaNacimiento
            // 
            DtpFechaNacimiento.CalendarFont = new Font("Segoe UI", 14F);
            DtpFechaNacimiento.CalendarMonthBackground = SystemColors.HotTrack;
            DtpFechaNacimiento.Location = new Point(249, 245);
            DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            DtpFechaNacimiento.Size = new Size(177, 23);
            DtpFechaNacimiento.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGray;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Verdana", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Tomato;
            label9.Location = new Point(208, 19);
            label9.Name = "label9";
            label9.Size = new Size(361, 59);
            label9.TabIndex = 51;
            label9.Text = "Entregas S.A";
            // 
            // DgvConsulta
            // 
            DgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsulta.Location = new Point(12, 368);
            DgvConsulta.Name = "DgvConsulta";
            DgvConsulta.Size = new Size(776, 212);
            DgvConsulta.TabIndex = 52;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 592);
            Controls.Add(DgvConsulta);
            Controls.Add(label9);
            Controls.Add(DtpFechaNacimiento);
            Controls.Add(TxtPrimerApellido);
            Controls.Add(CmbActivo);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(BttGuardar);
            Controls.Add(TxtSegundoApellido);
            Controls.Add(TxtNombre);
            Controls.Add(TxtIdentificacion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BttMenu);
            Name = "FrmClientes";
            Text = "Registro Clientes Entregas S.A";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbActivo;
        private Label label7;
        private Label label8;
        private Label label6;
        private Button BttGuardar;
        private TextBox TxtSegundoApellido;
        private TextBox TxtNombre;
        private TextBox TxtIdentificacion;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label3;
        private Button BttMenu;
        private TextBox TxtPrimerApellido;
        private DateTimePicker DtpFechaNacimiento;
        private Label label9;
        private DataGridView DgvConsulta;
    }
}