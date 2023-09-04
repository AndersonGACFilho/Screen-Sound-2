namespace ScreenSound.Models;


internal class Episodio
{
    public string Titulo { get; }
    public string Resumo { get; }
    public int Duracao { get; }
    public int Numero { get; }
    public DateTime DataPublicacao { get; }

    private List<String> Convidados;

    public Episodio(string titulo, string resumo, int duracao, int numero, DateTime dataPublicacao)
    {
        Titulo = titulo;
        Resumo = resumo;
        Duracao = duracao;
        Numero = numero;
        DataPublicacao = dataPublicacao;
        Convidados = new List<string>();
    }

    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }

    public void RemoverConvidado(string convidado)
    {
        Convidados.Remove(convidado);
    }

    public override string ToString()
    {
        string convidados = "Nenhum";
        if (Convidados.Count > 0)
        {
            convidados = Convidados.Aggregate("", (current, convidado) => current + $"{convidado} {(Convidados.Count - 1 == Convidados.FindIndex(c => c == convidado) ? "" : ", ")}");
        }
        string returnedString = $"Título: {Titulo}\nResumo: {Resumo}\nDuração: {Duracao}\nNúmero: {Numero}\nData de publicação: {DataPublicacao}\nConvidados: {convidados}";
        int maxLength = returnedString.Split('\n').Max(s => s.Length);
        return $"{returnedString}\r\n";

    }
}
