using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBB4A61849CB9F4C8, NameHash = 0xE586E1C6C9A10307)]
    public class GcMissionSequenceTeleport : NMSTemplate
    {
        /* 0x000 */ public float EffectTime;
        /* 0x004 */ public float SequenceTime;
        /* 0x008 */ public GcTeleporterType TeleporterType;
        /* 0x00C */ public NMSString0x80 DebugText;
        /* 0x08C */ public NMSString0x80 Message;
        /* 0x10C */ public bool DoCameraShake;
        /* 0x10D */ public bool DoWhiteout;
    }
}
