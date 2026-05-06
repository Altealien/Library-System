using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Core
{
    public class Loan
    {
        public Book LoanedBook { get; set; }
        public Member LoanedBy { get; set; }
        public DateTime LoanedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
    }
}
