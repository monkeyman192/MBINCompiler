using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B8AD43A964FB688, NameHash = 0x9A051A6D204FA9F2)]
    public class GcNGuiStyleAnimationKeyframeData : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> StyleProperties;
        /* 0x10 */ public float Position;
    }
}
