﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , "Programlamaya Başlangıç İçin Temel Kurs" , "Java","Python" };

            for (int i = 0; i <kurslar.Length; i++)  
                //bu ifade,kursların 0'ıncı elemanından başlayarak eleman sayısı kadar i'inci elemanını gez.i=eleman sayısı
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar) 
                //kurslar içindeki elemanları tek tek gez. foreach, dizilere uygulanır.
                //"kurs" verilen takma isim. herhangi bir isim verebilirsin.
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
