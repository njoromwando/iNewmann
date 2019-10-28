using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.ViewModels.Common
{
   public class Common
    {
        public class ResponseMessage
        {
            public string Status { get; set; }
            public string Message { get; set; }
            public string HighlightFieldId { get; set; }
            public string UniqueReferenceCode { get; set; }
        }
    }
}
