//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;


//namespace return_practical
//{
//    public class Tournament  
//    {
//        private string Name;
//        private List<Team> Teams;
//        private List<Team> CurrentTeams;

//        public Tournament(string name, List<Team> teams)
//        {

//            Name = name;
//            Teams = teams;
//            CurrentTeams = teams;
//        }


//        private List<Match> Draw()
//        {
//            var matches = new List<Match>();
//            //  var teams = new  List<Team>();

//            while (CurrentTeams.Count > 0)
//            {
//                var match = GenerateRandomMatch.GenerateMatch(CurrentTeams);
//                matches.Add(match);

//            }
//            return matches;
//        }
//        public Team GetWinnersRecursive()
//        {
//            if (CurrentTeams.Count == 1)
//                return CurrentTeams.First();

//            var matches = CurrentTeams.Count == 2 ? new[] { new Match(CurrentTeams.First(), CurrentTeams.Last()) }.ToList() : Draw();

//            if (matches.Count == 1)
//            {
//                var incompleteMatch = matches.First();
//                var final = new FinallMatch(incompleteMatch.Home, incompleteMatch.Away);
//                final.Start();
//                CurrentTeams = new[] {final.GetWinners()}.ToList();
//                var penaltusScore = final?.PenaltySeries != null ? final.PenaltySeries.GetPenaltyScorePrint() : string.Empty;
//                Console.WriteLine($"{final.Home.Name} {final.HomeScore} - {final.AwayScore}  {final.Away.Name} {penaltusScore} ");
//            }
            

//            var matchesRoundPlayyOff = matches.Select(x => new PlayOffRounds(x)).ToList();
            

//            foreach (var ubralodCvladi in matchesRoundPlayyOff)
//            {
//                ubralodCvladi.Start();
//            }

//            var team = GetWinnersRecursive();
//            return team;

            

//        }

        
//    }
//}
