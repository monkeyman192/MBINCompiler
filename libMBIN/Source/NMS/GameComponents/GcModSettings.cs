using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0FBE60CB863BACD, NameHash = 0xCB6FA010D5725BB5)]
    public class GcModSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcModSettingsInfo> Data;
    }
}
