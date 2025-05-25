using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCode
{
    public class RomanNumerals
    {
        private static Dictionary<char, int> romanNumbers = new Dictionary<char, int>()
        {
            {'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}
        };

        public static void FindRomanNumerals(string InputString)
        {
            foreach(var input in InputString)
            {
                if (romanNumbers.ContainsKey(input)){
                    Console.WriteLine(input);
                }
            }
            
        }
        public static void ConvertRomanNumeralToInteger(string InputString)
        {
            int total = 0;
            int lastValue = 0;
            for(int i = InputString.Length - 1; i >= 0; i--)
            {
                int newValue = romanNumbers[InputString[i]];
                if (newValue < lastValue)
                {
                    total -= newValue;                    
                }
                else
                {
                    total += newValue;                    
                }
                lastValue = newValue;
            }

            Console.WriteLine(total);
        }
    }

    
}
