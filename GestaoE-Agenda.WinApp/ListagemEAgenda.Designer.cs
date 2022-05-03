namespace GestaoE_Agenda.WinApp
{
    partial class FormListagemEAgenda
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
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.labelGerenciadorCompromissos = new System.Windows.Forms.Label();
            this.labelGerenciadorContatos = new System.Windows.Forms.Label();
            this.labelGerenciadorDeTarefas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelListagem = new System.Windows.Forms.Panel();
            this.panelOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelOpcoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpcoes.Controls.Add(this.labelGerenciadorCompromissos);
            this.panelOpcoes.Controls.Add(this.labelGerenciadorContatos);
            this.panelOpcoes.Controls.Add(this.labelGerenciadorDeTarefas);
            this.panelOpcoes.Controls.Add(this.label1);
            this.panelOpcoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpcoes.Location = new System.Drawing.Point(0, 0);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(210, 450);
            this.panelOpcoes.TabIndex = 0;
            // 
            // labelGerenciadorCompromissos
            // 
            this.labelGerenciadorCompromissos.AutoSize = true;
            this.labelGerenciadorCompromissos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGerenciadorCompromissos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGerenciadorCompromissos.Location = new System.Drawing.Point(11, 254);
            this.labelGerenciadorCompromissos.Name = "labelGerenciadorCompromissos";
            this.labelGerenciadorCompromissos.Size = new System.Drawing.Size(184, 50);
            this.labelGerenciadorCompromissos.TabIndex = 3;
            this.labelGerenciadorCompromissos.Text = "Gerenciador \r\n     de compromissos";
            this.labelGerenciadorCompromissos.Click += new System.EventHandler(this.labelGerenciadorCompromissos_Click);
            // 
            // labelGerenciadorContatos
            // 
            this.labelGerenciadorContatos.AutoSize = true;
            this.labelGerenciadorContatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGerenciadorContatos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGerenciadorContatos.Location = new System.Drawing.Point(11, 180);
            this.labelGerenciadorContatos.Name = "labelGerenciadorContatos";
            this.labelGerenciadorContatos.Size = new System.Drawing.Size(140, 50);
            this.labelGerenciadorContatos.TabIndex = 2;
            this.labelGerenciadorContatos.Text = "Gerenciador \r\n      de contatos";
            this.labelGerenciadorContatos.Click += new System.EventHandler(this.labelGerenciadorContatos_Click);
            // 
            // labelGerenciadorDeTarefas
            // 
            this.labelGerenciadorDeTarefas.AutoSize = true;
            this.labelGerenciadorDeTarefas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGerenciadorDeTarefas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGerenciadorDeTarefas.Location = new System.Drawing.Point(11, 104);
            this.labelGerenciadorDeTarefas.Name = "labelGerenciadorDeTarefas";
            this.labelGerenciadorDeTarefas.Size = new System.Drawing.Size(125, 50);
            this.labelGerenciadorDeTarefas.TabIndex = 1;
            this.labelGerenciadorDeTarefas.Text = "Gerenciador \r\n      de tarefas";
            this.labelGerenciadorDeTarefas.Click += new System.EventHandler(this.labelGerenciadorDeTarefas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Agenda 2.0";
            // 
            // panelListagem
            // 
            this.panelListagem.BackgroundImage = global::GestaoE_Agenda.WinApp.Properties.Resources.icons8_agenda_64;
            this.panelListagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListagem.Location = new System.Drawing.Point(210, 0);
            this.panelListagem.Name = "panelListagem";
            this.panelListagem.Size = new System.Drawing.Size(590, 450);
            this.panelListagem.TabIndex = 1;
            // 
            // FormListagemEAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelListagem);
            this.Controls.Add(this.panelOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormListagemEAgenda";
            this.Text = "E-Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelOpcoes.ResumeLayout(false);
            this.panelOpcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpcoes;
        private System.Windows.Forms.Panel panelListagem;
        private System.Windows.Forms.Label labelGerenciadorCompromissos;
        private System.Windows.Forms.Label labelGerenciadorContatos;
        private System.Windows.Forms.Label labelGerenciadorDeTarefas;
        private System.Windows.Forms.Label label1;
    }
}
