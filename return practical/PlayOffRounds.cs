using System;
using System.Collections.Generic;
using System.Linq;

namespace return_practical
{
    class PlayOffRounds<TTeam> where TTeam : Team
    {
        public List<Match<TTeam>> Rounds;
        //public Match<TTeam> FirstRound;
        //public Match<TTeam> SecendRound;
        public PenaltySeries PenaltySeries;
        public SportRules Rules;


        public PlayOffRounds(Match<TTeam> firstRound, SportRules rules)
        {
            Rounds = new List<Match<TTeam>>();
            Rules = rules;
            var range = Enumerable.Range(1, rules.MinRaodenoba);
            Rounds.Add(firstRound);

            for (int i = 0; i < range.Count(); i++)
            {
                if (i % 2 != 0)
                {
                    //barsa reali <<<<
                    // reali barsa 
                    // barsa realio 
                    
                    Rounds.Add(firstRound.Reverse().Reverse());
                }
                else
                {
                    Rounds.Add(firstRound.Reverse());
                }
            }


            // Rounds.Add(firstRound);
            // FirstRound = firstRound;
            // SecendRound = firstRound.Reverse();
        }
        public void Start()
        {
            foreach (var elementebi in Rounds)
            {
                elementebi.Start();
            }

            // FirstRound.Start();
            // SecendRound.Start();
            var winner = withoutPenaltiesWinner();
            if (winner == null)
            {
                PenaltySeries = new PenaltySeries(SecendRound.Home, SecendRound.Away);
                PenaltySeries.PenaltyShoots(1, 6);
            };

            PrinScore();
        }
        private void PrinScore()
        {
            var penalaties = PenaltySeries != null ? PenaltySeries.GetPenaltyScorePrint() : string.Empty;
            Console.WriteLine($"{FirstRound.Away.Name} ({FirstRound.HomeScore}) {FirstRound.AwayScore + SecendRound.HomeScore}" +
                $"  <<<>>> {FirstRound.HomeScore + FirstRound.AwayScore} ({FirstRound.HomeScore}) {FirstRound.Home.Name}" +
                 $" Pen: {penalaties} [{GetWinner().Name}]");

        }

        private Team withoutPenaltiesWinner()
        {
            var totalFirstGolas = FirstRound.HomeScore + SecendRound.AwayScore;
            var totalSecendGoals = SecendRound.HomeScore + FirstRound.AwayScore;


            var winner = totalFirstGolas > totalSecendGoals ? FirstRound.Home :
                totalFirstGolas < totalSecendGoals ? FirstRound.Away : null;
            return winner;
        }


        public Team GetWinner()
        {
            if (!Rounds.All(x => x.IsFinished))
                throw new InvalidOperationException("Jer Start Metodi Gaushvi Zmao Jan !!!");


            var winner = withoutPenaltiesWinner();
            if (winner != null)
                return winner;

            return PenaltySeries.FirstsGolebi > PenaltySeries.SecondGolebi ?
                  PenaltySeries.TeamFirst : PenaltySeries.TeamSecond;


        }

    }
}
