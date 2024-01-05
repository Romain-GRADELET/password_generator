using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {

        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR: le nombre doit être positif et non nul");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnalise = null)
        {
            while (true)
            {
                int nombre = DemanderNombre(question);
                if ((nombre >= min) && (nombre <= max))
                {
                    // Valide
                    return nombre;
                }
                if (messageErreurPersonnalise == null)
                {
                    Console.WriteLine("ERREUR: Le nombre doit être compris entre " + min + " et " + max);
                }
                else
                {
                    Console.WriteLine(messageErreurPersonnalise);
                }
                Console.WriteLine();
            }

        }

        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                // Conversion et gestion de l'erreur de conversion
                try
                {
                    int passwordLength = int.Parse(reponse);
                    return passwordLength;
                }
                catch
                {
                    Console.WriteLine("ERREUR: Veuillez rentrer un nombre valide");
                    Console.WriteLine();
                }
                // Boucler tant que l'on a pas reçu une réponse valide (qui contient que des chiffres)
            }
        }


    }
}
