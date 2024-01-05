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
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }

        public static int DemanderNombreEntre(string question, int min, int max)
        {
            while (true)
            {
                int nombre = DemanderNombre(question);
                if ((nombre >= min) && (nombre <= max))
                {
                    // Valide
                    return nombre;
                }
                Console.WriteLine("ERREUR: Le nombre doit être compris entre " + min + " et " + max);
            }

        }

        public static int DemanderNombre(string question)
        {
            while (true)
            {
                // Poser la question
                Console.Write(question);
                // Récupérer la réponse
                string reponse = Console.ReadLine();
                // Convertir
                // Gérer l'erreur de conversion
                try
                {
                    int passwordLength = int.Parse(reponse);
                    return passwordLength;
                }
                catch
                {
                    Console.WriteLine("ERREUR: Veuillez rentrer un nombre valide");
                }
                // Boucler tant que l'on a pas reçu une réponse valide (qui contient que des chiffres)
            }
        }


    }
}
