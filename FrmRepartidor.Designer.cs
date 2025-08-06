namespace CapaPresentacion
{
    partial class FrmRepartidor
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
            TxtSegApellido = new TextBox();
            TxtNombre = new TextBox();
            TxtIdentificacion = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            BttMenu = new Button();
            label9 = new Label();
            TxtPriApelli = new TextBox();
            DtpFechNaci = new DateTimePicker();
            DtpFecCont = new DateTimePicker();
            label2 = new Label();
            DgvConsulta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // CmbActivo
            // 
            CmbActivo.BackColor = SystemColors.ActiveBorder;
            CmbActivo.Font = new Font("Segoe UI", 14F);
            CmbActivo.FormattingEnabled = true;
            CmbActivo.Location = new Point(623, 247);
            CmbActivo.Name = "CmbActivo";
            CmbActivo.Size = new Size(159, 33);
            CmbActivo.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.Location = new Point(447, 247);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 45;
            label7.Text = "Esta Activo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label8.Location = new Point(434, 201);
            label8.Name = "label8";
            label8.Size = new Size(222, 25);
            label8.TabIndex = 43;
            label8.Text = "Digite Segundo apellido:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label6.Location = new Point(12, 245);
            label6.Name = "label6";
            label6.Size = new Size(223, 25);
            label6.TabIndex = 44;
            label6.Text = "Escoja fecha nacimiento:";
            // 
            // BttGuardar
            // 
            BttGuardar.BackColor = Color.ForestGreen;
            BttGuardar.Font = new Font("Segoe UI", 15F);
            BttGuardar.ForeColor = SystemColors.ButtonHighlight;
            BttGuardar.Location = new Point(388, 314);
            BttGuardar.Name = "BttGuardar";
            BttGuardar.Size = new Size(115, 38);
            BttGuardar.TabIndex = 42;
            BttGuardar.Text = "Guardar";
            BttGuardar.UseVisualStyleBackColor = false;
            BttGuardar.Click += BttGuardar_Click;
            // 
            // TxtSegApellido
            // 
            TxtSegApellido.BackColor = SystemColors.ActiveBorder;
            TxtSegApellido.Font = new Font("Segoe UI", 14F);
            TxtSegApellido.Location = new Point(656, 201);
            TxtSegApellido.Name = "TxtSegApellido";
            TxtSegApellido.Size = new Size(126, 32);
            TxtSegApellido.TabIndex = 41;
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = SystemColors.ActiveBorder;
            TxtNombre.Font = new Font("Segoe UI", 14F);
            TxtNombre.Location = new Point(618, 152);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(164, 32);
            TxtNombre.TabIndex = 40;
            // 
            // TxtIdentificacion
            // 
            TxtIdentificacion.BackColor = SystemColors.ActiveBorder;
            TxtIdentificacion.Font = new Font("Segoe UI", 14F);
            TxtIdentificacion.Location = new Point(245, 149);
            TxtIdentificacion.Name = "TxtIdentificacion";
            TxtIdentificacion.Size = new Size(166, 32);
            TxtIdentificacion.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(12, 194);
            label5.Name = "label5";
            label5.Size = new Size(207, 25);
            label5.TabIndex = 38;
            label5.Text = "Digite Primer Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(447, 152);
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
            label1.Size = new Size(199, 28);
            label1.TabIndex = 36;
            label1.Text = "Registro Repartidor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(211, 25);
            label3.TabIndex = 34;
            label3.Text = "Digite la Identificacion:";
            // 
            // BttMenu
            // 
            BttMenu.BackColor = Color.OrangeRed;
            BttMenu.Font = new Font("Segoe UI", 15F);
            BttMenu.ForeColor = SystemColors.ButtonHighlight;
            BttMenu.Location = new Point(245, 314);
            BttMenu.Name = "BttMenu";
            BttMenu.Size = new Size(115, 38);
            BttMenu.TabIndex = 33;
            BttMenu.Text = "Menu";
            BttMenu.UseVisualStyleBackColor = false;
            BttMenu.Click += BttMenu_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label9.Location = new Point(12, 283);
            label9.Name = "label9";
            label9.Size = new Size(235, 25);
            label9.TabIndex = 49;
            label9.Text = "Escoja fecha contratacion:";
            // 
            // TxtPriApelli
            // 
            TxtPriApelli.BackColor = SystemColors.ActiveBorder;
            TxtPriApelli.Font = new Font("Segoe UI", 14F);
            TxtPriApelli.Location = new Point(245, 191);
            TxtPriApelli.Name = "TxtPriApelli";
            TxtPriApelli.Size = new Size(169, 32);
            TxtPriApelli.TabIndex = 50;
            // 
            // DtpFechNaci
            // 
            DtpFechNaci.CalendarFont = new Font("Segoe UI", 14F);
            DtpFechNaci.Location = new Point(245, 245);
            DtpFechNaci.Name = "DtpFechNaci";
            DtpFechNaci.Size = new Size(169, 23);
            DtpFechNaci.TabIndex = 51;
            // 
            // DtpFecCont
            // 
            DtpFecCont.CalendarFont = new Font("Segoe UI", 14F);
            DtpFecCont.Location = new Point(245, 285);
            DtpFecCont.Name = "DtpFecCont";
            DtpFecCont.Size = new Size(169, 23);
            DtpFecCont.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Verdana", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(211, 27);
            label2.Name = "label2";
            label2.Size = new Size(361, 59);
            label2.TabIndex = 53;
            label2.Text = "Entregas S.A";
            // 
            // DgvConsulta
            // 
            DgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConsulta.Location = new Point(12, 358);
            DgvConsulta.Name = "DgvConsulta";
            DgvConsulta.Size = new Size(770, 214);
            DgvConsulta.TabIndex = 54;
            // 
            // FrmRepartidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 584);
            Controls.Add(DgvConsulta);
            Controls.Add(label2);
            Controls.Add(DtpFecCont);
            Controls.Add(DtpFechNaci);
            Controls.Add(TxtPriApelli);
            Controls.Add(label9);
            Controls.Add(CmbActivo);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(BttGuardar);
            Controls.Add(TxtSegApellido);
            Controls.Add(TxtNombre);
            Controls.Add(TxtIdentificacion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BttMenu);
            Name = "FrmRepartidor";
            Text = "Registro Repartidores Entregas S.A";
            Load += FrmRepartidor_Load;
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
        private TextBox TxtSegApellido;
        private TextBox TxtNombre;
        private TextBox TxtIdentificacion;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label3;
        private Button BttMenu;
        private Label label9;
        private TextBox TxtPriApelli;
        private DateTimePicker DtpFechNaci;
        private DateTimePicker DtpFecCont;
        private Label label2;
        private DataGridView DgvConsulta;
    }
}