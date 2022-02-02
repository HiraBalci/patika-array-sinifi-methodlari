using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_array_sinifi_methodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayiDizisi = { 23, 12, 86, 72,3,11 };
            Console.WriteLine("****Sırasız Liste Dizi****");
            foreach(var item in sayiDizisi)// böyle yazdırıyorsun.
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****Sıralı Liste Dizi****");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)// böyle yazdırıyorsun.
            {
                Console.WriteLine(item);
            }
            //clear methodu
            Console.WriteLine("****Array Clear****");
            Array.Clear(sayiDizisi,2,2);//2. indexten başla 2 tane eleman sil
            foreach (var item in sayiDizisi)// böyle yazdırıyorsun.
            {
                Console.WriteLine(item);
            }
            //Reverse
            // ortadan itibaren aynalıyormuş gibi yer değiştiriyor.
            Console.WriteLine("****Array Reverse****");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            //Indexof
            Console.WriteLine("****Array Indexof****");
            int sayi=Array.IndexOf(sayiDizisi,72);//72 sayısı hangi indexte
            Console.WriteLine(sayi);
            //Resize
            Console.WriteLine("****Array Resize****");
            Array.Resize<int>(ref sayiDizisi, 9);//size ını arttırıyorum.
            sayiDizisi[8] = 99;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

        }
    }
}
