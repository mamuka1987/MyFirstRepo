using System;
using System.Collections.Generic;
using System.Text;

namespace return_practical
{
    class LiveStream
    {
        public delegate void PublicLivePeople(int live);

        public PublicLivePeople publicLivePeople { get; set; }



        public void Start()
        {
            while (true)
            {
                var count = GenerationRandomNumber.Generate(100, 200000);
                publicLivePeople(count);
                break;
            }
        }

        
    }
}
