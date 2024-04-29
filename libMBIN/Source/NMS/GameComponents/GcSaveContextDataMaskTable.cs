using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40FF2F8B931C7F29, NameHash = 0x1D2BBA30C6CC5A88)]
    public class GcSaveContextDataMaskTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcSaveContextDataMaskTableEntry> Masks;
        [NMS(Index = 0)]
        /* 0x10 */ public GcSaveContextDataMask Default;
    }
}
