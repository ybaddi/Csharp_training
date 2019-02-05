
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;



// Exercice
// On se propose d'écrire un programme permettant de calculer 
//l'impôt d'un contribuable. On se place dans le cas simplifié d'un
// contribuable n'ayant que son seul salaire à déclarer : 

// • on calcule le nombre de parts du salarié nbParts=nbEnfants/2 +1 s'il n'est pas marié, nbEnfants/2+2 s'il est marié, où
// nbEnfants est son nombre d'enfants.
// • s'il a au moins trois enfants, il a une demi-part de plus
// • on calcule son revenu imposable R = 0.72 * S où S est son salaire annuel
// • on calcule son coefficient familial QF = R / nbParts
// • on calcule son impôt I.Considérons le tableau suivant : 

//    12620.0 0 0
//    13190 0.05 631
//    15640 0.1 1290.5
//    24740 0.15 2072.5
//    31810 0.2 3309.5
//    39970 0.25 4900
//    48360 0.3 6898.5
//    55790 0.35 9316.5
//    92970 0.4 12106
//    127860 0.45 16754.5
//    151250 0.50 23147.5
//    172040 0.55 30710
//    195000 0.60 39312
//    0 0.65 49062 

// Chaque ligne a 3 champs. Pour calculer l'impôt I, on recherche la première ligne où QF<=champ1. Par exemple, si QF=23000 on
// trouvera la ligne
//  24740 0.15 2072.5
// L'impôt I est alors égal à 0.15*R - 2072.5*nbParts. Si QF est tel que la relation QF<=champ1 n'est jamais vérifiée, alors ce sont les
// coefficients de la dernière ligne qui sont utilisés.Ici :
//  0 0.65 49062
// ce qui donne l'impôt I=0.65*R - 49062*nbParts. 

namespace Csharp.Day2
{
    class Program2
    {
        static void Main1(string[] args)
        {
            decimal[] limites = new decimal[]
                {12620.0M, 13190M ,5640M ,24740M ,1810M ,39970M ,48360M,55790M,92970M,27860M,151250M,172040M,195000M,0M};

            decimal[] Coef = new decimal[]
            {0M,0.05M,0.1M,0.15M,0.2M,0.25M,0.3M,0.35M,0.4M,0.45M,0.50M,0.55M,0.60M,0.65M };
            // matrice 3D

            /*decimal[,,] limites3D = new decimal[,,]
               { {12620.0M, 13190M ,5640M ,24740M ,1810M ,39970M ,48360M,55790M,92970M,27860M,151250M,172040M,195000M,0M },
               { },{ } }; */
            string reponse = null;
            bool OK = false;

            while (!OK)
            {
                Console.WriteLine("etes-vous marie(e) [O/N]?");
                reponse = Console.ReadLine().Trim().ToLower();
                if (reponse != "o" && reponse != "n")
                {
                    Console.WriteLine("reponse incorrect, la reponse doit etre O/N");
                }
                else
                {
                    OK = true;
                }
            }
            bool Marie = reponse == "o";
            Console.WriteLine("is marie {0} ", Marie);

            OK = false;
            int NbEnfant = 0;
            while (!OK)
            {
                Console.WriteLine("votre nombre d'enfant :");
                reponse = Console.ReadLine();
                try
                {
                    NbEnfant = int.Parse(reponse);
                    if (NbEnfant >= 0) OK = true;
                    else Console.WriteLine("reponse incorrect, try again la reponse doit etre un unsigned integer");
                }
                catch(Exception)
                {
                    Console.WriteLine("reponse incorrect, la reponse doit etre un unsigned integer");
                }

            }


            OK = false;
            decimal Salaire = 0M;
            while (!OK)
            {
                Console.WriteLine("votre salaire :");
                reponse = Console.ReadLine();
                try
                {
                    Salaire = decimal.Parse(reponse);
                    if (Salaire >= 0) OK = true;
                    else Console.WriteLine("reponse incorrect, try again la reponse doit etre un unsigned integer");
                }
                catch (Exception)
                {
                    //Console.WriteLine("reponse incorrect, la reponse doit etre un unsigned integer");
                    Console.Error.WriteLine("Reponse incerrect");
                }

            }

            // cacule du nombre de parts
            decimal NbParts;
            if (Marie) NbParts = (decimal)NbEnfant / 2 + 2;
            else NbParts = (decimal)NbEnfant / 2 + 1; ;
            if (NbEnfant >=3) NbParts += 0.5M;

            // revenu imposable 
            decimal Revenu;
            Revenu  = 0.7M * Salaire;

            // Quostion final
            decimal QF = Salaire / NbParts;

            // recherche de la tranche d'import correspond a QF
            int i = 0;
            int impot = 0;
            int Tranche = limites.Length;
            limites[Tranche - 1] = QF;
            while (QF > limites[i]) i++;

            impot = (int)(i * 0.05M * Revenu - Coef[i] * NbParts);
            

            Console.WriteLine("impot a payer : {0}", impot);

            Console.ReadLine();


        }
    }
}