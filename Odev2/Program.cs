namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console'dan alınan ay'ın mevsimini yazdıran prorgramı yapınız.

            Console.WriteLine("Lütfen ay giriniz");

            string ay = Console.ReadLine();

            switch (ay)
            {
                case "aralık":
                    Console.WriteLine("KIŞ");
                    Console.WriteLine("12. Ay"); break;

                case "ocak":
                    Console.WriteLine("KIŞ");
                    Console.WriteLine("1. Ay"); break;

                case "şubat":
                    Console.WriteLine("KIŞ");
                    Console.WriteLine("2. Ay"); break;



                case "mart":
                    Console.WriteLine("İLKBAHAR");
                    Console.WriteLine("3. Ay"); break;

                case "nisan":
                    Console.WriteLine("İLKBAHAR");
                    Console.WriteLine("4. Ay"); break;

                case "mayıs":
                    Console.WriteLine("İLKBAHAR");
                    Console.WriteLine("5. Ay"); break;



                case "haziran":
                    Console.WriteLine("YAZ");
                    Console.WriteLine("6. Ay"); break;

                case "temmuz":
                    Console.WriteLine("YAZ");
                    Console.WriteLine("7. Ay"); break;

                case "ağustos":
                    Console.WriteLine("YAZ");
                    Console.WriteLine("8. Ay"); break;



                case "eylül":
                    Console.WriteLine("SONBAHAR");
                    Console.WriteLine("9. Ay"); break;

                case "ekim":
                    Console.WriteLine("SONBAHAR");
                    Console.WriteLine("10. Ay"); break;

                case "kasım":
                    Console.WriteLine("SONBAHAR");
                    Console.WriteLine("11. Ay"); break;


                default:
                    Console.WriteLine("Ay Doğru Girildiğinden Emin Olunun");
                    break;

            }




            Console.ReadLine();




            // eğer ay;  aralık-ocak-şubat      girilirse ekrana KIŞ 
            // mart-nisan-mayıs       girilirse ekrana İLK BAHAR
            // haziran-temmuz-ağustos girilirse ekrana YAZ 
            // eylük-ekim-kasım       girilirse ekrana SON BAHAR
            // mesajlarını veren programı yazınız.. Girilen ay için kaçıncı ay olduunu yazınız ekrana n. Ay şeklinde yazınız..

            // örnek;
            // klavyeden girilen ocak ayı için çıktı aşağıdaki gibi olmalıdır;
            // KIŞ
            // 1. Ay


            // todo: bütün  istenilenleri switch-case ve if karar mekanizmaları kullanarak yapınız

            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}