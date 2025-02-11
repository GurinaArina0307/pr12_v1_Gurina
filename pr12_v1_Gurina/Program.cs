using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12_v1_Gurina
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirozhnoe p1 = new Pirozhnoe("Наполеон", "Слоеное", "Ваниль", 200, 320, 120);
            Pirozhnoe p2 = new Pirozhnoe("Прага", "Слоеное", "Шоколадный", 180, 200, 160);

            p1.ImputInformation();
            Console.WriteLine($"Общая калорийность : {p1.CaloricCalculation()} ккал");

            int kolichestvoP1 = 3;
            Console.WriteLine($"Стоимость {kolichestvoP1} пирожных {p1.Nazvanie} : {p1.CostCalculation(kolichestvoP1)} руб.");

            Console.WriteLine();

            p2.ImputInformation();
            Console.WriteLine($"Общая калорийность : {p2.CaloricCalculation()} ккал");

            int kolichestvoP2 = 3;
            Console.WriteLine($"Стоимость {kolichestvoP2} пирожных {p2.Nazvanie} : {p2.CostCalculation(kolichestvoP2)} руб.");

            Console.ReadKey();
        }
    }
}
