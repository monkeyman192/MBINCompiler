using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, Alignment = 0x10, GUID = 0xCED0783DBCA95F60, NameHash = 0x5AF4540465F27753)]
    public class GcSubstanceSecondaryLookup : NMSTemplate
    {
        public NMSString0x10 PrimaryID;
        public List<GcSubstanceSecondary> SecondaryChances;
    }
}
