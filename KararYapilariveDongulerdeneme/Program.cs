using System;

namespace KararYapilariveDongulerdeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             bool isActive = true;

             if (isActive)
             {
                 Console.WriteLine("Program aktif");
             }
             else
             {
                 Console.WriteLine("Program aktif degil");
             }


             if (false) Console.WriteLine("1");
             else Console.WriteLine("2");

             //if else-if

             Console.WriteLine("*************İf Else-If**********");


             int ortalama = 37;
             if (ortalama>=50)
             {
                 Console.WriteLine("Geçtiniz");
             }
             else if (ortalama>=40)
             {
                 Console.WriteLine("Şartlı geçtiniz");
             }
             else
             {
                 Console.WriteLine("Kaldınız");
             }

             /*
             string sonuc ="";

             if (ortalama>=50)
             {
                 sonuc = "gectiniz";
             }
             else
             {
                 sonuc = "kaldiniz";
             }  */

            // ternary if blogu ile yapilmak istenirse

            /*   int ortalama = 37;

               string sonuc = ortalama > 50 ? "gectiniz" : "kaldiniz";  


               // DATE TIME ILE UYGULAMA

               DateTime tarih = DateTime.Now;
               if (tarih.DayOfWeek == DayOfWeek.Sunday)
               {
                   sonuc = "pazar";
               }
               else if (tarih.DayOfWeek == DayOfWeek.Monday)
               {
                   sonuc = "pazartesi";
               }
               else if (tarih.DayOfWeek == DayOfWeek.Tuesday)
               {
                   sonuc = "salı";
               }
               else if (tarih.DayOfWeek == DayOfWeek.Wednesday)
               {
                   sonuc = "carşamba";
               }

               switch (sonuc)
               {
                   case "pazar" :
                       Console.WriteLine("Pazar");
                       break;

                   case "pazartesi":
                       Console.WriteLine("Pazartesi");
                       break;
                   case "salı":
                       Console.WriteLine("Salı");
                       break;

                   case "carsamba":
                       Console.WriteLine("Çarşamba");
                       break;
               }  */

            // Switch-Case Calismasi

            /*     string sonuc;

                DateTime tarih = DateTime.Now;

                DayOfWeek haftaningunu = tarih.DayOfWeek;

                switch (haftaningunu)
                {
                    case DayOfWeek.Sunday:
                        sonuc = "Pazar";
                        break;
                    case DayOfWeek.Monday:
                        sonuc = "Pazartesi";
                        break;
                    case DayOfWeek.Tuesday:
                        sonuc = "Salı";
                        break;
                    case DayOfWeek.Wednesday:
                        sonuc = "Carsamba";
                        break;
                    case DayOfWeek.Thursday:
                        sonuc = "Persembe";
                        break;
                    case DayOfWeek.Friday:
                        sonuc = "Cuma";
                        break;
                    default:
                        sonuc = "Cumartesi";
                        break;
                }  */


            // donguler

            //while dongusu

            DateTime tarih = DateTime.Now;

            int sayac = 0, gun = 0;

            while (gun < 100)
            {
                DateTime sonrakigun = tarih.AddDays(sayac);
                sayac++;
                if (sonrakigun.DayOfWeek == DayOfWeek.Saturday || sonrakigun.DayOfWeek == DayOfWeek.Sunday)
                    continue;
                Console.WriteLine(sonrakigun);
                gun++;

            }

            do
            {
                DateTime sonrakigun = tarih.AddDays(sayac);
                sayac++;
                if (sonrakigun.DayOfWeek == DayOfWeek.Saturday || sonrakigun.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }
                Console.WriteLine(sonrakigun);
                gun++;
            } while (gun < 100);

            // break continue return

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
