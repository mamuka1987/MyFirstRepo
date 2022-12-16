using System;
using System.Diagnostics;
using System.Security.Cryptography;
namespace return_practical

{
    [DebuggerDisplay("{" + nameof(Name) + "}")]
    public abstract class Team
    {
        public string Name;
        public Team(string name)
        {
            Name = name;
        }

    }

    public class BasketbollTeam : Team
    {
        public BasketbollTeam(string name) : base(name)
        {

        }
    }

    public class BasketballMatch : Match<BasketbollTeam>
    {
        public BasketballMatch(BasketbollTeam home, BasketbollTeam away) : base(home, away)
        {

        }
        public override void Start()
        {
            Start(100, 200);
        }


        public override Match<BasketbollTeam> Reverse()
        {
            return new BasketballMatch(Away, Home);
        }
    }
    public class FutballTeam : Team
    {
        public FutballTeam(string name) : base(name)
        {

        }
    }


    public class FotballMatch : Match<FutballTeam>
    {
        public FotballMatch(FutballTeam home, FutballTeam away) : base(home, away)
        {

        }

        public override Match<FutballTeam> ReverseMatch()
        {
            return new FotballMatch(Away, Home);
        }

        public override void Start()
        {
            Start(1, 7);
        }
    }
}

