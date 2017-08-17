using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_at_Home
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Name = new String[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + 1 + " Telebenin Adi: ");
                Name[i] = Console.ReadLine();

                Console.Write(i + 1 + " Sinaq1: ");
                s1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write(i + 1 + " Sinaq2: ");
                s2[i] =Convert.ToInt32(Console.ReadLine());

                ort[i] = (s1[i] + s2[i]) / 2; 
            }
            Console.WriteLine("Telebenin Adi , Sinaq 1 , Sinaq 2");
            Console.WriteLine(" " );

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" " + Name[i] + " " + s1[i] + " " + s2[i] + " " + ort[i]);
            }
            Console.Read();
        }
    }
}
