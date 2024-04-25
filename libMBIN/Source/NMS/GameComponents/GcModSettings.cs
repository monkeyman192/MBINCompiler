using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFD713C3B35709E3A, NameHash = 0xCB6FA010D5725BB5)]
    public class GcModSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcModSettingsInfo> Data;
    }
}
