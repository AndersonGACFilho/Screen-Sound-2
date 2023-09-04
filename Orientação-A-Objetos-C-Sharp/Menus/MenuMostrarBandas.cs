using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Models;

namespace ScreenSound.Menus;
internal class MenuMostrarBandas : Menu
{

    public override void Executar(List<Banda> listaDeBandas)
    {
        Console.WriteLine("\n\r");
        string titulo = "Bandas";
        ImprimirDivisoria(titulo);
        Console.WriteLine("");
        if (listaDeBandas.Count == 0)
        {
            Console.WriteLine("Nenhuma banda registrada");
            return;
        }
        Console.WriteLine("\nBandas registradas: \n");
        listaDeBandas.ForEach(banda => Console.WriteLine(banda));
    }
}
