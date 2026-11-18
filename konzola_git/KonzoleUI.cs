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
                Console.Write("===== ÚTULEK PRO ZVÍŘATA =====\r\n1) Přidat zvíře\r\n2) Vypsat všechna zvířata\r\n3) Vyhledat/ filtrovat\r\n4) Označit adopci\r\n5) Statistiky (volitelné)\r\n0) Konec\r\nVolba: ");
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
                            evidence.Vypis();   //dokončit tady metodu + poupravit to UI, aby tam byly vypsány funkce, který to reálně umí
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
