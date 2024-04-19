using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A052BCED9D7FE6B, NameHash = 0x7CC4297B73C8CB65)]
    public class GcNGuiStyleAnimationData : NMSTemplate
    {
        /* 0x00 */ public List<GcNGuiStyleAnimationKeyframeData> KeyFrames;
        /* 0x10 */ public float Length;
        /* 0x14 */ public bool AnimateByDefault;
        /* 0x15 */ public bool Loop;
    }
}
