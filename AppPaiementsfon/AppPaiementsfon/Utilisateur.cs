using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiementsfon
{
    internal class Utilisateur : Paiements
    {
        public string Nom { get; set; }
        public List<Paiements> Paiements { get; set; }
        public Utilisateur(decimal montant, string description, string nom) : base((double)montant, description)
        {
            Nom = nom;
            Paiements = new List<Paiements>();
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"Nom: {Nom}");
            Console.WriteLine("Paiements:");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }
        public void AjouterPaiement(Paiements paiement)
        {
            Paiements.Add(paiement);
        }
    }
}
