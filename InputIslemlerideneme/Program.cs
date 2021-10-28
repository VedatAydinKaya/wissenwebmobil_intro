using System;

namespace InputIslemlerideneme
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.Write("Kullanıcı adını ve soyadini giriniz: ");

              string ad_soyadi = Console.ReadLine();

              Console.WriteLine("Hoşgeldin "+ad_soyadi);  */


            // Exception Handling &&& Error HANDLING
            //
            // TRY-CATCH

            Console.Write("1-100 arasında bir sayı giriniz: ");
            int sayi;
            try
            {
                sayi = int.Parse(Console.ReadLine());
                if (sayi < 1 || sayi > 100)
                {
                    throw new Exception("girilen sayı aralıkta degil");
                }
                Console.WriteLine("GIRMIS OLDUGUNUZ SAYI : " + sayi);
            }
            catch (OverflowException ex1)
            {

                Console.WriteLine(ex1.Message);      // Value was either too large or too small for an Int32.
            }
            catch (FormatException ex2)
            {
                Console.WriteLine(ex2.Message);    // Input string was not in a correct format.
            }

            finally
            {
                Console.WriteLine("İşlem tamamlandı ");
            }


        }
    }
}
