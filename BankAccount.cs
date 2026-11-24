using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountNew
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
