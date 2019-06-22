using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeObserver
{
    /// Observer - Soyut sınıf tanımlanıyor...
    /// Birden fazla sınıf tarafından da takip edilmesini sağlamak için soyutlanıyor...
    /// </summary>
    abstract class Observer
    {
        //Herhangi bir değişimde gözlemleyiciler tarafından yapılması istenilen aksiyonlar tanımlanıyor...
        public abstract void Update();
    }
}
