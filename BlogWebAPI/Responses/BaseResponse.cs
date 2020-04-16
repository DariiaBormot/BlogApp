using BlogWebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BlogWebAPI.Responses
{
    public class BaseResponse
    {
        public ErrorCodes ErrorCode { get; set; }
        public string Message { get; set; }

        [IgnoreDataMember]
        public string InternalMessage { get; set; }
    }

    public class BaseResponse<T> : BaseResponse
    {
        public T Data { get; set; }
    }
}