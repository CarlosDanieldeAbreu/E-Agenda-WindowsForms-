using GestaoContato.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace GestaoContato.Infra.Arquivos
{
    public class RepositorioContatoEmArquivos : IRepositorioContato
    {
        private readonly ISerializadorContatos serializador;
        List<Contato> contatos;
        private int contador = 0;

        public RepositorioContatoEmArquivos(ISerializadorContatos serializador)
        {
            this.serializador = serializador;
            contatos = serializador.CarregarContatosDoArquivo();
            if (contatos.Count > 0)
                contador = contatos.Max(x => x.Numero);
        }

        public void Editar(Contato contato)
        {
            foreach(var pessoa in contatos)
            {
                if(pessoa.Numero == contato.Numero)
                {
                    pessoa.Nome = contato.Nome;
                    pessoa.Email = contato.Email;
                    pessoa.Empresa = contato.Empresa;
                    pessoa.Cargo = contato.Cargo;
                    pessoa.Telefone = contato.Telefone;
                    break;
                }
            }
            serializador.GravarContatosEmArquivo(contatos);
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);
            serializador.GravarContatosEmArquivo(contatos);
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Numero = ++contador;
            contatos.Add(novoContato);
            serializador.GravarContatosEmArquivo(contatos);
        }

        public List<Contato> SelecionarTodos()
        {
            contatos = serializador.CarregarContatosDoArquivo();
            return contatos;
        }
    }
}
