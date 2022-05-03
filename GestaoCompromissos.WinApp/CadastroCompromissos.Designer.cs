namespace GestaoCompromissos.WinApp
{
    partial class CadastroCompromissos
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelContato = new System.Windows.Forms.Label();
            this.comboBoxContato = new System.Windows.Forms.ComboBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.labelAssunto = new System.Windows.Forms.Label();
            this.dateTimeTermino = new System.Windows.Forms.DateTimePicker();
            this.labelHoraTermino = new System.Windows.Forms.Label();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelPrincipal.Controls.Add(this.textBoxNumero);
            this.panelPrincipal.Controls.Add(this.labelNumero);
            this.panelPrincipal.Controls.Add(this.btnCancelar);
            this.panelPrincipal.Controls.Add(this.btnSalvar);
            this.panelPrincipal.Controls.Add(this.labelContato);
            this.panelPrincipal.Controls.Add(this.comboBoxContato);
            this.panelPrincipal.Controls.Add(this.textBoxLocal);
            this.panelPrincipal.Controls.Add(this.labelLocal);
            this.panelPrincipal.Controls.Add(this.textBoxAssunto);
            this.panelPrincipal.Controls.Add(this.labelAssunto);
            this.panelPrincipal.Controls.Add(this.dateTimeTermino);
            this.panelPrincipal.Controls.Add(this.labelHoraTermino);
            this.panelPrincipal.Controls.Add(this.dateTimeInicio);
            this.panelPrincipal.Controls.Add(this.labelDataInicio);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(716, 164);
            this.panelPrincipal.TabIndex = 0;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Enabled = false;
            this.textBoxNumero.Location = new System.Drawing.Point(25, 27);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(45, 23);
            this.textBoxNumero.TabIndex = 19;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(12, 9);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(51, 15);
            this.labelNumero.TabIndex = 20;
            this.labelNumero.Text = "Número";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(590, 98);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 40);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(590, 40);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 40);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Location = new System.Drawing.Point(186, 110);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(50, 15);
            this.labelContato.TabIndex = 16;
            this.labelContato.Text = "Contato";
            // 
            // comboBoxContato
            // 
            this.comboBoxContato.FormattingEnabled = true;
            this.comboBoxContato.Location = new System.Drawing.Point(199, 128);
            this.comboBoxContato.Name = "comboBoxContato";
            this.comboBoxContato.Size = new System.Drawing.Size(368, 23);
            this.comboBoxContato.TabIndex = 6;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(199, 84);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(368, 23);
            this.textBoxLocal.TabIndex = 5;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(186, 66);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(35, 15);
            this.labelLocal.TabIndex = 13;
            this.labelLocal.Text = "Local";
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Location = new System.Drawing.Point(199, 40);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(368, 23);
            this.textBoxAssunto.TabIndex = 4;
            // 
            // labelAssunto
            // 
            this.labelAssunto.AutoSize = true;
            this.labelAssunto.Location = new System.Drawing.Point(186, 22);
            this.labelAssunto.Name = "labelAssunto";
            this.labelAssunto.Size = new System.Drawing.Size(50, 15);
            this.labelAssunto.TabIndex = 9;
            this.labelAssunto.Text = "Assunto";
            // 
            // dateTimeTermino
            // 
            this.dateTimeTermino.CustomFormat = "HH:mm";
            this.dateTimeTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTermino.Location = new System.Drawing.Point(26, 115);
            this.dateTimeTermino.Name = "dateTimeTermino";
            this.dateTimeTermino.Size = new System.Drawing.Size(67, 23);
            this.dateTimeTermino.TabIndex = 2;
            // 
            // labelHoraTermino
            // 
            this.labelHoraTermino.AutoSize = true;
            this.labelHoraTermino.Location = new System.Drawing.Point(12, 97);
            this.labelHoraTermino.Name = "labelHoraTermino";
            this.labelHoraTermino.Size = new System.Drawing.Size(94, 15);
            this.labelHoraTermino.TabIndex = 7;
            this.labelHoraTermino.Text = "Hora de término";
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInicio.Location = new System.Drawing.Point(26, 71);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(127, 23);
            this.dateTimeInicio.TabIndex = 1;
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Location = new System.Drawing.Point(12, 53);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(81, 15);
            this.labelDataInicio.TabIndex = 5;
            this.labelDataInicio.Text = "Hora de inicio";
            // 
            // CadastroCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 164);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCompromissos";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.DateTimePicker dateTimeTermino;
        private System.Windows.Forms.Label labelHoraTermino;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label labelDataInicio;
        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.ComboBox comboBoxContato;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumero;
    }
}