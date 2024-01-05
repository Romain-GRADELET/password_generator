using FormationCS;
using System;
using System.ComponentModel;

namespace generateur_mot_de_passe
{
    class Program
    {

        static void Main(string[] args)
        {
            // 1 - Demander la longueur du mot de passe (Delmander nombre) int longuieur mot de passe = ...
            int longueurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe :");

            // 2 - Alphabet "abcd1234..."
            // 3 - Comment choisir un caractère aléatoire

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string alphabet = minuscules;
            string motDePasse = "";
            int longueurAlphabet = alphabet.Length;
            Random rand = new Random();

            //Console.WriteLine(alphabet[index]);
            for (int i = 0; i < longueurMotDePasse; i++)
            {
                int index = rand.Next(0, longueurAlphabet);
                motDePasse += alphabet[index];
            }
            Console.WriteLine(motDePasse);

            // 4 - Générer le mot de passe
            // 5 - Améliorations : Choix alphabet

        }
    }
}