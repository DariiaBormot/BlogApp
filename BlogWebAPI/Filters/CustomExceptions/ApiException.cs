using BlogWebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebAPI.Filters.CustomExceptions
{
    public class ApiException : Exception
    {
        public ErrorCodes ErrorCodes { get; set; }
        public string AdditionalInfo { get; set; }

        public ApiException(string message, ErrorCodes codes, string additionalInfo = null) : base(message)
        {
            ErrorCodes = codes;
            AdditionalInfo = additionalInfo;
        }
    }
}