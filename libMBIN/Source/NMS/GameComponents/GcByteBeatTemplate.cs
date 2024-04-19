using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x972ED2E5C097966E, NameHash = 0xB764F802BDE36ADF)]
    public class GcByteBeatTemplate : NMSTemplate
    {
        /* 0x00 */ public List<GcByteBeatTemplate> Children;
        /* 0x10 */ public int MaxValue;
        /* 0x14 */ public int MinValue;
        /* 0x18 */ public GcByteBeatToken TokenType;
        /* 0x1C */ public float Weight;
    }
}
