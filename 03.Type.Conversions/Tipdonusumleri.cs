using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Type.Conversions
{
    internal class Tipdonusumleri
    {
        private static void Main(string[] args)
        {
            //Tür dönüşüm örnekleri - Bilinçsiz 


            byte a = 10;

            short b = 20;

            sbyte c = 30;

            int d = a + b + c;  //örnek bir tür dönüşümü (bilinçsiz) 

            string e = "IBB Project 100 KY";

            char f = 'A';

            object g = e + f + d; // farklı tiplerin obje tipine atanması  //objectte bir veri tipidir ama hepsini kapsıyor (int,byte..) 

            long h = d;

            float i = h;

            double j = i;

            double k = 21.6;

            Console.WriteLine("1.durum: " + d.ToString());
            Console.WriteLine("2.durum: " + g.ToString());
            Console.WriteLine("3.durum: " + h + k);

            // Bilinçsiz dönüşüm olayında ilginç bir durum

            char l = 'H';

            int m = l;

            Console.WriteLine("4.durum: " + m);    //karakterin bilgisayar tarafındaki karşılığını ekrana gösterir. ascii tablosundaki karşılığı 

            Console.WriteLine(""); // Bir satır boşluk bırakmak için yazdık.

            Console.WriteLine("\n\t"); // Bir satır boşluk bırakmak için yazdık.



            //Tür dönüşüm örnekleri - Bilinçsiz

            int r = 15;

            byte s = (byte)r; 


            Console.WriteLine("5.durum: " + ( s + r ));  // "str" + ( int ) yapmalısın.

            Console.WriteLine("6.durum: " + r.ToString());         // C + W + TAB + TAB yaparsan otomatik console çıkıyor.


           














        }
    }
}
