using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x63ECC02586BD84C2, NameHash = 0xD2FF58C5F7940C1F)]
    public class TkChordsImageLookup : NMSTemplate
    {
        public List<TkChordPathMapping> Lookup;
    }
}
