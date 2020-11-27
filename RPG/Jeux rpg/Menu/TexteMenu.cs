using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux_rpg
{
    class TexteMenu
    {
        public static void Info()
        //Fonction qui affiche les informations du jeux 
        {
            Console.Clear();
            Console.WriteLine("Ceci est un  jeux  tour  par tour  ou  vous vous battez contre  des  monstres.  ");
            Console.WriteLine("Vous pouvez choisir une classe entre les différents type d'héros qui existent.  ");
            Console.WriteLine("Chaque  héro  possède  des  points de  vie,  une  attaque minimum  et  maximum  ");
            Console.WriteLine("( les  dégats  sont  compris  entre l'attaque minimum et maximum ), un niveau   ");
            Console.WriteLine("qui est calculé sur la base de pokemon.");
            Console.WriteLine("gagnez 5 lvl. Vous  avez aussi la possibilité d'utilisé une potion de soin qui");
            Console.WriteLine("vous fera gagner 10 PV et une potion de force qui vous fera gagner 10 d'attaque");
            Console.WriteLine("Vous gagnez le jeux si vous atteignez les 15 niveaux.");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Menu.menu();
        }
        public static void Nom()
        {
            Console.WriteLine();
            Console.WriteLine("Quel est votre nom?");
            Console.WriteLine();

        }
    }
}
