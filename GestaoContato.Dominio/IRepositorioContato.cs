using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContato.Dominio
{
    public interface IRepositorioContato
    {
        void Editar(Contato contato);
        void Excluir(Contato contato);
        void Inserir(Contato novoContato);
        List<Contato> SelecionarTodos();
    }
}
