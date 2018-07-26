using System;
using System.Text;

namespace ReverseWordsSolution
{
    public static class ReverseWords
    {
        public static string Reverse(string sentence)
        {
            if(sentence == null)
            {
                throw new ArgumentNullException();
            }

            string[] words = sentence.Split(' ');
            StringBuilder currentWord = new StringBuilder();

            int wordCounter = 1;

            foreach (string word in words)
            {
                
                if(wordCounter != 1){
                    currentWord.Append(" ");
                }
                
                for(int i = word.Length - 1; i >= 0; i--)
                {
                    currentWord.Append(word[i]);
                }

                wordCounter++;

            }

            return currentWord.ToString();
        }
    }
}
