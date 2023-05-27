using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MomchilHW1
{
    public class FootballPlayer : Person
    {
        public int PlayerNumber { get; set; }
        public int Height { get; set; }
        public FootballPlayer(string name, int age,int playerNumber, int height) : base(name, age)
        {
            PlayerNumber = playerNumber;
            Height = height;
        }
        public FootballPlayer() { }
        public void ReturnDesc()
        {
            Console.WriteLine($"Name:{Name}/  Height:{Height}/   Age:{Age}/      Number:{PlayerNumber}");
        }
    }
}
