using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x580BFB26A391880B, NameHash = 0x74D183C5)]
    public class TkChordsImageLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkChordPathMapping> Lookup;
    }
}
