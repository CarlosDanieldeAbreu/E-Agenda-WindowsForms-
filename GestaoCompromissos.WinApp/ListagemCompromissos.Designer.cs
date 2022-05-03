namespace GestaoCompromissos.WinApp
{
    partial class ListagemCompromissos
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCompromissosPeriodo = new System.Windows.Forms.TabPage();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.dateTimeTermino = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCompromPeriodo = new System.Windows.Forms.ListBox();
            this.tabPageCompromissosPassados = new System.Windows.Forms.TabPage();
            this.listBoxPassados = new System.Windows.Forms.ListBox();
            this.tabPageCompromissosFuturos = new System.Windows.Forms.TabPage();
            this.listBoxFuturos = new System.Windows.Forms.ListBox();
            this.tabPageCompromissos = new System.Windows.Forms.TabPage();
            this.listBoxCompromissos = new System.Windows.Forms.ListBox();
            this.panelPrincipal.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCompromissosPeriodo.SuspendLayout();
            this.tabPageCompromissosPassados.SuspendLayout();
            this.tabPageCompromissosFuturos.SuspendLayout();
            this.tabPageCompromissos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelPrincipal.Controls.Add(this.btnEditar);
            this.panelPrincipal.Controls.Add(this.btnExcluir);
            this.panelPrincipal.Controls.Add(this.btnInserir);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(165, 236);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(13, 58);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 40);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(13, 104);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(140, 40);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.Location = new System.Drawing.Point(13, 12);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(140, 40);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCompromissos);
            this.tabControl1.Controls.Add(this.tabPageCompromissosPeriodo);
            this.tabControl1.Controls.Add(this.tabPageCompromissosPassados);
            this.tabControl1.Controls.Add(this.tabPageCompromissosFuturos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(165, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 236);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageCompromissosPeriodo
            // 
            this.tabPageCompromissosPeriodo.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPageCompromissosPeriodo.Controls.Add(this.buttonProcurar);
            this.tabPageCompromissosPeriodo.Controls.Add(this.dateTimeTermino);
            this.tabPageCompromissosPeriodo.Controls.Add(this.label2);
            this.tabPageCompromissosPeriodo.Controls.Add(this.dateTimeInicio);
            this.tabPageCompromissosPeriodo.Controls.Add(this.label1);
            this.tabPageCompromissosPeriodo.Controls.Add(this.listBoxCompromPeriodo);
            this.tabPageCompromissosPeriodo.Location = new System.Drawing.Point(4, 24);
            this.tabPageCompromissosPeriodo.Name = "tabPageCompromissosPeriodo";
            this.tabPageCompromissosPeriodo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompromissosPeriodo.Size = new System.Drawing.Size(888, 208);
            this.tabPageCompromissosPeriodo.TabIndex = 0;
            this.tabPageCompromissosPeriodo.Text = "Compromissos por Período";
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProcurar.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProcurar.Location = new System.Drawing.Point(31, 117);
            this.buttonProcurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(98, 35);
            this.buttonProcurar.TabIndex = 7;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = false;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // dateTimeTermino
            // 
            this.dateTimeTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTermino.Location = new System.Drawing.Point(31, 77);
            this.dateTimeTermino.Name = "dateTimeTermino";
            this.dateTimeTermino.Size = new System.Drawing.Size(98, 23);
            this.dateTimeTermino.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de término do período";
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.CustomFormat = "dd/MM/yyyy ";
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInicio.Location = new System.Drawing.Point(31, 25);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(98, 23);
            this.dateTimeInicio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data de inicio do período";
            // 
            // listBoxCompromPeriodo
            // 
            this.listBoxCompromPeriodo.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxCompromPeriodo.FormattingEnabled = true;
            this.listBoxCompromPeriodo.ItemHeight = 15;
            this.listBoxCompromPeriodo.Location = new System.Drawing.Point(176, 3);
            this.listBoxCompromPeriodo.Name = "listBoxCompromPeriodo";
            this.listBoxCompromPeriodo.Size = new System.Drawing.Size(709, 202);
            this.listBoxCompromPeriodo.TabIndex = 0;
            // 
            // tabPageCompromissosPassados
            // 
            this.tabPageCompromissosPassados.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPageCompromissosPassados.Controls.Add(this.listBoxPassados);
            this.tabPageCompromissosPassados.Location = new System.Drawing.Point(4, 24);
            this.tabPageCompromissosPassados.Name = "tabPageCompromissosPassados";
            this.tabPageCompromissosPassados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompromissosPassados.Size = new System.Drawing.Size(888, 208);
            this.tabPageCompromissosPassados.TabIndex = 1;
            this.tabPageCompromissosPassados.Text = "Compromissos Passados";
            // 
            // listBoxPassados
            // 
            this.listBoxPassados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPassados.FormattingEnabled = true;
            this.listBoxPassados.ItemHeight = 15;
            this.listBoxPassados.Location = new System.Drawing.Point(3, 3);
            this.listBoxPassados.Name = "listBoxPassados";
            this.listBoxPassados.Size = new System.Drawing.Size(882, 202);
            this.listBoxPassados.TabIndex = 1;
            // 
            // tabPageCompromissosFuturos
            // 
            this.tabPageCompromissosFuturos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPageCompromissosFuturos.Controls.Add(this.listBoxFuturos);
            this.tabPageCompromissosFuturos.Location = new System.Drawing.Point(4, 24);
            this.tabPageCompromissosFuturos.Name = "tabPageCompromissosFuturos";
            this.tabPageCompromissosFuturos.Size = new System.Drawing.Size(888, 208);
            this.tabPageCompromissosFuturos.TabIndex = 2;
            this.tabPageCompromissosFuturos.Text = "Compromissos Futuros";
            // 
            // listBoxFuturos
            // 
            this.listBoxFuturos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFuturos.FormattingEnabled = true;
            this.listBoxFuturos.ItemHeight = 15;
            this.listBoxFuturos.Location = new System.Drawing.Point(0, 0);
            this.listBoxFuturos.Name = "listBoxFuturos";
            this.listBoxFuturos.Size = new System.Drawing.Size(888, 208);
            this.listBoxFuturos.TabIndex = 1;
            // 
            // tabPageCompromissos
            // 
            this.tabPageCompromissos.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPageCompromissos.Controls.Add(this.listBoxCompromissos);
            this.tabPageCompromissos.Location = new System.Drawing.Point(4, 24);
            this.tabPageCompromissos.Name = "tabPageCompromissos";
            this.tabPageCompromissos.Size = new System.Drawing.Size(888, 208);
            this.tabPageCompromissos.TabIndex = 3;
            this.tabPageCompromissos.Text = "Compromissos";
            // 
            // listBoxCompromissos
            // 
            this.listBoxCompromissos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCompromissos.FormattingEnabled = true;
            this.listBoxCompromissos.ItemHeight = 15;
            this.listBoxCompromissos.Location = new System.Drawing.Point(0, 0);
            this.listBoxCompromissos.Name = "listBoxCompromissos";
            this.listBoxCompromissos.Size = new System.Drawing.Size(888, 208);
            this.listBoxCompromissos.TabIndex = 2;
            // 
            // ListagemCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 236);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListagemCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de compromissos";
            this.panelPrincipal.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCompromissosPeriodo.ResumeLayout(false);
            this.tabPageCompromissosPeriodo.PerformLayout();
            this.tabPageCompromissosPassados.ResumeLayout(false);
            this.tabPageCompromissosFuturos.ResumeLayout(false);
            this.tabPageCompromissos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCompromissosPeriodo;
        private System.Windows.Forms.TabPage tabPageCompromissosPassados;
        private System.Windows.Forms.TabPage tabPageCompromissosFuturos;
        private System.Windows.Forms.DateTimePicker dateTimeTermino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCompromPeriodo;
        private System.Windows.Forms.ListBox listBoxPassados;
        private System.Windows.Forms.ListBox listBoxFuturos;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.TabPage tabPageCompromissos;
        private System.Windows.Forms.ListBox listBoxCompromissos;
    }
}
