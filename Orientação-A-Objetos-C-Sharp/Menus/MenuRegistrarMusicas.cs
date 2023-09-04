using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;
internal class MenuRegistrarMusicas : Menu
{
    public override void Executar(List<Banda> listaDeBandas)
    {
        Console.WriteLine("\n\r");
        string titulo = "Registrar músicas em um álbum";
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

        while (true)
        {
            Console.Write("Digite o nome da música ou 0 para sair: ");
            string nomeMusica = Console.ReadLine()!;
            if (nomeMusica == "0")
            {
                break;
            }

            while (true)
            {
                try
                {
                    Console.Write("Digite a duração da música: ");
                    int duracao = int.Parse(Console.ReadLine()!);
                    Musica musica = new Musica(nomeMusica, duracao);
                    album.AdicionarMusica(musica);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Duração inválida. Digite novamente: ");
                }
            }
        }
    }

}
