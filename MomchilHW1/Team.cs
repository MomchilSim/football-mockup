using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomchilHW1
{
    public class Team
    {
        public Coach TeamCoach { get; private set; }
        public List<FootballPlayer> Players { get; private set; } 
        public double AverageAge { get => Players.Average(player => player.Age); }
        public Team() { }
        public Team(Coach teamCoach, IEnumerable<FootballPlayer> team)
        {
            if (team.Count() > 22 || team.Count() < 11)
            {
                Console.WriteLine("INVALID AMOUNT OF PEOPLE, ADD OR REMOVE IMMEDIENTLY");
               throw new ArgumentException("INVALID AMOUNT OF PEOPLE, ADD MORE IMMEDIENTLY");
            }
            Players = new List<FootballPlayer>();
            TeamCoach = teamCoach;
            foreach (var item in team)
            {
                Players.Add(item);
            }        
        }
        public Team(IEnumerable<FootballPlayer> team)
        {
            Players = new List<FootballPlayer>();
            foreach (var item in team)
            {
                Players.Add(item);
            }
        }
        public FootballPlayer ReturnRandomPlayer()
        {
            var random = new Random();
            int index = random.Next(Players.Count);
            return Players[index];
        }
    }
}
