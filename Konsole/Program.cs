using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zeilen = 20;
            int spalten = zeilen * 2;

            for (int j = 0; j < zeilen ; j++)
            {
                for (int i = 0; i < spalten ; i++)
                {
                    // wenn wir in der ERSTEN oder in der LETZTEN Zeile sind >> alle rauten machen
                    if (j == 0 || j == zeilen - 1)
                    {
                        Console.Write("#");
                    }
                    else if (i == 0 || i == spalten - 1)
                    {  
                        //Console.SetCursorPosition(i,j);
                        Console.Write("#"); 
                    } 
                    else
                    {
                        Console.Write(" ");
                    }
                    
                    
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
