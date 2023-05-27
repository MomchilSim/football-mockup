using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomchilHW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating the potential teams
            List<FootballPlayer> ManshineCity = new List<FootballPlayer>();
            GK GK11 = new GK(new FootballPlayer("Rook", 19, 12, 190));
            DF DF11 = new DF(new FootballPlayer("Damon", 20, 13, 188));
            DF DF12 = new DF(new FootballPlayer("Busby", 19, 14, 189));
            DF DF13 = new DF(new FootballPlayer("Young", 18, 15, 180));
            DF DF14 = new DF(new FootballPlayer("Driver ", 19, 16, 179));
            MF MF11 = new MF(new FootballPlayer("Reo Mikage", 19, 17, 190));
            MF MF12 = new MF(new FootballPlayer("kazuma Nio", 19, 18, 186));
            FW FW11 = new FW(new FootballPlayer("Kairu Saramadara", 19, 19, 186));
            FW FW12 = new FW(new FootballPlayer("Seishiro Nagi", 19, 20, 190));
            FW FW13 = new FW(new FootballPlayer("Hyoma chigiri", 18, 21, 184));
            FW FW14 = new FW(new FootballPlayer("Chris Prince", 19, 22, 190));
            FW FW15 = new FW(new FootballPlayer("TestCase", 19, 23, 190));
            Coach coach11 = new Coach("Carl", 24);
            ManshineCity.Add(GK11);
            ManshineCity.Add(DF11);
            ManshineCity.Add(DF12);
            ManshineCity.Add(DF13);
            ManshineCity.Add(DF14);
            ManshineCity.Add(MF11);
            ManshineCity.Add(MF12);
            ManshineCity.Add(FW11);
            ManshineCity.Add(FW12);
            ManshineCity.Add(FW13);
            ManshineCity.Add(FW14);
            ManshineCity.Add(FW15);

            //team splitter

            List<FootballPlayer> BastardMunich = new List<FootballPlayer>();
            GK GK21 = new GK(new FootballPlayer("Gagamaru Gin", 18, 12, 192));
            DF DF21 = new DF(new FootballPlayer("Hiori Yo", 20, 21, 190));
            DF DF22 = new DF(new FootballPlayer("Ali", 17, 35, 188));
            DF DF23 = new DF(new FootballPlayer("Jingo Raichi", 18, 14, 185));
            DF DF24 = new DF(new FootballPlayer("Isagi", 18, 56, 184));
            MF MF21 = new MF(new FootballPlayer("Alexis Ness", 19, 23, 188));
            MF MF22 = new MF(new FootballPlayer("Erik Gesner", 19, 7, 189));
            FW FW21 = new FW(new FootballPlayer("Yoichi Isagi", 18, 18, 190));
            FW FW22 = new FW(new FootballPlayer("I Ranout OfNames", 18, 93, 190));
            FW FW23 = new FW(new FootballPlayer("Spare me TheNaming", 18, 88, 190));
            FW FW24 = new FW(new FootballPlayer("Kaiser", 19, 89, 184));
            FW FW25 = new FW(new FootballPlayer("Noel Noa", 19, 160, 179));
            FW FW26 = new FW(new FootballPlayer("Rensuke Kunigami", 19, 131, 192));
            Coach coach21 = new Coach("Jake", 24);
            BastardMunich.Add(GK21);
            BastardMunich.Add(DF21);
            BastardMunich.Add(DF22);
            BastardMunich.Add(DF23);
            BastardMunich.Add(DF24);
            BastardMunich.Add(MF21);
            BastardMunich.Add(MF22);
            BastardMunich.Add(FW21);
            BastardMunich.Add(FW22);
            BastardMunich.Add(FW23);
            BastardMunich.Add(FW24);
            BastardMunich.Add(FW25);
            BastardMunich.Add(FW26);

            Team BM = CreateTeam(coach21, BastardMunich);
            Team MC = CreateTeam(coach11, ManshineCity);
            
            //creating teams from list of players
            Team CreateTeam(Coach TeamCoach, List<FootballPlayer> TeamToBe)
            {
                Team res = new Team(TeamCoach, TeamToBe);
                return res;
            }
            /* 
             TEAMS HAVE BEEN CREATED AND WE ARE MOVING ON TO GAME CREATION / TEAMS HAVE BEEN CREATED AND WE ARE MOVING ON TO GAME CREATION TEAMS HAVE BEEN CREATED AND WE ARE MOVING ON TO GAME CREATION TEAMS HAVE BEEN CREATED AND WE ARE MOVING ON TO GAME CREATION 
             TEAMS HAVE BEEN CREATED AND WE ARE MOVING ON TO GAME CREATION / TEAMS HAVE BEEN CREATED AND WE ARE MOVING ON TO GAME CREATION TEAMS HAVE BEEN CREATED AND WE ARE MOVING ON TO GAME CREATION TEAMS HAVE BEEN CREATED AND WE ARE MOVING ON TO GAME CREATION
             */
            Ref mainRef = new Ref("RefMain1", 30);
            Ref sideRef1 = new Ref("RefSide1", 34);
            Ref sideRef2 = new Ref("RefSide2", 32);
            //GAME ITSELF
            new Game(BM,MC,mainRef,sideRef1,sideRef2);


        }
    }
}
