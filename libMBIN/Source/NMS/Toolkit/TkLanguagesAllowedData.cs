using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF2DEF3DB775B3ED9, NameHash = 0x282FD8A1)]
    public class TkLanguagesAllowedData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<TkLanguages> Allowed;
        [NMS(Index = 1)]
        /* 0x10 */ public TkLanguages Fallback;
    }
}
