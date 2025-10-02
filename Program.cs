using _04_ScreenSound_API.Modelos;
using System.Text.Json;
using _04_ScreenSound_API.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.WriteLine(musicas.Count);
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistaOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");

        //var musicasPreferidasDoArthur = new MusicasPreferidas("Arthur");
        //musicasPreferidasDoArthur.AdicionarMusicasFavoritas(musicas[0]);
        //musicasPreferidasDoArthur.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoArthur.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoArthur.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoArthur.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoArthur.ExibirListaDeMusicasFavoritas();

        var musicasPreferidasDeFelipe = new MusicasPreferidas("Felipe");
        musicasPreferidasDeFelipe.AdicionarMusicasFavoritas(musicas[18]);
        musicasPreferidasDeFelipe.AdicionarMusicasFavoritas(musicas[111]);
        musicasPreferidasDeFelipe.AdicionarMusicasFavoritas(musicas[122]);
        musicasPreferidasDeFelipe.AdicionarMusicasFavoritas(musicas[501]);
        musicasPreferidasDeFelipe.AdicionarMusicasFavoritas(musicas[637]);

        musicasPreferidasDeFelipe.ExibirListaDeMusicasFavoritas();
        musicasPreferidasDeFelipe.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
}


