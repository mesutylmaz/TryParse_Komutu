using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maas_Hesaplama_Alternatif
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal odeme = 0;

            maasTekrar:
            Console.WriteLine(Environment.NewLine + "Lütfen maaşınızı giriniz: ");
            decimal maas;
            bool sonuc = decimal.TryParse(Console.ReadLine(), out maas);

            if (!sonuc) //sonuc=false(girilen ifadenin int olmadığını gösterir.
            {
                Console.WriteLine(Environment.NewLine + "Maaş bilgisini doğru girmediniz.");
                goto maasTekrar;
            }

            medeniDurum:
            Console.WriteLine(Environment.NewLine + "Lütfen medeni durumunuzu giriniz:(Evli/Bekar) ");
            string medeniDurum = Console.ReadLine();

            if (medeniDurum != "Bekar" && medeniDurum != "bekar" && medeniDurum != "Evli" && medeniDurum != "evli")
            {
                Console.WriteLine("Medeni durum bilginizi hatalı girdiniz!");
                goto medeniDurum;
            }

            cocukCevap:
            Console.WriteLine(Environment.NewLine + "Lütfen çocuk sayısını giriniz.");
            int cocuk;
            bool cocukcevap = int.TryParse(Console.ReadLine(), out cocuk);

            if (!cocukcevap)            // Bu yazım tarzı da güzel
            {
                Console.WriteLine(Environment.NewLine + "Lütfen çocuk sayısını tekrar giriniz.");
                goto cocukCevap;
            }

            if (medeniDurum == "Bekar" || medeniDurum == "bekar")
            {
                odeme = maas;
            }

            else
            {
                if (cocuk == 0)
                    maas = maas * 1.03m;
                else if (cocuk == 1)
                    maas = maas * 1.05m;

                else if (cocuk == 2)
                    maas *= 1.1m;           //Bu yazım tipini de öğren. İlginç bi yazım.

                else if (cocuk >= 3)
                    maas *= 1.15m;
            }

            Console.WriteLine(Environment.NewLine + "Eklentisiz maaşınız: " + maas);
            Console.WriteLine(Environment.NewLine + "Medeni durumunuz: " + medeniDurum);
            Console.WriteLine(Environment.NewLine + "Çocuk sayınız: " + (cocuk == 0 ? "Çocuğunuz yok." : cocuk.ToString()));   // Bu yazım tipini de öğren. İlginç bi yazım.
            Console.WriteLine(Environment.NewLine + "Toplam maaşınız: " + maas);

            Console.ReadLine();
        }
    }
}
