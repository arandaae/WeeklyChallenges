using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if(vals[i] == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //throw new NotImplementedException();

            if(numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();

            var number = false;
            var lower = false;
            var upper = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsNumber(password[i]))
                {
                    number = true;
                }

                if (char.IsLower(password[i]))
                {
                    lower = true;
                }

                if (char.IsUpper(password[i]))
                {
                    upper = true;
                }
            }

            if (number == true && lower == true && upper == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();

            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            //throw new NotImplementedException();

            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();

            if(divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //throw new NotImplementedException();

            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            //throw new NotImplementedException();

            var list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    list.Add(i);
                }

            }
                return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //throw new NotImplementedException();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
