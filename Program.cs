using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Produit p1 = new Produit(1, "Gâteau Bimo", 300, new DateTime(2024, 12, 31), Categorie.Alimentaire, 150);
        Produit p2 = new Produit(2, "Robe", 50, new DateTime(2026, 6, 1), Categorie.Vestimentaire, 3500);
        Produit p3 = new Produit(3, "Shampoing", 100, new DateTime(2021, 5, 1), Categorie.Cosmétique, 900);
        Produit p4 = new Produit(4, "Détergent XYZ", 200, new DateTime(2025, 8, 15), Categorie.Détergent, 1200);
        Produit p5 = new Produit(5, "Huile", 80, new DateTime(2025, 3, 10), Categorie.Alimentaire, 7000);

        List<Produit> listeProduits = new List<Produit> { p1, p2, p3, p4, p5 };
        Superette superette = new Superette("Monoprix", "Alger", listeProduits);

        Console.WriteLine("=== Produits disponibles ===");
        superette.afficher(superette.Produits);

        Console.WriteLine("\n=== Produits chers (> 5000 DA) ===");
        superette.afficher(superette.stocker());

        Console.WriteLine("\n=== Produits en promotion ===");
        superette.afficher(superette.vendre());

        Console.WriteLine("\n=== Chiffre d'affaire par catégorie ===");
        List<Chiffre> chiffres = superette.calculerChiffreAffaire();
        foreach (var c in chiffres) Console.WriteLine(c);

        Console.WriteLine("\n=== Chiffre d'affaire global ===");
        double global = 0;
        foreach (var c in chiffres) global += c.chiffre;
        Console.WriteLine(global + " DA");
    }
}
