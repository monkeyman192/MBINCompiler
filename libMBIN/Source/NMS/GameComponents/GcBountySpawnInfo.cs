using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x190, GUID = 0xF040BF3CE072C30A, NameHash = 0x39C7A4F372F6707C)]
    public class GcBountySpawnInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public GcAIShipSpawnData Data;
        /* 0x0D8 */ public NMSString0x10 AttackData;
        /* 0x0E8 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x16C */ public byte[] Padding14C;
        /* 0x170 */ public NMSString0x20 Label;
    }
}
