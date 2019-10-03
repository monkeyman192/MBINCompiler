using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x78, GUID = 0xFF0643125795309F, NameHash = 0x51D536C649733342)]
    public class TkTrophyEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string TrophyId;
        /* 0x10 */ public int Ps4Id;
        [NMS(Size = 0x40)]
        /* 0x14 */ public string PCId;
        [NMS(Size = 0x20)]
        /* 0x54 */ public string XboxOneId;

        [NMS(Size = 4, Ignore = true)]
        /* 0x74 */ public byte[] EndPadding;
    }
}
