using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace konzola_git
{
    internal class Evidence
    {

        public List<Zvire> list = new List<Zvire>();
        
        public void PridatZvire()
        {
            Console.Write("Zadejte jméno zvířete: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte druh zvířete: ");
            string druh = Console.ReadLine();
            Console.Write("Zadejte věk zvířete: ");
            int vek = int.Parse(Console.ReadLine());
            Console.Write("Zadejte pohlaví zvířete: ");
            string pohlavi = Console.ReadLine();
            Console.Write("Zadejte, zda je zvíře adoptované (A/N): ");
            string volba = Console.ReadLine();
            bool vybrane = false;
            bool adopce = false;
            if (volba.ToUpper() == "A")
            {
                adopce = true;
                vybrane = true;
            }
            else if (volba.ToUpper() == "N")
            {
                vybrane = true;
            }
            else
            {
                Console.WriteLine("Neplatná hodnota. Zadejte buď 'A' nebo 'N'.");
            }
            if (vybrane)
            {
                Zvire zvire = new Zvire(jmeno, druh, vek, pohlavi, adopce);
            }
        }

        public void Uprava()
        {
            Console.WriteLine("U kterého zvířete chcete upravit jejich atributy?");
            for (int i =0; i<list.Count; i++)
            {
                Console.WriteLine(list[i].jmeno);
            }
            Console.WriteLine();
            Console.Write("Zadejte ID: ");
            int volba = int.Parse(Console.ReadLine());
            if ((volba - 1) < 0 || (volba - 1) > list.Count)
            {
                Console.WriteLine("Neplatné ID.");
            }
            else
            {
                Console.Write("Kterou atributu chcete změnit? (jméno, druh, věk, pohlaví, adopce): ");
                string volbaAtributy = Console.ReadLine();
                switch (volbaAtributy.ToLower())
                {
                    case "jméno":
                        Console.Write("Zadejte jméno zvířete: ");
                        string jmeno = Console.ReadLine();
                        list[volba - 1].jmeno = jmeno;
                        break;
                    case "druh":
                        Console.Write("Zadejte druh zvířete: ");
                        string druh = Console.ReadLine();
                        list[volba - 1].druh = druh;
                        break;
                    case "věk":
                        Console.Write("Zadejte jméno zvířete: ");
                        int vek = int.Parse(Console.ReadLine());
                        list[volba - 1].vek = vek;
                        break;
                    case "pohlaví":
                        Console.Write("Zadejte jméno zvířete: ");
                        string pohlavi = Console.ReadLine();
                        list[volba - 1].pohlavi = pohlavi;
                        break;
                    default:
                        Console.WriteLine("Zadejte přesný název atributy, kterou chcete změnit.");
                        break;
                }
            }
        }

        public void Smazat()
        {
            Console.WriteLine("Které zvíře chcete odstranit");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].jmeno);
            }
            Console.WriteLine();
            Console.Write("Zadejte ID: ");
            int volba = int.Parse(Console.ReadLine());
            if ((volba - 1) < 0 || (volba - 1) > list.Count)
            {
                Console.WriteLine("Neplatné ID.");
            }
            else
            {

            }
        }
    }
}
