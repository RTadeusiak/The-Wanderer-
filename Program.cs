using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        {
            int currentLevel = 0; // poziom, na którym znajduje się wędrowiec
            int valleysCount = 0; // liczba dolin, które przeszedł wędrowiec
            foreach (char step in path)
            {
                if (step == 'U')
                {
                    currentLevel++;
                    if (currentLevel == 0) // jeśli wędrowiec wraca na poziom morza, to przeszedł przez dolinę
                    {
                        valleysCount++;
                    }
                }
                else if (step == 'D')
                {
                    currentLevel--;
                }
            }
            return valleysCount;
        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        Console.WriteLine(result);

    }
}
