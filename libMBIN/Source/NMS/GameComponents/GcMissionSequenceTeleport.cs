using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBB4A61849CB9F4C8, NameHash = 0xE586E1C6C9A10307)]
    public class GcMissionSequenceTeleport : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x000 */ public float EffectTime;
        [NMS(Index = 5)]
        /* 0x004 */ public float SequenceTime;
        [NMS(Index = 2)]
        /* 0x008 */ public GcTeleporterType TeleporterType;
        [NMS(Index = 1)]
        /* 0x00C */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x08C */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x10C */ public bool DoCameraShake;
        [NMS(Index = 4)]
        /* 0x10D */ public bool DoWhiteout;
    }
}
