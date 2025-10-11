using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountApp.Exceptions;

namespace AccountApp.Model
{
    internal class Account
    {
        public int Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }
        public decimal Balance { get; set; }

        public Account()
        {

        }

        public Account(int id, string iban, string firstname, string lastname, string ssn, decimal balance)
        {
            Id = id;
            Iban = iban;
            Firstname = firstname;
            Lastname = lastname;
            Ssn = ssn;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Iban: {Iban}, Firstname: {Firstname}, Lastname: {Lastname}, Ssn: {Ssn}, Balance: {Balance}";
        }

        /// <summary>
        /// Deposits an amount of money to the <see cref="Account" />.
        /// </summary>
        /// <param name="amount">The amount of money</param>
        /// <exception cref="ArgumentException"></exception>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount < 0) throw new NegativeAmountException("Error. Amount must not be negative.");
                Balance += amount;
            } catch (NegativeAmountException e) 
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        /// <summary>
        /// Withdraws a certain amount of money from the <see cref="Account" /> if the provided SSN is valid.
        /// </summary>
        /// <param name="amount">The amount to be withdrawn.</param>
        /// <param name="ssn">The account ssn.</param>
        public void Withdraw(decimal amount, string ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnException(ssn);
                if (ssn != Ssn) throw new InvalidSsnException(ssn);
                if (amount < 0) throw new NegativeAmountException("Error. Amount must not be negative.");
                if (amount > Balance) throw new InsufficientBalanceException("Error. Balance is insufficient.");

                Balance -= amount;
            } catch(NegativeAmountException e) 
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (InvalidSsnException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.StackTrace);
            }

    }
}
