using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71C19DF25548EF2F, NameHash = 0xE586E1C6C9A10307)]
    public class GcMissionSequenceTeleport : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 DebugText;
        /* 0x100 */ public GcTeleporterType TeleporterType;
        /* 0x104 */ public bool DoCameraShake;
        /* 0x105 */ public bool DoWhiteout;
        /* 0x108 */ public float SequenceTime;
        /* 0x10C */ public float EffectTime;
    }
}
