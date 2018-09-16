using System;

namespace CsharpInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Member[] clubMembers = new Member[5];

            clubMembers[0] = new NormalMember("Special Rate", "Nathan", 42, 2006);
            clubMembers[1] = new NormalMember("Special Rate", "Pollo El Diablo", 25, 2001);
            clubMembers[2] = new VIPMember("Starshine", 24, 2006);
            clubMembers[3] = new VIPMember("Peazy", 14, 2001);
            clubMembers[4] = new VIPMember("FoxyPop", 56, 2000);

            foreach (Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
            }

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

        //virtual keyword allows this method to be overriden in derived classes
        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }

    }
}
