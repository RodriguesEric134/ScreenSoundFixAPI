using System.Net.Http; // Importa o namespace para usar HttpClient
using System.Text.Json; // Importa o namespace para usar JsonSerializer
using ScreenSoundFixAPI.Filtros;
using ScreenSoundFixAPI.Modelos;

class Program
{
    static async Task Main(string[] args) // Método principal assíncrono
    {
        using (HttpClient client = new HttpClient()) // Cria uma instância de HttpClient
        {
            try
            {
                // Faz uma requisição para obter os dados das músicas
                string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

                // Desserializa a resposta JSON para uma lista de objetos Musica
                var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
                //musicas[1].ExibirDetalhesDaMusica();


                // Chama o método para filtrar (São vários filtros)
                //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
                //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
                //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
                //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Arctic Monkeys");
                LinqFilter.FiltrarTonalidade(musicas, 1);


                //var musicasEric = new MusicasPreferidas("Eric");
                //musicasEric.AdicionarMusicasFavoritas(musicas[1]);
                //musicasEric.AdicionarMusicasFavoritas(musicas[545]);
                //musicasEric.AdicionarMusicasFavoritas(musicas[623]);
                //musicasEric.AdicionarMusicasFavoritas(musicas[245]);
                //musicasEric.AdicionarMusicasFavoritas(musicas[1880]);

                //musicasEric.ExibirMusicasFavoritas();

                //var musicasCire = new MusicasPreferidas("Cire");
                //musicasCire.AdicionarMusicasFavoritas(musicas[15]);
                //musicasCire.AdicionarMusicasFavoritas(musicas[270]);
                //musicasCire.AdicionarMusicasFavoritas(musicas[777]);
                //musicasCire.AdicionarMusicasFavoritas(musicas[134]);
                //musicasCire.AdicionarMusicasFavoritas(musicas[1345]);

                //musicasCire.ExibirMusicasFavoritas();


                //musicasCire.GerarArquivosJson();

            }
            catch (Exception ex) // Captura exceções que podem ocorrer
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}"); // Exibe a mensagem de erro
            }
        }
    }
}