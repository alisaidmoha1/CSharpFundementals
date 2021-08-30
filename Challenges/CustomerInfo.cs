using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class CustomerInfo // class
    {
        string _firstName; // these are fields
        string _lastName;
        string _email;
        decimal _phoneNumber;
        string _address;
        string _Gender;
        //constructor has the same name as the class and it can have parameters, and does not return value
        public CustomerInfo(string FirstName, string LastName, string Email, decimal PhoneNumber, string address, string Gender)
        { // this refers to an object of customerinfo class
            this._firstName = FirstName;
            this._lastName = LastName;
            this._email = Email;
            this._phoneNumber = PhoneNumber;
            this._Gender = Gender;
            this._address = address;
        }
        // Method
        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0} \n Email = {1} \n Phone Number: {2} \n Gender: {3} \n Address: {4}" , this._firstName + " " + this._lastName, this._email, this._phoneNumber, this._Gender, this._address );

        }



    }

    public class Math
    {

        int _num1;
        int _num2;

        public Math(int Num1, int Num2)
        {
            this._num1 = Num1;
            this._num2 = Num2;
        }

        public int Product()
        {
            return this._num1 * this._num2;
        }
    }

    public class Employee
    {
        string _firstName;
        string _lastName;
        string _email;
        float _phoneNumber;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; set; }
        public float PhoneNumber { get; private set; }

        public void EmployeeFullName()
        {
            Console.WriteLine(_firstName + " " + _lastName);
        }

        public void EmployeePhoneNumber()
        {
            Console.WriteLine("Phone Number: {0}", _phoneNumber);
        }

    }

    public class FullTimeEmployee : Employee
    {
        float _yearlySalary;
        float _salaryIncrease;

        public float YealySalary
        {
            get
            {
                return _yearlySalary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Salary cannot be empty or zero");
                }
            }
        }
        public float SalaryIncrease

        {

            get
            {
                return _salaryIncrease;

            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Salary Increase cannot be empty or zero");
                }
            }


        }

    }

  
   //public class PartTimeEmployee : Employee
    //{
    //    float HourlyRate;
    //    float OverTimeRate;

    //    public float HourlyRaye { get; private set; }
    //   public float OverTimeRate { get; private set; }
    //}

}
