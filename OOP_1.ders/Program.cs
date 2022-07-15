using System;

namespace OOP_1.ders
{
    class Program
    {
        static void Main(string[] args)
        {
            Ev ev = new Ev();
            ev.setodaSayisi(5);
            Console.WriteLine("Oda Sayısı: {0}", ev.getodaSayisi());
            
            ev.setadres("istanbul");
            Console.WriteLine("Adres: {0}", ev.getadres());

        }
    }
}
