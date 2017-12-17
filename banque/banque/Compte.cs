using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banque
{
    class Compte
    {
        private static int nombreComptes;
        private int numero;
        private string titulaire;
        private decimal solde;
        private decimal decouvertMax;
        private decimal debitMax;
        

        public Compte(string titulaire, decimal solde)
        {
            Compte.nombreComptes = Compte.nombreComptes + 1;
            this.titulaire = titulaire;
            this.solde = solde;
            this.numero = Compte.nombreComptes;
        }

        // Chainage
        public Compte(string titulaire, decimal solde, decimal decouvertMax, decimal debitMax) :
            this(titulaire, solde)
        {
            this.decouvertMax = decouvertMax;
            this.debitMax = debitMax;
            //this.depenseactuelle = depenseactuelle;
        }

        public void Crediter(decimal montant)
        {
            // augmente le solde
            this.solde = solde + montant;
        }

        public bool Debiter(decimal montant)
        {
            // diminue le solde
            if (montant > this.debitMax)
            {
                Console.WriteLine("Débit rejeté : le montant est supérieur au débit max");
                return false;
            }
            else
            {
                if (this.solde <= this.decouvertMax)
                {
                    if (solde < this.decouvertMax)
                    {
                        this.solde = this.solde - montant;
                        Console.WriteLine("Prélèvement rejeté");
                        return true;
                    }
                    else
                    {
                        this.solde = this.solde + montant;
                        return false;
                    }
                }
            }
            return true;

            // retourn true ou false si l'opération a réussi.

        }

        public void Virement(Compte CompteDestinataire, decimal montant)
        {
            // virement entre deux comptes.
            if (montant > this.debitMax)
            {
                if (solde < decouvertMax)
                {
                    Console.WriteLine("Virement");
                }
                else
                {
                    this.solde = solde - montant;
                    CompteDestinataire.Crediter(montant);

                }
            }
        }

        public string ToString()
        {
            return string.Format("Compte n°{0} \n Titulaire : {1} \n Solde : {2} \n Découvert Maximum : {3} \n Débit max {4}", this.numero, this.titulaire, this.solde, this.decouvertMax, this.debitMax);
        }
    }
}
