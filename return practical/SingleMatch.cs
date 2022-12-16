using System;
using System.Collections.Generic;
using System.Text;

namespace return_practical
{
  /*  public class SingleMatch<TTeam> : Match<TTeam> where TTeam : Team
    {


        public SingleMatch(TTeam home, TTeam away) : base(home, away)
        {

        }

        public PenaltySeries PenaltySeries;
        public override void Start()
        {
            //base.Start();
            if (HomeScore == AwayScore)
                PenaltySeries = new PenaltySeries(Home, Away);
            PenaltySeries.PenaltyShoots(1, 6);

        }
        /// <summary>
        /// Winner Metodi
        /// </summary>
        /// <returns></returns>
        public Team GetWinners()
        {
            if (!IsFinished)
            {
                throw new InvalidOperationException("Tkjzasklxjsakcjhkdsjkdsb asjdhjkasjkdsjfk  >>>>GetWinnerShi<<<<");
            }
            if (HomeScore > AwayScore)
            {
                return Home;

            }
            else if (HomeScore == AwayScore)
            {
                if (PenaltySeries.FirstsGolebi > PenaltySeries.SecondGolebi)
                    return PenaltySeries.TeamFirst;
                else
                    return PenaltySeries.TeamSecond;
            }
            return Away;
        }


        public override Match<TTeam> ReverseMatch()
        {
            return new SingleMatch<TTeam>(Away, Home);
        }
    }*/
}
