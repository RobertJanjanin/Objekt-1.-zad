using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaOoJanjanin
{
    class Neboder
    {
        private int visina;
        private int brojKatova;
        public Neboder()
        {


        }
        public void setVisina(int visina)
        {
            this.visina = visina;
        }
        public void setBrojKatova(int brojKatova)
        {
            this.brojKatova = brojKatova;
        }

        public int getVisina()
        {
            return visina;

        }
        public int getBrojKatova() {
            return brojKatova;

        }
        public override string ToString()
        {
            string ispis = "visina nebodera: " + visina + "\nBroj Katova: " + brojKatova;
               
            return ispis;
        }
        public Neboder(int visina, int brojKatova) {
            this.visina = visina;
            this.brojKatova = brojKatova;
        }
    }
}
