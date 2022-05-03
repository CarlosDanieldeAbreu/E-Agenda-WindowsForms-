namespace GestaoContato.WinApp
{
    partial class ListagenContatos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.principal = new System.Windows.Forms.Panel();
            this.panelListBox = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.principal.SuspendLayout();
            this.panelListBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.principal.Size = new System.Drawing.Size(800, 149);
            this.principal.TabIndex = 3;
            // 
            // panelListBox
            // 
            this.panelListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListBox.Controls.Add(this.tabControl1);
            this.panelListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListBox.Location = new System.Drawing.Point(163, 0);
            this.panelListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(633, 145);
            this.panelListBox.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 143);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.Controls.Add(this.listBoxContatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 115);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agrupados por cargo";
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 15;
            this.listBoxContatos.Location = new System.Drawing.Point(3, 3);
            this.listBoxContatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(617, 109);
            this.listBoxContatos.TabIndex = 1;
            this.listBoxContatos.TabStop = false;
            // 
            // panelBotoes
            // 
            this.panelBotoes.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelBotoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoes.Controls.Add(this.btnEditar);
            this.panelBotoes.Controls.Add(this.btnExcluir);
            this.panelBotoes.Controls.Add(this.btnInserir);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotoes.Location = new System.Drawing.Point(0, 0);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(163, 145);
            this.panelBotoes.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(10, 54);
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
            this.btnExcluir.Location = new System.Drawing.Point(10, 100);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(140, 40);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.Location = new System.Drawing.Point(10, 8);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(140, 40);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // ListagenContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 149);
            this.Controls.Add(this.principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListagenContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de contatos";
            this.principal.ResumeLayout(false);
            this.panelListBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel principal;
        private System.Windows.Forms.Panel panelListBox;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
