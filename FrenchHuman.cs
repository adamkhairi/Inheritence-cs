using System;

namespace Inheritence_cs
{
    public class FrenchHuman : AmericanHuman
    {
        public bool isHuman;

        public FrenchHuman(string name, int age, string email, bool isHuman) : base(name, age, email)
        {
         
            this.isHuman = isHuman;
        }

        public void Say()
        {
            Console.WriteLine("Hello");
        }

        public override void Language()
        {
            Console.WriteLine("Je la langue Française");
        }
    }
}
