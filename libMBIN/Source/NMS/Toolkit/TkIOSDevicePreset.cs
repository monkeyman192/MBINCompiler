using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1857E6667515729C, NameHash = 0x85F192FA)]
    public class TkIOSDevicePreset : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkGraphicsSettings DefaultGraphicsSettings;
        [NMS(Index = 1)]
        /* 0x208 */ public List<TkIOSDeviceModel> Models;
        [NMS(Index = 0)]
        /* 0x218 */ public NMSString0x100 DeviceName;
    }
}
