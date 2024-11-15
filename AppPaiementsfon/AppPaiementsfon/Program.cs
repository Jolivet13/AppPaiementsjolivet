namespace AppPaiementsfon;

internal class Program
{
    static void Main(string[] args)
    {
        var achat_jolivet = new Cartecredit(150.00m, " Achat de vêtements ", 123456789);
        var achat_steve = new Cartecredit(250.00m, " Achat de livres ", 234567890);
        var achat_fon = new Cartecredit(300.00m, " Achat de nourritures ", 345678901);
        List<Cartecredit> achats = new List<Cartecredit> { achat_jolivet, achat_steve, achat_fon };
        foreach (var achat in achats)
        {
            achat.AfficherDetails();
            Console.WriteLine();
        }
        var paypal1 = new Paypal(750.00m, "Achat de logiciels", "kenfackjolivet@gmail.com");
        var paypal2 = new Paypal(100.00m, "Paiement abonnement", "jolivet.fonkenfack@monboreal.ca");
        List<Paypal> paiements = new List<Paypal> { paypal1, paypal2 };
        foreach (var paiement in paiements)
        {
            paiement.AfficherDetails();
            Console.WriteLine();
        }
    }
}
