using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string CheckPrimeNumber(int primeNumber)
        {
            string prime = "Prime Number";
            string notPrime = "Not a Prime Number";

            if (primeNumber <= 1 || primeNumber % 2 == 0)
            {
                return notPrime;
            }
            else if (primeNumber == 2)
            {
                return prime;
            }

            var boundary = (int)Math.Floor(Math.Sqrt(primeNumber));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (primeNumber % i == 0)
                {
                    return notPrime;
                }
            }

            return prime;
        }

        public string PrintTag(string tag, string data)
        {
            return "<" + tag + ">" + data + "</" + tag + ">";
        }

        public string ReverseString(string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int[] SortNumbers(string sortType, int[] data)
        {
            int[] sorted = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                sorted[i] = data[i];
            }

            if (sortType == "Ascending")
            {
                Array.Sort(sorted);
                return sorted;
            }
            else
            {
                sorted = sorted.OrderByDescending(c => c).ToArray();
                return sorted;
            }
        }

        public int SumOfDigits(int digits)
        {
            int result = digits.ToString().Sum(c => c - '0');
            return result;
        }
    }
}
