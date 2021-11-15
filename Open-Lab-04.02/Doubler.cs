using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original_string)
        {
            int position = 0;
            char[] characters = original_string.ToCharArray();
            char[] New_Characters = new char[characters.Length * 2];
            foreach (char character in characters)
            {
                New_Characters[position] = character;
                New_Characters[position + 1] = character;

                position += 2;
            }
            return new string(New_Characters);
        }
    }
}
