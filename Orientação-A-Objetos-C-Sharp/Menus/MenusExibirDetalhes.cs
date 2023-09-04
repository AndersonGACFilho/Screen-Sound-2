
using ScreenSound.Models;

namespace ScreenSound.Menus;
internal class MenusExibirDetalhes : Menu
{

    public override void Executar(List<Banda> listaDeBandas)
    {
        Console.WriteLine("\n\r");
        string titulo = "Mostrar detalhes de uma banda";
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
        Console.WriteLine($"\nDetalhes da banda {banda.Nome}: ");
        Console.WriteLine(banda);
        banda.ExibirDiscografia();
    }

}
