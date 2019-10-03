using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x190, GUID = 0xD396BBDFA5B10438, NameHash = 0x39C7A4F372F6707C)]
    public class GcBountySpawnInfo : NMSTemplate
    {
        [NMS(Size = 0x10)]
	    /* 0x000 */ public string Id;
        /* 0x010 */ public GcAIShipSpawnData Data;
        [NMS(Size = 0x10)]
        /* 0x0D8 */ public string AttackData;
        /* 0x0E8 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x16C */ public byte[] Padding14C;
        [NMS(Size = 0x20)]
        /* 0x170 */ public string Label;
    }
}
