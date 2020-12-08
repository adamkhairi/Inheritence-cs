namespace Inheritence_cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AmericanHuman jessy = new AmericanHuman("Jessy", 30, "example@email.com");
            FrenchHuman frencois = new FrenchHuman("Fencois",80,"email@mail.com",true);
            
            jessy.Color();
            jessy.Language();
            
            frencois.Color();
            frencois.Say();
            frencois.Language();
        }
    }
}