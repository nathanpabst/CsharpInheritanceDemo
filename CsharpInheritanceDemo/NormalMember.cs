using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpInheritanceDemo
{
    //the NormalMember class is derived from the Member class and inherits the ToString method and two constructors 
    class NormalMember : Member
    {
        public NormalMember()
        {
            Console.WriteLine("child constructor with no parameter");
        }
        public NormalMember(string remarks, string name, int memberID, int memberSince) : base (name, memberID, memberSince)
        {
            Console.WriteLine("child constructor with 4 parameters.");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }

    }
}
