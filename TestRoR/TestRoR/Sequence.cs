using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestRoR
{
    class Sequence
    {
        public List<int> digits = new List<int>();
        public List<string> sequence = new List<string>();
        public int i;


        public Sequence(int n, int k) //метод, создающий последовательность
        {
            sequence.Add(n.ToString()); //добавляем в последовательность первый элемент, задающий эту самую последовательность
            Console.WriteLine(sequence[0]);
            i = 0;
            while (i < (k - 1))
            {
                foreach (char element in sequence[i])
                    digits.Add(int.Parse(element.ToString()));

                var addition = NewLine(digits);
                sequence.Add(addition);

                Console.WriteLine(sequence[i + 1]);
                i++;
                digits.Clear();
            }

        }

        public static string NewLine(List<int> digits) //метод, создающий строки для последовательности
        {
            StringBuilder s = new StringBuilder(); 

            int count = 1;

            if (digits.Count == 1)
            {
                s.Append(1);
                s.Append(digits[0]);
                return s.ToString();
            }

            for (int i = 0; i < digits.Count - 1; i++)
            {
                if ((digits[i] != digits[i + 1] && digits.Count != 1) || i == digits.Count - 1)
                {
                    s.Append(count);
                    s.Append(digits[i]);
                    count = 0;
                }
                count++;
            }

            s.Append(count);
            s.Append(digits[digits.Count - 1]);


            return s.ToString();
        }
    }
}
