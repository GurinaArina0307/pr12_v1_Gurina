using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12_v1_Gurina
{
    public class Pirozhnoe
    {
        public string Nazvanie { get; set; }
        public string Testo { get; set; }
        public string Kream { get; set; }
        public double Ves { get; set; }
        public double Kalorinost { get; set; }
        public double Cena { get; set; }

        public Pirozhnoe(string nazvanie, string testo, string kream, double ves, double kalorinost, double cena)
        {
            Nazvanie = nazvanie;
            Testo = testo;
            Kream = kream;
            Ves = ves;
            Kalorinost = kalorinost;
            Cena = cena;
        }

        public void ImputInformation()
        {
            Console.WriteLine($"Название : {Nazvanie}");
            Console.WriteLine($"Тесто : {Testo}");
            Console.WriteLine($"Крем : {Kream}");
            Console.WriteLine($"Вес: {Ves} г");
            Console.WriteLine($"Калорийность : {Kalorinost} ккал/100 г");
            Console.WriteLine($"Цена : {Cena} руб.");
        }

        public double CostCalculation(int kolichestvo)
        {
            return kolichestvo * Cena;
        }

        public double CaloricCalculation()
        {
            return (Kalorinost / 100) * Ves;
        }
    }
}
