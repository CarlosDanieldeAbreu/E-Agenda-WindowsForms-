using GestaoTarefas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroItensTarefa : Form
    {
        private readonly Tarefa tarefa;

        public CadastroItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            
            this.tarefa = tarefa;

            labelTituloTarefa.Text = tarefa.Titulo;

            foreach (ItemTarefa item in tarefa.Itens)
            {
                listBoxItens.Items.Add(item);
            }            
        }

        public List<ItemTarefa> ItensAdicionados 
        {
            get 
            {
                return listBoxItens.Items.Cast<ItemTarefa>().ToList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (titulos.Count == 0 || titulos.Contains(textBoxTitulo.Text) == false)
            {
                ItemTarefa itemTarefa = new ItemTarefa();

                itemTarefa.Titulo = textBoxTitulo.Text;

                listBoxItens.Items.Add(itemTarefa);
            }
            textBoxTitulo.Clear();
        }
    }
}
