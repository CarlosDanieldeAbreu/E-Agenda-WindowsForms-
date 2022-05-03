using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCompromissos.Dominio
{
    public interface IRepositorioCompromisso
    {
        void Editar(Compromisso compromisso);
        void Excluir(Compromisso compromisso);
        void Inserir(Compromisso novoCompromisso);
        List<Compromisso> SelecionarTodos();

        List<Compromisso> SelecionarRegistrosPorPeriodo(DateTime dataInicio, DateTime dataTermino);
        List<Compromisso> SelecionarCompromissosFuturos();
        List<Compromisso> SelecionarCompromissosPassados();
        List<Compromisso> RetornaRegistrosPorPeriodo(DateTime inicio, DateTime termino);
    }
}
