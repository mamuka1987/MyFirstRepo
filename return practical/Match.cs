using System;
using System.Security.Cryptography;
using System.Diagnostics;
namespace return_practical
{
   
    public abstract class Match<TTeam> where TTeam : Team
    {
        public TTeam Home;
        public TTeam Away;
        public int HomeScore;
        public int AwayScore;
        public bool IsFinished;
        public Match(TTeam home, TTeam away)
        {
            Home = home;
            Away = away;
        }
        public abstract void Start();
        
        public  void Start(int start , int end)
        {
            HomeScore = GenerationRandomNumber.Generate(start, end);
            AwayScore = GenerationRandomNumber.Generate(start, end);
            Console.WriteLine($"Match Day {DateTime.Now} Finally 2022 ");
            Console.WriteLine();
            Console.WriteLine($"{Home.Name} {HomeScore}  <<<>>>  {AwayScore} {Away.Name}");
            IsFinished = true;
        }


        public abstract Match<TTeam> Reverse();
        
    }
}

