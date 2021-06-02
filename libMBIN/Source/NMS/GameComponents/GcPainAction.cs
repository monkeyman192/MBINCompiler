using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, Alignment = 0x8, GUID = 0x9A9D9B667592CEE8, NameHash = 0x9B8944FB55B77041)]
    public class GcPainAction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Damage;
        /* 0x10 */ public float Radius;
        /* 0x14 */ public bool RadiusBasedDamage;
        /* 0x15 */ public bool AffectsPlayer;
        /* 0x18 */ public float RetriggerTime;
        [NMS(Size = 4, Ignore = true)]
        /* 0x1C */ public byte[] EndPadding;
    }
}
