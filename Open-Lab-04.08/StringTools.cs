using System;
using System.Linq;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int loopsNumber = 0;
            int x = 0;
            for (int a = 0; a < strings.Length; a++)
            {
                if (strings[a].Length == 4)
                {
                 loopsNumber++;
                }
            }
            string[] newArray = new string[loopsNumber];

            for (int b = 0; b < strings.Length; b++)
            {
                if (strings[b].Length == 4)
                {
                    newArray[x] = strings[b];
                    x++;
                }
            }
            return newArray;
        }
    }
}