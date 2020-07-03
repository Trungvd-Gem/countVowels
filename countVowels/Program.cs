using System;
using System.Text;

namespace countVowels
{
    class Program
    {
        static void Main(string[] args)
        {
        repeat:

            string str;
            int i, count, leng;
            Console.Write("Please enter the text:  ");
            str = Console.ReadLine();
            count = 0;
            leng = str.Length;
            for (i = 0; i < leng; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' ||
                   str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' ||
                   str[i] == 'O' || str[i] == 'U')
                {
                    count++;
                }
            }
            Console.Write("\nVowels in the string: {0}\n", count);
            Console.ReadKey();
            goto repeat;
        }
    }
}


