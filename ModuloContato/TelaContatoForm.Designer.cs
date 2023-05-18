namespace E_Agenda.ModuloContato
{
    partial class TelaContatoForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            lblNome = new Label();
            lblID = new Label();
            lblTelefone = new Label();
            lblEmpresa = new Label();
            lblEmail = new Label();
            lblCargo = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            txtTelefone = new TextBox();
            txtEmpresa = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(163, 187);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 40);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(244, 187);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(12, 51);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 13);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(12, 24);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 13);
            lblID.TabIndex = 3;
            lblID.Text = "ID: ";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefone.Location = new Point(12, 77);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 13);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpresa.Location = new Point(12, 104);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(53, 13);
            lblEmpresa.TabIndex = 5;
            lblEmpresa.Text = "Empresa:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(200, 77);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 13);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-mail:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCargo.Location = new Point(200, 104);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(41, 13);
            lblCargo.TabIndex = 7;
            lblCargo.Text = "Cargo:";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(64, 21);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(33, 16);
            txtID.TabIndex = 8;
            txtID.Text = "0";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(64, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(130, 16);
            txtNome.TabIndex = 9;
            // 
            // txtCargo
            // 
            txtCargo.BorderStyle = BorderStyle.None;
            txtCargo.Location = new Point(244, 101);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(75, 16);
            txtCargo.TabIndex = 10;
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Location = new Point(64, 74);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(130, 16);
            txtTelefone.TabIndex = 11;
            // 
            // txtEmpresa
            // 
            txtEmpresa.BorderStyle = BorderStyle.None;
            txtEmpresa.Location = new Point(64, 101);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(130, 16);
            txtEmpresa.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(244, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(75, 16);
            txtEmail.TabIndex = 13;
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 239);
            Controls.Add(txtEmail);
            Controls.Add(txtEmpresa);
            Controls.Add(txtTelefone);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(lblCargo);
            Controls.Add(lblEmail);
            Controls.Add(lblEmpresa);
            Controls.Add(lblTelefone);
            Controls.Add(lblID);
            Controls.Add(lblNome);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label lblNome;
        private Label lblID;
        private Label lblTelefone;
        private Label lblEmpresa;
        private Label lblEmail;
        private Label lblCargo;
        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtTelefone;
        private TextBox txtEmpresa;
        private TextBox txtEmail;
    }
}