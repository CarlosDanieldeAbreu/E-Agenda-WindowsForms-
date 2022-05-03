using System;
using GestaoCompromissos.Dominio;
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

namespace GestaoCompromissos.WinApp
{
    public partial class CadastroCompromissos : Form
    {
        private Compromisso compromisso;

        private ISerializadorContatos serializador;
        List<Contato> contatos;

        private RepositorioContatoEmArquivos repositorioContato;


        public CadastroCompromissos()
        {
            InitializeComponent();
            AtualizarTela();
        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                compromisso = value;
                textBoxNumero.Text = compromisso.Numero.ToString();
                textBoxAssunto.Text = compromisso.Assunto;
                textBoxLocal.Text = compromisso.Local;
                try
                {
                    dateTimeInicio.Text = compromisso.HoraInicio.ToString();
                    dateTimeTermino.Text = compromisso.HoraTermino.ToString();
                }
                catch(Exception ex)
                {
                   
                }
                comboBoxContato.SelectedItem = compromisso.Contato;
            }
        }

        private void AtualizarTela()
        {
            serializador = new SerializadorContatosEmJsonDotnet();
            repositorioContato = new RepositorioContatoEmArquivos(serializador);
            List<Contato> contatosDisponiveis = repositorioContato.SelecionarTodos();

            comboBoxContato.Items.Clear();
            if (contatosDisponiveis.Count > 0)
            {
                foreach (Contato contato in contatosDisponiveis)
                {
                    comboBoxContato.Items.Add(contato);
                }
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            compromisso.Contato = (Contato)comboBoxContato.SelectedItem;
            compromisso.Assunto = textBoxAssunto.Text;
            compromisso.Local = textBoxLocal.Text;
            compromisso.HoraInicio = DateTime.Parse(dateTimeInicio.Text);
            compromisso.HoraTermino = DateTime.Parse(dateTimeTermino.Text);
        }
    }
}
