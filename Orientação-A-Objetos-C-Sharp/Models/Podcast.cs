namespace ScreenSound.Models;


internal class Podcast
{
    public string Nome { get; }

    public string Host { get; }
    public List<Episodio> Episodios { get; }

    private int QuantidadeEpisodios;

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
        QuantidadeEpisodios = 0;
        Episodios = new List<Episodio>();
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
        QuantidadeEpisodios++;
    }

    public void RemoverEpisodio(Episodio episodio)
    {
        Episodios.Remove(episodio);
        QuantidadeEpisodios--;
    }

    public override string ToString()
    {
        string returnString =
            $"Nome: {this.Nome}\nHost: {this.Host}\nQuantidade de episódios: {this.QuantidadeEpisodios}";
        int maxLength = returnString.Split('\n').Max(s => s.Length);
        string pad = string.Empty.PadLeft(maxLength, '-');
        return $"{pad}\r\n{returnString}\r\n{pad}\n";
    }

    public string DescricaoDetalhada()
    {
        string episodios = Episodios.Aggregate("", (current, episodio) => current + $"{episodio}\n");
        string returnString =
            $"Nome: {this.Nome}\nHost: {this.Host}\nQuantidade de episódios: {this.QuantidadeEpisodios}\nEpisódios:\r\n {episodios}";
        int maxLength = returnString.Split('\n').Max(s => s.Length);
        string pad = string.Empty.PadLeft(maxLength, '-');
        return $"{pad}\r\n{returnString}\r\n{pad}\n";
    }
}