using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0xB0542B06F2EB90B3, NameHash = 0xE586E1C6C9A10307)]
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
