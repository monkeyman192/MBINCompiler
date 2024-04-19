using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E80B13A04452FAF, NameHash = 0xA9CCD3801AE3DA64)]
    public class GcPhotoFauna : NMSTemplate
    {
        /* 0x0 */ public int AmountMax;
        /* 0x4 */ public int AmountMin;
        /* 0x8 */ public GcPhotoCreature CreatureArea;
        /* 0xC */ public bool MustBePet;
    }
}
