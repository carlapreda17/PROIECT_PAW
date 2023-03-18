using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROIECT_PAW
{
    
    internal class Tranzactii:Produs
    {
        private int cantitate_produs;
        private string data;
       
        

        public int Cantitate_produs { 
            
            get => cantitate_produs;
            set
            {
                if (value > 0)
                   cantitate_produs=value;
            }
        }
        public string Data { get => data; set => data = value; }
       

        public Tranzactii():base()
        {
           
            data = "";
            cantitate_produs = 0;
        }

        public Tranzactii(string data,int cantitate,int cod,string nume,string tip,float pret):base(cod,nume,tip,pret)
        {
            this.data=data;
            this.cantitate_produs = cantitate;
            
        }

        public override string ToString()
        {
            return base.ToString() + ". A fost achizionat la data de " + data + ", iar cantiatea este: "+cantitate_produs;
        }

        public float CalculeazaTranzactia()
        {
            return Pret * cantitate_produs;
        }

      



    }
}
