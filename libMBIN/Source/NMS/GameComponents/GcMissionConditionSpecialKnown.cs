using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x18B1DA9A905699E0, NameHash = 0x4F66A082950329D8)]
    public class GcMissionConditionSpecialKnown : NMSTemplate
    {
        public NMSString0x10 SpecialID;
    }
}
