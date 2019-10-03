using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x2D11F57910D9373A, NameHash = 0x5BD84E5380495165)]
    public class GcCostGameMode : NMSTemplate
    {
        public bool InvertMode;
        public GcGameMode Mode;
        [NMS(Size = 0x20)]
        public string CostStringCantAfford;
    }
}
