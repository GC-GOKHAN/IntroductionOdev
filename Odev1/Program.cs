using System;
using System.Data.SqlTypes;
using System.Security.Claims;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*******Öğrenci Vize Final Notu Hesaplama*********");


            double vize, final, ort;


            Console.WriteLine("Lütfen Vize Sınav Notunuzu Giriniz");

            vize = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Lütfen Final Sınav Notunuzu Giriniz");

            final = Convert.ToInt32(Console.ReadLine());

            ort = Convert.ToInt32(vize * 0.4) + (final * 0.6);


            if (ort < 25)
            {
                Console.WriteLine($"Ortalamanız :" + ort);
                Console.WriteLine("Harf Notunuz : FF");
            }

            else if (ort >= 25 && ort < 49)
            {
                Console.WriteLine($"Ortalamanız :" + ort);
                Console.WriteLine("Harf Notunuz : DC");

            }
            else if (ort >= 50 && ort < 64)
            {
                Console.WriteLine($"Ortalamanız :" + ort);
                Console.WriteLine("Harf Notunuz : CC");

            }
            else if (ort >= 65 && ort < 74)
            {
                Console.WriteLine($"Ortalamanız :" + ort);
                Console.WriteLine("Harf Notunuz : BB");

            }
            else if (ort >= 75 && ort < 84)
            {
                Console.WriteLine($"Ortalamanız :" + ort);
                Console.WriteLine("Harf Notunuz : BA");

            }

            else if (ort >= 85 && ort <= 100)
            {
                Console.WriteLine($"Ortalamanız :" + ort);
                Console.WriteLine("Harf Notunuz : AA");

            }

            Console.WriteLine("Kapatmak İçin Bir Tuşa Basınız");
        }



        //ÖDEV NOTLARIM HARF NOTUNU ALTINA YAZDIRMAK İSTEDİĞİM İÇİN ALTA ALDIM,
        //ELSE İF (ort >= 85 && ort <= 100) ALANNININ SONUNA ; EKLEDİĞİM İÇİN 2. ELSE İF GİRERKEN UYARI ALDIM NEDEN OLDUĞUNU BULMAK İÇİN ÇOK ARADIM :)
        // DİĞER ÖRNEĞİ SWITCH CASE OLARAK YAPTIM.


        //string harfNotu = "FF";


        //Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}");

        // Console.WriteLine("Kapatmak için bir tuşa basınız");
        //Console.ReadKey();


        // Console'^dan girilen vize ve final notları ile ortalamayı hesaplayan bu ortalamaya göre harfnotunu bulup ekrana ortalama ve harfnotunu yazan prog. yazınız.. tanımladığım değişkenleri kullanınız... 

        // float vize, final, ort=0; 

        // vize notu isteyiniz

        // final notu isteyiniz

        // ortalama hesaplayınız
        // ortalam vize notunun %40 finalnotunun %60 formülü ile hesaplanır. Formül (vizenotu * 0.4) + (finalnotu * 0.6)

        // string harfNotu="FF"; 

        // harfNotu =  Eğer ortalama 85 ile 100 arasında ise AA, 75 ile 84 arasında ise BA,65 ile 74 arasında ise BB,50 ile 64 arasında ise CC,25 ile 49 arasında ise DC, 25'ten küçük ise FF olarak bulunmalıdır..

        // Console.WriteLine($"Ortalamanız ={ort} HarfNotunuz = {harfNotu}"); 

        // todo: bütün  istenilenleri switch-case ve if karar mekanizmaları kullanarak yapınız


        //Console.WriteLine("Kapatmak için bir tuşa basınız"); 
        //Console.ReadKey(); 
    }
}
