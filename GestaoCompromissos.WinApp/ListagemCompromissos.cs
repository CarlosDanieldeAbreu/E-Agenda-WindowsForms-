using System;
using GestaoCompromissos.Dominio;
using GestaoCompromisso.Infra.Arquivos;
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
    public partial class ListagemCompromissos : Form
    {
        private IRepositorioCompromisso repositorioCompromisso;
        public ListagemCompromissos()
        {
            SerializadorConpromissosEmJsonDotnet serializador = new SerializadorConpromissosEmJsonDotnet();

            repositorioCompromisso = new RepositorioCompromissoEmArquivos(serializador);

            InitializeComponent();
            CarregarCompromissos();
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> viazualizarTodosCompromissos = repositorioCompromisso.SelecionarTodos();

            listBoxCompromissos.Items.Clear();

            foreach (Compromisso c in viazualizarTodosCompromissos)
            {
                listBoxCompromissos.Items.Add(c);
            }

            List<Compromisso> compromissosFuturos = repositorioCompromisso.SelecionarCompromissosFuturos();

            listBoxFuturos.Items.Clear();

            foreach (Compromisso c in compromissosFuturos)
            {
                listBoxFuturos.Items.Add(c);
            }

            List<Compromisso> compromissosPassados = repositorioCompromisso.SelecionarCompromissosPassados();

            listBoxPassados.Items.Clear();

            foreach (Compromisso c in compromissosPassados)
            {
                listBoxPassados.Items.Add(c);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroCompromissos tela = new CadastroCompromissos();
            tela.Compromisso = new Compromisso();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (tela.Compromisso.Validar() == "REGISTRO_VALIDO")
                {
                    repositorioCompromisso.Inserir(tela.Compromisso);
                    CarregarCompromissos();
                }else
                {
                    MessageBox.Show("Prencha os campos brigatorios Assunto, Local e Data do compromisso",
                        "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listBoxCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroCompromissos tela = new CadastroCompromissos();

            tela.Compromisso = compromissoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (tela.Compromisso.Validar() == "REGISTRO_VALIDO")
                {
                    repositorioCompromisso.Editar(tela.Compromisso);
                    CarregarCompromissos();
                }else
                {
                    MessageBox.Show("Prencha os campos brigatorios Assunto, Local e Data do compromisso",
                        "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listBoxCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um Compromisso primeiro",
                "Exclusão de compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o compromisso?",
                "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissos();
            }
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dateTimeInicio.Value;
            DateTime termino = dateTimeTermino.Value;

            List<Compromisso> compromissosPorPeriodo = repositorioCompromisso.RetornaRegistrosPorPeriodo(inicio, termino);

            listBoxCompromPeriodo.Items.Clear();

            foreach (Compromisso c in compromissosPorPeriodo)
            {
                listBoxCompromPeriodo.Items.Add(c);
            }
        } 
    }
}
