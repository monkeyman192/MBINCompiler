using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD8, GUID = 0x955729FC17138A79, NameHash = 0x864FCB26DF972FCF)]
    public class GcPlayerTitle : NMSTemplate {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x30 */ public string UnlockDescription;
        [NMS(Size = 0x20)]
        /* 0x50 */ public string AlreadyUnlockedDescription;
        [NMS(Size = 0x10)]
        /* 0x70 */ public string RevealedBy;
        [NMS(Size = 0x10)]
        /* 0x80 */ public string UnlockedByProductRecipe;
        [NMS(Size = 0x10)]
        /* 0x90 */ public string UnlockedByMission;
        [NMS(Size = 0x10)]
        /* 0xA0 */ public string UnlockedByTrophy;
        [NMS(Size = 0x10)]
        /* 0xB0 */ public string UnlockedByStat;
        /* 0xC0 */ public float UnlockedByStatValue;
        /* 0xC4 */ public GcInteractionType UnlockedByInteraction;
        /* 0xC8 */ public int UnlockedByInteractionIndex;
        /* 0xCC */ public GcAlienRace UnlockedByInteractionRace;
        /* 0xD0 */ public bool UnlockableInCreativeMode;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0xD1 */ public byte[] EndPadding;
    }

}
