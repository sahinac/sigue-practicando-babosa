using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace sigue_practicando_babosa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string satz;
            char espacio = ' ';
            int count = 0;
            Console.WriteLine("Satz:");
            satz = Console.ReadLine();

            char[] satza = satz.ToCharArray();
            Array.Reverse(satza);
            foreach (char i in satza)
            {
                Console.WriteLine("última letra" + "\t" + i);
                break;
            }

            for (int i = 0; i < satz.Length; i++)
            {
                if (satz[i] == espacio)
                {
                    count++;
                }

            }
            Console.WriteLine("él número de espacios es " + "\t\t" + count);

            //string satz1;
            //Console.WriteLine("SATZ");
            //satz1 = Console.ReadLine();
            //string espacio = " ";
            
            //string cleanstrng = satz1.Replace(espacio, "");
            //Console.WriteLine(cleanstrng);

            //string vokal = "aeiouAEIUO";
            //for(int i=0;i<vokal.Length;i++) 
            //{
            //    satz1 = satz1.Replace(vokal[i].ToString(), "");

            //}
            //Console.WriteLine(satz1);
            //Console.ReadLine();
        }


        
              
        }
    }

