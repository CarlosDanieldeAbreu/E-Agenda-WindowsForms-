using System;
using System.Text;

namespace GestaoTarefas.Dominio
{
    [Serializable]
    public class ItemTarefa
    {
        public string Titulo { get; set; }
        public bool Concluido { get; set; }

        public override string ToString()
        {
            return Titulo;
        }

        public string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Titulo))
                sb.AppendLine("O titulo do item da tarefa é obrigatória!");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

        public void Concluir()
        {
            Concluido = true;
        }

        internal void MarcarPendente()
        {
            Concluido = false;
        }
    }
}
