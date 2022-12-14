using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask5
{
    public class Tasks
    {

        public List<int> GetIntegersFromList(List<object> input) //Task1
        {
            if (input == null || input.Contains(null)) return null;
            if (input.Any(i => i.GetType() != typeof(int) && i.GetType() != typeof(string))) return null; //The input List should contain only int or string objects

            List<int> result = input.Where(i => i.GetType() == typeof(int)).Select(i => (int)i).ToList();

            if (result.Any(i => i < 0)) return null;    // The input List should not contain any non-negative numbers!
            else return result;
        }

        public string First_Non_Repeating_Letter(string input) //Task2
        {
            if (input == null) return "";

            char res = '\0';

            foreach (char i in input.ToLower())
            {
                if (input.ToLower().Count(j => j == i) == 1)
                {
                    res = i;
                    break;
                }
            }

            if (res == '\0') return "";

            int idx = input.ToLower().IndexOf(res);

            return input[idx].ToString();
        }

        public int Digital_Root(int input)                      //Task3
        {
            if (input < 0) return -1; //input should be a non-negative integer

            while (input >= 10)
            {
                input = input.ToString().Select(i => int.Parse(i.ToString())).Sum();
            }

            return input;
        }

        public int Task4_CntPairsWithSumOfTarget(int[] input, int target) //Task4
        {
            if (input == null) return 0;

            int addedToItselfSuccessCnt = input.Count(i => 2 * i == target);
            int successCnt = input.Sum(i => input.Count(j => i + j == target));

            return (successCnt - addedToItselfSuccessCnt) / 2;
        }

        public string Meeting(string input)                     //Task5
        {                                                       
            if (input == null) return null;                     

            var elements = input.Split(';').Select(i => i.ToUpper());

            if (elements.Any(i => i.Count(j => j == ':') != 1)) return null;   //input string format is not appropriate

            var res = elements.OrderBy(i => i.Substring(i.IndexOf(":"))).ThenBy(i => i.Substring(0, i.IndexOf(":"))).Select(i => i.Substring(i.IndexOf(":") + 1) + ", " + i.Substring(0, i.IndexOf(":")));

            return ("(" + String.Join(")(", res) + ")");
        }


    }
}

