using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomchilHW1
{
    public class FW : FootballPlayer
    {
        public FW(FootballPlayer a)
        {
            Name = a.Name;
            Age = a.Age;
            PlayerNumber = a.PlayerNumber;
            Height = a.Height;
        }
    }
}
