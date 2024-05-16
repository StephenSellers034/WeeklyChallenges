using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();
                var lower = words.Select(x => x.ToLower()).ToList();
                containWord = lower.Contains(word);
            }
            if(ignoreCase == false)
            {
                containWord = words.Contains(word);
            }
            
            return containWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var prime = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    prime = true;

                }
            }
            if((num == 2) || (num == 3))
            {
                 prime = true;
            }
            if (num == 1)
            {
                prime = false;
            }


            return prime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int last = -1;
            bool lastOne;

            for(int i = 0; i < str.Length; i++)
            {
                lastOne = true;

                for(int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        lastOne = false;
                    }
                }

                if(lastOne == true)
                {
                    last = i;
                }
            }
            return last;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxc = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                int count = 1;

                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    count++;
                }
                if(count > maxc)
                {
                    maxc = count;
                }
            }
            return maxc;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nineE = new List<double>();
            if(elements == null || n <= 0 || n > elements.Count)
            {
                return nineE.ToArray();
            }
            
            for(int i = n - 1; i < elements.Count; i += n)
            {
                nineE.Add(elements[i]);
            }
            return nineE.ToArray();
        }
    }
}
