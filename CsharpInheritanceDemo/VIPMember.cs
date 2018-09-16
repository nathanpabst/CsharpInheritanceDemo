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
            Console.WriteLine("From VIPMembers.cs line 13: child constructor with 3 parameters");
        }

        //need to override the method in the parent class
        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }
}
