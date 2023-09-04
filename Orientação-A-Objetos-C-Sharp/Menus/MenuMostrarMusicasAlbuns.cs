using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;
internal class MenuMostrarMusicasAlbuns : Menu
{
    public override void Executar(List<Banda> listaDeBandas)
    {
        Console.WriteLine("\n\r");
        string titulo = "Mostrar músicas de um álbum";
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
        Console.WriteLine($"\nMúsicas do álbum {album.Name}: ");
        album.DescricaoDetalhada();
    }
}