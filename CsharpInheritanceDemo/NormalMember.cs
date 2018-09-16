using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpInheritanceDemo
{
    //the NormalMember class is derived from the Member class and inherits the ToString method, the annualFee field and two constructors 
    class NormalMember : Member
    {
        public NormalMember()
        {
            Console.WriteLine("From NormalMembers.cs line 12: child constructor with no parameter");
        }
        public NormalMember(string remarks, string name, int memberID, int memberSince) : base (name, memberID, memberSince)
        {
            Console.WriteLine("From NormalMembers.cs line 16: child constructor with 4 parameters.");
            Console.WriteLine("From NormalMembers.cs line 17: Remarks = {0}", remarks);
        }

        //this keyword overrides the method in the parent class
        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }

    }
}
