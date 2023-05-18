namespace E_Agenda.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpData = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            label5 = new Label();
            dtpTermino = new DateTimePicker();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            rbRemoto = new RadioButton();
            rbPresencial = new RadioButton();
            label6 = new Label();
            txtAssunto = new TextBox();
            txtID = new TextBox();
            txtRemoto = new TextBox();
            txtPresencial = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(314, 333);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(233, 333);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 40);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 13);
            label1.TabIndex = 4;
            label1.Text = "Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 44);
            label2.Name = "label2";
            label2.Size = new Size(52, 13);
            label2.TabIndex = 5;
            label2.Text = "Assunto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 80);
            label3.Name = "label3";
            label3.Size = new Size(34, 13);
            label3.TabIndex = 6;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 118);
            label4.Name = "label4";
            label4.Size = new Size(38, 13);
            label4.TabIndex = 7;
            label4.Text = "Início:";
            // 
            // dtpData
            // 
            dtpData.CustomFormat = "dd/mm/yyyy";
            dtpData.Location = new Point(62, 74);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(131, 23);
            dtpData.TabIndex = 8;
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "HH:mm";
            dtpInicio.Location = new Point(62, 111);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(131, 23);
            dtpInicio.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(210, 118);
            label5.Name = "label5";
            label5.Size = new Size(51, 13);
            label5.TabIndex = 10;
            label5.Text = "Término:";
            // 
            // dtpTermino
            // 
            dtpTermino.CustomFormat = "HH:mm";
            dtpTermino.Location = new Point(261, 108);
            dtpTermino.Name = "dtpTermino";
            dtpTermino.Size = new Size(128, 23);
            dtpTermino.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(62, 147);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(233, 16);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Deseja marcar um contato neste compromisso?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(62, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 13;
            // 
            // rbRemoto
            // 
            rbRemoto.AutoSize = true;
            rbRemoto.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            rbRemoto.Location = new Point(146, 248);
            rbRemoto.Name = "rbRemoto";
            rbRemoto.Size = new Size(60, 16);
            rbRemoto.TabIndex = 14;
            rbRemoto.TabStop = true;
            rbRemoto.Text = "Remoto:";
            rbRemoto.UseVisualStyleBackColor = true;
            // 
            // rbPresencial
            // 
            rbPresencial.AutoSize = true;
            rbPresencial.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            rbPresencial.Location = new Point(146, 283);
            rbPresencial.Name = "rbPresencial";
            rbPresencial.Size = new Size(68, 16);
            rbPresencial.TabIndex = 15;
            rbPresencial.TabStop = true;
            rbPresencial.Text = "Presencial:";
            rbPresencial.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 213);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 16;
            label6.Text = "Localização";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(62, 40);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(314, 23);
            txtAssunto.TabIndex = 17;
            // 
            // txtID
            // 
            txtID.Location = new Point(62, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 18;
            // 
            // txtRemoto
            // 
            txtRemoto.Location = new Point(212, 241);
            txtRemoto.Name = "txtRemoto";
            txtRemoto.Size = new Size(164, 23);
            txtRemoto.TabIndex = 19;
            // 
            // txtPresencial
            // 
            txtPresencial.Location = new Point(212, 280);
            txtPresencial.Name = "txtPresencial";
            txtPresencial.Size = new Size(164, 23);
            txtPresencial.TabIndex = 20;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 385);
            Controls.Add(txtPresencial);
            Controls.Add(txtRemoto);
            Controls.Add(txtID);
            Controls.Add(txtAssunto);
            Controls.Add(label6);
            Controls.Add(rbPresencial);
            Controls.Add(rbRemoto);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(dtpTermino);
            Controls.Add(label5);
            Controls.Add(dtpInicio);
            Controls.Add(dtpData);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            Text = "Controle de Compromissos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpData;
        private DateTimePicker dtpInicio;
        private Label label5;
        private DateTimePicker dtpTermino;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private RadioButton rbRemoto;
        private RadioButton rbPresencial;
        private Label label6;
        private TextBox txtAssunto;
        private TextBox txtID;
        private TextBox txtRemoto;
        private TextBox txtPresencial;
    }
}