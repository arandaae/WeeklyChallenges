using System;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            
            var answer = minuend - subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            var answer = number1 + number2;
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {           
                return Math.Min(number1, number2);
                
        }

        public long Multiply(long factor1, long factor2)
        {
            var answer =factor1 * factor2;
            return answer;
        }

        public string GetGreeting(string nameOfPerson)
        {
           
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
            //return String.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!";

                      
        }

        public string GetHey()
        {
            
            return "HEY!";
        }
    }
}
