using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MomchilHW1
{
    public class Game
    {
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public int Team1Score { get; private set; }
        public int Team2Score { get; private set; }
        public Ref MainRef { get; private set; }
        public Ref AssistantRef1 { get; private set; }
        public Ref AssistantRef2 { get; private set; }
        public List<Goal> Goals { get; private set; }

        public Game(Team team1, Team team2, Ref mainRef, Ref assistant1, Ref assistant2)
        {
            Goals = new List<Goal>();
            Team1 = team1;
            Team2 = team2;
            Team1Score = 0;
            Team2Score = 0;
            MainRef = mainRef;
            AssistantRef1 = assistant1;
            AssistantRef2 = assistant2;
            if (Team1.Players.Count > 11)
            {
                Console.WriteLine("Choose player via their shirt number for team MC");
                RemovePlayers(Team1);
            }
            Console.WriteLine();
            if (Team2.Players.Count > 11) 
            { 
            Console.WriteLine("Choose player via their shirt number for team BM");
            RemovePlayers(Team2);
            }

            //game begins
            Console.WriteLine("!@ game start @!");
            Console.WriteLine();
            //creating goals
            Goal goal1 = new Goal(Team1.ReturnRandomPlayer(),25); Team1Score++; Goals.Add(goal1);
            Goal goal2 = new Goal(Team2.ReturnRandomPlayer(), 45); Team2Score++; Goals.Add(goal2);
            Goal goal3 = new Goal(Team1.ReturnRandomPlayer(), 65); Team1Score++; Goals.Add(goal3);
            Console.WriteLine();
            Console.WriteLine("GAME END");

            //printing results
            Console.WriteLine($"Final result: Bastard Munich {Team1Score} - {Team2Score} Manshine City" );
            Console.WriteLine();
            PrintWinner();
            Console.WriteLine();
            Console.WriteLine($"Goals: ");
            foreach (var item in Goals)
            {
                item.PrintGoal();
            }
        }
        //removes players from both teams if necessary
        void RemovePlayers(Team team)
        {
            foreach (var item in team.Players)
            {
                item.ReturnDesc();
                Console.WriteLine();
            }
            while (team.Players.Count > 11)
            {
                Console.WriteLine(" choose a player to bench via their number");
                int input = int.Parse(Console.ReadLine());
                foreach (var item in team.Players)
                {
                    if (input == item.PlayerNumber)
                    {
                        team.Players.Remove(item);
                        Console.WriteLine($"{item.Name} has been removed ");
                        break;
                    }
                }
            }
        }

    void PrintWinner()
        {
            if (Team1Score > Team2Score) 
            {
                Console.WriteLine(" WINNER IS BASTARD MUNICH!");
            }
            else if(Team1Score < Team2Score)
            {
                Console.WriteLine(" WINNER IS MANSHINE CITY!");
            }
            else
            {
                Console.WriteLine("draw");
            }
        }
    }
}
