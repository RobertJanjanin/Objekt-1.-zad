using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaOoJanjanin
{
    class Program
    {
        static void Main(string[] args)
        {
            float prosjek;
            Neboder Tower = new Neboder(200, 100);                     
            Console.WriteLine(Tower.ToString());
            Tower.setVisina(Tower.getVisina() + 10);
            Tower.setBrojKatova(Tower.getBrojKatova() + 1);
            Console.WriteLine(Tower.ToString());
            prosjek = Tower.getVisina() / Tower.getBrojKatova();
            Console.WriteLine("Prosječna visina kata je: "+prosjek);
            Console.ReadKey();
        }
    }
}
