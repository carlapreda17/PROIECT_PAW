using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    public class Raion
    {
        private string nume_raion;
        private List<Tuple<Produs,int>> listaProduse; //adaugare produs+cantitate


        public string Nume_raion { get => nume_raion; set => nume_raion = value; }
        

        public List<Tuple<Produs, int>> ListaProduse
        {
            get { return listaProduse; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Lista de produse nu poate fi null.");
                }

                listaProduse = value;
            }
        }


        public Raion()
        {
            
            nume_raion = "";
            listaProduse= new List<Tuple<Produs,int>>();
        }

        public Raion(string nume, List<Tuple<Produs, int>> lista)
        {
            this.nume_raion = nume;
            List<Tuple<Produs, int>> listaNoua = new List<Tuple<Produs, int>>();
            foreach (var p in lista)
                    listaNoua.Add(p);
            listaProduse.AddRange(listaNoua);   //adauga elementele listei noi in listaProduse

        }

        public override string ToString()
        {
            string rezultat = "Raionul " + nume_raion + " are urmatoarele produse "+ Environment.NewLine;
            foreach(var p in listaProduse)
            {
                rezultat=rezultat+ p.ToString()+Environment.NewLine;
            }
           
            return rezultat;
        }

        public static Raion operator +(Raion r, Tuple<Produs, int> pereche )
        {

            r.listaProduse.Add(pereche);
            return r;
        }

        public static Raion operator -(Raion r, Tuple<Produs, int> pereche)
        {


            r.listaProduse.Remove(pereche);
            return r;
        }

       

    }
}
