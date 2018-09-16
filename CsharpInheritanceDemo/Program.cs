using System;

namespace CsharpInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalMember mem1 = new NormalMember("special rate", "Nathan", 42, 2006);
            Console.Read();
        }
    }

    class Member
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;

        public override string ToString()
        {
            return "\nName: " + name + "\nMemberId: " + memberID + "\nMemberSince: " + memberSince + "\nTotal Annual Fee: " + annualFee;
        }

        public Member()
        {
            Console.WriteLine("Member is a parent constructor with no parameters");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Member is a parent constructor with 3 parameters");

            name = pName;
            memberSince = pMemberSince;
            memberID = pMemberID;

        }

    }
}
