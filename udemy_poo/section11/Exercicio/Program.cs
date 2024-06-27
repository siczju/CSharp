using Exercicio.Entities;
using Exercicio.Entities.Exceptions;
using System.Globalization;

namespace Exercicio;
public class Program { 
 public static void Main(){

    Console.WriteLine("Enter account data");

    Console.Write("Number: ");
    int Number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string Holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double InitialBalance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double WithdrawLimit = double.Parse(Console.ReadLine());

    Account acc = new Account(Number, Holder, InitialBalance, WithdrawLimit);

    Console.Write("\nEnter amount for withdraw: ");
    double Amount = double.Parse(Console.ReadLine());

        try
        {
            acc.Withdraw(Amount);
            Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
        } catch (NotEnoughBalanceToWithdrawException ex){
            Console.WriteLine("Withdraw error: " + ex.Message);
        } catch(WithdrawExceedsLimitException ex)
        {
            Console.WriteLine("Withdraw error: " + ex.Message);
        }
        
    }
}