using System;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = "AA BB AB";
            var chars = document.ToCharArray();
            var characterFactory=new CharacterFactory();
            var position = 0;
            foreach (var c in chars)
            {
                var character = characterFactory.GetCharacter(c);
                character.Display(position++);
            }
            Console.Read();
        }
    }
}
