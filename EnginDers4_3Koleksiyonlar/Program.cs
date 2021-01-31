using System;
using System.Collections.Generic;

namespace EnginDers4_3Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            // diziye yeni eleman eklenemez.
            //Aşağıda yeni bir dizi oluşturulmuş ve onun 4. ve 0. elemanları istenmiştir.
            //0. eleman boş olduğu için çıktıda boşluk gelecektir.

            names = new string[5];
            names[4] = "İlker";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);

            // ctrl+k+ctrl+c işaretlenen tüm satırları yorum satırı yapar.
            // ctrl+k+ctrl+u işaretlenen tüm satırları yorum satırından çıkarır.

            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);
        }
    }
}
