using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF97E7C4C681871A4, NameHash = 0xEFC01E37)]
    public class GcMissionSequenceTeleport : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 6)]
        /* 0x20 */ public float EffectTime;
        [NMS(Index = 5)]
        /* 0x24 */ public float SequenceTime;
        [NMS(Index = 2)]
        /* 0x28 */ public GcTeleporterType TeleporterType;
        [NMS(Index = 3)]
        /* 0x2C */ public bool DoCameraShake;
        [NMS(Index = 4)]
        /* 0x2D */ public bool DoWhiteout;
    }
}
