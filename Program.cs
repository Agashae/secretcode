using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secretcode_premakumar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // afficher le titre
            Title();

            // afficher les règles
            Rules();








            Console.ReadLine();
        }

        // pour le titre
        static void Title()
        {
            Console.WriteLine("╔═════════════ Agashae Premakumar ═══════════╗");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║    Bienvenue dans le jeu : Secret Code     ║");
            Console.WriteLine("║                                            ║");
            // \n pour faire un retour à la ligne
            Console.WriteLine("╚════════════════════════════════════════════╝\n");

        }

        static void Rules()
        {
            Console.WriteLine("Un code secret avec 4 chiffres est généré.");
            // \n pour faire un retour à la ligne
            Console.WriteLine("À vous de le découvrir en 10 essais maximum !\n");
            Console.WriteLine("À chaque essai on reçoit un indice selon le niveau choisi\n");
            Console.WriteLine("Pour les niveaux 1 et 3 avec indices visibles :");

            // alt + 254 : https://alt-codes.fr/tables/windows/
            string carreAscii = "■";

            // couleur bleu
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write(carreAscii);
            Console.ResetColor();
            Console.Write(" : Chiffre bien placé\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(carreAscii);
            Console.ResetColor();
            Console.WriteLine(" : Chiffre correct mais mal placé");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(carreAscii);
            Console.ResetColor();
            Console.WriteLine(" : Chiffre absent\n");
            Console.WriteLine("Un exemple");
            Console.WriteLine("Le code secret est : 1234 (caché)");
            Console.WriteLine("Votre essai : 1325");
            Console.WriteLine("Indice :\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(carreAscii);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(carreAscii + carreAscii);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(carreAscii);
            Console.ResetColor();
            Console.Write("( 1 bien mis, 2 mal mis et 1 absent)\n");

            Console.WriteLine("Pour ées niveaux 2 et 4 avec des indices discrets :");
            Console.WriteLine("Un exemple");
            Console.WriteLine("Le code secret est : 5413 (caché)");
            Console.WriteLine("Votre essai : 1234");
            Console.WriteLine("Indice :");
            Console.ForegroundColor = ConsoleColor.Blue;
            // alt + 26
            Console.WriteLine("→ 0 bien placé(s), 3 de mal placé(s)\n");
            Console.ResetColor();
            Console.WriteLine("Appuie sur un touche pour commencer...");




            Console.ReadKey();

            // aller au choix du level
            LevelChoice();



        }

        static void LevelChoice()
        {
            // nettoyer la console
            Console.Clear();


            Console.WriteLine("=== SECRET CODE ===\n");

            Console.WriteLine("Choisir un niveau :");
            Console.WriteLine(" Tapez 1 pour débutant (1 à 6, sans doublons, indices visibles)");
            Console.WriteLine(" Tapez 2 pour l'intermédiaire (1 à 6, sans doublons, indices discrets)");
            Console.WriteLine(" Tapez 3 pour l'avancé (1 à 8, avec doublons, indices visibles)");
            Console.WriteLine(" Tapez 4 pour l'expert (1 à 9, avec doublons, indices discrets)");
            Console.WriteLine("Votre choix(1 - 4) :");


        }

    }
}
