using System.Text.Json.Serialization;

namespace ScreenSoundFixAPI.Modelos
{
    internal class Musica
    {
        private string[] keys = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; } // Renomeado para Key

        public string Nota
        {
            get
            {
                return keys[Key]; // Usando Key para acessar o array
            }
        }

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Tonalidade: {Nota}"); // Alterado para exibir Nota
        }
    }
}