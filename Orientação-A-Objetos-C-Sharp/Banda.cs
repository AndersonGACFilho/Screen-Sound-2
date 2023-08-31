using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Banda
{
    public string Nome {get;}
    public List<Album> Albuns { get; }

    public Banda(List<Album> albuns, string nome)
    {
        Nome = nome;
        Albuns = albuns;
    }

    public Banda(string nome)
    {
        Nome = nome;
        Albuns = new List<Album>();
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

}

