﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void Comparison()
        {
            int age = 25;
            string username = "Joshua";
            //Equal comparison
            bool equals = age == 41;
            bool userIsAdam = username == "Adam;";
            //Inequals comparison
            bool notEqual = age != 122;
            bool useIsNotJustin = username != "Justin";
            //Not all things are equal, reference types are not understood the same waye
            List<string> firstList = new List<string>();
            firstList.Add(username);
            List<string> secondList = new List<string>();
            secondList.Add(username);
            bool isEqual = firstList == secondList; // eventhough the two list have the same username the resut will be false since they are on different lists.
            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 24;
            bool lessThan = age < 66;
            bool lessThanOrEqual = age <= 24;

        }

        [TestMethod]
        public void AnOr()
        {
            bool trueValue = true;
            bool falseValue = false;

            //OR
            bool tORT = trueValue || trueValue; //True
            bool tOrF = trueValue || falseValue; // True
            bool fOrF = falseValue || falseValue; //False

            //AND
            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndF = falseValue && falseValue;
        }

    } 
    
   
}
