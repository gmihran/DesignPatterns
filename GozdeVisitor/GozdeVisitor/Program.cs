using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Visitor kullanılıyor...
            Console.Title = "Visitor Tasarım Deseni";
            AkutAgriKesici akut = new AkutAgriKesici("Parol");
            KronikAgriKesici kronik = new KronikAgriKesici("Morfin");

            akut.Accept(new AkutVisitor());
            kronik.Accept(new AkutVisitor());

            akut.Accept(new KronikVisitor());
            kronik.Accept(new KronikVisitor());

            Console.ReadKey();

            //Visitor kullanıldı...

        }
    }
}
