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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        if (s.Substring(8) == "AM") {

                int a = Int32.Parse(s.Substring(0, 2)) % 12;
                if(a <10)
                    return "0" +a.ToString() + s.Substring(2, 6);
                return a.ToString() + s.Substring(2, 6);
            }
            else
            {
                int b = Int32.Parse(s.Substring(0, 2)) % 12 + 12;
                return b.ToString() + s.Substring(2, 6);
            }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
