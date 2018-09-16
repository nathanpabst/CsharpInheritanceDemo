using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpInheritanceDemo
{

    //The VIP member class is derived from Member class and inherits: annualFee field, ToString and CalculateAnnualFee methods, and a constructor
    class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince) : base (name, memberID, memberSince)
        {
            Console.WriteLine("child constructor with 3 parameters");
        }


        public void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }
}
