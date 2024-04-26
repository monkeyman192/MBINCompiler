using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7958D3C49BD96694, NameHash = 0x1FE13AB26770D8C5, Alignment = 0x10)]
    public class GcScanEffectComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcScanEffectData> ScanEffects;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x40 NodeName;
    }
}
