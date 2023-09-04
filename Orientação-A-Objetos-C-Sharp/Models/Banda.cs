using System.Runtime.InteropServices.JavaScript;
using ScreenSound.Interfaces;

namespace ScreenSound.Models;

class Banda : IAvaliavel
{
    public string Nome {get;}

    public string? Descricao { get; set; }
    public List<Album> Albuns { get; }

    private List<Avaliacao> Avaliacoes;

    public Banda(List<Album> albuns, string nome)
    {
        Nome = nome;
        Albuns = albuns;
        Avaliacoes = new List<Avaliacao>();
    }

    public Banda(string nome)
    {
        Nome = nome;
        Albuns = new List<Album>();
        Avaliacoes = new List<Avaliacao>();
    }

    public void AdicionarAlbum(Album album)
    {
        album.Artista = Nome;
        Albuns.Add(album);
    }

    public void RemoverAlbum(Album album)
    {
        Albuns.Remove(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia da banda {Nome}:\n");
        Albuns.ForEach(album => Console.WriteLine(album.ToString()));
    }

    
    public override string ToString()
    {

        string returnString;
        double media  = MediaAvaliacoes;
        if (media > 0)
            returnString = $"Nome: {Nome}\r\nAvaliação: {media}\r\nNúmero de Avaliações: {Avaliacoes.Count}\r\nQuantidade de Albuns: {Albuns.Count}";
        else
            returnString = $"Nome: {Nome}\r\nAvaliação: Não há avaliações\r\nNúmero de Avaliações: 0 \r\nQuantidade de Albuns: {Albuns.Count}";

        int maxLength = returnString.Split('\n').Max(s => s.Length);
        string pad = string.Empty.PadLeft(maxLength, '-');
        return $"{pad}\r\n{returnString}\r\n{pad}\n";
    }
    public string getAvaliacao()
    {
        double media = MediaAvaliacoes;
        if (media > 0)
            return $"A avaliação da banda {Nome} é: {MediaAvaliacoes}";
        return $"A banda {Nome} não possui avaliações";
    }

    public double MediaAvaliacoes
    {
        get
        {
            if (Avaliacoes.Count == 0)
                return 0;
            return Avaliacoes.Average(avaliacao => avaliacao.Nota);
        }
    }

    public void Avaliar(Avaliacao avaliacao)
    {
        Avaliacoes.Add(avaliacao);
    }
}

