using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangtur
{
    public class GameLogic
    {
        public const int MaxSize = 173;
        public const int MaxFails = 6;
        private int fails = 0;
        private String word;
        private String currentGuess;
        private static readonly Char[] underscore;
        private Dictionary<Char, List<int>> map;
        private List<Char> letters = new List<char>();

        static GameLogic()
        {
            underscore = new Char[MaxSize];
            for (int i = 0; i < MaxSize; i++)
            {
                underscore[i] = '_';
            }
        }

        public GameLogic(String secretWord)
        {
            if (secretWord.Length > MaxSize)
            {
                throw new ArgumentException("Input must be at most " + MaxSize + " characters long.");
            }
            if (secretWord.Length <= 0)
            {
                throw new ArgumentException("Input must be at 1 characters long.");
            }

            for (int i = 'A'; i <= 'Z'; i++)
            {
                letters.Add((Char)i);
            }
            letters.Add('Æ');
            letters.Add('Ø');
            letters.Add('Å');

            word = secretWord.ToUpper();
            currentGuess = new string(underscore, 0, word.Length);

            map = new Dictionary<char, List<int>>();
            for (int i = 0; i < word.Length; i++)
            {
                if (!letters.Contains(word[i])) {
                    throw new ArgumentException("Illegal character '" + word[i] + "'. Only danish alphabet is allowed. ");
                }
                AddToMap(word[i], i);
            }
        }

        private void AddToMap(char v, int i)
        {
            if (!map.ContainsKey(v))
            {
                map.Add(v, new List<int>());
            }
            map[v].Add(i);
        }

        public void Guess(Char ch)
        {
            if (fails >= MaxFails)
            {
                return;
            }
            Char c = Char.ToUpper(ch);

            if (map.ContainsKey(c))
            {
                foreach (var i in map[c])
                {
                    currentGuess = ReplaceAt(currentGuess, i, c);
                }
            } else
            {
                fails++;
            }
            
            int index = letters.IndexOf(c);
            if (index != -1)
            {
                letters[index] = '_';
            }
        }

        public bool Attempt(String attempt)
        {
            if (fails >= MaxFails)
            {
                return false;
            }
            bool result = word.Equals(attempt.ToUpper());
            if (!result)
            {
                fails++;
            } else
            {
                currentGuess = word;
            }
            return result;
        }

        private String ReplaceAt(string currentGuess, int i, char c)
        {
            Char[] array = currentGuess.ToCharArray();
            array[i] = c;
            return new String(array);
        }

        public String CurrentGuess
        {
            get { return currentGuess; }
        }

        public List<Char> Letters {
            get { return letters; }
        }

        public int Fails
        {
            get { return fails; }
        }
    }
}
