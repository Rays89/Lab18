using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
          

            int max = 8;
            foreach(int number in numbers)
            {
                if(number >max)
                {
                    max = number;
                }

            }

            int[] freq = new int[max + 1];
            for(int i = 0; i<freq.Length; i++)
            {
                freq[numbers[i]]++;
            }
            for(int i =0; i < freq.Length;i++)
            {
                if(freq[i] != 0)
                {
                    Console.WriteLine($"[{i}]: {freq[i]}");
                }
            }

           //Racheal google = new Racheal();

           // google.Add("Mike");
           // google.Add("Anna");
           // google.Add("Sarah");

           // google.printInfo();
           // google.RemoveAll("Mike");
           // google.printInfo();
        }
    }
}
