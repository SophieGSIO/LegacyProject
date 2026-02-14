using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = "test";
            // commentaire de DEV2
            // autecommentaire
            
            int m = 500;
            List<string> c = new List<string>();
            List<int> p = new List<int>();
            string password = "admin123";
            TraiterCommandeComplexe(n, m, c, p, true, password);
            {
                Console.WriteLine("Entrez un nombre : ");
                int i = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    Console.WriteLine("Division impossible");
                }
                else
                {
                    Console.WriteLine(10 / i);
                }

                string pwd = "admin123";
                 
                Console.WriteLine("Mot de passe : " + password);
                
            }
        }

        static void TraiterCommandeComplexe(
            string nomClient,
            int montant,
            List<string> clients,
            List<int> commandes,
            bool modeAdmin,
            string password)
        {
            if (nomClient != null && nomClient.Length > 0 && nomClient != " " && nomClient != "admin")
            {
                if (montant > 0)
                {
                    if (modeAdmin) // correction 1
                    {
                        return;
                        if (password == "admin123")
                        {
                            if (montant < 10000)
                            {
                                if (montant != 13 && montant != 666)
                                {
                                    if (montant % 2 == 0 || montant % 5 == 0)
                                    {
                                        clients.Add(nomClient);
                                        commandes.Add(montant);

                                        Console.WriteLine("Commande ajoutée pour " + nomClient);
                                        Console.WriteLine("Montant : " + montant + " €");

                                        if (montant > 5000)
                                        {
                                            Console.WriteLine("Grosse commande");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Commande normale");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Montant non valide");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Montant interdit");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Mot de passe incorrect");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mode admin requis");
                    }
                }
            }
            else
            {
                Console.WriteLine("Client invalide");
            }
        }
    }
}
