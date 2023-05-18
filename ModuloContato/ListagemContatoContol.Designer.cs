namespace E_Agenda.ModuloContato
{
    partial class ListagemContatoContol
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            listContatos = new ListBox();
            SuspendLayout();
            // 
            // listContatos
            // 
            listContatos.Dock = DockStyle.Fill;
            listContatos.FormattingEnabled = true;
            listContatos.ItemHeight = 15;
            listContatos.Location = new Point(0, 0);
            listContatos.Name = "listContatos";
            listContatos.Size = new Size(467, 332);
            listContatos.TabIndex = 0;
            // 
            // ListagemContatoContol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listContatos);
            Name = "ListagemContatoContol";
            Size = new Size(467, 332);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listContatos;
    }
}
