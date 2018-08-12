using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input password");
            string password = Console.ReadLine();
            string attemps = "";

            int first = 0;
            int second = 0;
            int third = 0;
            int fourth = 0;
            int cracks = 0;

            string[] StrArray = new string[27];
            StrArray[0] = "";
            StrArray[1] = "a";
            StrArray[2] = "b";
            StrArray[3] = "c";
            StrArray[4] = "d";
            StrArray[5] = "e";
            StrArray[6] = "f";
            StrArray[7] = "g";
            StrArray[8] = "h";
            StrArray[9] = "i";
            StrArray[10] = "j";
            StrArray[11] = "k";
            StrArray[12] = "l";
            StrArray[13] = "m";
            StrArray[14] = "n";
            StrArray[15] = "o";
            StrArray[16] = "p";
            StrArray[17] = "q";
            StrArray[18] = "r";
            StrArray[19] = "s";
            StrArray[20] = "t";
            StrArray[21] = "u";
            StrArray[22] = "v";
            StrArray[23] = "w";
            StrArray[24] = "x";
            StrArray[25] = "y";
            StrArray[26] = "z";
            while (!attemps.Equals(password))
            {
                if (first == StrArray.Length)
                {
                    second++;
                    first = 0;
                }
                if (second == StrArray.Length)
                {
                    third++;
                    second = 0;
                }
                if (third == StrArray.Length)
                {
                    fourth++;
                    third = 0;
                }
                if (fourth == StrArray.Length)
                {
                    break;
                }
                attemps = StrArray[fourth] + StrArray[third] + StrArray[second] + StrArray[first];
                Console.WriteLine(attemps);
                first++;
                cracks++;
            }

           

           Console.WriteLine("passowrd--->"+cracks);
            Console.ReadKey();

        }
    }
}
