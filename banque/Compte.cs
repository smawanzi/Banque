class Compte
{
    private static int nombreComptes;

    private int numero;
    private string titulaire;
    private decimal solde;
    private decimal decouvertMax;
    private decimal debitMax;

    public Compte(string titulaire, decimal solde) {
    }

    public void Crediter(decimal montant) {
        // augmente le solde
    }

    public bool Debiter(decimal montant) {
        // diminue le solde
        // retourn true ou false si l'opération a réussi.
        return false;
    }

    public void Virement(Compte CompteDestinataire, decimal montant) {
        // virement entre deux comptes.
    }
}