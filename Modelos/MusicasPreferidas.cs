namespace _04_ScreenSound_API.Modelos;
using System.Text.Json;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas (string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }
           
    public void AdicionarMusicasFavoritas(Musica musica)

    {
        ListaDeMusicasFavoritas.Add(musica);
    }
    
    public void ExibirListaDeMusicasFavoritas()
    {
        Console.WriteLine($"Essas sao as musicas favoritas - {Nome}");
        foreach(var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }
    
    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Json criado com sucesso!! {Path.GetFullPath(nomeDoArquivo)}");
    }

}

