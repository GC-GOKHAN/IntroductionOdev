namespace Odev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*******Öğrenci Vize Final Notu Hesaplama*********");


            double vize, final, ort, ogrenci;



            Console.WriteLine("Lütfen ögrenci sayısı Giriniz");

            ogrenci = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ogrenci; i++)
            {
            vize:
                Console.WriteLine(" Vize Sınav Notunuzu Giriniz");
                vize = Convert.ToInt32(Console.ReadLine());
                if (vize > 0 && vize < 101)
                {
                    Console.WriteLine("0 ile 100 Arası Girildi ");
                }
                else
                {
                    Console.WriteLine("Tekrar Giriniz ( 0 ie 100 arası)");
                    goto vize;
                }

            final:
                Console.WriteLine("Final Sınav Notunuzu Giriniz");
                final = Convert.ToInt32(Console.ReadLine());
                if (final > 0 && final < 101)
                {
                    Console.WriteLine("0 ile 100 Arası Girildi ");
                }
                else
                {
                    Console.WriteLine("Tekrar Giriniz ( 0 ie 100 arası)");
                    goto final;
                }

                ort = Convert.ToInt32(vize * 0.4) + (final * 0.6);
                Console.WriteLine($"Ortalamanız :" + ort);
            }


            Console.WriteLine("Kapatmak İçin Bir Tuşa Basınız");
        }




    }

}        



  


 