using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_DI.Currency
{
    public interface ICurrency
    {
        //Dependency Injection - When a class depends on some type of object being "injected" into it. DI allow for "interchangeable parts"
        string Name { get; } // no set because we don't want to change what is called.
        decimal Value { get; }// again no set because the value of the curreny is not gonna change
    }
}
