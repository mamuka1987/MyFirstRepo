using System;
using System.Collections.Generic;
using System.Linq;

namespace return_practical
{
    public static class GenerateRandomMatch
    {
        public static TTeam GetOpponent<TTeam>(IList<TTeam> teams) where TTeam : Team
        {

            var rndmIndex = GenerationRandomNumber.Generate(0, teams.Count);
            var rndm1 = teams[rndmIndex];
            teams.RemoveAt(rndmIndex);
            return rndm1;
        }
       /* public static Match<T> GenerateMatch<T>(List<T> teams) where T: Team
        {
            var home = GetOpponent(teams);
            var away = GetOpponent(teams);
            return new Match<>(home, away);
        }*/
        public static TMatch GenerateMatch<TMatch, TTeam>(List<TTeam> teams) where TTeam : Team
        {
            var home = GetOpponent(teams);
            var away = GetOpponent(teams);
            return (TMatch)Activator.CreateInstance(typeof(TMatch), new object[] { home, away });

        }
    }


}

