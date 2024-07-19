using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB13BB46F284E6C9D, NameHash = 0xE5D33B2E)]
    public class GcNGuiStyleAnimationData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcNGuiStyleAnimationKeyframeData> KeyFrames;
        [NMS(Index = 0)]
        /* 0x10 */ public float Length;
        [NMS(Index = 2)]
        /* 0x14 */ public bool AnimateByDefault;
        [NMS(Index = 1)]
        /* 0x15 */ public bool Loop;
    }
}
