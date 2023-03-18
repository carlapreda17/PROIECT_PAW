using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    internal class Magazin
    {
        private string nume_magazin;
        private string adresa;
        private List<Raion> listaRaioane;
        private List<Tranzactii> listaTranzactii;
      
        public string Nume_magazin { get => nume_magazin; set => nume_magazin = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public List<Raion> ListaRaioane 
        {
            get => listaRaioane;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Lista de raioane nu poate fi null.");
                }

                listaRaioane = value;
            }
        }
        internal List<Tranzactii> ListaTranzactii
        { 
            get => listaTranzactii;

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Lista de raioane nu poate fi null.");
                }

                listaTranzactii = value;
            }
        }

       

        public Magazin()
        {
            this.adresa = "";
            this.nume_magazin = "";
            listaRaioane=new List<Raion>();
            listaTranzactii = new List<Tranzactii>();
               
            
        }

        public Magazin(string nume,string adresa, List<Raion> listaR, List<Tranzactii> listaT)
        {
            this.adresa = adresa;   
            this.nume_magazin = nume;
            List<Raion> listaNouaR=new List<Raion>();
            foreach (Raion r in listaR)
                listaNouaR.Add(r);
            listaRaioane.AddRange(listaNouaR);

            List<Tranzactii> listaNouaT = new List<Tranzactii>();
            foreach (Tranzactii t in listaT)
                listaNouaT.Add(t);
           listaTranzactii.AddRange(listaNouaT);
           


        }

        public override string ToString()
        {
            string rezultat = "Magazinul de dulciuri " + nume_magazin + " de pe strada " + adresa + " are urmatoarele raioane: " + Environment.NewLine;
         
            foreach (Raion r in listaRaioane)
            {
                rezultat += r.ToString() + Environment.NewLine;
            }
            return rezultat;
        }

        public void AdaugaRaion(Raion raion)
        {
            listaRaioane.Add(raion);
        }

        public void StergeRaion(Raion raion)
        {
            listaRaioane.Remove(raion);
        }

        public void AdaugaTranzactie(Tranzactii tranzactie)
        {
            listaTranzactii.Add(tranzactie);
        }

       

        

       
       

    }

}
