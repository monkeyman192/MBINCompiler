using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xB74CF9E0CF4A5022, NameHash = 0xECC1CDECFE5FC437)]
    public class GcStatLevelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 LevelName;
        /* 0x20 */ public NMSString0x20 OSDLevelName;
        /* 0x40 */ public GcStatValueData Value;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4C */ public byte[] Padding4C;
        /* 0x50 */ public NMSString0x10 TrophyToUnlock;
    }
}
