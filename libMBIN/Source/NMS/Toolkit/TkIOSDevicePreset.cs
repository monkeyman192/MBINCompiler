using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC4AB47DF93441898, NameHash = 0x85F192FA)]
    public class TkIOSDevicePreset : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkGraphicsSettings DefaultGraphicsSettings;
        [NMS(Index = 1)]
        /* 0x200 */ public List<NMSString0x100> ModelIdentifiers;
        [NMS(Index = 0)]
        /* 0x210 */ public NMSString0x100 DeviceName;
    }
}
