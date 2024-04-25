using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4AAD09A3D87C187F, NameHash = 0x75302EADC2AAED35)]
    public class TkTrophyData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkTrophyEntry> Trophies;
    }
}
