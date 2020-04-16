using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebAPI.Filters.CustomExceptions
{
    public class InvalidTitleExeption : ApiException
    {
        public InvalidTitleExeption(string message, string additionalInfo) : base(message, Enums.ErrorCodes.InvalidTitle, additionalInfo)
        {

        }
    }
}