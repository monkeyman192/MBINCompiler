using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3370D2C62FB1C135, NameHash = 0xEFC01E37)]
    public class GcMissionSequenceTeleport : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 5)]
        /* 0x20 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 6)]
        /* 0x24 */ public float AudioTime;
        [NMS(Index = 8)]
        /* 0x28 */ public float EffectTime;
        [NMS(Index = 7)]
        /* 0x2C */ public float SequenceTime;
        [NMS(Index = 2)]
        /* 0x30 */ public GcTeleporterType TeleporterType;
        [NMS(Index = 3)]
        /* 0x34 */ public bool DoCameraShake;
        [NMS(Index = 4)]
        /* 0x35 */ public bool DoWhiteout;
    }
}
