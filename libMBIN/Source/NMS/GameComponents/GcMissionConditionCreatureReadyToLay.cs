using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A42C8C469B750DE, NameHash = 0x6E93108EAA8C6218)]
    public class GcMissionConditionCreatureReadyToLay : NMSTemplate
    {
        public bool PrimaryCreatureOnly;
    }
}
