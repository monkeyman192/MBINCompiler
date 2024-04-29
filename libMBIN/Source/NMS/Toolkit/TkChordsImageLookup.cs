using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC3F3D39C0F5B45DE, NameHash = 0xD2FF58C5F7940C1F)]
    public class TkChordsImageLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkChordPathMapping> Lookup;
    }
}
