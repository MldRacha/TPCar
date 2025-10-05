using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Produit
    {
        private int codeBarre;
        private string designation;
        private int quantité;
        private DateTime expire;
        private Categorie categorieProduit;
        private double prix;

        public Produit() { }
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
        public int CodeBarre
        {
            get { return codeBarre; }
            set { codeBarre = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public int Quantité
        {
            get { return quantité; }
            set { quantité = value; }
        }

        public DateTime Expire
        {
            get { return expire; }
            set { expire = value; }
        }

        public Categorie CategorieProduit
        {
            get { return categorieProduit; }
            set { categorieProduit = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public bool egalite(Produit x)
        {
            return this.prix == x.prix;
        }

        public override string ToString()
        {
            return $"{codeBarre}, '{designation}', {quantité}, {expire.Year}, {categorieProduit}, {prix} DA";
        }

        public void afficher() => Console.WriteLine(this.ToString());

    }
}
