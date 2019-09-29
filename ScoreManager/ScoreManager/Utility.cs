using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Linq.Enumerable;

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
            if (stringToLevel.ContainsKey(name))
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
        static public int? StringToDifficulty(string name)
        {
            foreach (var i in Range(0, 3))
            {
                if (difficultyToString[i] == name)
                {
                    return i;
                }
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


        static public decimal GetPotential(decimal scorePotential, int points)
        {
            if (points < 980_0000)
            {
                return Math.Max(scorePotential + ((decimal)points - 950_0000) / 30_0000, default);
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

        static public decimal GetStep(decimal potential)
        {
            return 2.5m + 2.45m * Sqrt(potential);
        }

        static public decimal GetStep(decimal scorePotential,int point)
        {
            return GetStep(GetPotential(scorePotential, point));
        }

        static decimal Sqrt(decimal v)
        {
            if (v < 0)
            {
                throw new ArgumentOutOfRangeException($"非負の値が必要です");
            }
            else if (v == 0)
            {
                return 0m;
            }
            var ret = v / 2;
            var prev = ret;
            while (Math.Abs(ret - prev) < 0.00001m)
            {
                prev = ret;
                ret = (prev + v / prev) / 2;
            }
            return ret;
        }

        static public decimal RoundDown(decimal v, int digit = 3)
        {
            var ret = decimal.Truncate(v);
            v -= ret;
            foreach (var c in Range(0, digit))
            {
                ret *= 10m;
                v *= 10m;
                ret += decimal.Truncate(v);
                v -= decimal.Truncate(v);
            }
            foreach (var c in Range(0, digit))
            {
                ret /= 10m;
            }
            return ret;
        }

        static public int? PartitionPoint(int min, int max, Func<int, bool> pred)
        {
            if (!pred(max))
            {
                return null;
            }
            if (pred(min))
            {
                return min;
            }
            while (max - min > 1)
            {
                var mid = (max + min) / 2;
                if (pred(mid))
                {
                    max = mid;
                }
                else
                {
                    min = mid;
                }
            }
            return max;
        }

        static public int MaxElemental<T>(params T[] ar)
            where T : IComparable<T>
        {
            var maxindex = 0;
            foreach (var i in Range(1, ar.Length - 1))
            {
                if (ar[maxindex].CompareTo(ar[i]) < 0)
                {
                    maxindex = i;
                }
            }
            return maxindex;
        }

        static public IEnumerable<(T, int)> Indexed<T>(this IEnumerable<T> ts)
        {
            var index = -1;
            foreach(var v in ts)
            {
                yield return (v, ++index);
            }
        }
    }
}
