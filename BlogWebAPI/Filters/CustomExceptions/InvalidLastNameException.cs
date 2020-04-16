using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebAPI.Filters.CustomExceptions
{
    public class InvalidLastNameException : ApiException
    {
        public InvalidLastNameException(string message, string additionalInfo) : base(message, Enums.ErrorCodes.InvalidUserLastName, additionalInfo)
        {

        }
    }
}