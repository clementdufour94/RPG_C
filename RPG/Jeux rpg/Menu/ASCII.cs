using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux_rpg
{
    class ASCII
    { 
        
        public static void RPG()
        //Fonction ASCCI qui s'affiche en début de jeux 
        {
            Console.WriteLine("                                            _____    _____     _____ ");
            Console.WriteLine("                                           |  __ \\  |  __ \\   / ____|");
            Console.WriteLine("                                           | |__) | | |__) | | |  __ ");
            Console.WriteLine("                                           |  _  /  |  ___/  | | |_ |");
            Console.WriteLine("                                           | | \\ \\  | |      | |__| |");
            Console.WriteLine("                                           |_|  \\_\\ |_|       \\_____|");

        }

        
        public static void Victoire()
        //Fonction ASCCI qui s'affiche lors de la victoire (niveau > 15)
        {
            Console.Clear();
            Console.WriteLine("                        __      __  _          _             _               ");
            Console.WriteLine("                        \\ \\    / / (_)        | |           (_)              ");
            Console.WriteLine("                         \\ \\  / /   _    ___  | |_    ___    _   _ __    ___ ");
            Console.WriteLine("                          \\ \\/ /   | |  / __| | __|  / _ \\  | | | '__|  / _ \\");
            Console.WriteLine("                           \\  /    | | | (__  | |_  | (_) | | | | |    |  __/");
            Console.WriteLine("                            \\/     |_|  \\___|  \\__|  \\___/  |_| |_|     \\___|");
            Console.ForegroundColor = ConsoleColor.White;
            

        }
        public static void Defaite()
        //Fonction ASCCI qui s'affiche lors de la défaite
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("                            _____            __           _   _          ");
            Console.WriteLine("                           |  __ \\          / _|         (_) | |         ");
            Console.WriteLine("                           | |  | |   ___  | |_    __ _   _  | |_    ___ ");
            Console.WriteLine("                           | |  | |  / _ \\ |  _|  / _` | | | | __|  / _ \\");
            Console.WriteLine("                           | |__| | |  __/ | |   | (_| | | | | |_  |  __/");
            Console.WriteLine("                           |_____/   \\___| |_|    \\__,_| |_|  \\__|  \\___|");            

        }
        public static void Texte()
        //Fonction ASCCI qui s'affiche lors du choix du nom
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("              .______     ______   .__   __. .__   __.  _______      ______  __    __       ___      .__   __.   ______  _______     __  ");
            Console.WriteLine("              |   _  \\   /  __  \\  |  \\ |  | |  \\ |  | |   ____|    /      ||  |  |  |     /   \\     |  \\ |  |  /      ||   ____|   |  | ");
            Console.WriteLine("              |  |_)  | |  |  |  | |   \\|  | |   \\|  | |  |__      |  ,----'|  |__|  |    /  ^  \\    |   \\|  | |  ,----'|  |__      |  | ");
            Console.WriteLine("              |   _  <  |  |  |  | |  . `  | |  . `  | |   __|     |  |     |   __   |   /  /_\\  \\   |  . `  | |  |     |   __|     |  | ");
            Console.WriteLine("              |  |_)  | |  `--'  | |  |\\   | |  |\\   | |  |____    |  `----.|  |  |  |  /  _____  \\  |  |\\   | |  `----.|  |____    |__| ");
            Console.WriteLine("              |______/   \\______/  |__| \\__| |__| \\__| |_______|    \\______||__|  |__| /__/     \\__\\ |__| \\__|  \\______||_______|   (__) ");
            Console.ReadKey();
            Console.Clear();

        }



    }
}
