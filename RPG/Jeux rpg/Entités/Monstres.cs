using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux_rpg
{
    class Monstres : Entite
    {
        public enum Role { Scorpion, Loup, Spider }
        
        

        

        

        public Monstres(Role r, string nom) : base(nom)
        //Constructeur des monstres 
        {
            

            switch (r)
            {
                case Role.Scorpion:
                    this.nom = nom;
                    PV = 100;
                    degatsMin = 8;
                    degatsMax = 13;
                    image = " ___    ___" + Environment.NewLine +
                            "( _<    >_ )" + Environment.NewLine +
                            "//        \\\\" + Environment.NewLine +
                            "\\\\___..___//" + Environment.NewLine +
                            " `-(    )-'" + Environment.NewLine +
                            "   _|__|_" + Environment.NewLine +
                            "  /_|__|_\\" + Environment.NewLine +
                            "  /_|__|_\\" + Environment.NewLine +
                            "  /_\\__/_\\" + Environment.NewLine +
                            "   \\ || /  _)" + Environment.NewLine +
                            "     ||   ( )" + Environment.NewLine +
                            "     \\\\___//" + Environment.NewLine +
                            "      `---'";




                    break;
                case Role.Loup:
                    this.nom = nom;
                    PV = 100;
                    degatsMin= 1;
                    degatsMax = 5;
                    image = "        _" + Environment.NewLine +
                        "       / \\      _-'" + Environment.NewLine +
                        "     _/|  \\-''- _ /" + Environment.NewLine +
                        "__-' { |          \\" + Environment.NewLine +
                        "    /             \\" + Environment.NewLine +
                        "    /       \"o.  | o }" + Environment.NewLine +
                        "    |            \\ ;" + Environment.NewLine +
                        "                  '," + Environment.NewLine +
                        "       \\_         __\\" + Environment.NewLine +
                        "         ''-_    \\.//" + Environment.NewLine +
                        "           / '-____'" + Environment.NewLine +
                        "          /" + Environment.NewLine +
                        "        _'" + Environment.NewLine +
                        "      _-'" + Environment.NewLine;
                        
                

                    break;
                case Role.Spider:
                    this.nom = nom;
                    PV = 130;
                    degatsMin = 4;
                    degatsMax = 8;
                    image = "              (" + Environment.NewLine +
                        "               )" + Environment.NewLine +
                        "              (" + Environment.NewLine +
                        "        /\\  .-\"\"\" -.  /\\" + Environment.NewLine +
                        "       //\\\\/  ,,,  \\//\\\\" + Environment.NewLine +
                        "       |/\\| ,;;;;;, |/\\|" + Environment.NewLine +
                        "       //\\\\\\;-\"\"\" -;///\\\\" + Environment.NewLine +
                        "      //  \\/   .   \\/  \\\\" + Environment.NewLine +
                        "     (| ,-_| \\ | / |_-, |)" + Environment.NewLine +
                        "       //`__\\.-.-./__`\\\\" + Environment.NewLine +
                        "      // /.-(() ())-.\\ \\\\" + Environment.NewLine +
                        "     (\\ |)   '---'   (| /)" + Environment.NewLine +
                        "      ` (|           |) `" + Environment.NewLine +
                        "        \\)           (/";



                    break;



            }
        }

    }
}
