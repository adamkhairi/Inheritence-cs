using System;

namespace Inheritence_cs
{
    public class AmericanHuman
    {
        public string name;
        public int age;
        protected string email;

        
        public AmericanHuman(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        

        public virtual void Color()
        {
            Console.WriteLine("White");
        }
        
        public virtual void Language()
        {
            Console.WriteLine("I speak English");
        }
        
    }
}