using System;
using System.Collections.Generic;
using System.Text;

namespace NumericConversion
{
    public class BigNumber
    {
        private List<int> numbers;

        // c'tors
        public BigNumber() : this("0") { }

        public BigNumber(String s)
        {
            this.numbers = new List<int>();
            for (int i = 0; i < s.Length; i++)
                this.numbers.Add(s[i] - '0');

            this.RemoveLeadingZeroes();
        }

        // properties
        public bool IsNull
        {
            get
            {
                for (int i = 0; i < this.numbers.Count; i++)
                {
                    if (this.numbers[i] != 0)
                        return false;
                }

                return true;
            }
        }

        public int Length
        {
            get
            {
                return this.numbers.Count;
            }
        }

        // indexer
        public int this [int i]
        {
            get
            {
                return this.numbers[i];
            }
        }


        // methods
        public BigNumber DivideByTwo()
        {
            StringBuilder result = new StringBuilder();

            int rest = 0;
            for (int i = 0; i < this.numbers.Count; i++)
            {
                int current = (this.numbers[i] + 10 * rest) / 2;
                result.Append(current);
                rest = (this.numbers[i] + 10 * rest) % 2;
            }

            return new BigNumber(result.ToString());
        }


        public int RemainderModulusTwo()
        {
            return (this.numbers[this.numbers.Count - 1] % 2);
        }

        private void RemoveLeadingZeroes()
        {
            if (this.numbers.Count != 0)
            {
                while (this.numbers[0] == 0)
                {
                    this.numbers.RemoveAt(0);

                    if (this.numbers.Count == 0)
                    {
                        this.numbers.Add(0);
                        break;
                    }
                }
            }
        }

        // overrides
        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.numbers.Count; i++)
                sb.Append(this.numbers[i]);

            return sb.ToString();
        }
    }
}
