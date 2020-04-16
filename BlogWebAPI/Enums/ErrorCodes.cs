using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebAPI.Enums
{
    public enum ErrorCodes
    {
        Success = 0,
        General = 1,
        InvalidId = 2,
        InvalidUserName = 3,
        InvalidUserLastName = 4,
        InvalidTitle = 5,
        InvalidBody = 6
        
    }
}