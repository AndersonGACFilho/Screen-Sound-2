using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbuns : Menu
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
        Console.Write("Digite o nome do álbum: ");
        string nomeAlbum = Console.ReadLine()!;
        Album album = banda.Albuns.Find(album => album.Name == nomeAlbum);
        if (album == null)
        {
            Console.WriteLine("Álbum não registrado");
            return;
        }
        Console.Write("Digite a avaliação: ");
        while (true)
        {
            try
            {
                Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);
                album.Avaliar(avaliacao);
                Console.WriteLine($"Album {album.Name} da banda {banda.Nome} avaliado com sucesso com {avaliacao}");
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