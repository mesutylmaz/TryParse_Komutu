using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciAdi_Sifre_Tahmin_Etme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen kullanıcı adı ve şifreyi kontrol edip, "Giriş Başarılı" veya "Giriş Başarısız" mesajını ekrana yazdıran program(kullanıcı adı: admin, Şifre:1234) Büyük harfte kullanılabilir.


            kullaniciAdiTekrar:
            Console.WriteLine(Environment.NewLine + "Lütfen kullanıcı adınızı giriniz: ");
            string kullaniciAdi;
            kullaniciAdi = Convert.ToString(Environment.NewLine + Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Lütfen şifrenizi giriniz: ");
            bool sonuc = int.TryParse(Console.ReadLine(), out int sifre);


            if (sonuc == true)
            {
                Console.WriteLine(Environment.NewLine + "Giriş Başarılı!");
                Console.WriteLine(Environment.NewLine + "Kullanıcı Adınız: " + kullaniciAdi);
                Console.WriteLine(Environment.NewLine + "Şifreniz: " + sifre);
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Giriş Başarısız! Lütfen yeniden deneyin.");
                goto kullaniciAdiTekrar;
            }

            Console.Read();
        }
    }
}
