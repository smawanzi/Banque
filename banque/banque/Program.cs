using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque b1 = new Banque("crédit lyonnais");
            Banque b2 = new Banque("Société Générale");

            Compte c1 = new Compte("harry tutle",0,-200,3000);
            Compte c2 = new Compte("jill layton", 100, -100, 3000);

            
            b1.Add("sam lowry", 1000, -500, 3000);
            b2.Add("jack lint",200,0,3000);

            for (int i = 0; i < b1.Count; i=i+1)
            {
                b1.GetCompte(i);
                Console.WriteLine("");

            }

            Console.ReadLine();
        }
    }
}
