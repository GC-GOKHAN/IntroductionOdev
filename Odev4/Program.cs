namespace Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Kullanıcıdan kullanıcı adı ve şifre isteyelim. Kullanıcı Adı => Admin && Şifre => 123 , Eğer kullanıcı yanlış girerse bu bilgileri tekrar isteyelim.
            // Kullanıcı üst üste hatalı bilgileri 3 defa girebilsin. 3 defa hatalı giriyorsa hakkınız bitti mesajı vereceğiz.
            // Doğru bilgiyi girdiyse hoşgeldin diyeceğiz.

            {
                string KULLANICIADI = "admin";
                string SIFRE = "123";
                int DENEME_HAKKI = 3;
                int deneme = 0;
                string kul_adı, kul_sifre;

                while (deneme < DENEME_HAKKI)
                {
                    Console.Write("Kullanıcı adı girin = ");

                    kul_adı = Console.ReadLine();

                    Console.Write("Şifreyi girin = ");

                    kul_sifre = Console.ReadLine();

                    if (kul_adı == KULLANICIADI && kul_sifre == SIFRE)
                    {
                        Console.WriteLine("Hoşgeldiniz");
                        break;
                    }

                    else if (deneme >= 2)
                    {
                        Console.WriteLine("Şifreniz Bloke Oldu");
                        break;
                    }

                    {
                        Console.WriteLine("Yanlış kullanıcı adı veya şifre girdiniz.");
                        deneme++;
                        Console.Write("Kalan hakkınız ");
                        Console.WriteLine(DENEME_HAKKI - deneme);

                        Console.ReadKey();
                    }

                }
            }
        }
    }
}











       
    

      
