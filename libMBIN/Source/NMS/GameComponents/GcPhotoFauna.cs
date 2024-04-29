using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C65DFB899EDCEA1, NameHash = 0xA9CCD3801AE3DA64)]
    public class GcPhotoFauna : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 2)]
        /* 0x8 */ public GcPhotoCreature CreatureArea;
        [NMS(Index = 3)]
        /* 0xC */ public bool MustBePet;
    }
}
