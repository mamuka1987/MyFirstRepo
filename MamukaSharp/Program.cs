using System;
using System.Net;
using System.IO;

namespace MamukaSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            
            static string TestMethod(int a)
            {
                return a.ToString();
            }

            static უსაფრთხოების_მიმდევარი Getმიმდევარი(bool value)
            {
                if (value)
                    return new SecurityMan(წოდება.ახალბედა, "გელა", 4);
                return new პოლიციელი(წოდება.ახალბედა, "გელა");
            }

        }
        class SecurityMan : უსაფრთხოების_მიმდევარი
        {
            public SecurityMan(წოდება _წოდება, string name, int სამიზნესართულები) : base(_წოდება, name)
            {

                სამიზნე_სართული = სამიზნესართულები;
            }
            public int სამიზნე_სართული;

            public override void სროლა()
            {
                სროლა(false);
            }
        }


        public class პოლიციელი : უსაფრთხოების_მიმდევარი
        {
            public პოლიციელი(წოდება _წოდება, string name) : base(_წოდება, name)
            {
            }

            public override void სროლა()
            {
                throw new NotImplementedException();
            }
        }


        public abstract class Person
        {
            public Person(string name)
            {
                Name = name;
            }
            public string Name { get; set; }
        }

        public abstract class უსაფრთხოების_მიმდევარი : Person
        {
            public უსაფრთხოების_მიმდევარი(წოდება _წოდება, string name) : base(name)
            {
                წოდება = _წოდება;
            }
            public წოდება წოდება { get; set; }
            public bool ტარების_უფლება
            {
                get
                {
                    return წოდება == წოდება.ახალბედა && წოდება == წოდება.კაპიტანი ? false : true;
                }
            }
            public void სროლა(bool ნებართვა)
            {
                if (ნებართვა)
                    Console.WriteLine("Vsroulob");
                else
                {
                    throw new InvalidOperationException("Ar shemidzlia srola");
                    Console.WriteLine();
                }
            }
            public abstract void სროლა();


        }

        public enum წოდება
        {
            კაპიტანი = 0,
            მაიორი = 1,
            ახალბედა = 2
        }
    }
}

