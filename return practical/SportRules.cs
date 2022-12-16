using System;
using System.Collections.Generic;
using System.Text;

namespace return_practical
{
    public abstract class SportRules
    {
        public abstract int MinRaodenoba { get; }
    }
   /* public class GamePlayRange
    {
        public int MinRaodenoba { get; set; }
        public int MaxRaodenoba { get; set; }

        public GamePlayRange(int minRaodenoba)
        {
            MinRaodenoba = minRaodenoba;
        }

        public GamePlayRange(int minRaodenoba, int maxRaodenoba)
        {
            MinRaodenoba = minRaodenoba;
            MaxRaodenoba = maxRaodenoba;
        }
    }*/

    public class BasketballRules : SportRules
    {
        public override int MinRaodenoba => 3;
        

    }

    public  class FotballRules : SportRules
    {
        public override int MinRaodenoba => 1;
    }
    public  class HockeyRules
    {

    }
    public  class TennisRules
    {

    }
    public  class RagbyRules
    {

    }
    
    
}
