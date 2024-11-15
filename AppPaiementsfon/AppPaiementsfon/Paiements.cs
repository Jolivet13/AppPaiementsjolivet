using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiementsfon
{
    internal class Paiements
    {
        public double Montant { get; set; }
        public string Description { get; set; }
        public Paiements(double montant, string description)
        {
            Montant = montant;
            Description = description;
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"Montant: {Montant}, Description: {Description}");
        }
    }
}
