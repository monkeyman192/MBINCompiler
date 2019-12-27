using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0xEBECDBDBC0F9EFB9, NameHash = 0x62C0729D49C7216D)]
    public class GcSolarGenerationData : NMSTemplate
    {
        /* 0x00 */ public ulong SolarSeed;
    }
}
