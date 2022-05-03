using GestaoContato.Dominio;
using GestaoContato.Infra.Arquivos;
using System;
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
    public partial class ListagenContatos : Form
    {
        private IRepositorioContato repositorioContato;
        public ListagenContatos()
        {
            SerializadorContatosEmJsonDotnet serializador = new SerializadorContatosEmJsonDotnet();

            repositorioContato = new RepositorioContatoEmArquivos(serializador);

            InitializeComponent();
            CarregarContatos();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroContatos tela = new CadastroContatos();
            tela.Contato = new Contato();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (tela.Contato.Validar() == "REGISTRO_VALIDO")
                {
                    repositorioContato.Inserir(tela.Contato);
                    CarregarContatos();
                }
                else
                {
                    MessageBox.Show("Prencha os campos brigatorios Nome, E-mail, Telefone, Empresa e Cargo",
                        "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listBoxContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Edição de contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContatos tela = new CadastroContatos();

            tela.Contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (tela.Contato.Validar() == "REGISTRO_VALIDO")
                {
                    repositorioContato.Editar(tela.Contato);
                    CarregarContatos();
                }
                else
                {
                    MessageBox.Show("Prencha os campos brigatorios Nome, E-mail, Telefone, Empresa e Cargo",
                        "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listBoxContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o Contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }

        public void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listBoxContatos.Items.Clear();

            var contatosAgrupados = repositorioContato
                .SelecionarTodos()
                .GroupBy(x => x.Cargo);

            foreach (var contatoAgrupado in contatosAgrupados)
            {
                listBoxContatos.Items.Add(contatoAgrupado.Key);

                foreach (Contato contatoDisponivel in contatos)
                    if (contatoDisponivel.Cargo == contatoAgrupado.Key)
                        listBoxContatos.Items.Add(contatoDisponivel);
            }
        }
    }
}
