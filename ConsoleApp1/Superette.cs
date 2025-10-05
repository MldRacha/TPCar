using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Superette
    {
        private string nom;
        private string adresse;
        private List<Produit> produits;

        public Superette(string nom, string adresse, List<Produit> produits)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.produits = produits;
        }

        public Superette()
        {
            nom = "Sans nom";
            adresse = "Inconnue";
            produits = new List<Produit>();
        }

        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public List<Produit> Produits { get => produits; set => produits = value; }

        public Produit chercherProduit(string designation) => produits.Find(p => p.Designation == designation);

        public void ajouterProduit(Produit unProduit) => produits.Add(unProduit);

        public void supprimerProduit(int codeBarre) => produits.RemoveAll(p => p.CodeBarre == codeBarre);

        public void modifierProduit(int codeBarre, string designation, int quantité, DateTime expire, Categorie categorieProduit, double prix)
        {
            Produit p = produits.Find(x => x.CodeBarre == codeBarre);
            if (p != null)
            {
                p.Designation = designation;
                p.Quantité = quantité;
                p.Expire = expire;
                p.CategorieProduit = categorieProduit;
                p.Prix = prix;
            }
        }

        public int nbProduit() => produits.Count;

        public List<Produit> stocker() => produits.FindAll(p => p.Prix > 5000);

        public List<Produit> vendre() => produits.FindAll(p => p.CategorieProduit == Categorie.Cosmétique &&
                                                              p.Prix < 1000 &&
                                                              p.Expire.Year == 2021);

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

        public List<Chiffre> calculerChiffreAffaire()
        {
            Dictionary<Categorie, double> dict = new Dictionary<Categorie, double>();
            foreach (Produit p in produits)
            {
                if (!dict.ContainsKey(p.CategorieProduit))
                    dict[p.CategorieProduit] = 0;
                dict[p.CategorieProduit] += p.Prix * p.Quantité;
            }

            List<Chiffre> result = new List<Chiffre>();
            foreach (var kv in dict) result.Add(new Chiffre(kv.Key, kv.Value));
            return result;
        }

        public void afficher(List<Produit> liste)
        {
            foreach (Produit p in liste) p.afficher();
        }

    }
}
