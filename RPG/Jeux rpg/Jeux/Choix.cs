using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux_rpg
{
    class Choix
    {
        public static void Salle(Personnage monPerso)
        //Fonction qui s'affiche quand un monstre est mort pour savoir si on veut utiliser une potion ou quitter le jeux
        {
            bool suivant = false;

            while (!suivant)
                {
                    Console.WriteLine("Utiliser une potion de Soin/Force ? (S/A)");
                    Console.WriteLine("Salle suivante ? (O/N)");
                    Console.WriteLine();
                    string saisie = Console.ReadLine().ToUpper();
                    if (saisie == "O")
                    {
                        suivant = true;
                        Jeux.Jouer(monPerso);
                    }
                    else if (saisie == "N")
                    {
                        Environment.Exit(0);
                    }
                    else if (saisie == "S")
                    {
                        if (monPerso.Potion_Soin > 0)//Vérifie si on a une potion de soin dans l'inventaire du perso
                        {
                            monPerso.PV += 10; //Augmente de 10 PV le perso

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Potion de soin utilisé, vous avez gagné 10 PV");
                            Console.WriteLine();
                            monPerso.Potion_Soin -= 1;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(monPerso.Caracteristique());
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine();
                        }
                        else//Si on a pas de potion on affiche un message  
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Vous ne possédez pas de potion de soin");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }

                    }
                    else if (saisie == "A") //Même que la potion de soin pour la potion de force
                    {
                        if (monPerso.Potion_Attaque > 0)
                        {
                            monPerso.degatsMin += 10;
                            monPerso.degatsMax += 10;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Potion de force utilisé, vous avez gagné 10 d'attaque");
                            monPerso.Potion_Attaque -= 1;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(monPerso.Caracteristique());
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Vous ne possédez pas de potion de force");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }
                    }
                }

        }
    }
}
