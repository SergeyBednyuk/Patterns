using System.Collections.Generic;

namespace FlyWeight
{
    class CharacterFactory
    {
        private readonly Dictionary<char,Character> chars=new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            if (!chars.ContainsKey(key))
            {
                if (key == ' ')
                {
                    chars.Add(key,new WhiteSpace());
                }
                else
                {
                    chars.Add(key,new LatinCharacter(){Symbol = key});
                }
            }
            return chars[key];
        }
    }
}
