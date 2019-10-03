using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, Alignment = 0x10, GUID = 0xAEF7CA64F6466504, NameHash = 0x4309D65C13EEC689)]
    public class GcStatsEntry : NMSTemplate
    {
        /* 0x00 */ public GcStatsTypes Type;
        /* 0x10 */ public Colour Colour;
        /* 0x20 */ public float RangeMin;
        /* 0x24 */ public float RangeMax;
        /* 0x28 */ public bool LessIsBetter;

        [NMS(Size = 0x7, Ignore = true)]
        /* 0x29 */ public byte[] Padding29;

        [NMS(Size = 0x10)]
        /* 0x30 */ public string BaseTechID;
    }
}
