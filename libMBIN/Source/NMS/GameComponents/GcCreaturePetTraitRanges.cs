using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0C793FFA12CE763, NameHash = 0x55F9EF59F3B21D8)]
    public class GcCreaturePetTraitRanges : NMSTemplate
    {
        [NMS(Size = 0x3)]
        /* 0x0 */ public GcCreaturePetTraitRange[] TraitRanges;
    }
}
