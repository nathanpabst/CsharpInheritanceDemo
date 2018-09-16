using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpInheritanceDemo
{
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
