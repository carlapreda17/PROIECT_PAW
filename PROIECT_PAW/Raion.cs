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
        private List<Produs> listaProduse;

        public string Nume_raion { get => nume_raion; set => nume_raion = value; }
        

        public List<Produs> ListaProduse
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
            listaProduse = new List<Produs>();
        }

        public Raion(string nume, List<Produs> lista)
        {
            this.nume_raion = nume;
            List<Produs> listaNoua = new List<Produs>();
            foreach (Produs p in lista)
                    listaNoua.Add(p);
            listaProduse.AddRange(listaNoua);   //adauga elementele listei noi in listaProduse

        }

        public override string ToString()
        {
            string rezultat = "Raionul " + nume_raion + " are urmatoarele produse "+ Environment.NewLine;
            foreach(Produs p in listaProduse)
            {
                rezultat=rezultat+ p.ToString()+Environment.NewLine;
            }
           
            return rezultat;
        }

        public static Raion operator +(Raion r, Produs p)
        {

            r.listaProduse.Add(p);
            return r;
        }

        public static Raion operator -(Raion r, Produs p)
        {

            r.listaProduse.Remove(p);
            return r;
        }

       

    }
}
