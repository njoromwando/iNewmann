using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.ViewModels.Finance
{
  public  class FinanceViewModels
    {
        public class COA
        {
            public string AccountCode { get; set; }
            public string Description { get; set; }
            public string AccountGroup { get; set; }
            public string AccountSubGroup { get; set; }

        }

        public class COAGroup
        {
            public string GroupCode { get; set; }
            public string SubGroupCode { get; set; }
            public string Description { get; set; }

        }

    }
}
