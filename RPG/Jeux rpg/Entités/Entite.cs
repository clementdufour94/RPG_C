using System;
using System.Collections.Generic;
using System.Text;

namespace Jeux_rpg
{
    public abstract class Entite
    //Constructeur des Entités 
    {
        protected string nom;
        protected bool estMort = false;
        public int PV;
        public int degatsMin;
        public int degatsMax;
        public string image;
        protected Random random = new Random();

        public Entite(string nom)
        {
            this.nom = nom;
        }

        public void Attaquer(Entite uneEntite)
        {
            int degats = random.Next(degatsMin, degatsMax); //Prend un nombre aléatoire compris entre l'atq minimum et l'atq maximum

            uneEntite.PerdrePointsDeVie(degats);
            Console.WriteLine(this.nom + " (" + this.PV + ")" + " attaque : " + uneEntite.nom); 
            Console.WriteLine(uneEntite.nom + " a perdu " + degats + " points de vie "); //Affiche le nombre de Pv perdu
            Console.WriteLine("Il reste " + uneEntite.PV + " points de vie à " + uneEntite.nom); //Affiche le nombre de Pv restant
            if (uneEntite.estMort)
            {
                Console.WriteLine();
                Console.WriteLine(uneEntite.nom + " est mort");

            }

        }

        protected void PerdrePointsDeVie(int PV)
        //Fonction pour retirer des Pv à l'entité
        {
            this.PV -= PV;
            if(this.PV <= 0)// si les pv de l'entité sont négatifs alors on remet les pv à 0 pour l'affichage
            {
                this.PV = 0;
                estMort = true;

            }

        }
        public bool EstMort()
        {
            return this.estMort;
        }

       


    }
}
