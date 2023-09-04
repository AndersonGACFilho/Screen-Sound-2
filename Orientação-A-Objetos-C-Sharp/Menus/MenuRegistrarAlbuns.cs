using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbuns : Menu
{
    public override void Executar(List<Banda> listaDeBandas)
    {
        Console.WriteLine("\n\r");
        string titulo = "Registrar um álbum em uma banda";
        ImprimirDivisoria(titulo);
        Console.WriteLine();
        Console.Write("Digite o nome da banda: ");
        string nomeBanda = Console.ReadLine()!;
        if (!listaDeBandas.Exists(banda => banda.Nome == nomeBanda))
        {
            Console.WriteLine("Banda não registrada");
            return;
        }
        Console.Write("Digite o nome do álbum: ");
        string nomeAlbum = Console.ReadLine()!;
        while (true)
        {
            try
            {
                Banda banda = listaDeBandas.Find(banda => banda.Nome == nomeBanda);
                Album album = new Album(nomeAlbum);
                banda.AdicionarAlbum(album);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Ano inválido. Digite novamente: ");
                nomeBanda = Console.ReadLine()!;
            }
        }
    }

}
