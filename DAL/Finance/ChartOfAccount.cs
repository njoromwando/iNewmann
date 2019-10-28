using DAL.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Finance
{
    public class ChartOfAccount : BaseEntity
    {
        public string AccountCode { get; set; }
        public string Description { get; set; }
        public string AccountGroup { get; set; }
        public string AccountSubGroup { get; set; }
    }

}
