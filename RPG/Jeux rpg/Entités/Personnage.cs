using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux_rpg
{
     class Personnage : Entite
    {
        public int niveau;
        private int XP;
        public int Potion_Soin;
        public int Potion_Attaque;
        public enum Role { Guerrier, Archer, Sorcière }

       

        

   
        public Personnage( Role role,string nom) : base(nom)
        //Constructeur des personnages 
        {
            
            
            
           
            switch (role)
            {
                case Role.Guerrier:
                    this.nom = nom;
                    PV = 120;
                    degatsMin = 10;
                    degatsMax = 15;
                    niveau = 1;
                    XP = 0;
                    Potion_Soin = 0;
                    Potion_Attaque = 1;
                    image = "   ,   A           {}" + Environment.NewLine +
                        "  / \\, | ,        .--." + Environment.NewLine +
                        " |    =|= >      /.--.\\" + Environment.NewLine +
                        "  \\ /` | `       |====|" + Environment.NewLine +
                        "   `   |         |`::`|  " + Environment.NewLine +
                        "       |     .-;`\\..../`;_.-^-._" + Environment.NewLine +
                        "      /\\\\/  /  |...::..|`   :   `|" + Environment.NewLine +
                        "      |:'\\ |   /'''::''|   .:.   |" + Environment.NewLine +
                        "       \\ /\\;-,/\\   ::  |..:::::..|" + Environment.NewLine +
                        "       |\\ <` >  >._::_.| ':::::' |" + Environment.NewLine +
                        "       | `\"\"`  /   ^^  |   ':'   |" + Environment.NewLine +
                        "       |       |       \\    :    /" + Environment.NewLine +
                        "       |       |        \\   :   / " + Environment.NewLine +
                        "       |       |___/\\___|`-.:.-`" + Environment.NewLine +
                        "       |        \\_ || _/    `" + Environment.NewLine +
                        "       |        <_ >< _>" + Environment.NewLine +
                        "       |        |  ||  |" + Environment.NewLine +
                        "       |        |  ||  |" + Environment.NewLine +
                        "       |       _\\.:||:./_" + Environment.NewLine +
                        "       |      /____/\\____\\";
                    break;

                case Role.Archer:
                    this.nom = nom;
                    PV = 105;
                    degatsMin = 15;
                    degatsMax = 20;
                    niveau = 1;
                    XP = 0;
                    Potion_Soin = 0;
                    Potion_Attaque = 0;
                    image = "            /`.                      " + Environment.NewLine +
                        "           /   :.                        " + Environment.NewLine +
                        "          /     \\                      " + Environment.NewLine +
                        "       ,;/,      ::              " + Environment.NewLine +
                        "   ___:c/.(      ||                     " + Environment.NewLine +
                        " ,'  _|:)>>>--,-'B)>                    " + Environment.NewLine +
                        "(  '---'\\--'` _,'||                     " + Environment.NewLine +
                        " `--.    \\ ,-'   ;;                   " + Environment.NewLine +
                        "     |    \\|    //                  " + Environment.NewLine +
                        "     |     \\   ;'                  " + Environment.NewLine +
                        "     |_____|\\,'                          " + Environment.NewLine +
                        "     :     :                             " + Environment.NewLine +
                        "     |  ,  |                             " + Environment.NewLine +
                        "     | : \\ :                             " + Environment.NewLine +
                        "     | | : :                             " + Environment.NewLine +
                        "     | | | |                            " + Environment.NewLine +
                        "     | | |_`.                   " + Environment.NewLine +
                        "     '--`                             ";




                    break;

                case Role.Sorcière:
                    this.nom = nom;
                    PV = 80;
                    degatsMin = 10;
                    degatsMax = 25;
                    niveau = 1;
                    XP = 0;
                    Potion_Soin = 2;
                    Potion_Attaque = 0;
                    image = "                      \'/" + Environment.NewLine +
                        "                    -= * =-" + Environment.NewLine +
                        "                .-\" -. / #,_" + Environment.NewLine +
                        "               / /\\_ \\  `#|\\" + Environment.NewLine +
                        "              / /')'\\ \\  /#/" + Environment.NewLine +
                        "             (  \\ = /  )/\\/#" + Environment.NewLine +
                        "              )  ) (  (/  \\" + Environment.NewLine +
                        "             (_.;`\"`;._)  |" + Environment.NewLine +
                        "            / (  \\|/  )   |" + Environment.NewLine +
                        "           /  /\\-'^'-/\\   |" + Environment.NewLine +
                        "          |  \\| )=@=(  \\_/" + Environment.NewLine +
                        "          |  /\\/     \\" + Environment.NewLine +
                        "          | /\\ \\      ;" + Environment.NewLine +
                        "          \\(// /'     |" + Environment.NewLine +
                        "             \\/       |" + Environment.NewLine +
                        "              |     / /" + Environment.NewLine +
                        "              | ___/\\_\\" + Environment.NewLine +
                        "              |/ / \\ \\|" + Environment.NewLine +
                        "             / | | | | \\" + Environment.NewLine +
                        "             \\_|/   \\|_/" + Environment.NewLine +
                        "              / \\`-'/ \\" + Environment.NewLine +
                        "              `-'   '-`";
                    break;


            }




        }

        public void gagnerXP(int XP)
        //Fonction qui augmente le niveau en fonction du nombre d'expérience 
        {
            this.XP += XP;
            while (this.XP >= experienceRequise())
            //Lors du passage au niveau supérieur, les PV, les dégats ainsi que le niveau est augmenté 
            {
                niveau += 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bravo : Vous avez atteint le niveau " + niveau + "!");
                

                PV += 10;
                degatsMin += 3;
                degatsMax += 3;
            }


        }

        public double experienceRequise()
        //Fonction qui calcule le nombre d'expeérience requis pour passer au niveau supérieur (c'est la même que dans pokemon )
        {
            return Math.Round(4 * (Math.Pow(niveau, 3) / 5));


        }
        

        public string Caracteristique()
        //Affiche les caractéristique du joueur 
        {
            return this.nom + "\n" +
                "Points de vie : " + PV + "\n" +
                "Niveau :" + niveau + "\n" +
                "Points d'expérience : (" + XP + "/" + experienceRequise() + ")\n" +
                "Dégats : [" + degatsMin + ";" + degatsMax + "]\n" +
                "Potion de soin : " + Potion_Soin + "\n" +
                "Potion d'attaque : " + Potion_Attaque;

        }



    }
}
