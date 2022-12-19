using System;
using System.Collections.Generic;
using System.Linq;

namespace return_practical
{
   public  abstract class  PlayOffRounds<TTeam> where TTeam : Team
    {
        public List<Match<TTeam>> Rounds;
        public PenaltySeries PenaltySeries;
        public PlayOffRounds(Match<TTeam> firstRound, int minGameRaodenoba)
        {
            Rounds = new List<Match<TTeam>>();
            var range = Enumerable.Range(1, minGameRaodenoba);
            Rounds.Add(firstRound);

            for (int i = 0; i < range.Count(); i++)
            {
                if (i % 2 != 0)
                {
                    Rounds.Add(firstRound.Reverse().Reverse());
                }
                else
                {
                    Rounds.Add(firstRound.Reverse());
                }
            }
            // SecendRound = firstRound.Reverse();
        }

        public abstract void Start();
        public abstract Team GetWinner();
        
        //private void PrinScore()
        //{
        //    var penalaties = PenaltySeries != null ? PenaltySeries.GetPenaltyScorePrint() : string.Empty;
        //    Console.WriteLine($"{FirstRound.Away.Name} ({FirstRound.HomeScore}) {FirstRound.AwayScore + SecendRound.HomeScore}" +
        //        $"  <<<>>> {FirstRound.HomeScore + FirstRound.AwayScore} ({FirstRound.HomeScore}) {FirstRound.Home.Name}" +
        //         $" Pen: {penalaties} [{GetWinner().Name}]");
        //}
    }
}
