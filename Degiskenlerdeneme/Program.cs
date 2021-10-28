using System;

namespace degiskenlerdeneme
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             byte veri;
             veri = byte.MaxValue;
             Console.WriteLine( veri );
             veri = byte.MinValue;
             Console.WriteLine(veri);

             short degiskenShort = 16;

             degiskenShort = Int16.MaxValue;  // 32767
             Console.WriteLine(degiskenShort);

             degiskenShort = short.MinValue;  // -32767
             Console.WriteLine(degiskenShort);


             degiskenShort = 50;        //50
             Console.WriteLine(degiskenShort);  

            int degisken = Int32.MaxValue;
            Console.WriteLine(degisken);

            degisken = Int16.MaxValue;
            Console.WriteLine(degisken);

            degisken = Int32.MinValue;
            Console.WriteLine(degisken);  


            // ushort uint ulong

            ushort degisken = ushort.MaxValue;  //65535
            Console.WriteLine(degisken);

            degisken = ushort.MinValue;        // 0

            Console.WriteLine(degisken);
              
            uint variable = uint.MaxValue;    // 4294967295

            Console.WriteLine(variable);


            variable = uint.MinValue;        //  0

            Console.WriteLine(variable);


            ulong sayi = long.MaxValue;     //9223372036854775807

            Console.WriteLine(sayi); 



            //implicity convert kucuk veri tipini >===== daha buyuk veri tipine atma kendiliginden program yapar

            short sayi1 = 5;

            int sayi2 = sayi1;

            byte sayi3 = 0;

            long sayi4 = sayi3;

            // explicit  conversion

            short value1 = 7;

            byte value2 = (byte)value1;

             value2 = Convert.ToByte(value1); 



            // ondalıklı sayılar


            float degiskenFloat = float.MaxValue;   // 4byte

            Console.WriteLine(degiskenFloat);

            degiskenFloat = float.MinValue;
            Console.WriteLine(degiskenFloat);

            degiskenFloat = 3.14f;
            Console.WriteLine(degiskenFloat);



            double degiskenDouble = double.MaxValue;  //8byte

            Console.WriteLine(degiskenDouble);

            degiskenDouble = double.MinValue;

            Console.WriteLine(degiskenDouble);

            degiskenDouble = 4.7d;
            Console.WriteLine(degiskenDouble);


            decimal degiskenDecimal = decimal.MaxValue;  //79228162514264337593543950335  16byte

            Console.WriteLine(degiskenDecimal);


            degiskenDecimal = decimal.MinValue;        // -79228162514264337593543950335

            Console.WriteLine(degiskenDecimal);

            degiskenDecimal = 8.79458519848515m;

            Console.WriteLine(degiskenDecimal);   


            double sonuc = 7 / 2;  // 3

            Console.WriteLine("Sonuc:" + sonuc);


           sonuc = 7 / 2f;        //3,5

            Console.WriteLine("Sonuc:" + sonuc);


            float sonuc2 = (float)(7 / 2d);  



            //string kelime


            char karakter = 'a';

            Console.WriteLine(karakter);


            string kelime = "deneme";
            Console.WriteLine(kelime);

            char harf = kelime[5];

            Console.WriteLine(harf);  


            // mantıksal degiskenler


            bool isActive = true;


            int a = 5, b = 6;

            isActive = a == b;

            Console.WriteLine(isActive);  */


            // DateTime degisken veri tipi


            DateTime tarih = DateTime.Now;

            Console.WriteLine(tarih);

            DayOfWeek gun = tarih.DayOfWeek;

            Console.WriteLine(gun);

            string saat = DateTime.Now.ToString("HH:mm");

            Console.WriteLine("Saat: " + saat);


            string haftanıngunu = DateTime.Now.ToString("M");

            Console.WriteLine(haftanıngunu);

            string hafta = DateTime.Now.ToString("dddd");

            Console.WriteLine(" hafta:" + hafta);




            //object veri tipi  =>>>>>>>>>>>>>>>object tum veri tiplerinden kendisinden turedigi icin hepsini alabilir;

            int a = 5;

            char karakter = '5';

            object obje = a;

            Console.WriteLine(obje);

            obje = a;

            Console.WriteLine(obje);

            obje = "kelime";


        }
    }
}
