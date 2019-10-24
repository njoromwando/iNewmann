using DAL.Common;

namespace DAL.Finance
{
    public class ChartOfAccountGroup : BaseEntity
    {
        public string GroupCode { get; set; }
        public string SubGroupCode { get; set; }
        public string Description { get; set; }

    }

}
