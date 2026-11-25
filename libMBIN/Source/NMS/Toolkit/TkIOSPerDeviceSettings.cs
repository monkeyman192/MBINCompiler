using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9772AEF763CB129C, NameHash = 0xF78534FE)]
    public class TkIOSPerDeviceSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkIOSDevicePreset> DevicePresets;
    }
}
