using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Level
    {
        private readonly char category;
        private readonly IList<int> scores;

        public Level(char category, IEnumerable<int> scores)
        {
            this.category = category;
            this.scores = new List<int>(scores);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{category}:");
            foreach (float sc in scores) sb.Append($" {sc}");
            return sb.ToString();
        }

        public void IncScores()
        {
            for (int i = 0; i < scores.Count; i++) scores[i] += 1;
        }

        public Level ShallowCopy()
        {
            // Finish me!
            throw new NotImplementedException();
        }

        public Level DeepCopy()
        {
            // Finish me!
            throw new NotImplementedException();
        }
    }
}