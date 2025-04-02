using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            TavlaZari tavlaZari1 = new TavlaZari(8);
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt());

            //tavlaZari2 adında yeni bir obje oluşturun
            //Bu obje ile zar atıp konsola yazdırıp 1. ile yarıştırın
        }
    }
}
