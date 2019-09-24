using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManager
{
    static class Utility
    {
        static SortedDictionary<string, int> stringToLevel;
        static string[] levelToString;
        static string[] difficultyToString;

        static Utility()
        {
            stringToLevel = new SortedDictionary<string, int>()
            {
                ["1"] = 0,
                ["2"] = 1,
                ["3"] = 2,
                ["4"] = 3,
                ["5"] = 4,
                ["6"] = 5,
                ["7"] = 6,
                ["8"] = 7,
                ["9"] = 8,
                ["9+"] = 9,
                ["10"] = 10
            };
            levelToString = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "9+", "10" };
            difficultyToString = new string[] { "Past", "Present", "Future" };
        }

        static public int? StringToLevel(string name)
        {
            if(stringToLevel.ContainsKey(name))
            {
                return stringToLevel[name];
            }
            return null;
        }

        static public string LevelToString(int level)
        {
            if (0 <= level && level < levelToString.Length)
            {
                return levelToString[level];
            }
            return null;
        }

        static public string DifficultyToString(int difficulty)
        {
            if (0 <= difficulty && difficulty < difficultyToString.Length)
            {
                return difficultyToString[difficulty];
            }
            return null;
        }

        static public decimal GetPotential(decimal scorePotential,int points)
        {
            if (points < 980_0000)
            {
                return scorePotential + ((decimal)points - 950_0000) / 30_0000;
            }
            else if (points < 995_0000)
            {
                return scorePotential + 1.0m + ((decimal)points - 980_0000) / 40_0000;
            }
            else if (points < 1000_0000)
            {
                return scorePotential + 1.5m + ((decimal)points - 995_0000) / 10_0000;
            }
            else
            {
                return scorePotential + 2.0m;
            }
        }
    }
}
