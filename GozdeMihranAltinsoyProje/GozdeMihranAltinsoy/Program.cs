using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    class Program
    {
        abstract class SoyutIlacFabrikasi
        {
            abstract public SoyutIlacKutusu KutuUret();
            abstract public SoyutIlacTableti TabletUret();
        }

        class GecmelliIlacFabrikasi : SoyutIlacFabrikasi
        {
            public override SoyutIlacKutusu KutuUret()
            {
                return new GecmeliIlacKutusu();
            }

            public override SoyutIlacTableti TabletUret()
            {
                return new DrajeIlacTableti();
            }
        }

        class DrajeIlacFabrikasi : SoyutIlacFabrikasi
        {
            public override SoyutIlacKutusu KutuUret()
            {
                return new TekliIlacKutusu();
            }

            public override SoyutIlacTableti TabletUret()
            {
                return new TekDozHap();
            }
        }

        abstract class SoyutIlacKutusu
        {
            abstract public void IlacDoldur(SoyutIlacTableti a);
        }

        abstract class SoyutIlacTableti
        {
        }

        class GecmeliIlacKutusu : SoyutIlacKutusu
        {
            public override void IlacDoldur(SoyutIlacTableti ilac)
            {
                Console.WriteLine(ilac + " ilacli GecmeliIlacKutusu");
            }
        }


        class TekliIlacKutusu : SoyutIlacKutusu
        {
            public override void IlacDoldur(SoyutIlacTableti ilac)
            {
                Console.WriteLine(ilac + " ilacli TekliIlacKutusu");
            }

        }


        class DrajeIlacTableti : SoyutIlacTableti
        {

        }

        class TekDozHap : SoyutIlacTableti
        {

        }

        class FabrikaOtomasyon
        {
            private SoyutIlacKutusu IlacKutusu;
            private SoyutIlacTableti IlacTableti;

            public FabrikaOtomasyon(SoyutIlacFabrikasi fabrika)
            {
                IlacKutusu = fabrika.KutuUret();
                IlacTableti = fabrika.TabletUret();
            }

            public void IlacDoldur()
            {
                IlacKutusu.IlacDoldur(IlacTableti);
            }
        }
        class UretimBandi
        {
            static void Main(string[] args)
            {
                //Kocaeli Üniversitesi Fen Bilimleri Enstitüsü Bilgisayar Mühendisliği Tasarım Örüntüleri Dersi Projesi
                //Dersin Öğretim Elemanı: Dr.Öğr.Üyesi ALPASLAN BURAK İNNER

                //Proje kodlarının tamamı bana aittir. Yapmaya çalıştığım İlaç Projesine benzer örneklerden edindiğim kaynak kodları kendi projeme uyarlayarak projemi tamamladım.
                //Author: Gözde Mihran Altınsoy
               
                Console.ForegroundColor = ConsoleColor.Green;
                //Singleton Tasarım Deseni Kullanılıyor...
                //Ilac.cs class ile ilacim nesnesi oluşturuluyor
                Console.Title = "Singleton Tasarım Deseni";
                Ilac ilacim = Ilac.Instance;
                ilacim.Firma = "Health Group";
                Ilac ilacim2 = Ilac.Instance;
                //Ilac.cs class ile ilacim2 nesnesi oluşturuluyor
                Console.WriteLine(ilacim2.Firma);
                
                //Tanımladığımız ikinci değere Firma tanımlamadığımız halde ilacın firması birinci ilacın firması ile aynı oldu.
                //Singleton Tasarım Deseni Kullanıldı...
                //Kaynak: https://www.mshowto.org/c-singleton-tasarim-deseni-icin-ornekli-anlatim.html 

                tasarimGecis();
                //Console temizlendi...

                //Abstract Factory kullanılıyor...
                Console.Title = "Abstract Factory Tasarım Deseni";
                SoyutIlacFabrikasi fabrika1 = new GecmelliIlacFabrikasi();
                FabrikaOtomasyon fo1 = new FabrikaOtomasyon(fabrika1);
                fo1.IlacDoldur();

                SoyutIlacFabrikasi fabrika2 = new DrajeIlacFabrikasi();
                FabrikaOtomasyon fo2 = new FabrikaOtomasyon(fabrika2);
                fo2.IlacDoldur();

                //Abstract Factory kullanıldı...
                //Kaynak: http://www.csharpnedir.com/articles/read/?id=146

                tasarimGecis();
                //Console temizlendi...

                //Factory kullanılıyor...
                //Bu uygulamada Interface İle Factory Method Design Pattern kullanılmıştır.
                //Abstract Class İle Factory Method Design Pattern ile aynı uygulama gerçekleştirilebilir.
                Console.Title = "Factory Tasarım Deseni";
                Krem krem = new Krem();
                Surup surup = new Surup();
                Tablet tablet = new Tablet();

                krem.IlacCesitleri();
                surup.IlacCesitleri();
                tablet.IlacCesitleri();
                
                //Factory kullanıldı...
                //Kaynak: https://www.gencayyildiz.com/blog/c-factory-method-design-patternfactory-method-tasarim-deseni/

                tasarimGecis();
                //Console temizlendi...

                //Prototype kullanılıyor...
                Console.Title = "Prototype Tasarım Deseni";
                //Bu örnekte Prototype Tasarım Deseni ile Deep Copy Gerçekleştirilmiştir.

                Ilac2 prototip = new Ilac2();
                prototip.adi = "Apranax";
                prototip.turu = "Ağrı";
                prototip.sekil = "Dikdörtgen";
                prototip.miktar = 20;
                prototip.cesit = "Tablet";

                Ilac2 majezik = (Ilac2)prototip.Clone();
                majezik.adi = "Majezik";

                Ilac2 parol = (Ilac2)prototip.Clone();
                parol.adi = "Parol";

                Ilac2 vermidon = (Ilac2)prototip.Clone();
                vermidon.adi = "Vermidon";

                Ilac2 nurofen = (Ilac2)prototip.Clone();
                nurofen.adi = "Nurofen";

                Ilac2 aspirin = (Ilac2)prototip.Clone();
                aspirin.adi = "Aspirin";

                Ilaclar ilaclar = new Ilaclar
            {
                majezik,
                parol,
                vermidon,
                nurofen,
                aspirin
            };
                ilaclar.Liste();

                majezik.miktar = 15;
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Majezik miktarı güncellenecektir.");
                try
                {
                    
                    Console.Write("Lütfen Majezik İlacının Miktarını Giriniz:");
                    int miktar = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Majezik Miktarı güncelleniyor...");
                    System.Threading.Thread.Sleep(1000);
                    majezik.miktar = miktar;
                    Console.WriteLine("Majezik Miktarı güncellendi...");
                    Console.WriteLine("İlaçlar tekrar yazdırılıyor...");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    ilaclar.Liste();

                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Geçersiz veya hatalı bir değer girdiniz.");
                }
                finally
                {
                    tasarimGecis();
                }
                //Prototype kullanıldı...

                //Kaynak: https://www.turkayurkmez.com/prototype-design-pattern/

                //Object Pool kullanılıyor...

                Console.Title = "Object Pool Tasarım Deseni";
                Factory fa = new Factory();
                Ilacim Ilac1 = fa.GetIlac();
                Console.WriteLine("1. ilaç");
                Ilacim Ilac2 = fa.GetIlac();
                Console.WriteLine("2. ilaç");
                Ilacim Ilac3 = fa.GetIlac();
                Console.WriteLine("3. ilaç");

                //Object Pool kullanıldı...
                //Kaynak: https://www.codeguru.com/csharp/csharp/cs_misc/object-pooling-in-c.html

                tasarimGecis();

                //Builder kullanılıyor...
                Console.Title = "Builder Tasarım Deseni";
                IlacBuilder ilac_builder = new IlacConcrete1();
                IlacDirector ilac_olusturucu = new IlacDirector(ilac_builder);
                Console.WriteLine(ilac_builder.ilac.ToString());

                ilac_builder = new IlacConcrete2();
                ilac_olusturucu = new IlacDirector(ilac_builder);
                Console.WriteLine(ilac_builder.ilac.ToString());


                //Builder kullanıldı...
                //Kaynak: http://harunozer.com/Makale/builder_tasarim_deseni__builder_design_pattern.htm

                tasarimGecis();


                //Iterator kullanılıyor...
                Console.Title = "Iterator Tasarım Deseni";
                IlacConcreteAggregate IlacCollection = new IlacConcreteAggregate();
                IlacCollection.Add(new Ilac { Adi = "Majezik", Miktar = 20 });
                IlacCollection.Add(new Ilac { Adi = "Aferin", Miktar = 15 });
                IlacCollection.Add(new Ilac { Adi = "Augmentin", Miktar = 14 });
                IIlacIterator itr = IlacCollection.GetIterator();
                while (itr.IsDone())
                {
                    Console.WriteLine("{0}:{1}", itr.CurrentItem().Adi, itr.CurrentItem().Miktar);
                    itr.Next();
                }
                //First metodu ile ilk değere dönüldü.
                Console.WriteLine("\nİlk değer ekrana yazdırılıyor...");
                Ilac ilac = itr.First();
                Console.WriteLine("{0}:{1}", itr.CurrentItem().Adi, itr.CurrentItem().Miktar);
                Console.WriteLine("\nİlk değerin miktarı ekrana yazdırılıyor...");
                Console.WriteLine("Miktar:"+ilac.Miktar.ToString());

                //Iterator kullanıldı...
                //Kaynak: http://harunozer.com/Makale/iterator_tasarim_deseni__iterator_design_pattern.htm
                //Kaynak: https://www.buraksenyurt.com/post/Tasarc4b1m-Desenleri-Iterator

                tasarimGecis();

                //Memento kullanılıyor....
                Console.Title = "Memento Tasarım Deseni";
                AyarlarCareTaker ayarlarCaretaker = new AyarlarCareTaker();

                Ayarlar ayarlar = new Ayarlar();
                ayarlar.Adi = "Majezik";
                ayarlar.Turu = "Ağrı";
                ayarlar.Sekil = "Kare";
                ayarlar.Miktar = 15;
                ayarlar.Cesit = "Tablet";


                Console.Write(ayarlar.ToString() + Environment.NewLine);

                // Kopyasını alıyoruz.
                ayarlarCaretaker.Memento = ayarlar.Backup();

                ayarlar.Miktar = 20;
                ayarlar.Sekil = "Şurup";

                Console.Write(ayarlar.ToString() + Environment.NewLine);

                // Caretaker üzerinde bulunan kopyasından nesne orjinal haline geri döndürülüyor...
                ayarlar.GetDefaultAyarlar(ayarlarCaretaker.Memento);

                Console.WriteLine(ayarlar.ToString());

                //Memento kullanıldı....
                //Kaynak: https://www.gokhan-gokalp.com/c-memento-pattern-kullanimi/

                tasarimGecis();

                //Observer kullanılıyor...
                Console.Title = "Observer Tasarım Deseni";
                Product i1 = new Product();
                Gozlemleyici g1 = new Gozlemleyici { Bilgiler = "G. Mihran Altınsoy" };
                i1.GozlemleyiciEkle(g1);
                Gozlemleyici g2 = new Gozlemleyici { Bilgiler = "A. Burak İnner" };
                i1.GozlemleyiciEkle(g2);
                i1.Adi = "Aerius";
                i1.Turu = "Alerji";
                i1.Sekil = "Yuvarlak";
                i1.Miktar = 20;
                i1.Cesit = "Tablet";
                Console.WriteLine("Miktar güncelleniyor...");
                i1.MiktarGuncelleme = DateTime.Now;
                Console.WriteLine("İki gözlemciye de bildirim gitmektedir...\n");
                //MiktarGuncelleme metodu gözlemcilere bildirim yapmayı tetiklemektedir. Aynı zamanda değişikliğin olduğu zamanı tutmaktadır.

                Console.WriteLine("1. gözlemci Product listesinden kaldırılmıştır...\n");

                Console.WriteLine("Miktar güncelleniyor...");
                i1.GozlemleyiciSil(g1);
                i1.Miktar = 15;
                i1.MiktarGuncelleme = DateTime.Now;

                Console.WriteLine("1. gözlemci gözlemci listesinden kaldırıldığı için sadece 2. gözlemciye bildirim gitmektedir...");

                //Observer kullanıldı...
                //Kaynak: https://docplayer.biz.tr/48645957-Yazilim-tasarim-desenleri-ve-prensipleri-c-ile.html
                //Kaynak: https://www.gokhan-gokalp.com/c-observer-pattern-kullanimi/
                //Kaynak: http://safakunel.blogspot.com/2013/10/c-observer-pattern-kullanimi-oop-design.html


                tasarimGecis();

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

                //Chain Of Responcibility (COR) Kullanıldı...
                //Kaynak: https://docplayer.biz.tr/48645957-Yazilim-tasarim-desenleri-ve-prensipleri-c-ile.html

                tasarimGecis();

                //Command Kullanılıyor...

                Console.Title = "Command Tasarım Deseni";
                SatisYapKomutu satisYapKomutu = new SatisYapKomutu(new IlacIslemleri());
                IlacPaketleKomutu ilacPaketleKomutu = new IlacPaketleKomutu(new IlacIslemleri());

                KomutIletici iletici = new KomutIletici();


                iletici.Calistir(satisYapKomutu);
                iletici.Calistir(ilacPaketleKomutu);

                //Command Kullanıldı...
                //Kaynak: https://www.turkayurkmez.com/command-design-pattern/
                //Kaynak: https://www.yazilimbilisim.net/c-sharp/c-list-kullanimi/

                tasarimGecis();


                //Visitor Kullanılıyor...
                Console.Title = "Visitor Tasarım Deseni";
                AkutAgriKesici akut = new AkutAgriKesici("Parol");
                KronikAgriKesici kronik = new KronikAgriKesici("Morfin");

                akut.Accept(new AkutVisitor());
                kronik.Accept(new AkutVisitor());

                akut.Accept(new KronikVisitor());
                kronik.Accept(new KronikVisitor());


                //Visitor Kullanıldı...
                //Kaynak: http://safakunel.blogspot.com/2013/12/c-visitor-pattern-kullanimi-oop-design.html

                tasarimGecis();

                //Mediator Kullanılıyor...


                //Mediator Kullanıldı...


                //tasarimGecis();

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
                        else if (secim != 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Hatalı Seçim Yapıldı...");
                            Console.Write("Devam etmek için bir tuşa basınız...");
                            Console.ReadKey();
                        }

                    } while (secim != 3);

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

                //tasarimGecis();

                //Decorator Kullanılıyor...


                //Decorator Kullanıldı...

                //tasarimGecis();

                //Component Kullanılıyor...


                //Component Kullanıldı...
            }

        }
        public static void tasarimGecis()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDiğer Tasarım Desenine Geçmek için herhangi bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
