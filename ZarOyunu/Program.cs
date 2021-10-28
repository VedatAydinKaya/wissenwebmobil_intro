using System;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ZAR OYUNUU
              Kullanıcıdan 1-6 arası bir zar bilgisi alınacak. Örnek olarak kullanıcı 6 seçti. program 6 için 
 2 zarı 6-6 gelene kadar rastgele atacak. kaçıncı denemede çifti bulduğunu ekranda yazan programı yazınız.*/

            do
            {
                int tahmin = 0, girilenSayi = 0;
                Random rnd = new Random();
                do
                {
                    Console.Write("ZAR OYUNU ICIN SANSLI SAYINIZI GIRINIZ: ");

                    try
                    {

                        girilenSayi = int.Parse(Console.ReadLine());
                        if (girilenSayi < 1 || girilenSayi > 6)
                            throw new Exception("1-6 arasında bir sayi girmediniz:");
                        // break;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Lutfen sayi giriniz:");
                        Console.WriteLine(ex.Message);
                        continue;

                    }

                    break;

                } while (true);
                do
                {

                    int randomsayi1 = rnd.Next(1, 7);
                    int randomsayi2 = rnd.Next(1, 7);
                    tahmin++;
                    if (randomsayi1 == girilenSayi && randomsayi2 == girilenSayi)
                    {
                        Console.WriteLine($"Tebrikler {tahmin}.denemede ugurlu sayiniz {girilenSayi} bulundu ");
                        break;
                    }

                    //break;
                } while (true);
                // tekrar oyun oynama kontrolu
                Console.WriteLine("TEKRAR OYNAMAK ICIN E YA BAS: ");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;
                // 
            
            } while (true);



        }
    }
}
