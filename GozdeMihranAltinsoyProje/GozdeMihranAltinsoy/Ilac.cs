using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    public class Ilac
    {
        static Ilac instance;

        public static Ilac Instance
        {
            get { return Ilac.instance; }
        }
        static Ilac()
        {
            instance = new Ilac();
        }

        string firma;

        public string Firma
        {
            get { return firma; }
            set { firma = value; }
        }

        public string Adi { get; set; }
        public string Turu { get; set; }
        public string Sekil { get; set; }
        public int Miktar { get; set; }
        public string Cesit { get; set; }
        public override string ToString()
        {
            return String.Format("Adı:{0} \tTuru:{1} \tSekil:{2} \tMiktar:{3} \tCesit:{4}", Adi, Turu, Sekil, Miktar, Cesit);
        }
    }
    
}
