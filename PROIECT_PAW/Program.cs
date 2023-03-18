using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Produs p1=new Produs(122,"ciocolata","Milka",4);
           Produs p2 = new Produs(123, "ciocolata", "Poiana",2);
           Produs p3 = new Produs(124, "ciocolata", "Heidi",6);
           Produs p4 = new Produs(125, "bomboane", "Milka", 8);
           Produs p5 = new Produs(126, "bomboane", "Choco", 5);



            Raion r1=new Raion();
            r1.Nume_raion = "Cicoloata";
            r1 += p1;
            r1 += p2;
            r1 += p3;
            Raion r2=new Raion();
            r2.Nume_raion = "Bomboane";
            r2 += p4;
            r2 += p5;

            Tranzactii t1 = new Tranzactii("12/02/2022", 2, 122, "ciocolata", "Milka", 4);
            Tranzactii t2 = new Tranzactii("15/08/2021", 4, 124, "ciocolata", "Heidi", 6);

            Magazin m1=new Magazin();
            m1.Nume_magazin = "CandyLand";
            m1.Adresa = "Dornei nr2";
            m1.AdaugaRaion(r1);
            m1.AdaugaRaion(r2);
            m1.AdaugaTranzactie(t1);
            m1.AdaugaTranzactie(t2);

            

           


            Console.WriteLine(m1);


        }
    }
}
