using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x994EFDCC977485D6, NameHash = 0x952196ED)]
    public class GcModSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcModSettingsInfo> Data;
    }
}
