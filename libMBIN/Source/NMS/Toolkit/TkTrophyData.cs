using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA3943CF4C0D1EA83, NameHash = 0xAAF79A7E)]
    public class TkTrophyData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkTrophyEntry> Trophies;
    }
}
