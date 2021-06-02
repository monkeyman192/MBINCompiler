using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x5E795C71E43EA2BE, NameHash = 0x5BD84E5380495165)]
    public class GcCostGameMode : NMSTemplate
    {
        public bool InvertMode;
        public GcGameMode Mode;
        public NMSString0x20A CostStringCantAfford;
    }
}
