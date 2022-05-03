using System;
using GestaoContato.Dominio;
using GestaoContato.Infra.Arquivos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoContato.WinApp
{
    public partial class CadastroContatos : Form
    {
        private Contato contato;

        public CadastroContatos()
        {
            InitializeComponent();
        }

        
        public Contato Contato 
        { 
            get 
            { 
                return contato; 
            }
            set
            {
                contato = value;
                textBoxNumero.Text = contato.Numero.ToString();
                textBoxNome.Text = contato.Nome;
                textBoxEmpresa.Text = contato.Empresa;
                comboBoxCargo.Text = contato.Cargo;
                maskedTextBoxEmail.Text = contato.Email;
                maskedTextBoxTelefone.Text = contato.Telefone;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            contato.Nome = textBoxNome.Text;
            contato.Empresa = textBoxEmpresa.Text;
            contato.Email = maskedTextBoxEmail.Text;
            contato.Telefone = maskedTextBoxTelefone.Text;
            contato.Cargo = comboBoxCargo.Text;
        }
    }
}
