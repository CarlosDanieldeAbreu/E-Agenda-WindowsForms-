using GestaoContato.Dominio;
using System;
using System.Text;

namespace GestaoCompromissos.Dominio
{
    [Serializable]
    public class Compromisso
    {
        private DateTime data;
        public int Numero { get; set; }
        public string Assunto { get; set; }
        public string Local { get; set; }

        private DateTime dataCompromisso;
        public DateTime DataCompromisso { get => HoraInicio; set => dataCompromisso = value ; }
        public DateTime HoraInicio { get; set;  }
        public DateTime HoraTermino { get; set; }
        public Contato Contato { get; set; }

        public Compromisso(string assunto, string local, DateTime dataCompromisso, DateTime horaInicio, DateTime horaTermino, Contato contato, int numero) : this()
        {
            Numero = numero;
            Assunto = assunto;
            Local = local;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            DataCompromisso = dataCompromisso;
            Contato = contato;
        }

        public Compromisso()
        {
        }

        public string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Assunto))
                sb.AppendLine("O assunto do compromisso é obrigatório!");

            if (string.IsNullOrEmpty(Local))
                sb.AppendLine("O local do compromisso é obrigatório!");

            //if (DataCompromisso == DateTime.MinValue)
            //    sb.AppendLine("A data do compromisso obrigatória!");

            //if (DataCompromisso < DateTime.Today)
            //    sb.AppendLine("A data do compromisso não pode ser antes de hoje!");

            if (HoraInicio > HoraTermino)
                sb.AppendLine("A hora de início não pode ser depois do término!");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

        public override string ToString()
        {
            string contatoRelacionado = Contato is null ? "Não disponível" : Contato.Nome;

            return $"Número: {Numero}, Assunto: {Assunto}, Local: {Local}, Data do compromisso: {DataCompromisso.ToString("dd/MM/yyyy")}, Hora de ínicio: {HoraInicio.ToString("HH:mm")}, Hora de término: {HoraTermino.ToString("HH:mm")} , Contato: {contatoRelacionado}";
        }
    }
}
