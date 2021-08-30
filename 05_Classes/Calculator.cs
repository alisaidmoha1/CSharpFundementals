using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {

        // addition method
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        // Subtraction

        public int Sub( int numOne, int numTwo)
        {
            int result = numOne - numTwo;
            return result;
        }

        public double Sub (double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        // Mult

        public int Diff(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public double Diff (double num1, double num2)
        {
            return num1 * num2;
        }

        // Division

        public int Div(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

        public double Div(double num1, double num2)
        {
            return num1 / num2;
        }

        public int Remainder (int x, int y)
        {
            return x % y;
        }

        // Age Calculation

        public int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            double ageRounded = Math.Floor(totalAgeInYears);
            int years = Convert.ToInt32(ageRounded);
            return years;
        }
    }
}
