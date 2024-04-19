using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20B4998D273351AF, NameHash = 0xE8F2F4C4A2F01AD1)]
    public class GcGenericMissionStage : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate Stage;
        /* 0x50 */ public List<GcGenericMissionVersionProgress> Versions;
    }
}
