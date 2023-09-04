using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAvaliarBandas : Menu
{
    public override void Executar(List<Banda> listaDeBandas)
    {
        Console.WriteLine("\n\r");
        string titulo = "Avaliar uma banda";
        ImprimirDivisoria(titulo);
        Console.WriteLine();
        Console.Write("Digite o nome da banda: ");
        string nomeBanda = Console.ReadLine()!;
        Banda banda = listaDeBandas.Find(banda => banda.Nome == nomeBanda);
        if (banda == null)
        {
            Console.WriteLine("Banda não registrada");
            return;
        }
        Console.Write("Digite a avaliação da banda: ");
        while (true)
        {
            try
            {
                Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);
                banda.Avaliar(avaliacao);
                Console.WriteLine($"Banda {banda.Nome} avaliada com sucesso com {avaliacao}");
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Avaliação inválida. Digite novamente: ");
                nomeBanda = Console.ReadLine()!;
            }
        }

    }

}
