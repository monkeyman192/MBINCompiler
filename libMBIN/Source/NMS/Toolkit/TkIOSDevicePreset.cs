using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x865B84712EF8F2F0, NameHash = 0x85F192FA)]
    public class TkIOSDevicePreset : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkGraphicsSettings DefaultGraphicsSettings;
        [NMS(Index = 1)]
        /* 0x208 */ public List<NMSString0x100> ModelIdentifiers;
        [NMS(Index = 0)]
        /* 0x218 */ public NMSString0x100 DeviceName;
    }
}
