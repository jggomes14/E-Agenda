﻿namespace E_Agenda.ModuloTarefa
{
    partial class ListagemTarefaControl
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
            listTarefas = new ListBox();
            SuspendLayout();
            // 
            // listTarefas
            // 
            listTarefas.Dock = DockStyle.Fill;
            listTarefas.FormattingEnabled = true;
            listTarefas.ItemHeight = 15;
            listTarefas.Location = new Point(0, 0);
            listTarefas.Name = "listTarefas";
            listTarefas.Size = new Size(428, 307);
            listTarefas.TabIndex = 2;
            // 
            // ListagemTarefaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTarefas);
            Name = "ListagemTarefaControl";
            Size = new Size(428, 307);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listTarefas;
    }
}
