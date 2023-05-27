using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomchilHW1
{
    public class Goal
    {
        public FootballPlayer Scorer { get; private set; }
        public int Time { get; private set; } 
        public Goal(FootballPlayer scorer, int time)
        {
            Scorer = scorer;
            Time = time;
            Console.WriteLine($"GOAL SCORED BY {Scorer.Name} WEARING THE {Scorer.PlayerNumber}/ at the {Time} minute");

        }
        public void PrintGoal()
        {
            Console.WriteLine($"GOAL SCORED BY {Scorer.Name}/ at the {Time} minute");
        }
    }
}
