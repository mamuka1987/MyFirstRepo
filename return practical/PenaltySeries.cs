using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;


namespace return_practical
{
    public class PenaltySeries
    {
        public Team TeamFirst { get; set; }
        public Team TeamSecond { get; set; }
        public int FirstsGolebi { get; set; }
        public int SecondGolebi { get; set; }

        public PenaltySeries(Team teamFirst, Team teamSecond)
        {
            TeamFirst = teamFirst;
            TeamSecond = teamSecond;
        }

        public string GetPenaltyScorePrint()
        {
           return  $"{FirstsGolebi} - {SecondGolebi}";
        }
        public void PenaltyShoots(int start, int end)
        {


            var homePenalty = GenerationRandomNumber.Generate(start, end);
            var awayPenalty = GenerationRandomNumber.Generate(start, end);
            FirstsGolebi = FirstsGolebi + homePenalty;
            SecondGolebi = SecondGolebi + awayPenalty;

            if (homePenalty == awayPenalty)
            {
                PenaltyShoots(0, 2);
            }

        }
    }
}
