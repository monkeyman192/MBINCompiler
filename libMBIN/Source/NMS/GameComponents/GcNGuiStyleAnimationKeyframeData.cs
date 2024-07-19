using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CEBC3C23900162E, NameHash = 0x7D610529)]
    public class GcNGuiStyleAnimationKeyframeData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSTemplate> StyleProperties;
        [NMS(Index = 0)]
        /* 0x10 */ public float Position;
    }
}
