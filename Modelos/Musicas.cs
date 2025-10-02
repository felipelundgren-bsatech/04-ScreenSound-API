﻿using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace _04_ScreenSound_API.Modelos;

internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("song")]
    public string Nome { get; set; }
    
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    
    [JsonPropertyName("genre")]
    public string Genero { get; set; }
    //Aula 05 desafio
    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade {
        get
        {
            return tonalidades[Key];
        }
    }
    //-----------------------------------------------------
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração: {Duracao/1000} em segundos");
        Console.WriteLine($"Genero Musical: {Genero}");
        //----------------------------------------------
        Console.WriteLine($"Tonalidade: {Tonalidade}");
        //----------------------------------------------

    }
}
