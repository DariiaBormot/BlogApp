using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebAPI.Filters.CustomExceptions
{
    public class InvalidIdExeption : ApiException
    {
        public InvalidIdExeption(string message, string additionalInfo) :base(message,Enums.ErrorCodes.InvalidId, additionalInfo)
        {

        }
    }
}