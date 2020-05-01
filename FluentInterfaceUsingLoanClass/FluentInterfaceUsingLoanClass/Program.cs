using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaceUsingLoanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentLoan loan = new FluentLoan();
            loan.LoanAccount(123456789)
                    .HasBalanceOf(450)
                    .DueOn(DateTime.Today)
                    .HasAnnualRateOf(23.15)
                    .HasLimitOf(2000);

            Console.Read();
        }
    }

    public class Loan
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal CreditLine { get; set; }
        public double APR { get; set; }
        public DateTime DueDate { get; set; } 

    }


    /// <summary>
    /// Wrapper class to achieve method chaining 
    /// </summary>
    public class FluentLoan
    {
        private Loan loan = new Loan();
        public FluentLoan LoanAccount(int AccountNumber)
        {
            loan.AccountNumber = AccountNumber;
            return this;
        }
        public FluentLoan HasBalanceOf(int Balance)
        {
            loan.Balance = Balance;
            return this;
        }

        public FluentLoan HasAnnualRateOf(double APR)
        {
            loan.APR = APR;
            return this;
        }
        public FluentLoan HasLimitOf(decimal CreditLine)
        {
            loan.CreditLine = CreditLine;
            return this;
        }

        public FluentLoan DueOn(DateTime DueDate)
        {
            loan.DueDate = DueDate;
            return this;
        }
    }

}

