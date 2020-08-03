using System;

interface IBankAccount
{
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
    decimal Balance { get; }
}
        /*Krishna Kumar Singh
         * 7/13/2019
         * Writing code for Handling Desopite and Withdraw from Saving Account
         * SavingAccount()
         * 
         */
public class SavingAccount : IBankAccount
{
    private decimal balance;
    private decimal perDayLimit;


    // Console.WriteLine(sysTime.ToString("hh:mm:ss"));
    // Console.WriteLine(setTime.TimeOfDay);

    //   DateTime sysTime = DateTime.Now.TimeOfDay;
    //   DateTime setTime = DateTime.Parse("2012/12/12 15:03:00.000");

    /*Krishna Kumar Singh
     * 7/13/2019
     * Create Saving Account to update Per Day Limit at 24 System time.
     * 
     */


    public SavingAccount(){
        DateTime sysTime = DateTime.Now;
        DateTime setTime = DateTime.Parse("23:59:00");
        int i = TimeSpan.Compare(setTime.TimeOfDay, sysTime.TimeOfDay);
        if(i==0){
        //    Console.WriteLine("True");
            perDayLimit=0;
       // }else{
        //    Console.WriteLine("False");
        }
    }
    

    //Only Deposite
    public void Deposit(decimal amount)
    {
        balance += amount;
    }
    //Withdrawn - 1. insufficient balance 2. Withdrawal Failed
    public void Withdraw(decimal amount)
    {
        if (balance < amount)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else if ((perDayLimit + amount) > 10000) //limit is 10000
        {
            Console.WriteLine("Daily Limit Crossed");
        }else{
            balance -= amount;
            perDayLimit += amount;
            Console.WriteLine("Successfully withdraw: "+ amount);
        }
    }
    public decimal Balance
    {
        get { return balance; }
    }

    public override string ToString()
    {
        return String.Format("Saving Account Balance: "+ balance);
    }
    
}
        /*Krishna Kumar Singh
         * 7/13/2019
         * Writing code for Handling Desopite and Withdraw from Current Account
         * CurrentAccount()
         * 
         */
public class CurrentAccount : IBankAccount
{
    private decimal balance;
    public void Deposit(decimal amount)
    {
        balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        if (balance < amount)
        {
            Console.WriteLine("Low Balance");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Successfully withdraw: "+ amount);
        }
    }
    public decimal Balance
    {
        get { return balance; }
    }
    
    public override string ToString()
    {
        return String.Format("Current Account Balance : "+ balance);
    }
    
}
class Program
{
    static void Main(string[] args)
    {
       
        IBankAccount savingAccount = new SavingAccount();
        IBankAccount currentAccount = new CurrentAccount();
        int j, k;
        /*Krishna Kumar Singh
        * 7/13/2019
        * Writing Code to provide access to Saving Account and Current Account
        * do - while
        */
        do
        {
            Console.WriteLine("Press 1: For Saving Account\nPress 2: For CurrentAccount\nPress 9: For exit\n");
            j = int.Parse(Console.ReadLine());
            if(j==1||j==2){
                break;
            }else if(j==9){
                Console.WriteLine("You are successfully exited!\nThanks for taking our services");
                Console.ReadKey();
                return;
            }
            else{
                Console.WriteLine("You Enter a wrong Choice!\n Please enter again\n\n");
            }
        }while(true);
        /*Krishna Kumar Singh
         * 7/13/2019
         * Writing code for Deposite and Withdraw in Saving Account
         * if(j==1)
         */
        if (j==1){
            
            do{
                Console.WriteLine("Press 1: For Deposite in Saving Account\nPress 2: For Withdraw in Saving Account\nPress 9: For exit\n");
                k = int.Parse(Console.ReadLine());
                switch(k){
                     case 1: {
                            Console.WriteLine("Enter Amount");
                            decimal i = decimal.Parse(Console.ReadLine());
                            savingAccount.Deposit(i);
                            Console.WriteLine(savingAccount.ToString());
                          
                            break;
                        }
                    case 2: {
                            Console.WriteLine("Enter Amount");
                            decimal i = decimal.Parse(Console.ReadLine());
                            savingAccount.Withdraw(i);
                            Console.WriteLine(savingAccount.ToString());
                            break;
                    }
                     case 9:{
                             Console.WriteLine("You are successfully exited!\nThanks for taking our services\n");
                             Console.ReadLine();
                            return;
                            break;
                     }
                     default: {
                            Console.WriteLine("You Enter a wrong Choice!\n Please enter again\n\n");
                            break;
                    }

                }
            }while(true);
        }
        /*Krishna Kumar Singh
         * 7/13/2019
         * Writing code for Deposite and Withdraw in Current Account
         * if(j==2)
         * 
         */ 
    if(j==2){
        do{
            Console.WriteLine("Press 1: For Deposite in Current Account\nPress 2: For Withdraw in Current Account\nPress 9: For exit");
            k = int.Parse(Console.ReadLine());
            switch(k){
                 case 1: {
                        Console.WriteLine("Enter Amount");
                        decimal i = decimal.Parse(Console.ReadLine());
                        currentAccount.Deposit(i);
                        Console.WriteLine(currentAccount.ToString());
                        break;
                     
                    }
                case 2: {
                        Console.WriteLine("Enter Amount");
                        decimal i = decimal.Parse(Console.ReadLine());
                        currentAccount.Withdraw(i);
                        Console.WriteLine(currentAccount.ToString());
                        break;
                }
                 case 9:{
                        Console.WriteLine("You are successfully exited!\nThanks for taking our services\n");
                        Console.ReadKey();
                        return;
                            break;
                 }
                default:
                    {
                        Console.WriteLine("You Enter a wrong Choice!\n Please enter again\n\n");
                            break;
                    }
                   
            }
        }while(true);
    }    

    }
}
