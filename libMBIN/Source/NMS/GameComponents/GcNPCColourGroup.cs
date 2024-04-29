using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD6E283DE0129571, NameHash = 0x2E19620D3EC8F3AC)]
    public class GcNPCColourGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Colour Primary;
        [NMS(Index = 2)]
        /* 0x10 */ public List<Colour> Secondary;
        [NMS(Index = 0)]
        /* 0x20 */ public float Rarity;
    }
}
