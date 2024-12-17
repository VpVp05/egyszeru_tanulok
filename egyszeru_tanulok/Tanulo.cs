using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egyszeru_tanulok
{
    internal class Tanulo
    {
        string igszam;
        string nev;
        DateTime szulido;
        string osztaly;
        string irszam;
        string varos;
        string utca;

        public string Igszam { get => igszam; set => igszam = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szulido { get => szulido; set => szulido = value; }
        public string Osztaly { get => osztaly; set => osztaly = value; }
        public string Irszam { get => irszam; set => irszam = value; }
        public string Varos { get => varos; set => varos = value; }
        public string Utca { get => utca; set => utca = value; }

        public Tanulo(string sor)
        {
            string[] darabok = sor.Split(';');
            igszam = darabok[0];
            nev = darabok[1];
            szulido = Convert.ToDateTime(darabok[2]);
            osztaly=darabok[3];
            irszam = darabok[4];
            varos = darabok[5];
            utca = darabok[6];
        }
    }
}
