using System;

namespace return_practical
{
    class GenerationRandomNumber
    {
        public static Random  Random = new Random();
        

        public static int Generate(int start, int end)
        {
            
            var randomNumber = Random.Next(start, end);
            return randomNumber;
        }

    }
}

