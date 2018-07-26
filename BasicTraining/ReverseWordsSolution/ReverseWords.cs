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
            StringBuilder currentWord;
            string returnSentence = "";

            int wordCounter = 1;

            foreach (string word in words)
            {
                

                if(wordCounter != 1){
                    returnSentence = returnSentence + " ";
                }

                currentWord = new StringBuilder();
                for(int i = word.Length - 1; i >= 0; i--)
                {
                    currentWord.Append(word[i]);
                }

                returnSentence = returnSentence + currentWord.ToString();

                wordCounter++;

            }

            return returnSentence;
        }
    }
}
