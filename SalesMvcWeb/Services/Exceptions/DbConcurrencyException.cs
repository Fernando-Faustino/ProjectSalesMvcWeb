using System;

namespace SalesMvcWeb.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        { 

        }
    }
}
