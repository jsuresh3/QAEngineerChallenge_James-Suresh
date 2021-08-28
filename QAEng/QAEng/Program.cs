using System;
using System.Collections;
using System.IO;

namespace QAEng
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Loop 1 finds the largest number from the file
             * Array created, based on largest number to tally the frequency of occurence
             * Loop 2 assigns frequency
             * Loop 3 finds number with lowest occurence and the number of times its repeated
             */

            Console.WriteLine("Enter file name");
            string fpath = ("src/"+Console.ReadLine());
            
            string[] lines = System.IO.File.ReadAllLines(fpath);
           
            
            int max=int.Parse(lines[0]); //Largest number on list, initialized as first number on the file          
            int temp = 0;
            int lineNum; // converts line to a number

            //Loop 1

            foreach (string line in lines)
            {
                temp = int.Parse(line);
                
                if (temp>max)
                {
                    max = temp;
                }
            }

            int[] numArray = new int[max+1]; // starts from 0, hence size is max+1

            int maxF = 0; // Max Frequency - largest frequency, initialized to 0;

            //Loop 2
            
            foreach (string line in lines)
            {
                lineNum = int.Parse(line);

                numArray[lineNum] +=1;
                
                if (numArray[lineNum] > maxF)
                {
                    maxF = numArray[lineNum];
                }
            }

            int minF = maxF;//Min Frequency - fewest number of times a number will occur, initializing at max frequency
            int minN = 0; // Min Number - number that will occur the lowest

            //Loop 3
            
            for (int i=0; i<=max;i++)
            {
                if (numArray[i] >= 1 && numArray[i]<minF)
                {
                    minF = numArray[i];
                    minN = i;
                }
                
            }

            Console.WriteLine("Number: " + minN);

            Console.WriteLine("Repeates " + (minF-1) + " times after the first occurence (Total : "+minF+")");
        }
    }
}
