using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xD8, GUID = 0x9501197E0E183F4F, NameHash = 0x864FCB26DF972FCF)]
    public class GcPlayerTitle : NMSTemplate {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x20A Title;
        /* 0x30 */ public NMSString0x20A UnlockDescription;
        /* 0x50 */ public NMSString0x20A AlreadyUnlockedDescription;
        /* 0x70 */ public NMSString0x10 RevealedBy;
        /* 0x80 */ public NMSString0x10 UnlockedByProductRecipe;
        /* 0x90 */ public NMSString0x10 UnlockedByMission;
        /* 0xA0 */ public NMSString0x10 UnlockedByTrophy;
        /* 0xB0 */ public NMSString0x10 UnlockedByStat;
        /* 0xC0 */ public float UnlockedByStatValue;
        /* 0xC4 */ public GcInteractionType UnlockedByInteraction;
        /* 0xC8 */ public int UnlockedByInteractionIndex;
        /* 0xCC */ public GcAlienRace UnlockedByInteractionRace;
        /* 0xD0 */ public bool UnlockableInCreativeMode;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0xD1 */ public byte[] EndPadding;
    }

}
