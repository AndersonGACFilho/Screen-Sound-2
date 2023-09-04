using ScreenSound.Models;

namespace ScreenSound.Interfaces;
internal interface IAvaliavel
{
    public string getAvaliacao();

    public void Avaliar(Avaliacao nota);

    double MediaAvaliacoes { get; }
}