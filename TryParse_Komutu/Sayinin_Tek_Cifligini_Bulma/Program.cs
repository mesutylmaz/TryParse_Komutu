using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayinin_Tek_Cifligini_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayının çift mi tek mi olduğunu bulduruan program. Tekse 2 katı, çiftse yarısını yazdır:

            sayiGir:
            Console.WriteLine("Lütfen bir sayı değeri giriniz: ");
            //bool sonuc = double.TryParse(Console.ReadLine(), out double sayi);      //İster sadece bu satır, ister alttaki 2 satır aynı anlamdadır.     
            double sayi;
            bool sonuc = double.TryParse(Console.ReadLine(), out sayi);      //Dışarıdan girdiğim değerin tipini bilmiyorsam TryParse kullanabilirim. Klavyeye girdiğim                                                              değer sayisal değer dışında ise, sonuc ifadem false olucak. Sayısal olsaydı true dönücekti.                                                             TryParse girilen veriyi kontrol edip bool ile kullanılarak true/false şeklinde çalıştırarak                                                             programın hata vermeden işlem yapmamısını kolaylaştırıyor.

            if (!sonuc)      //sonuc=false(girilen ifadenin double olmadığını gösterir.
            {
                Console.WriteLine("Girilen değer bir sayı değildir! Lütfen tekrar deneyiniz.");
                goto sayiGir;
            }
            else            //sonuc=true(girilen ifadenin int olduğunu gösterir.
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Girilen sayı çifttir. Yarısı: " + sayi / 2);
                }
                else
                {
                    Console.WriteLine("Girilen sayı tektir. İki katı: " + sayi * 2);
                }
            }
            Console.Read();
        }
    }
}
