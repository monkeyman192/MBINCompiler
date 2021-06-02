using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x128, Alignment = 0x8, GUID = 0x498C96F5B230C04E, NameHash = 0xCEBA3C32BCAF04F6)]
    public class GcMissionSequenceWaitForStatSeasonal : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x10 Stat;
        /* 0x090 */ public NMSString0x10 StatGroup;
        /* 0x0A0 */ public int Amount;
        /* 0x0A4 */ public bool TakeAmountFromSeasonalData;
        /* 0x0A5 */ public NMSString0x80 DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x125 */ public byte[] EndPadding;
    }
}
