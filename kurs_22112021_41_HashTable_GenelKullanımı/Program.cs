using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace kurs_22112021_41_HashTable_GenelKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();
            //yeni değer ekleme
            H1.Add("Car", "Araba");
            H1.Add("House", "Ev");
            H1.Add("Cars", "Araba");
            //H1.Add("Cars", "Arabalar");//Key değeri benzersiz olmalıdır.

            //hashtable yazdırma şekli

            foreach (var item in H1.Keys)
            {
                Console.WriteLine("Key: {0} - Value:{1}",item, H1[item]);
            }
            //yardımcı metodlar
            bool kontrol1 = H1.Contains("House");
            bool kontrol2 = H1.Contains("Door");
            Console.WriteLine(kontrol1);
            Console.WriteLine(kontrol2);

            bool kontrol3 = H1.Contains("House");
            bool kontrol4 = H1.Contains("Araba");
            Console.WriteLine(kontrol3);
            Console.WriteLine(kontrol4);

            H1["House"] = "Villa";
            H1.Remove("Cars");

            Console.WriteLine("************");
            foreach (var item in H1.Keys)
            {
                Console.WriteLine("Key: {0} - Value:{1}", item, H1[item]);
            }
            int koleksiyonToplam = H1.Count;
            Console.WriteLine(koleksiyonToplam);

            H1.Clear();//koleksiyon içindeki tüm detayı temizleriz

            int koleksiyonToplam2 = H1.Count;
            Console.WriteLine(koleksiyonToplam2);



            Console.ReadKey();
        }
    }
}
