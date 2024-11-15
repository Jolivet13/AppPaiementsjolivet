using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiementsfon
{
    internal class Cartecredit:Paiements
    {
        public int NumeroCarte { get; set; }
        public Cartecredit(decimal montant, string description, int Carte)
        : base((double)montant, description)
        { NumeroCarte = Carte; }
        public new virtual void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Numéro de Carte: {NumeroCarte}");

        }
    }
}
