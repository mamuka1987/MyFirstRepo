using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using return_practical.PlayOffs;

namespace return_practical.PlayOffs
{
    public class FotballPlayOffRounds : PlayOffRounds<FutballTeam>
    {
        public const int minGameRaodenoba = 1;
        private Match<FutballTeam> FirstRound;
        private Match<FutballTeam> SecondRound;
        public FotballPlayOffRounds(Match<FutballTeam> firstRound) : base(firstRound, minGameRaodenoba)
        {
            FirstRound = firstRound;
            SecondRound = Rounds.Skip(1).First();

        }
        public override void Start()
        {
            foreach (var elementebi in Rounds)
            {
                elementebi.Start();
            }
            var winner = GetWithoutPenaltiesWinner();
            if (winner !=null)
            {
                PrinScore();
                return;
            };
            var secondtRound = Rounds.Skip(1).First();

            PenaltySeries = new PenaltySeries(secondtRound.Home, secondtRound.Away);
            PenaltySeries.PenaltyShoots(1, 6);
            
        }
        private Team GetWithoutPenaltiesWinner()
        {
            var totalFirstGolas = FirstRound.HomeScore + SecondRound.AwayScore;
            var totalSecendGoals = SecondRound.HomeScore + FirstRound.AwayScore;
            var winner = totalFirstGolas > totalSecendGoals ? FirstRound.Home :
                totalFirstGolas < totalSecendGoals ? FirstRound.Away : null;
            return winner;
        }
       
        public override Team GetWinner()
        {
            if (Rounds.Any(x => !x.IsFinished))
                throw new InvalidOperationException("Jer Start Metodi Gaushvi Zmao Jan !!!");
            var winner = GetWithoutPenaltiesWinner();
            if (winner != null)
                return winner;
            return PenaltySeries.FirstsGolebi > PenaltySeries.SecondGolebi ?
                  PenaltySeries.TeamFirst : PenaltySeries.TeamSecond;
        }
        private void PrinScore()
        {

            var penalaties = PenaltySeries != null ? PenaltySeries.GetPenaltyScorePrint() : string.Empty;
            Console.WriteLine($"{FirstRound.Away.Name} ({FirstRound.HomeScore}) {FirstRound.AwayScore + SecondRound.HomeScore}" +
                $"  <<<>>> {FirstRound.HomeScore + FirstRound.AwayScore} ({FirstRound.HomeScore}) {FirstRound.Home.Name}" +
                 $" Pen: {penalaties} [{GetWinner().Name}]");

        }
    }
}
