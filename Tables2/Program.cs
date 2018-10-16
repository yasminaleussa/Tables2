using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables2
{
    class Program
    {
        static void Main(string[] args)
        {
            Table[] tab = new Table[10];
            Random rnd = new Random();

            for (int i = 1; i < tab.Length; i++)
            {
                
                if(i%2 == 0 && i == 1)
                { 
                    tab[i-1] = new Table(rnd.Next(50,201), rnd.Next(50, 201));
                    tab[i-1].ShowData();
                }
                else
                {
                    tab[i - 1] = new CoffeeTable(rnd.Next(40, 121), rnd.Next(40, 121));
                    tab[i - 1].ShowData();
                }
            }
            Console.Read();
        }
  
    }
}
