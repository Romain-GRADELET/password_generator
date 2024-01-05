using System;
using System.ComponentModel;

namespace generateur_mot_de_passe
{
    class Program
    {
        static int DemanderNombrePositifNonNul (string question)
        {
            /*int nombre = DemanderNombre(question);
            if (nombre > 0) 
            {
                return nombre;
            }
            Console.WriteLine("ERREUR: Veuillez renseigner un nombre supérieur à 0");

            return DemanderNombrePositifNonNul(question);*/

            return DemanderNombreEntre(question, 1, int.MaxValue);
        }



        static int DemanderNombreEntre (string question, int min, int max)
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

        static int DemanderNombre (string question)
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


        static void Main(string[] args)
        {
            // 1 - Demander la longueur du mot de passe (Delmander nombre) int longuieur mot de passe = ...
            int longueurMotDePasse = DemanderNombre("Longueur du mot de passe :");

            // 2 - Alphabet "abcd1234..."
            // 3 - Comment choisir un caractère aléatoire
            // 4 - Générer le mot de passe
            // 5 - Améliorations : Choix alphabet

        }
    }
}