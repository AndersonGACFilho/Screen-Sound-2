namespace ScreenSound.Models;


internal class Musica
{
    private string Nome { get; set; }
    private string Album { get; set; }
    private string Artista { get; set; }

    private int Duracao { get; set; }
    private bool Disponivel { get; set; }

    public string ResumoMusica { get;}

    public Musica(string nome, int duracao)
    {
        Nome = nome;
        Duracao = duracao;
        Disponivel = true;
    }

    public Musica(string nome, string album, string artista, int duracao, bool isDisponivel)
    {
        this.Nome = nome;
        this.Album = album;
        this.Artista = artista;
        this.Duracao = duracao;
        this.Disponivel = isDisponivel;
        this.ResumoMusica = $"{this.Nome} - {this.Artista}";
    }

    public string getNome() { return this.Nome; }
    public string getAlbum() { return this.Album; }
    public string getArtista() { return this.Artista; }
    public int getDuracao() { return this.Duracao; }
    public bool getDisponivel() { return this.Disponivel; }

    public void setNome(string nome) { this.Nome = nome; }
    public void setAlbum(string album) { this.Album = album; }
    public void setArtista(string artista) { this.Artista = artista; }
    public void setDuracao(int duracao) { this.Duracao = duracao; }
    public void setDisponivel(bool disponivel) { this.Disponivel = disponivel; }

    public string DescricaoDetalhada()
    {
        TimeSpan time = TimeSpan.FromSeconds(Duracao);
        string timeInMinutes = time.ToString(@"mm\:ss");
        string returnString = $"Nome: {this.Nome}\nAlbum: {this.Album}\nArtista: {this.Artista}\nDuração: {timeInMinutes}\nDisponível: {(this.Disponivel?"Sim":"Não")}";
        int maxLength = returnString.Split('\n').Max(s => s.Length);
        string pad = string.Empty.PadLeft(maxLength, '-');
        return $"{pad}\r\n{returnString}\r\n{pad}\n";
    }

    public override string ToString()
    {
        string pad = string.Empty.PadLeft(ResumoMusica.Length, '*');
        return $"{pad}\n{ResumoMusica}\n{pad}";
    }
}
