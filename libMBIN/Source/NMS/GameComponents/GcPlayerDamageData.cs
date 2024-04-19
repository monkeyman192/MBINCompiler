using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C1B6F8B35A14CEF, NameHash = 0x5F9BF82F9925D932)]
    public class GcPlayerDamageData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A CriticalHitMessage;
        /* 0x020 */ public NMSString0x20A DeathMessage;
        /* 0x040 */ public NMSString0x20A HitChatMessage;
        /* 0x060 */ public NMSString0x20A HitMessage;
        /* 0x080 */ public NMSString0x10 CameraShakeNoShield;
        /* 0x090 */ public NMSString0x10 CameraShakeShield;
        /* 0x0A0 */ public List<GcBreakTechByStatData> DamageTechWithStat;
        /* 0x0B0 */ public NMSString0x10 DeathStat;
        /* 0x0C0 */ public NMSString0x10 Id;
        /* 0x0D0 */ public TkTextureResource HitIcon;
        /* 0x154 */ public float CameraTurn;
        /* 0x158 */ public GcAudioWwiseEvents CriticalHitMessageAudio;
        /* 0x15C */ public float Damage;
        /* 0x160 */ public GcAudioWwiseEvents HitMessageAudio;
        // size: 0x5
        public enum PlayerDamageTypeEnum : uint {
            Normal,
            Toxic,
            Radioactive,
            Freeze,
            Scorch,
        }
        /* 0x164 */ public PlayerDamageTypeEnum PlayerDamageType;
        /* 0x168 */ public float PushForce;
        /* 0x16C */ public float TechDamageChance;
        /* 0x170 */ public bool AllowDeathInInteraction;
        /* 0x171 */ public bool ForceDamageInInteraction;
        /* 0x172 */ public bool ShowTrackIcon;
    }
}
