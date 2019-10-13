using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ScoreManager.Utility;

namespace ScoreManager
{
    [Serializable]public class ScoreManager:IEnumerable<string>
    {
        [Serializable]public class Unit
        {
            public int[] Levels { get; }
            public decimal[] Potentials { get; }
            public int[] Notes { get; }
            public int[] Bests { get; }

            public Unit(
                int pastLevel, decimal pastPotential, int pastNotes,
                int presentLevel, decimal presentPotential, int presentNotes,
                int futureLevel, decimal futurePotential, int futureNotes)
            {
                this.Levels = new int[3] { pastLevel, presentLevel, futureLevel };
                this.Potentials = new decimal[3] { pastPotential, presentPotential, futurePotential };
                this.Notes = new int[3] { pastNotes, presentNotes, futureNotes };
                this.Bests = new int[3];
            }
        }

        SortedDictionary<string, Unit> data;

        public ScoreManager()
        {
            this.data = new SortedDictionary<string, Unit>();
        }

        public bool Add(string name,
            int pastLevel, decimal pastPotential, int pastNotes,
            int presentLevel, decimal presentPotential, int presentNotes,
            int futureLevel, decimal futurePotential, int futureNotes)
        {
            if (this.data.ContainsKey(name))
            {
                return false;
            }
            this.data[name] = new Unit(
                pastLevel, pastPotential, pastNotes,
                presentLevel, presentPotential, presentNotes,
                futureLevel, futurePotential, futureNotes);
            return true;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach(var unit in this.data)
            {
                yield return unit.Key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Unit this[string name]
        {
            get
            {
                if (this.data.ContainsKey(name))
                {
                    return this.data[name];
                }
                return null;
            }
        }

        public int Count => this.data.Count;

        public bool ContainsKey(string name)
        {
            return this.data.ContainsKey(name);
        }
    }

    public struct ScoreData : IComparable<ScoreData>
    {
        public string Name { get; }
        public int Difficulty { get; }
        public int Level { get; }
        public decimal Potential { get; }
        public int Score { get; }
        public int Notes { get; }
        public int Rank { get; }
        public decimal CalcPotential { get; }

        public ScoreData(string name, int difficulty, int level, decimal potential, int score, int notes)
        {
            this.Name = name;
            this.Difficulty = difficulty;
            this.Level = level;
            this.Potential = potential;
            this.Score = score;
            this.Notes = notes;
            this.Rank = default;
            this.CalcPotential = GetPotential(potential, score);
        }

        public ScoreData(ScoreData score,int rank)
        {
            this.Name = score.Name;
            this.Difficulty = score.Difficulty;
            this.Level = score.Level;
            this.Potential = score.Potential;
            this.Score = score.Score;
            this.Notes = score.Notes;
            this.Rank = rank;
            this.CalcPotential = score.CalcPotential;
        }

        public int CompareTo(ScoreData other)
        {
            var calc = this.CalcPotential.CompareTo(other.CalcPotential);
            var score = this.Score.CompareTo(other.Score);
            var name = other.Name.CompareTo(this.Name);
            var difficulty = other.Difficulty.CompareTo(this.Difficulty);
            return
                calc != 0 ? calc :
                score != 0 ? score :
                name != 0 ? name :
                difficulty;
        }
    }
}
