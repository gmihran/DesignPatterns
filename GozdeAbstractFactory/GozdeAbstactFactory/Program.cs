using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeAbstractFactory
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
            public static void Main()
            {
                //Abstract Factory kullanılıyor...
                Console.Title = "Abstract Factory Tasarım Deseni";
                SoyutIlacFabrikasi fabrika1 = new GecmelliIlacFabrikasi();
                FabrikaOtomasyon fo1 = new FabrikaOtomasyon(fabrika1);
                fo1.IlacDoldur();

                SoyutIlacFabrikasi fabrika2 = new DrajeIlacFabrikasi();
                FabrikaOtomasyon fo2 = new FabrikaOtomasyon(fabrika2);
                fo2.IlacDoldur();
                Console.ReadKey();
                //Abstract Factory kullanıldı...
            }
        }
    }
}

