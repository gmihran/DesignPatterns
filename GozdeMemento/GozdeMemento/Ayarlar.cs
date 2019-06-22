using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMemento
{
    public class Ayarlar
    {
        //Kullanıcının güncelleyebileceği ayarlar tanımlanıyor...
        public string Adi { get; set; }
        public string Turu { get; set; }
        public string Sekil { get; set; }
        public int Miktar { get; set; }
        public string Cesit { get; set; }
        

        //Çağrıldığında Ayarlar nesnemizin kopyasını oluşturacak olan metot tanımlanıyor...
        public AyarlarMemento Backup()
        {
            AyarlarMemento ayarlarMemento = new AyarlarMemento
            {
                Adi = this.Adi,
                Turu = this.Turu,
                Sekil = this.Sekil,
                Miktar = this.Miktar,
                Cesit = this.Cesit,
            };
            return ayarlarMemento;
        }

        //Çağrıldığında daha önceden kopyası alınan Memento sınıfındaki bilgiler Ayarlar nesnesine geri döndürülüyor...
        public void GetDefaultAyarlar(AyarlarMemento ayarlarMemento)
        {
            this.Adi = ayarlarMemento.Adi;
            this.Turu = ayarlarMemento.Turu;
            this.Sekil = ayarlarMemento.Sekil;
            this.Miktar = ayarlarMemento.Miktar;
            this.Cesit = ayarlarMemento.Cesit;
        }

        public override string ToString()
        {
            return string.Format("Adı: {0} \tTürü: {1} \tŞekil: {2} \tMiktar: {3} \tÇeşit: {4}", this.Adi, this.Turu, this.Sekil, this.Miktar.ToString(),this.Cesit);
        }
    }
}
