using ScreenSound.Models;

namespace ScreenSound.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Menu
{


    static Dictionary<int, Menu> opcoesDoMenu = new Dictionary<int, Menu>()
    {
        {1, new MenuMostrarBandas()},
        {2, new MenuRegistrarBandas()},
        {3, new MenuRegistrarAlbuns()},
        {4, new MenuRegistrarMusicas()},
        {5, new MenuAvaliarBandas()},
        {6, new MenuAvaliarAlbuns()},
        {7, new MenusExibirDetalhes()},
        {8, new MenuMostrarMusicasAlbuns()},
        {9, new MenuMostrarAvaliacoes()}
    };

    static string title = @"

█████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█▄─▀█▄─▄███─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
█▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀██─█▄▀─████▄▄▄▄─█─██─██─██─███─█▄▀─███─██─█
█▄▄▄▄▄█▄▄▄▄▄█▄▄█▄▄█▄▄▄▄▄█▄▄▄▄▄█▄▄▄██▄▄███▄▄▄▄▄█▄▄▄▄██▄▄▄▄██▄▄▄██▄▄█▄▄▄▄██

";
    static void PrintWelcomeMessage()
    {
        Console.WriteLine(title);
    }

    public static void ExibirOpcoesDoMenu(List<Banda> listaDeBandas)
    {
        int opcaoInt = ImprimirOpcoesDoMenu();

        while (true)
        {
            if (opcaoInt == 0)
            {
                break;
            }
            opcoesDoMenu[opcaoInt].Executar(listaDeBandas);
            Menu.LimparTela();
            opcaoInt = ImprimirOpcoesDoMenu();
        }
    }
    static int ImprimirOpcoesDoMenu()
    {
        PrintWelcomeMessage();
        Console.WriteLine("Escolha uma opção:\n\r");

        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Mostrar todas as bandas");
        Console.WriteLine("2 - Registrar uma banda");
        Console.WriteLine("3 - Registrar um álbum em uma banda");
        Console.WriteLine("4 - Registrar uma música em um álbum");
        Console.WriteLine("5 - Avaliar uma banda");
        Console.WriteLine("6 - Avaliar um álbum");
        Console.WriteLine("7 - Exibir discografia de uma banda");
        Console.WriteLine("8 - Exibir músicas de um álbum");
        Console.WriteLine("9 - Exibir avaliação de uma banda");


        Console.Write("\n\rDigite o número da opção desejada: ");
        string opcao;
        int opcaoInt;

        opcao = Console.ReadLine()!;

        while (true)
        {
            try
            {
                opcaoInt = int.Parse(opcao);

                if (opcaoInt is < 0 or > 8)
                {
                    throw new Exception();
                }

                Console.WriteLine($"A opção escolhida foi: {opcaoInt}");
                break;

            }
            catch (Exception)
            {
                Console.WriteLine("Opção inválida. Digite novamente: ");
                opcao = Console.ReadLine()!;
            }
        }

        return opcaoInt;
    }
    public static void LimparTela()
    {

        Console.WriteLine("");
        string titulo = "Voltando ao menu...";
        Console.WriteLine(titulo);
        Console.WriteLine("");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }

    public static void ImprimirDivisoria(string titulo)
    {
        int numeroDeAsteriscos = titulo.Length;
        string asteriscos = string.Empty.PadLeft(numeroDeAsteriscos, '*');

        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos);
        Console.WriteLine();
    }

    public virtual void Executar(List<Banda> listaDeBandas)
    {
        throw new NotImplementedException();
    }
}
