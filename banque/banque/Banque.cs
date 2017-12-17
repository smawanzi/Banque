using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Banque
{
    class Banque
    {
        //type
        private ArrayList lesCompte;
        private string nom;
        //private int count;
        private ArrayList posseder;

        public Banque(string nom)
        {
            this.nom = nom;
            this.posseder = new ArrayList();
        }
        //une surchage
        public void Add(string titulaire, decimal solde, decimal decouvertMax, decimal debitMax)
        {
            Compte nouveauCompte = new Compte(titulaire,solde,decouvertMax,debitMax);
            
        }
        
        public int GetCount()
        {
            return this.Count;
        }
        
        public int Count
        {
            get 
            {
                return this.GetCount();
            }
        }

        public Compte GetCompte(int position)
        {
            if (position>=0 && position < this.lesCompte.Count)
	        {
		        return (Compte)this.lesCompte[position];
	        }
            else
            {
                return null;
            }
        }
        public Compte this[int position] 
        {
            get 
            {
                return (Compte)this.lesCompte[position];
            }
        }
        //public decimal ValeurDepotsBanque() 
        //{
        //    decimal cumul = 0;

        //    for (int i = 0; i < this.Count; i++) 
        //    {
        //        Compte c = this.GetCompte(i);
        //    }
        //public int CountSoldesNegatifs() 
        //{
            
        //}
        
        }
       
    }
