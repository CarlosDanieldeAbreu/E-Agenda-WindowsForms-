using GestaoCompromissos.Dominio;
using GestaoContato.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoCompromisso.Infra.Arquivos
{
    public class RepositorioCompromissoEmArquivos : IRepositorioCompromisso
    {
        private readonly ISerializadorCompromissos serializador;
        List<Compromisso> compromissos;
        private int contador = 0;

        public RepositorioCompromissoEmArquivos(ISerializadorCompromissos serializador)
        {
            this.serializador = serializador;
            compromissos = serializador.CarregarCompromissosDoArquivo();
            if (compromissos.Count > 0)
                contador = compromissos.Max(x => x.Numero);
        }

        public void Editar(Compromisso conpromisso)
        {
            foreach (var evento in compromissos)
            {
                if (evento.Numero == conpromisso.Numero)
                {
                    evento.Assunto = conpromisso.Assunto;
                    evento.Local = conpromisso.Local;
                    evento.DataCompromisso = conpromisso.DataCompromisso;
                    evento.HoraInicio = conpromisso.HoraInicio;
                    evento.HoraTermino = conpromisso.HoraTermino;

                    break;
                }
            }
            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);
            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public void Inserir(Compromisso novoConpromisso)
        {
            novoConpromisso.Numero = ++contador;
            compromissos.Add(novoConpromisso);
            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public List<Compromisso> SelecionarRegistrosPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return compromissos.Where(x => x.DataCompromisso > dataInicio && x.DataCompromisso < dataTermino).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            return compromissos.Where(x => x.DataCompromisso >= DateTime.Today).ToList();
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            return compromissos.Where(x => x.DataCompromisso < DateTime.Today).ToList();
        }

        public List<Compromisso> RetornaRegistrosPorPeriodo(DateTime inicio, DateTime termino)
        {
            List<Compromisso> compromissossPorPeriodo = SelecionarRegistrosPorPeriodo(inicio, termino);

            return compromissossPorPeriodo;
        }
    }
}
