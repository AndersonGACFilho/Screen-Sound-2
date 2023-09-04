using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI_API;

namespace ScreenSound.Menus;

internal class MenuRegistrarBandas : Menu
{
    public static string ApiKey = "";
    public override void Executar(List<Banda> listaDeBandas)
    {
        Console.WriteLine("\n\r");
        string titulo = "Registrar uma banda";
        ImprimirDivisoria(titulo);
        Console.WriteLine();
        Console.Write("Digite o nome da banda: ");
        string nomeBanda = Console.ReadLine()!;
        if (listaDeBandas.Exists(banda => banda.Nome == nomeBanda))
        {
            Console.WriteLine("Banda já registrada");
            return;
        }

        if (nomeBanda.Length < 4)
        {
            Console.WriteLine("Nome da banda deve ter no mínimo 4 caracteres");
            Executar(listaDeBandas);
            return;
        }
        Banda banda = new Banda(nomeBanda);

        var client = new OpenAIAPI(ApiKey);

        var chat = client.Chat.CreateConversation();

        string prompt =
            $"Resuma a banda {banda.Nome} em um parágrafo, adote o estilo condizente com o estilo da banda em questão";
        string opcao;
        int tentativa = 0;
        while (true)
        {
            tentativa++;
            try
            {
                chat.AppendSystemMessage(prompt);
                string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
                banda.Descricao = resposta;
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\r");
                Console.WriteLine("Tentativa " + tentativa);
                Console.WriteLine("Erro ao se conectar com a API");
                Console.WriteLine("Não foi possível gerar uma descrição automaticamente para a banda");
                Console.WriteLine("erro:" + e.Message);
                Console.WriteLine("\n\r");
                Console.WriteLine("1 - para tentar novamente");
                Console.WriteLine("2 - para inserir manualmente");
                Console.WriteLine("Qualquer outra tecla para cancelar");
                Console.WriteLine("\n\r");
                Console.Write("Digite a opção desejada: ");
                opcao = Console.ReadLine()!;

                if (opcao == "1")
                {
                    continue;
                }
                else if (opcao == "")
                {
                    Console.Write("Digite a descrição da banda: ");
                    banda.Descricao = Console.ReadLine()!;
                    break;
                }
                else
                {
                    Console.WriteLine("Você escolheu cancelar");
                    return;
                }

            }

        }


        listaDeBandas.Add(banda);
        Console.WriteLine($"Banda {nomeBanda} registrada com sucesso!");
    }
}
