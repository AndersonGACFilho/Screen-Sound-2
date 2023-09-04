using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuMostrarAvaliacoes : Menu
{
    public override void Executar(List<Banda> listaDeBandas)
    {
        Console.WriteLine("\n\r");
        string titulo = "Mostrar a avaliação de uma banda"; 
        ImprimirDivisoria(titulo);
        Console.WriteLine();

        Console.Write("Digite o nome da banda: ");
        string nomeBanda = Console.ReadLine()!;
        if (!listaDeBandas.Exists(banda => banda.Nome == nomeBanda))
        {
            Console.WriteLine("Banda não registrada");
            return;
        }
        Banda banda = listaDeBandas.Find(banda => banda.Nome == nomeBanda);
        Console.WriteLine($"\nA avaliação da banda {banda.Nome} é: ");
        Console.WriteLine(banda.getAvaliacao());
    }

}

