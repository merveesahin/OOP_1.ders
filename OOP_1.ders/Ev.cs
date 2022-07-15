using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1.ders
{
    public class Ev
    {
        private int odaSayisi;
        private string adres;

        public int getodaSayisi() 
        {
            return odaSayisi;
        }

        public void setodaSayisi(int odaSayisi)
        {
            if (odaSayisi > 8)
            {
                Console.WriteLine("Oda Sayısı 8'den büyük olamaz");
            }
            else
            {
                this.odaSayisi = odaSayisi;
            }
        }

        public string getadres()
        {
            return adres;
        }
        public void setadres(string adres)
        {
            this.adres = adres;
        }
        

    }
}
