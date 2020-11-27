using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux_rpg
{
    class Menu
    {
        public static void menu()
        //Fonction qui affiche le menu avec un switch pour choisir sa classe
        {


            Console.ForegroundColor = ConsoleColor.DarkBlue;

            ASCII.RPG();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("Choisis ta classe : ");
            Console.WriteLine();
            Console.WriteLine("1. Guerrier : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              Points de vie: 120 \n              Dégats minimum; Dégats maximum: 10; 15 \n              Potion de soin: 0 \n              potion de force : 1");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("2. Sorcière : ");         
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              Points de vie: 80 \n              Dégats minimum; Dégats maximum: 10; 25 \n              Potion de soin: 2 \n              potion de force : 0");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3. Archer : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              Points de vie: 105 \n              Dégats minimum; Dégats maximum: 10; 20 \n              Potion de soin: 0 \n              potion de force : 0");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4. A propos");
            Console.WriteLine();
            Console.WriteLine("5. Quitter");
            Console.WriteLine();
            

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Vous avez choisis Guerrier !");
                    TexteMenu.Nom();
                    string nom = Console.ReadLine();
                    Console.WriteLine();
                    ASCII.Texte();
                    Personnage p = new Personnage(Personnage.Role.Guerrier, nom);
                    Jeux.Jouer(p);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Vous avez choisis Sorcier !");
                    TexteMenu.Nom();
                    string nom1 = Console.ReadLine();
                    Console.WriteLine();
                    ASCII.Texte();
                    Personnage p1 = new Personnage(Personnage.Role.Sorcière, nom1);
                    Jeux.Jouer(p1);

                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Vous avez choisis Archer !");
                    TexteMenu.Nom();
                    string nom2 = Console.ReadLine();
                    Console.WriteLine();
                    ASCII.Texte();
                    Personnage p2 = new Personnage(Personnage.Role.Archer, nom2);
                    Jeux.Jouer(p2);
                    break;

                case "4":

                    TexteMenu.Info();                
                    break;
                case "5":
                    break;
            }
        }
    }
}
