using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21A8E9B6B9F97971, NameHash = 0x2E19620D3EC8F3AC)]
    public class GcNPCColourGroup : NMSTemplate
    {
        /* 0x00 */ public Colour Primary;
        /* 0x10 */ public List<Colour> Secondary;
        /* 0x20 */ public float Rarity;
    }
}
