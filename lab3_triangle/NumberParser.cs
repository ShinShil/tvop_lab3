using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_triangle
{
    class NumberParser
    {
        public Int64 Value { get; private set; }
        private bool parsed;
        private string userInput;
        public NumberParser(string userInput)
        {
            this.userInput = userInput;
            Int64 num;
            parsed = Int64.TryParse(this.userInput, out num);
            if(userInput.Equals("0"))
            {
                throw new Exception("Unhadled input case: 0");
            }
            Value = num;
        }
        public bool IsComplex
        {
            get
            {
                return !parsed && userInput.EndsWith("i");
            }
        }
        public bool IsFloat
        {
            get
            {
                Double tmp;
                return !parsed && Double.TryParse(userInput, out tmp);
            }
        }
        public bool IsNegative
        {
            get
            {
                return parsed && Value < 0;
            }
        }
        public bool IsTooBig
        {
            get
            {
                return parsed && Value > Math.Pow(10, 9);
            }
        }

        public bool isInvalidInput
        {
            get
            {
                return !IsComplex && !IsFloat && !parsed;
            }
        }
    }
}
