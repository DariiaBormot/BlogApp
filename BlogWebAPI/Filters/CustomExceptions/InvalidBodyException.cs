using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebAPI.Filters.CustomExceptions
{
    public class InvalidBodyException : ApiException
    {
        public InvalidBodyException(string message, string additionalInfo) : base(message, Enums.ErrorCodes.InvalidBody, additionalInfo)
        {

        }
    }
}