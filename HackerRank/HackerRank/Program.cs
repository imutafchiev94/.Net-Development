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
     * Complete the 'stringAnagram' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY dictionary
     *  2. STRING_ARRAY query
     */

    public static List<int> stringAnagram(List<string> dictionary, List<string> query)
    {
        bool isAnagram = false;
        int count = 0;
        List<int> list = new List<int>();
        foreach (var word in query)
        {
            var searchedWord = String.Concat(word.OrderBy(c => c));
            foreach (var anagram in dictionary)
            {
                var sortedAnagram = String.Concat(anagram.OrderBy(c => c));
                if (searchedWord == sortedAnagram)
                {
                    isAnagram = true;
                }

                if (isAnagram)
                {
                    count++;
                }

                isAnagram = false;
            }

            list.Add(count);
            count = 0;
        }
        return list;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int dictionaryCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> dictionary = new List<string>();

        for (int i = 0; i < dictionaryCount; i++)
        {
            string dictionaryItem = Console.ReadLine();
            dictionary.Add(dictionaryItem);
        }

        int queryCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> query = new List<string>();

        for (int i = 0; i < queryCount; i++)
        {
            string queryItem = Console.ReadLine();
            query.Add(queryItem);
        }

        List<int> result = Result.stringAnagram(dictionary, query);

        Console.WriteLine(String.Join("\n", result));
    }
}