using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcLeveledStatData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 StatId;
        /* 0x10 */ public NMSString0x20 StatTitle;
        /* 0x30 */ public NMSString0x20 NotifyMessage;

        /* 0x50 */ public bool ShowInTerminal;
        /* 0x51 */ public bool ShowStatLevel;
        /* 0x54 */ public TkTextureResource Icon;
        [NMS(Size = 0xB)]
        /* 0xD8 */ public GcStatLevelData[] StatLevels;
    }
}
