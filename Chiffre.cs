public struct Chiffre
{
    public Categorie categorie;
    public double chiffre;

    public Chiffre(Categorie c, double ch)
    {
        categorie = c;
        chiffre = ch;
    }

    public override string ToString()
    {
        return $"{categorie} : {chiffre} DA";
    }
}
