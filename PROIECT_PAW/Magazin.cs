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
            foreach(Tranzactii t in listaTranzactii)
            {
                rezultat += t.ToString() + Environment.NewLine;

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
        s
        public void AdaugaTranzactie(Tranzactii tranzactie)
        {
            listaTranzactii.Add(tranzactie);
           for(int j=0; j<listaRaioane.Count; j++)
            {
                var raion=listaRaioane[j];
                for(int i=0; i<raion.ListaProduse.Count; i++)
                {
                    var produs=raion.ListaProduse[i];   
                    if(tranzactie.Cod== produs.Item1.CodProdus)
                    {
                       tranzactie.CalculeazaCostFinal(produs.Item1.Pret);
                        if(tranzactie.Cantitate_produs< produs.Item2)
                        {
                            listaRaioane[j].ListaProduse[i] = new Tuple<Produs, int>(produs.Item1, produs.Item2-tranzactie.Cantitate_produs) ;
                            
                        }
                        else if (tranzactie.Cantitate_produs == produs.Item2)
                        {
                            //raion.ListaProduse.RemoveAt(i);
                            listaRaioane[j] -= produs;
                            
                        }
                        else
                        {
                            Console.WriteLine("produs invalid");
                        }

                        break;
                    }
                }
            }
        }

       

        

       
       

    }

}
