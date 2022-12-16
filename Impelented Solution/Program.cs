using System;
using System.Collections.Generic;
namespace Impelented_Solution
{




    class Cap
    {
        public string GetColor()
        {
            return color;
        }
        private string color = "Witeli";
    }
    class Human
    {
        public void Think()
        {
            Brain brain = new Brain();
            brain.Think();
        }
        Cap cap = new Cap();

        public void InspectedCap()
        {
            Console.WriteLine($"Chemi Kepka aris {cap.GetColor()} feris");
        }
        public class Mozgi
        {
            public Mozgi()
            {
                Console.WriteLine("sg zma ");
            }
            
        }

        private class Brain
        {
            public void Think()
            {
                Console.WriteLine("me vfiqrob chemi tvinit da");
            }

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Human.Mozgi mozgi = new Human.Mozgi();

            Human human = new Human();

            human.Think();
            human.InspectedCap();

            MyStruct myStruct = new MyStruct();
            myStruct.X = 5;
            myStruct.Y = 1;
            myStruct.Print();

            MyClass myClass = new MyClass();
            myClass.X = 2;
            myClass.Y = 4;
            myClass.Print();
        }

    }
    class MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"MyClass X: {X} X: {Y}");
        }
    }
    struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"Stryct X: {X} X: {Y}");
        }
    }
}
