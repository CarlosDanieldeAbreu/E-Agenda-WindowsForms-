using GestaoTarefas.Infra.Arquivos;
using GestaoTarefas.Dominio;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class ListagemTarefas : Form
    {
        private IRepositorioTarefa repositorioTarefa;
        public ListagemTarefas()
        {
            //SerializadorTarefasEmBinario serializador = new SerializadorTarefasEmBinario();

            //SerializadorTarefasEmXml serializador = new SerializadorTarefasEmXml();

            //SerializadorTarefasEmJson serializador = new SerializadorTarefasEmJson();

            SerializadorTarefasEmJsonDotnet serializador = new SerializadorTarefasEmJsonDotnet();

            repositorioTarefa = new RepositorioTarefaEmArquivo(serializador);

            InitializeComponent();
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefasConcluidas = repositorioTarefa.SelecionarTarefasConcluidas();

            listBoxTarefasConcluidas.Items.Clear();

            foreach (Tarefa t in tarefasConcluidas)
            {
                listBoxTarefasConcluidas.Items.Add(t);
            }

            List<Tarefa> tarefasPendentes = repositorioTarefa.SelecionarTarefasPendentes();

            listBoxTarefasPendentes.Items.Clear();

            foreach (Tarefa t in tarefasPendentes)
            {
                listBoxTarefasPendentes.Items.Add(t);
            }
        }

        private void btnAtualizarItem_Click(object sender, System.EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AtualizacaoItensTarefa tela = new AtualizacaoItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);
                CarregarTarefas();
            }
        }

        private void btnItem_Click(object sender, System.EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefas();
            }
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroTarefas tela = new CadastroTarefas();

            tela.Tarefa = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (tela.Tarefa.Validar() == "REGISTRO_VALIDO")
                {
                    repositorioTarefa.Editar(tela.Tarefa);
                    CarregarTarefas();
                }
                else
                {
                    MessageBox.Show("Prencha os campo brigatorio",
                        "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnInserir_Click(object sender, System.EventArgs e)
        {
            CadastroTarefas tela = new CadastroTarefas();
            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (tela.Tarefa.Validar() == "REGISTRO_VALIDO")
                {
                    repositorioTarefa.Inserir(tela.Tarefa);
                    CarregarTarefas();
                }
                else
                {
                    MessageBox.Show("Prencha os campo brigatorio",
                        "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}
