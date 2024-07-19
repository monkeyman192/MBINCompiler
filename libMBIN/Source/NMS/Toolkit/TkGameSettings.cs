using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7D4D3A56285FDBBA, NameHash = 0x950A4669)]
    public class TkGameSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcInputActionMapping> KeyMapping;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcInputActionMapping2> KeyMapping2;
        [NMS(Index = 2)]
        /* 0x20 */ public TkPadEnum LastKnownPadType;
    }
}
