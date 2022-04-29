namespace GestaoTarefas.WinApp
{
    partial class ListagemTarefas
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
            this.principal = new System.Windows.Forms.Panel();
            this.panelListBox = new System.Windows.Forms.Panel();
            this.tabControlConcluidoPedente = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxTarefasPendentes = new System.Windows.Forms.ListBox();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnAtualizarItem = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.principal.SuspendLayout();
            this.panelListBox.SuspendLayout();
            this.tabControlConcluidoPedente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // principal
            // 
            this.principal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.principal.Controls.Add(this.panelListBox);
            this.principal.Controls.Add(this.panelBotoes);
            this.principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.principal.Location = new System.Drawing.Point(0, 0);
            this.principal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(790, 245);
            this.principal.TabIndex = 2;
            // 
            // panelListBox
            // 
            this.panelListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListBox.Controls.Add(this.tabControlConcluidoPedente);
            this.panelListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListBox.Location = new System.Drawing.Point(163, 0);
            this.panelListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(623, 241);
            this.panelListBox.TabIndex = 1;
            // 
            // tabControlConcluidoPedente
            // 
            this.tabControlConcluidoPedente.Controls.Add(this.tabPage1);
            this.tabControlConcluidoPedente.Controls.Add(this.tabPage2);
            this.tabControlConcluidoPedente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlConcluidoPedente.Location = new System.Drawing.Point(0, 0);
            this.tabControlConcluidoPedente.Name = "tabControlConcluidoPedente";
            this.tabControlConcluidoPedente.SelectedIndex = 0;
            this.tabControlConcluidoPedente.ShowToolTips = true;
            this.tabControlConcluidoPedente.Size = new System.Drawing.Size(621, 239);
            this.tabControlConcluidoPedente.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.Controls.Add(this.listBoxTarefasConcluidas);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(613, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Concluido";
            // 
            // listBoxTarefasConcluidas
            // 
            this.listBoxTarefasConcluidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTarefasConcluidas.FormattingEnabled = true;
            this.listBoxTarefasConcluidas.ItemHeight = 15;
            this.listBoxTarefasConcluidas.Location = new System.Drawing.Point(3, 3);
            this.listBoxTarefasConcluidas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxTarefasConcluidas.Name = "listBoxTarefasConcluidas";
            this.listBoxTarefasConcluidas.Size = new System.Drawing.Size(607, 205);
            this.listBoxTarefasConcluidas.TabIndex = 0;
            this.listBoxTarefasConcluidas.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage2.Controls.Add(this.listBoxTarefasPendentes);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(613, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pendente";
            // 
            // listBoxTarefasPendentes
            // 
            this.listBoxTarefasPendentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTarefasPendentes.FormattingEnabled = true;
            this.listBoxTarefasPendentes.ItemHeight = 15;
            this.listBoxTarefasPendentes.Location = new System.Drawing.Point(3, 3);
            this.listBoxTarefasPendentes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxTarefasPendentes.Name = "listBoxTarefasPendentes";
            this.listBoxTarefasPendentes.Size = new System.Drawing.Size(607, 205);
            this.listBoxTarefasPendentes.TabIndex = 1;
            this.listBoxTarefasPendentes.TabStop = false;
            // 
            // panelBotoes
            // 
            this.panelBotoes.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelBotoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoes.Controls.Add(this.btnAtualizarItem);
            this.panelBotoes.Controls.Add(this.btnEditar);
            this.panelBotoes.Controls.Add(this.btnExcluir);
            this.panelBotoes.Controls.Add(this.btnItem);
            this.panelBotoes.Controls.Add(this.btnInserir);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotoes.Location = new System.Drawing.Point(0, 0);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(163, 241);
            this.panelBotoes.TabIndex = 0;
            // 
            // btnAtualizarItem
            // 
            this.btnAtualizarItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtualizarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarItem.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarItem.Location = new System.Drawing.Point(10, 193);
            this.btnAtualizarItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarItem.Name = "btnAtualizarItem";
            this.btnAtualizarItem.Size = new System.Drawing.Size(140, 40);
            this.btnAtualizarItem.TabIndex = 5;
            this.btnAtualizarItem.Text = "Atualizar itens";
            this.btnAtualizarItem.UseVisualStyleBackColor = false;
            this.btnAtualizarItem.Click += new System.EventHandler(this.btnAtualizarItem_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(10, 55);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 40);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(10, 101);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(140, 40);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItem.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItem.Location = new System.Drawing.Point(10, 147);
            this.btnItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(140, 40);
            this.btnItem.TabIndex = 4;
            this.btnItem.Text = "Item";
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.Location = new System.Drawing.Point(10, 9);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(140, 40);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // ListagemTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 245);
            this.Controls.Add(this.principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListagemTarefas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Tarefas";
            this.principal.ResumeLayout(false);
            this.panelListBox.ResumeLayout(false);
            this.tabControlConcluidoPedente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel principal;
        private System.Windows.Forms.Panel panelListBox;
        private System.Windows.Forms.ListBox listBoxTarefasConcluidas;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnAtualizarItem;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TabControl tabControlConcluidoPedente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxTarefasPendentes;
    }
}