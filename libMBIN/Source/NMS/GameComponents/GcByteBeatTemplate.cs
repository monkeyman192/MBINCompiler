using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x972ED2E5C097966E, NameHash = 0xB764F802BDE36ADF)]
    public class GcByteBeatTemplate : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<GcByteBeatTemplate> Children;
        [NMS(Index = 3)]
        /* 0x10 */ public int MaxValue;
        [NMS(Index = 2)]
        /* 0x14 */ public int MinValue;
        [NMS(Index = 1)]
        /* 0x18 */ public GcByteBeatToken TokenType;
        [NMS(Index = 0)]
        /* 0x1C */ public float Weight;
    }
}
