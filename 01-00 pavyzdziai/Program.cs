using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_00_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracija ir inicializacija
            var ajbjs = 515;
            var sdgdj = 4.5;
            var asfsd = "asgfdgf";
            var sdg = 'a';
            var dgddfg = false;

            // deklaracija - VIENA KARTA TIK
            string sjdbh;
            int hgdg;
            double djgng;

            // inicializacija - GALIMA VELIAU KEISTI KIEK NORIT KARTU
            sjdbh = "ajfbd";
            hgdg = 74;
            djgng = 6.3;

            // ...one year later...
            sjdbh = "kskdbdfj";
            hgdg = 20;
            djgng = 8.7;

            /*
             * ant int, short, long ar bet kurio kintamojo tipo paspaudus dešinį pelės mygtuką
             * ir pasirinkus go to definition bus parodyta klasė, kurioje tas kintamasis aprašytas
             * ir bus galima pamatyti jo mažiausias ir didžiausias galimas reikšmes, jei tai skaičius
             * 
             * taip pat, galima min/max reikšmes pasiskaičiuoti ir patiems 2 pakėlus bitų skaičiumi,
             * pvz 2 pakelta 32 laipsniai yra maksimalus galimas kombinacijų skaičius, na arba kiek teigiamų
             * reikšmių nuo 0 iki x galime turėti, tačiau int paprastai sudaro ir teigiamos ir neigiamos
             * reikšmės, todėl gautą skaičių padalinus iš 2 gausime kiek jis turės atskirai teigiamų
             * ir kiek atskirai neigiamų reikšmių
             * jei norime tik teigiamų reikšmių tai reikia naudoti ne int, o uint
             * 
             * unsigned kintamieji yra tik teigiamos reikšmės
             * signed kintamieji yra ir teigiamos ir neigiamos, bet, kad gauti neigiamas reikšmes yra prarandama pusė teigiamų
             * ir jos perkeliamos į neigiamas
             */

            int hbfh; // 32 bit
            short hbgh; // 16 bit
            long sjgbjd; // 64 bit

            uint sjsddfg; // unsigned 32 bit
            ushort hdgbf; // unsigned 16 bit
            ulong sfddd; // unsigned 64 bit

            byte sbsgd; // 8 bit
            sbyte sgndf; // signed 8 bit
        }
    }
}
