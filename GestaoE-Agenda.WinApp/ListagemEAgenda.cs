using GestaoTarefas.WinApp;
using GestaoContato.WinApp;
using GestaoCompromissos.WinApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoE_Agenda.WinApp
{
    public partial class FormListagemEAgenda : Form
    {
        public FormListagemEAgenda()
        {
            InitializeComponent();
        }

        private void labelGerenciadorDeTarefas_Click(object sender, EventArgs e)
        {
            ListagemTarefas tela = new ListagemTarefas();
            tela.ShowDialog();
        }

        private void labelGerenciadorContatos_Click(object sender, EventArgs e)
        {
            ListagenContatos tela = new ListagenContatos();
            tela.ShowDialog();
        }

        private void labelGerenciadorCompromissos_Click(object sender, EventArgs e)
        {
            ListagemCompromissos tela = new ListagemCompromissos();
            tela.ShowDialog();
        }
    }
}
