using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeObserver
{
    //Takip edilecek nesne tanımlanıyor...
    class Product
    {
        // Gözlemleyicilerin tutulacağı liste tanımlanıyor.
        private List<Observer> observers = new List<Observer>();

        public void GozlemciEkle(Observer observer)
        {
            observers.Add(observer);
        }

        public void GozlemciSil(Observer observer)
        {
            observers.Remove(observer);
        }

        private void GozlemciUyar()
        {
            // Herhangi bir değişiklik olduğunda gözlemleyicilerimizin Update metotunu tetikleterek istenilen aksiyon gerçekleştirilebilir.
            observers.ForEach(o => { o.Update(); });
            /*
            //Bu şekilde de yazılabilir.
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
            */
        }

        public void MiktarDegis()
        {
            //İlacın miktarı değiştiğinde gözlemcilere bildiriliyor...
            this.GozlemciUyar();
        }
    }
}
