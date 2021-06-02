using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x160, GUID = 0x30B4483E1E27ABDD, NameHash = 0x5F9BF82F9925D932)]
    public class GcPlayerDamageData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x20A DeathMessage;
        /* 0x030 */ public NMSString0x10 DeathStat;
        /* 0x040 */ public TkTextureResource HitIcon;
        /* 0x0C8 */ public NMSString0x20A HitChatMessage;
        /* 0x0E8 */ public NMSString0x20A HitMessage;
        /* 0x108 */ public NMSString0x20A CriticalHitMessage;
        /* 0x128 */ public float Damage;
        /* 0x12C */ public float HardModeMultiplier;
        /* 0x130 */ public float PushForce;
        /* 0x134 */ public float CameraTurn;
        /* 0x138 */ public NMSString0x10 CameraShakeShield;
        /* 0x148 */ public NMSString0x10 CameraShakeNoShield;
        /* 0x158 */ public bool ShowTrackIcon;
        /* 0x159 */ public bool ForceDamageInInteraction;
        /* 0x159 */ public bool AllowDeathInInteraction;
		public enum PlayerDamageTypeEnum { Normal, Toxic, Radioactive, Freeze, Scorch }
		/* 0x15C */ public PlayerDamageTypeEnum PlayerDamageType;
    }
}
