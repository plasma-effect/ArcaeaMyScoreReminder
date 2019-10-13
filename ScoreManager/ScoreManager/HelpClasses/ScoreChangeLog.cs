using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ScoreManager.Utility;

namespace ScoreManager
{
    [Serializable]
    public struct ScoreChangeLog
    {
        public ScoreChangeLog(string songName, int difficulty, int previous, int update, DateTime timeStamp)
        {
            this.SongName = songName;
            this.Difficulty = difficulty;
            this.Previous = previous;
            this.Current = update;
            this.TimeStamp = timeStamp;
        }

        public string SongName { get; }
        public int Difficulty { get; }
        public int Previous { get; }
        public int Current { get; }
        public DateTime TimeStamp { get; }

        public override string ToString()
        {
            return $"{this.TimeStamp}-{this.SongName}({DifficultyToString(this.Difficulty)}): {this.Previous}->{this.Current}";
        }
    }
}
