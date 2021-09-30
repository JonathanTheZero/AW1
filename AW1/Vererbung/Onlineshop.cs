using AW1.Vererbung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AW1.Vererbung
{
    public static class Onlineshop
    {
        public static void TaskC()
        {
            List<Produkt> list = GenerateList();
            Console.OutputEncoding = Encoding.UTF8;

            foreach (Produkt p in list)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine("---------------");
            }
        }

        private static List<Produkt> GenerateList()
        {
            List<Produkt> list = new List<Produkt>()
            {
                new CD(1, 14.99m, "Vader - Tibi et Igni", "Nuclear Blast Records", "Death/Thrash Metal", 55.43),
                new CD(2, 14.99m, "Rammstein - Rammstein", "Universal Music", "Neue deutsche Härte", 60),
                new Buch(3, 12.99m, "Der Herr der Ringe", "100023423", "Tolkien Verlag", 367),
                new Buch(4, 24.99m, "Die Bibel", "666666666", "Päpstlicher Verlag", 1200),
                new CD(5, 13.99m, "Sepultura - Quadra", "Nuclear Blast Records", "Death/Thrash Metal", 72),
                new CD(6, 12.99m, "Die drei ??? und der Jadekönig", "Europa", "Hörspiel", 75)
            };
            return list;

        }

        public static void TaskD()
        {
            List<Produkt> list = FilterForCDsOver70Mins(GenerateList());
            Console.WriteLine("Alle CDs über 70 Minuten:");
            Console.OutputEncoding = Encoding.UTF8;

            foreach (Produkt p in list)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine("---------------");
            }
        }

        private static List<Produkt> FilterForCDsOver70Mins(List<Produkt> p)
        {
            return p.Where(e => e is CD cd && cd.Dauer > 70).ToList();
        }
    }
}
