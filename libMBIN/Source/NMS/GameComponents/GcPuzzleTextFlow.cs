using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAD97AE8724BF862B, Size = 0x50, NameHash = 0x44CB81CE83D73B16)]
    public class GcPuzzleTextFlow : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Text;
        /* 0x20 */ public bool IsAlien;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x21 */ public byte[] Padding21;
        [NMS(Size = 0x20)]
        /* 0x28 */ public string Title;
        /* 0x48 */ public GcAlienMood Mood;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4C */ public byte[] EndPadding;
    }
}
