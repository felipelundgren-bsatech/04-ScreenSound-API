using _04_ScreenSound_API.Modelos;

namespace _04_ScreenSound_API.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistaOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select
            (musica =>musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    
}
