using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B034AA457AF9D0, NameHash = 0x3ECB0104)]
    public class GcSaveContextDataMaskTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcSaveContextDataMaskTableEntry> Masks;
        [NMS(Index = 0)]
        /* 0x10 */ public GcSaveContextDataMask Default;
    }
}
