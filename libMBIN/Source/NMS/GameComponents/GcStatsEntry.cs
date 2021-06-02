using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, Alignment = 0x10, GUID = 0x379827528DC58AE0, NameHash = 0x4309D65C13EEC689)]
    public class GcStatsEntry : NMSTemplate
    {
        /* 0x00 */ public GcStatsTypes Type;
        /* 0x10 */ public Colour Colour;
        /* 0x20 */ public float RangeMin;
        /* 0x24 */ public float RangeMax;
        /* 0x28 */ public bool LessIsBetter;

        [NMS(Size = 0x7, Ignore = true)]
        /* 0x29 */ public byte[] Padding29;

        /* 0x30 */ public NMSString0x10 BaseTechID;
    }
}
