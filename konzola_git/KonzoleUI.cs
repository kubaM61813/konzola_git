using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzola_git
{
    internal class KonzoleUI
    {
        public static int Menu()
        {
            Console.Write("===== ÚTULEK PRO ZVÍŘATA =====\r\n1) Přidat zvíře\r\n2) Vypsat všechna zvířata\r\n3) Vyhledat/ filtrovat\r\n4) Označit adopci\r\n5) Statistiky (volitelné)\r\n0) Konec\r\nVolba:");
            string user_volba = Console.ReadLine();
            if (int.TryParse(user_volba, out int volba)){
                return int.Parse(user_volba);
            }
            else
            {
                Console.WriteLine("Neplatná volba, ukončuji program");
                return 0;
            }
        }
    }
}
