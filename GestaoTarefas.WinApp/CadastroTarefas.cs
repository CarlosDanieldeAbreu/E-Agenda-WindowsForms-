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
    public partial class CadastroTarefas : Form
    {
        private Tarefa tarefa;

        public CadastroTarefas()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                textBoxNumero.Text = tarefa.Numero.ToString();
                textBoxTitulo.Text = tarefa.Titulo;
            }
        }      

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = textBoxTitulo.Text;
        }
    }
}
