using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class AverageString
    {
        private static readonly IDictionary<string, int> NumberDict = new Dictionary<string, int>()
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 }
        };

        public static string Average(string str)
        {
            if (String.IsNullOrEmpty(str))
                return "n/a";

            List<int> numList = new List<int>();
            string[] strArray = str.Split(new string[] { " ", ",", "/", "\\" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in strArray)
            {
                if (NumberDict.ContainsKey(s.ToLower()))
                {
                    numList.Add(NumberDict[s.ToLower()]);
                }
            }

            if (numList.Count == 0)
                return "n/a";

            int result = numList.Sum() / numList.Count;

            return NumberDict.ElementAt(result).Key;
        }

    }
}
