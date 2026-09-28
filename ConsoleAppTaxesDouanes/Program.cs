using System;

namespace ConsoleAppTaxeDouane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pieceOr;
            decimal taxes = 0;
            int zone;

            Console.WriteLine("Saisir le prix de base de l'arme (en pièces d'or)");
            pieceOr = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Choisir la zone de provenance de la forge");
            Console.WriteLine();
            Console.WriteLine("1 - Forges de la Capitale (Taxe royale standard : 20%)");
            Console.WriteLine("2 - Ateliers des Nains des Montagnes (Taxe minière intermédiaire : 10%)");
            Console.WriteLine("3 - Port des Contrebandiers (Taxe réduite d'importation : 5,5%)");
            Console.WriteLine("4 - Terres Sacrées du Temple (Taxe d'artisanat béni : 2,1%)");

            zone = Convert.ToInt32(Console.ReadLine());

            if (zone < 1 || zone > 4)
            {
                Console.WriteLine("Saisissez un nombre entre 1 et 4");
                return;
            }

            if (zone == 1)
            {
                taxes = pieceOr * 0.20m;
            }
            else if (zone == 2)
            {
                taxes = pieceOr * 0.10m;
            }
            else if (zone == 3)
            {
                taxes = pieceOr * 0.055m;
            }
            else if (zone == 4)
            {
                taxes = pieceOr * 0.021m;
            }

            decimal total = pieceOr + taxes;

            Console.WriteLine($"Vous devez payer : {total} pièces d'or.");
        }
    }
}
