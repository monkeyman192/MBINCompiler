using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50DA776AC0AB5593, NameHash = 0xCB6FA010D5725BB5)]
    public class GcModSettings : NMSTemplate
    {
        public List<GcModSettingsInfo> Data;
    }
}
