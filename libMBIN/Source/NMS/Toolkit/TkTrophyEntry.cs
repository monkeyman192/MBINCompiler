using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x78, GUID = 0xFF0643125795309F, NameHash = 0x51D536C649733342)]
    public class TkTrophyEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TrophyId;
        /* 0x10 */ public int Ps4Id;
        /* 0x14 */ public NMSString0x40 PCId;
        /* 0x54 */ public NMSString0x20 XboxOneId;

        [NMS(Size = 4, Ignore = true)]
        /* 0x74 */ public byte[] EndPadding;
    }
}
