using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiementsfon
{
    internal class Paypal:Paiements
    {
        public string Courriel { get; set; }
        public Paypal(decimal montant, string description, string email)
            : base((double)montant, description)
        {
            Courriel = email;
        }
        public new virtual void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Email: {Courriel}");
        }
    }
}
