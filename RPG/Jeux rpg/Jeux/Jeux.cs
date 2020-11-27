using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux_rpg
{
    class Jeux
    {
        public static void Jouer(Personnage monPerso)
        {
            bool victoire = true;          
            Monstres monstre = null;

            if (monPerso.niveau < 5) //Fonction qui affiche les monstres en fonction du niveau du joueur
            {
                monstre = new Monstres(Monstres.Role.Loup, "Loup-enragé");
            }
            else if (monPerso.niveau >= 5 && monPerso.niveau < 10)
            {
                monstre = new Monstres(Monstres.Role.Spider, "Mygale");
            }
            else if (monPerso.niveau >= 10)
            {
                monstre = new Monstres(Monstres.Role.Scorpion, "Scorpus");
            }
            if (monPerso.niveau >= 15)
            {
                ASCII.Victoire();
                Console.ReadKey();
                Environment.Exit(0);
            }


            while (!monstre.EstMort())
            {
                //Fonction du tour du monstre
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(monstre.image);
                monstre.Attaquer(monPerso);
                Console.WriteLine();
                Console.ReadKey(true);
                Console.Clear();
                if (monPerso.EstMort())
                {
                    victoire = false;
                    break;
                }

                //Fonction du tour du joueur
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(monPerso.image);
                monPerso.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);
                Console.Clear();
            }
           
            if (victoire)
            //Fonction de victoire du combat
            {
                Console.Clear();
                monPerso.gagnerXP(5); //Donne 5 d'XP au joueur 
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Random aleatoire = new Random();
                int chance = aleatoire.Next(1, 5);//Fonction pour donner 1 potions avec 2 chance sur 5 d'obtenir une potion
                if (chance == 1)
                {
                    monPerso.Potion_Attaque += 1; //Donne 1 potion de force au joueur
                    Console.WriteLine("Vous avez gagné une potion de force");
                    Console.WriteLine();
                }
                if (chance == 5)
                {
                    monPerso.Potion_Soin += 1; //Donne 1 potion de soin au joueur
                    Console.WriteLine("Vous avez gagné une potion de soin");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine(monPerso.Caracteristique()); //Affiche les caractéristiques du joueur 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Choix.Salle(monPerso);

            }
            else
            //Fonction de défaite 
            {
                ASCII.Defaite();
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
