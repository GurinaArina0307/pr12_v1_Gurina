using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12_4_Gurina
{
    public class Pirozhnoe
    {
        // Поля класса
        public string Nazvanie { get; set; }
        public string Testo { get; set; }
        public string Krem { get; set; }
        public double Ves { get; set; } // Вес в граммах
        public double Kalorinost { get; set; } // Калорийность на 100 грамм
        public double Tsena { get; set; } // Цена за одно пирожное

        // Конструктор класса
        public Pirozhnoe(string nazvanie, string testo, string krem, double ves, double kalorinost, double tsena)
        {
            Nazvanie = nazvanie;
            Testo = testo;
            Krem = krem;
            Ves = ves;
            Kalorinost = kalorinost;
            Tsena = tsena;
        }

        // Метод для подсчета стоимости покупки пирожных конкретного вида
        public double PodschetStoimosti(int kolichestvo)
        {
            return kolichestvo * Tsena;
        }

        // Дополнительный метод для получения калорийности всего пирожного
        public double ObshchayaKalorinost()
        {
            return (Kalorinost / 100) * Ves;
        }
        // Переопределяем метод ToString для отображения в ListBox
        public override string ToString()
        {
            return $"{Nazvanie} ({Testo} тесто, {Krem} крем, {Ves} г, {Kalorinost} ккал/100г, {Tsena} руб.)";
        }
    }
}
