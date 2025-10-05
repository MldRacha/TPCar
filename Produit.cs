using System;

public class Produit
{
    private int codeBarre;
    private string designation;
    private int quantité;
    private DateTime expire;
    private Categorie categorieProduit;
    private double prix;

    public Produit(int codeBarre, string designation, int quantité, DateTime expire,
                   Categorie categorieProduit, double prix)
    {
        this.codeBarre = codeBarre;
        this.designation = designation;
        this.quantité = quantité;
        this.expire = expire;
        this.categorieProduit = categorieProduit;
        this.prix = prix;
    }

    public Produit()
    {
        codeBarre = 0;
        designation = "Inconnu";
        quantité = 0;
        expire = DateTime.Now;
        categorieProduit = Categorie.Rien;
        prix = 0.0;
    }

    public int CodeBarre { get => codeBarre; set => codeBarre = value; }
    public string Designation { get => designation; set => designation = value; }
    public int Quantité { get => quantité; set => quantité = value; }
    public DateTime Expire { get => expire; set => expire = value; }
    public Categorie CategorieProduit { get => categorieProduit; set => categorieProduit = value; }
    public double Prix { get => prix; set => prix = value; }

    public bool egalite(Produit unProduit) => this.prix == unProduit.prix;

    public override string ToString()
    {
        return $"{codeBarre}, '{designation}', {quantité}, {expire.Year}, {categorieProduit}, {prix} DA";
    }

    public void afficher() => Console.WriteLine(this.ToString());
}
