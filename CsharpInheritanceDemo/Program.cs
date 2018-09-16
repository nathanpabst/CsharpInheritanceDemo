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

            //using GetType() and typeof to determine the run time type for clubMembers[0]
            //GetType() method returns the runtime type of an object
            //typeof() method takes the name of a data type (else.g. int, float, ArgumentOutOfRangeException tthe name of a class) and returns the type of that name, which we can then compare with the result of the GetType() method on the left.)
            //the following if statement will return "No" as the output since clubMembers[0] is a normal member.

            //if (clubMembers[0].GetType() == typeof(VIPMember))
            //    Console.WriteLine("Yes, this is a VIP member");
            //else
            //    Console.WriteLine($"From Program.cs line 20: No, this is a normal member");

            //polymorphism example: at system runtime, the program is using the CalculateAnnualFee() method from the correct child class even when that object is declared to be of Member type.
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
            Console.WriteLine("From Program.cs line 47: Member is a parent constructor with no parameters");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("From Program.cs line 52: Member is a parent constructor with 3 parameters");

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
