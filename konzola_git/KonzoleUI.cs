using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzola_git
{
    internal class KonzoleUI
    {
        public static void Menu()
        {
            Evidence evidence = new Evidence();
            bool run = true;
            while (run)
            {
                Console.Write("===== ÚTULEK PRO ZVÍŘATA =====\r\n1) Přidat zvíře\r\n2) Vypsat celý seznam\r\n3) Upravit záznam (beze změny stavu adopce)\r\n4) Smazat záznam\r\n5) Adoptovat zvíře\r\n0) Konec\r\nVolba: ");
                string user_volba = Console.ReadLine();
                Console.WriteLine();
                if (int.TryParse(user_volba, out int volba))
                {
                    switch (user_volba)
                    {
                        case "1":
                            evidence.PridatZvire();
                            break;

                        case "2":
                            evidence.Vypis();
                            break;
                        case "3":
                            evidence.Uprava();
                            break;
                        case "4":
                            evidence.Smazat();
                            break;
                        case "5":
                            evidence.Adoptovat();
                            break;
                        case "0":
                            Console.WriteLine("Ukončuji program. Děkujeme za využívání naší aplikace.");
                            run = false;
                            break;
                        default:
                            Console.WriteLine("Vybrals nějakej BS.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Neplatná volba.");
                }
                Console.WriteLine();
            }
        }
    }
}
