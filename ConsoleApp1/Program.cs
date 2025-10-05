using ConsoleApp1;
using System;
using System.Collections.Generic;
using static ConsoleApp1.Superette;

class Program
{
    static void Main(string[] args)
    {
        Produit p1 = new Produit(1, "Gâteau Bimo", 300, new DateTime(2024, 12, 31), Categorie.Alimentaire, 150);
        Produit p2 = new Produit(2, "Robe", 50, new DateTime(2026, 6, 1), Categorie.Vestimentaire, 3500);
        Produit p3 = new Produit(3, "Shampoing", 100, new DateTime(2021, 5, 1), Categorie.Cosmétique, 900);
        Produit p4 = new Produit(4, "Détergent XYZ", 200, new DateTime(2025, 8, 15), Categorie.Détergent, 1200);
        Produit p5 = new Produit(5, "Huile", 80, new DateTime(2025, 3, 10), Categorie.Alimentaire, 7000);

        p1.afficher();

        Produit p6 = new Produit();
        p6.CodeBarre = 1001;
        p6.Designation = "Biscuit Tango";
        p6.Quantité = 250;
        p6.Expire = new DateTime(2025, 12, 31);
        p6.CategorieProduit = Categorie.Alimentaire;
        p6.Prix = 120;
        p6.afficher();


        List<Produit> listeProduits = new List<Produit> { p1, p2, p3, p4, p5 };
        Superette sup = new Superette("Monoprix", "Alger", listeProduits);

        Console.WriteLine("Produits disponibles:");
        sup.afficher(sup.Produits);
        Console.WriteLine("\nNombre total de produits : " + sup.nbProduit());
        Console.WriteLine("\n Produits chers > 5000 DA:");
        sup.afficher(sup.stocker());

        Produit recherche = sup.chercherProduit("Robe");
        if (recherche != null)
            Console.WriteLine("Produit trouve : " + recherche.Designation);
        else
            Console.WriteLine("Produit introuvable.");

        Console.WriteLine("\n Produits en promotion:");
        sup.afficher(sup.vendre());

        Console.WriteLine("\nChiffre daffaire par categorie:");
        List<Chiffre> chiffres = sup.calculerChiffreAffaire();
        foreach (var c in chiffres) Console.WriteLine(c);

        Console.WriteLine("\n Chiffre daffaire global:");
        double global = 0;
        foreach (var c in chiffres) global += c.chiffre;
        Console.WriteLine(global + " DA");

        sup.supprimerProduit(2); 
        Console.WriteLine("\nApres suppression:");
        sup.afficher(sup.Produits);

        sup.modifierProduit(3, "Shampoing Lux", 80, new DateTime(2025, 1, 1), Categorie.Cosmétique, 1000);
        Console.WriteLine("\napres modification:");
        sup.afficher(sup.Produits);


    }
}