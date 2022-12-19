using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace return_practical.PlayOffs
{
    public class BasketballPlayoffRounds : PlayOffRounds<BasketbollTeam>
    {
        public const int minGameRaodenoba = 4;
        public BasketballPlayoffRounds(Match<BasketbollTeam> firstRound) : base(firstRound, minGameRaodenoba)
        {
        }

        public override void Start()
        {
            foreach (var elementebi in Rounds)
            {
                elementebi.Start();
            }
            var firstTeam = Rounds.First().Home;
            var secondTeam = Rounds.First().Away;
            var winners = Rounds.Select(x => (x as BasketballMatch).GetWinner());
            var firstTeamWinnerVictoryQuantity = winners.Count(x => x.Name == firstTeam.Name);
            var secondTeamWinnerVictoryQuantity = winners.Count(x => x.Name == secondTeam.Name);
            while (firstTeamWinnerVictoryQuantity != 4 && secondTeamWinnerVictoryQuantity != 4)
            {
                var newMatch = new BasketballMatch(firstTeam, secondTeam);
            }

        }
        public override Team GetWinner()
        {
            throw new NotImplementedException();
        }


    }
}
