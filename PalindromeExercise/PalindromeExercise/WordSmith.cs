using System;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string answer)
        {
            return answer.ToLower().SequenceEqual(answer.ToLower().Reverse());

        }
       
    }
}

