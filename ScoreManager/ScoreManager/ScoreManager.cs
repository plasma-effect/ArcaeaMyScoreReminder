using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
