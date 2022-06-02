using System.Text.Json.Serialization;

namespace Facec.Teste.WPF
{
    public class Cliente
    {

        [JsonPropertyName("id")]
        public int id { get; set; } = 0;

        [JsonPropertyName("documento")]
        public string Documento { get; set; } = string.Empty;

        [JsonPropertyName("nome")]
        public string Nome { get; set; } = string.Empty;

        public Cliente() { }

        public Cliente(int id, string documento, string nome)
        {
            id = id;
            Documento = documento;
            Nome = nome;
        }
    }
}