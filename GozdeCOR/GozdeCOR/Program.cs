using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeCOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chain Of Responcibility (COR) Kullanılıyor...

            //Senaryo aşağıdaki gibidir.
            //3 çeşit firma türümüz vardır.
            //Firma Türü Üretici ise satış adetinde bir üst limiti ve alt limiti yoktur. Sınırsız haklara sahiptir.
            //Firma Türü Toptancı ise maksimum satış adetinde sınır yoktur. Minimum satış adetindwki sınır 100 ilaçtır.
            //Firma Türü Perakende ise maksimum bir seferde 100 adet satış sınırı vardır. Minimum satış adeti sınırı yoktur.
            Console.Title = "Chain Of Responcibility (COR)";
            CORHandler toptanci = new Toptanci();
            CORHandler perakende = new Perakende();
            CORHandler ureten = new Ureten();

            //Toptancı en az 100 adet ürün satmalıdır. 10 adet ürün satamaz. Bu yüzden ödeme onaylanmadı.
            SatisYetkisi satis = new SatisYetkisi() { Adet = 10, Yetki = true };
            toptanci.Istek(satis);
            Console.WriteLine("Toptancı minimum 100 adet ürün satmalıdır. 10 adet ürün satamaz. Bu yüzden ödeme onaylanmadı.\n");

            satis = new SatisYetkisi() { Adet = 101, Yetki = true };
            perakende.Istek(satis);
            Console.WriteLine("Perakende maksimum 100 adet ürün satmalıdır. 101 adet ürün satamaz. Bu yüzden ödeme onaylanmadı.\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Successor metodu uygulanıyor...");
            //Toptancıya Üreten ile, Perakendeciye Toptancı ile aynı hakları tanımlamak adına Successor metodunu uyguluyoruz...
            toptanci.Successor(ureten);
            perakende.Successor(toptanci);
            Console.WriteLine("Successor metodu uygulandı...\n");

            satis = new SatisYetkisi() { Adet = 10, Yetki = true };
            perakende.Istek(satis);
            Console.WriteLine("Perakendenin kendi hakları da devam ettiği için 10 adet satışı onaylandı.\n");

            satis = new SatisYetkisi() { Adet = 10, Yetki = true };
            toptanci.Istek(satis);
            Console.WriteLine("Successor yetkilendirmesi ile Toptancı Üreten ile aynı haklara sahip oldu. Bu yüzden 10 adet satışı onaylandı.\n");

            satis = new SatisYetkisi() { Adet = 200, Yetki = true };
            perakende.Istek(satis);
            Console.WriteLine("Successor yetkilendirmesi ile Perakende Toptancı ile aynı haklara sahip oldu. Bu yüzden 200 adet satışı onaylandı.\n");

            satis = new SatisYetkisi() { Adet = 200, Yetki = false };
            perakende.Istek(satis);
            Console.WriteLine("Successor yetkilendirmesi ile Perakende Toptancı ile aynı haklara sahip olmasına rağmen Yetki değeri false verildiği için 200 adet satış onaylanmadı.");

            Console.ReadKey();

            //Chain Of Responcibility (COR) Kullanıldı...
        }
    }
}
