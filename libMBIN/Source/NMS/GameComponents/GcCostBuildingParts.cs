using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xA50B10766E494BB3, NameHash = 0x61447A1079C43833)]
    public class GcCostBuildingParts : NMSTemplate
    {
        public NMSString0x20A Description;
        public List<GcBuildingCostPartCount> RequiredParts;
    }
}