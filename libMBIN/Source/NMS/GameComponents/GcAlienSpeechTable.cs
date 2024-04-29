using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x857CAD1D08E2AD70, NameHash = 0xCC5FB6577E4B6B47)]
    public class GcAlienSpeechTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAlienSpeechEntry> Table;
    }
}
