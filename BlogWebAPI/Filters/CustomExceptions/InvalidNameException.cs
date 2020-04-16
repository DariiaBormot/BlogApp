﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebAPI.Filters.CustomExceptions
{
    public class InvalidNameException : ApiException
    {
        public InvalidNameException(string message, string additionalInfo) : base(message, Enums.ErrorCodes.InvalidUserName, additionalInfo)
        {

        }
    }
}