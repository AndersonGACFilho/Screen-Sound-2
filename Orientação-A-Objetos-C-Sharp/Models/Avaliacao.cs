namespace ScreenSound.Models;

internal class Avaliacao
{
    public double Nota { get; }

    public Avaliacao(double nota)
    {
        Nota = nota;
    }

    public override string ToString()
    {
        return $"{Nota}";
    }

    public static Avaliacao Parse(string avaliacao)
    {
        return new Avaliacao(double.Parse(avaliacao));
    }

    
}
