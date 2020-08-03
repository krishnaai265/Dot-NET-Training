using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding5
{
    interface IAccount{
        void open();
    }
    interface IRDAccount{
        void close();
    }
    class Account : IRDAccount, IAccount {
      
        public void close()
            {
                Console.WriteLine("Opps! I am closed");
             //   throw new NotImplementedException();
            }

            public void open()
            {
                Console.WriteLine("Hey! I am open now");
       //         throw new NotImplementedException();
            }
        }

    

    abstract class RDAccount
    {
        public abstract void openRD();
       
    }

    abstract class BankAccount : RDAccount{
        public void welcomeMessage() {
            Console.WriteLine("Hey! Non Abstract Method");
        }
        public abstract void deposite();
        public abstract void withdrawal();
        public abstract void balance();
    }
    class SavingAccount : BankAccount {
        public override void balance()
        {
            Console.WriteLine("Saving");
        }

        public override void deposite()
        {
            throw new NotImplementedException();
        }

        public override void openRD()
        {
            Console.WriteLine("RDAccount");
        }

        public override void withdrawal()
        {
            throw new NotImplementedException();
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount s = new SavingAccount();
            s.balance();
            s.openRD();
            s.welcomeMessage();
            

            Account a = new Account();
            a.open();
            a.close();
            Console.ReadKey();

        }
    }
}
