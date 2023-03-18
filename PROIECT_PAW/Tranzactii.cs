using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROIECT_PAW
{
    
    internal class Tranzactii
    {
        private int cod;
        private int cantitate_produs;
        private string data;
        private float cost_final;
        

        public int Cantitate_produs { 
            
            get => cantitate_produs;
            set
            {
                if (value > 0)
                   cantitate_produs=value;
            }
        }
        public string Data { get => data; set => data = value; }
        public int Cod { get => cod; set => cod = value; }
        public float Cost_final { get => cost_final; set => cost_final = value; }

        public Tranzactii()
        {
           
            data = "";
            cantitate_produs = 0;
            cod = 0;
            cost_final = 0;
        }

        public Tranzactii(string data,int cantitate,int cod)
        {
            this.data=data;
            this.cantitate_produs = cantitate;
            this.cod = cod;
            this.cost_final = 0;
            
        }

        public override string ToString()
        {
            return base.ToString() + ". A fost achizionat la data de " + data + ", iar cantiatea este: "+cantitate_produs;
        }

        public void CalculeazaCostFinal(float pret_produs)
        {
            this.cost_final= pret_produs * cantitate_produs;
        }

      



    }
}
