using System;
using System.Linq;
using System.Collections.Generic;

namespace return_practical
{


    class Program
    {


        static void Main(string[] args)
        {
            //var kalatburtiMatchi = new Match<FutballTeam>(); 

            var match212121 = new BasketballMatch(new BasketbollTeam("gundi 1"),new BasketbollTeam("maiami"));
            var playoff = new PlayOffRounds<BasketbollTeam>(match212121, new BasketballRules());
            playoff.Start();

            return;



/*
            //MasivisMasivisMasivi();
            var masivi = new int[] { 1, 2, 4, 5, 6, 9 };
            var listi = masivi.ToList();
            var randomCifri = new Random().Next(0, listi.Count);
            listi.Add(masivi[randomCifri]);

            var teamNames = new string[] {"Dinamo Tbilisi","guriis Mercxali","Reingersi","Airton Sena","Juventus","Selta VIGO","Deportivo"
            ,"Libereci","Ajax","Dinamo Drezden","Lidsi","Marselle","Chelsia","Novac Jokovich","DOrtmundi","Maverick Dallas NBA "};
            //var teamByLinq = teamNames.Select(x => new Team(x)).ToList(); 





            var teams = teamNames.Select(x => new BasketbollTeam(x)).ToList();
            var match = GenerateRandomMatch.GenerateMatch<BasketballMatch, BasketbollTeam>(teams);


            var tournament = new Tournament("Uefa Chempions League", teams);
            var winner = tournament.GetWinnersRecursive();
            Console.WriteLine($" Finnal Winner Club >>> {winner.Name.ToUpper()} <<< Congrats ");

            LiveStream liveStream = new LiveStream();
            liveStream.publicLivePeople = ShowLive;
            liveStream.Start();
            static void ShowLive(int live)
            {
                Console.WriteLine($"Tamashs uyurebda SetanTaSport-ze  LIVE: {live}  Mayurebeli");
            }

*/


            /*
            var winnerList = new List<Team>();
            var matches = new List<Match>();
            
            
           
            foreach (var item in matches)
            {
                item.Start();
                var winner = item.GetWinner();
                winnerList.Add(winner);
            }
            */

        }




    }
}

