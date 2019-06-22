using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adapter Kullanılıyor...
            Console.Title = "Adapter Tasarım Deseni";
            
            
            git: try
            {

                Adapter adapter = new Adapter();
                string tercih = null;
                Client client = new Client();
                int secim = 0;
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1 - İlaç Türüne Göre KDV Uygulayarak Tutar Hesapla");
                    Console.WriteLine("2 - KDV Değerini Girerek Tutar Hesapla");
                    Console.WriteLine("3 - Çıkış");
                    Console.Write("Seçiminiz...:");
                    tercih = Console.ReadLine();
                    secim = Convert.ToInt16(tercih);
                    if (secim == 1)
                    {
                        client.OdenecekTutarHesapla(new IlacCesidineGoreHesapla());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Tutar hesaplandı...");
                        Console.Write("Devam etmek için bir tuşa basınız...");
                        Console.ReadKey();
                    }
                    else if (secim == 2)
                    {
                        client.OdenecekTutarHesapla(new Adapter());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Tutar hesaplandı...");
                        Console.Write("Devam etmek için bir tuşa basınız...");
                        Console.ReadKey();
                    }
                    else if(secim!=3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatalı Seçim Yapıldı...");
                        Console.Write("Devam etmek için bir tuşa basınız...");
                        Console.ReadKey();
                    }
                    
                } while (secim!=3);

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı Giriş...");
                Console.ReadLine();
                goto git;
                
            }
           

            //Adapter Kullanıldı...
            //Kaynak: http://www.yazgelistir.com/Makale/adapter-tasarim-deseni.html
        }
    }
}
