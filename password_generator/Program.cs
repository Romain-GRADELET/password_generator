using FormationCS;
using System;
using System.ComponentModel;
using System.Security;

namespace generateur_mot_de_passe
{
    class Program
    {

        static void Main(string[] args)
        {
            const int NB_MOTS_DE_PASSE = 10;

            // 1 - Demander la longueur du mot de passe (Demander nombre) int longueur mot de passe = ...
            int longueurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe :");

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caractereSpeciaux = "#&+-!/";
            string alphabet;
            string motDePasse = "";


            Console.WriteLine();
            int choixAlphabet = outils.DemanderNombreEntre("Vous voulez un mot de passe avec:\n" +
                "1 - Uniquement des caractères minuscule\n" +
                "2 - Des caractères minuscules et majuscules\n" +
                "3 - Des caractères et des chiffres\n" +
                "4 - Des caractères, des chiffres et des caractères spéciaux\n" +
                "Votre choix : ", 1, 4);
            
            if (choixAlphabet == 1 ) 
            {
                alphabet = minuscules;
            }
            else if (choixAlphabet == 2 )
            {
                alphabet = minuscules + majuscules;
            }
            else if (choixAlphabet == 3 )
            {
                alphabet = minuscules + majuscules + chiffres;
            }
            else
            {
                alphabet = minuscules + majuscules + chiffres + caractereSpeciaux;
            }

            int longueurAlphabet = alphabet.Length;
            Random rand = new Random();

            //Console.WriteLine(alphabet[index]);
            Console.WriteLine();
            for (int j = 0; j < NB_MOTS_DE_PASSE; j++)
            {
                motDePasse = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];
                }
                Console.WriteLine("mot de passe N°" + (j+1) +  " : " + motDePasse);
            }
        }
    }
}