using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB74CF9E0CF4A5022, NameHash = 0xECC1CDECFE5FC437)]
    public class GcStatLevelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A LevelName;
        /* 0x20 */ public NMSString0x20A OSDLevelName;
        /* 0x40 */ public GcStatValueData Value;
        /* 0x50 */ public NMSString0x10 TrophyToUnlock;
    }
}
