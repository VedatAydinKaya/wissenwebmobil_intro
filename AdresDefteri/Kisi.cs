using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteri
{
    class Kisi
    {

        // field
        private string _ad;
        private string _soyad;


        // encapsulation

        public string  Ad 
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new FormatException("Kisinin adi bos gecilemez");

                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))

                        throw new Exception("Kisinin adinda rakam bulunamaz");

                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))

                        throw new Exception("Kisinin adinda gecersiz karakter bulunmaktadir");

                    if (value.Length > 50)

                        throw new Exception("Kisinin adi 50 karakterden buyuk olamaz");
                }
                _ad = value;

            }
            get
            {
                return _ad;
            } 
        
        }

        public string Soyad 
        {


            get
            {
                return _soyad.Substring(0, 2).ToUpper() + _soyad.Substring(2).ToLower();
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new FormatException("Kisinin soyadi bos gecilemez");
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))

                        throw new Exception("Kisinin soyadında rakam bulunamaz");

                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))

                       throw new Exception("Kisinin soyadında gecersiz karakter bulunmaktadir");

                    if (value.Length > 50)

                        throw new Exception("Kisinin soyadında 50 karakterden buyuk olamaz");
                }
                _soyad = value;


            }




        }

    }
}
