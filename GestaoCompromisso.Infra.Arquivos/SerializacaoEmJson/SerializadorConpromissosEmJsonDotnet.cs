using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using GestaoCompromissos.Dominio;

namespace GestaoCompromisso.Infra.Arquivos
{
    public class SerializadorConpromissosEmJsonDotnet : ISerializadorCompromissos
    {
        private const string arquivoConpromissos = @"C:\temp\Compromissos2.json";

        public List<Compromisso> CarregarCompromissosDoArquivo()
        {
            if (File.Exists(arquivoConpromissos) == false)
                return new List<Compromisso>();

            string conpromissosJson = File.ReadAllText(arquivoConpromissos);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Compromisso>>(conpromissosJson, settings);
        }

        public void GravarCompromissosEmArquivo(List<Compromisso> compromissos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string conpromissosJson = JsonConvert.SerializeObject(compromissos, settings);

            File.WriteAllText(arquivoConpromissos, conpromissosJson);
        }
    }
}
