using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcCostBuildingParts : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Description;
        public List<GcBuildingCostPartCount> RequiredParts;
    }
}
