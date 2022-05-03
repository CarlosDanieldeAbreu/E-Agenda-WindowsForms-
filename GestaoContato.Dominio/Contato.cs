using System;
using System.Text;
using System.Text.RegularExpressions;

namespace GestaoContato.Dominio
{
    [Serializable]
    public class Contato
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public Contato(string nome, string email, string telefone, string empresa, string cargo, int numero) : this()
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
            Numero = numero;
        }

        public Contato()
        {
        }

        public string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Nome))
                sb.AppendLine("O nome do contato é obrigatório!");

            if (EmailEstaValido(ValidarEmail) == false)
                sb.AppendLine("Insira um endereço de email válido! (Ex: contato@gmail.com)");

            if (string.IsNullOrEmpty(Telefone))
                sb.AppendLine("O número do telefone é obrigatorio");

            if (string.IsNullOrEmpty(Empresa))
                sb.AppendLine("O nome da empresa é obrigatório!");

            if (string.IsNullOrEmpty(Cargo))
                sb.AppendLine("O nome do cargo é obrigatório!");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

        private bool EmailEstaValido(Func<bool> validacaoSelecionada)
        {
            bool emailEstaValido = validacaoSelecionada();

            return emailEstaValido;
        }

        private bool ValidarEmail()
        {
            bool emailEstaValido = System.Net.Mail.MailAddress.TryCreate(Email, out _);

            return emailEstaValido;
        }

        public override string ToString()
        {
            return $"Número: {Numero}, Nome: {Nome}, Telefone: {Telefone}, Empresa:  {Empresa}, Cargo: {Cargo} ";
        }
    }
}
