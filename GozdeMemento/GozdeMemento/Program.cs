using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMemento
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.Write(ayarlar.ToString());
            Console.ReadKey();
            //Memento kullanıldı....
        }
    }
}
