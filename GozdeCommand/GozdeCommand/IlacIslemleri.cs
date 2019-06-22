using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeCommand
{
    
    
    public class IlacIslemleri
    {
        List<Satis> Satislar = new List<Satis>();
        string firmaAd,ilacAd;
        int miktar,adet;

        public void SatisYap()
        {
            Console.Write("Firma adı:...:");
            firmaAd = Console.ReadLine();
            try
            {
                Console.Write("Kaç tane satış girişi yapılacak?...:");
                miktar = Convert.ToInt16(Console.ReadLine());
            
            
                for (int i = 1;i<= miktar;i++)
                {
                    Console.Write("İLaç adı:...:");
                    ilacAd = Console.ReadLine();
                    Console.Write("Satış miktarını:...:");
                    adet=Convert.ToInt16(Console.ReadLine());
                    Satis satis1 = new Satis();
                    satis1.FirmaAdi = firmaAd;
                    satis1.IlacAdi = ilacAd;
                    satis1.Adet = adet;
                    Satislar.Add(satis1);
                }
                foreach (Satis satis in Satislar)
                {
                    Console.WriteLine("Firma:{0} \tIlac:{1} \tAdet:{2}",satis.FirmaAdi,satis.IlacAdi,satis.Adet);
                }
                Console.WriteLine("Satışlar Yapıldı....\n");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bir hata oluştu. Lütfen tekrar deneyiniz...");
            }
            
        }

        public void IlacPaketle()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("İlaçlar Paketleniyor...\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("İlaçlar Paketlendi...");

        }  

    }
}
