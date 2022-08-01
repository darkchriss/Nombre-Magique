using System;

namespace Nombre_Magique_V._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int VAL_MIN = 1;
            const int VAL_MAX = 10;

            Random random = new Random();
            int nombreMagique = random.Next(VAL_MIN, VAL_MAX);
            // génération du nombre Magique


            int nombreDeVie = 3;
            while (nombreDeVie > 0)
            {
                Console.Write("Devinez le nombre magique compris entre " + VAL_MIN + " et " + VAL_MAX + " (il vous reste " + nombreDeVie + " vie ):");
                String résultat = Console.ReadLine();

                int nombreUtilisateur = 0;
                if (int.TryParse(résultat, out nombreUtilisateur))
                { // La conversion s'est bien passé
                    if (nombreUtilisateur < VAL_MIN ||nombreUtilisateur > VAL_MAX)
                    {
                        Console.WriteLine("ERREUR : Vous devez saisir un nombre compris entre " + VAL_MIN + " et " + VAL_MAX);
                    }
                    else
                    {

                        if (nombreUtilisateur < nombreMagique)
                        {
                            Console.WriteLine("Le nombre Magique est plus grand.");
                        }
                        else if (nombreUtilisateur > nombreMagique)
                        {
                            Console.WriteLine("Le nombre Magique est plus petit.");
                        }
                        else
                        {
                            // Egalité le joueur à gagner
                            Console.WriteLine("Bravo ! Vous avez trouvé le nombre magique !");
                            break;
                        }
                        nombreDeVie--;
                    }
                }
                else
                { // Erreur de la convertion
                    Console.WriteLine("ERREUR : Vous devez saisir un nombre.");
                }
                Console.WriteLine("");
            }
            if (nombreDeVie == 0)
            {
                Console.WriteLine("Désolé vous avez perdu. Le nombre magique était " + nombreMagique);
            }
        }
    }
}
