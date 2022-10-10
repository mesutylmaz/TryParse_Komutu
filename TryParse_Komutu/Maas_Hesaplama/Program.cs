using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maas_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir fabrikada sabit maaşla çalışan işçiler, aile durumlarına göre ek maaş almaktadır. Bekar olanlar sadece maaş, evli ve çocuğu olmayanlar %3 ek maaş, çocuk sayısı 1 olanlar %5 ek maaş, çocuk sayısı 2 olanlar %10, çocuk sayısı %15 kadar ek maaş almaktadır. Bu hesaplamayı yapan program.


            MaaşGir:
            Console.WriteLine(Environment.NewLine + "Lütfen maaş bilgisi giriniz: ");
            double maas;
            bool sonuc = double.TryParse(Console.ReadLine(), out maas);

            if (!sonuc)
            {
                Console.WriteLine(Environment.NewLine + "Maaş bilgisini doğru girmediniz. Lütfen tekrar deneyiniz.");
                goto MaaşGir;
            }
            else
            {
                medeniDurumGir:
                Console.WriteLine(Environment.NewLine + "Lütfen medeni durum bilginizi giriniz: (Evli/Bekar)");
                string medeniDurum;
                medeniDurum = Console.ReadLine();

                if (medeniDurum == "Evli" || medeniDurum == "evli")
                {
                    cocukSayisiTekrar:
                    Console.WriteLine(Environment.NewLine + "Lütfen çocuk sayısını giriniz: ");
                    byte cocukSayisi;
                    bool sonucCocuk = byte.TryParse(Console.ReadLine(), out cocukSayisi);

                    if (!sonucCocuk)    //sonuc=false(girilen ifadenin int olmadığını gösterir.
                    {
                        Console.WriteLine(Environment.NewLine + "Çocuk bilgisini doğru girmediniz. Lütfen tekrar deneyiniz!");
                        goto cocukSayisiTekrar;
                    }

                    else
                    {
                        if (cocukSayisi == 0)
                            maas = maas * 1.03;

                        else if (cocukSayisi == 1)
                            maas = maas * 1.05;

                        else if (cocukSayisi == 2)
                            maas = maas * 1.1;

                        else if (cocukSayisi >= 3)
                            maas = maas * 1.15;

                        else
                            Console.WriteLine(Environment.NewLine + "Hatalı işlem.");

                        Console.WriteLine(Environment.NewLine + "Medeni Durumunuz: " + medeniDurum);
                        Console.WriteLine(Environment.NewLine + "Çocuk sayınız: " + cocukSayisi);
                        Console.WriteLine(Environment.NewLine + "Maaşınız: " + maas + " TL");
                    }
                }

                else if (medeniDurum == "Bekar" || medeniDurum == "bekar")
                {
                    maas = maas * 1.1;
                    Console.WriteLine(Environment.NewLine + "Medeni Durumunuz: " + medeniDurum);
                    Console.WriteLine(Environment.NewLine + "Çocuk sayınız: " + "0");
                    Console.WriteLine(Environment.NewLine + "Maaşınız: " + maas + " TL");
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "Medeni durum bilgisi yanlış! Lütfen tekrar giriniz.");
                    goto medeniDurumGir;
                }
            }

            Console.Read();
        }
    }
}
