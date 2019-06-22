using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    public class Product
    {
        private DateTime miktarGuncelleme;
        public DateTime MiktarGuncelleme
        {
            get { return miktarGuncelleme; }
            set
            {
                miktarGuncelleme = value;
                GozlemleyiciUyar();
            }
        }
        public string Adi { get; set; }
        public string Turu { get; set; }
        public string Sekil { get; set; }
        public int Miktar { get; set; }
        public string Cesit { get; set; }

        public List<IGozlemleyici> gozlemleyiciler;
        public Product()
        {
            gozlemleyiciler = new List<IGozlemleyici>();
        }
        public void GozlemleyiciEkle(IGozlemleyici gozlemleyici)
        {
            gozlemleyiciler.Add(gozlemleyici);
        }
        public void GozlemleyiciSil(IGozlemleyici gozlemleyici)
        {
            gozlemleyiciler.Remove(gozlemleyici);
        }
        public void GozlemleyiciUyar()
        {
            foreach (IGozlemleyici gozlemleyici in gozlemleyiciler)
            {
                gozlemleyici.Guncelle(this);
            }
        }
    }
    //Observer
    public interface IGozlemleyici
    {
        void Guncelle(Product product);

    }
    public class Gozlemleyici : IGozlemleyici
    {
        public void Guncelle(Product product)
        {
            Console.WriteLine(product.MiktarGuncelleme + " itibariyle miktar güncellendi... Yeni Miktar: " + product.Miktar.ToString());
        }
        public string Bilgiler { get; set; }
    }
}
