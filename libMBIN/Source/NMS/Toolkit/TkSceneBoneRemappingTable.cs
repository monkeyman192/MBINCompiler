using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x10, GUID = 0x68DDDBFC00E41FCE, NameHash = 0xAF2831AAF7DE1710)]
    public class TkSceneBoneRemappingTable : NMSTemplate
    {
        public List<TkSceneBoneRemapping> BoneMappings;
    }
}
