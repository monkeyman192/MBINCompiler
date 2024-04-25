using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C1B6F8B35A14CEF, NameHash = 0x5F9BF82F9925D932)]
    public class GcPlayerDamageData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public NMSString0x20A CriticalHitMessage;
        [NMS(Index = 1)]
        /* 0x020 */ public NMSString0x20A DeathMessage;
        [NMS(Index = 4)]
        /* 0x040 */ public NMSString0x20A HitChatMessage;
        [NMS(Index = 5)]
        /* 0x060 */ public NMSString0x20A HitMessage;
        [NMS(Index = 13)]
        /* 0x080 */ public NMSString0x10 CameraShakeNoShield;
        [NMS(Index = 12)]
        /* 0x090 */ public NMSString0x10 CameraShakeShield;
        [NMS(Index = 18)]
        /* 0x0A0 */ public List<GcBreakTechByStatData> DamageTechWithStat;
        [NMS(Index = 2)]
        /* 0x0B0 */ public NMSString0x10 DeathStat;
        [NMS(Index = 0)]
        /* 0x0C0 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x0D0 */ public TkTextureResource HitIcon;
        [NMS(Index = 11)]
        /* 0x154 */ public float CameraTurn;
        [NMS(Index = 8)]
        /* 0x158 */ public GcAudioWwiseEvents CriticalHitMessageAudio;
        [NMS(Index = 9)]
        /* 0x15C */ public float Damage;
        [NMS(Index = 6)]
        /* 0x160 */ public GcAudioWwiseEvents HitMessageAudio;
        // size: 0x5
        public enum PlayerDamageTypeEnum : uint {
            Normal,
            Toxic,
            Radioactive,
            Freeze,
            Scorch,
        }
        [NMS(Index = 17)]
        /* 0x164 */ public PlayerDamageTypeEnum PlayerDamageType;
        [NMS(Index = 10)]
        /* 0x168 */ public float PushForce;
        [NMS(Index = 19)]
        /* 0x16C */ public float TechDamageChance;
        [NMS(Index = 16)]
        /* 0x170 */ public bool AllowDeathInInteraction;
        [NMS(Index = 15)]
        /* 0x171 */ public bool ForceDamageInInteraction;
        [NMS(Index = 14)]
        /* 0x172 */ public bool ShowTrackIcon;
    }
}
