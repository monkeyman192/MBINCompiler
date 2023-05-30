using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcStatLevelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 LevelName;
        /* 0x20 */ public GcStatValueData Value;
        /* 0x30 */ public NMSString0x10 TrophyToUnlock;
    }
}
