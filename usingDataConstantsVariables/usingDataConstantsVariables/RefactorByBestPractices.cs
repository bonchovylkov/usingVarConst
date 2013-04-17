using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace usingDataConstantsVariables
{
    class RefactorByBestPractices
    {
        public void PrintStatistics(double[] arr)
        {
            Console.WriteLine(FindMaxNumber(arr));
            Console.WriteLine(FindMinNumber(arr));
            Console.WriteLine(FindAvarage(arr));
        }

        private double FindAvarage(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double avg = sum / numbers.Length;
            return avg;
        }

        private double FindMinNumber(double[] numbers)
        {
            double minNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            return minNumber;
        }

        private double FindMaxNumber(double[] numbers)
        {
            double maxNumber = double.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            return maxNumber;
        }

    }
}
