using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrikMedurList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                Console.Write("Unesite ime. (ako želite prekinuti upišite ne)");
                string ime = Console.ReadLine();
                if (ime == "ne")
                {
                    break;
                }
                list.Add(ime);

            }
            list.Sort();
            list.Reverse();
            Console.WriteLine("Unesena imena obrnutim redom: ");
            foreach (string ime in list)
            {
                Console.WriteLine("{0},\n", ime);
            }

        for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
        
    }
}
