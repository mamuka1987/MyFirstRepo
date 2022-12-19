using System;
using System.Linq;
using System.Collections.Generic;
using return_practical.PlayOffs;

namespace return_practical
{


    class Program
    {

        static void Main(string[] args)
        {
            var matchi222 = new BasketballMatch(new BasketbollTeam("Dalass"), new BasketbollTeam("Toronto"));
            var playoff2 = new BasketballPlayoffRounds(matchi222);
            playoff2.Start();
            Console.ReadLine();
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

