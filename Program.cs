namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
        Console.WriteLine("Bienvenue dans la chasse au cerf !");
        Console.WriteLine("Arthur s'apprête à tirer, il a 5 flèches");

        int fleches = 5;
        int tirsReussis = 0;

        while (fleches > 0 && tirsReussis < 3)
        {
            Console.WriteLine($"fleche restant {fleches} : tirs reussis {tirsReussis}/3");
            Console.Write("tapez 'touche' ou 'rate' : ");

            string ecrit = Console.ReadLine();

            if (ecrit == "touche")
            {
                tirsReussis++;
                fleches--;
                Console.WriteLine("bravo tu l'as toucher !");
            }
            else if (ecrit == "rate")
            {
                fleches--;
                Console.WriteLine("raté");
            }
            else
            {
                Console.WriteLine("touche ou rater seulement");
            }
        }
        Console.WriteLine("|bilan de chasse|");
        if (tirsReussis >= 3)
        {
            Console.WriteLine($"bravo, il te reste {fleches} fleches");
        }
        else
        {
            Console.WriteLine($"nul, seulement {tirsReussis} reussi");
        }
    }
}

