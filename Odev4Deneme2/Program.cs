namespace Odev4Deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıdan kullanıcı adı ve şifre isteyelim. Kullanıcı Adı => Admin && Şifre => 123 , Eğer kullanıcı yanlış girerse bu bilgileri tekrar isteyelim.
            // Kullanıcı üst üste hatalı bilgileri 3 defa girebilsin. 3 defa hatalı giriyorsa hakkınız bitti mesajı vereceğiz.
            // Doğru bilgiyi girdiyse hoşgeldin diyeceğiz.

            string kul_adi = "admin";
            string sifre = "123";

            int n = 0;
            int j = 0;
            int deneme = 0;

            while (n <= 2)
            {
                Console.Write("Lütfen kullanıcı adınızı girin=");
                string kullaniciadi = Console.ReadLine();

                Console.Write("Lütfen Şifrenizi Giriniz=");
                string kullanici_sifre = Console.ReadLine();

                if (kul_adi == kullaniciadi)
                {

                    Console.WriteLine("Hoşgeldin");
                }
                else

                {
                    n++;
                    Console.WriteLine("Yanlış Girdiniz Lütfen Tekrar Giriniz");
                    continue;
                    
                }                       
                          




         }   }
 }   }
