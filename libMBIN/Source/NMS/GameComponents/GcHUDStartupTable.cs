using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x212C02299B825A2, NameHash = 0x83FCDC89)]
    public class GcHUDStartupTable : NMSTemplate
    {
        // size: 0xD
        public enum HUDStartupEnum {
            WaitingForInit,
            Startup,
            Booting,
            LifeSupport,
            Shield,
            ShieldEffect,
            Scanner,
            Jetpack,
            Weapon,
            Finishing,
            DiscoverPlanet,
            Done,
            Inactive,
        }
        [NMS(Index = 6, Size = 0xD, EnumType = typeof(HUDStartupEnum))]
        /* 0x000 */ public GcHUDStartup[] HUDStartup;
        [NMS(Index = 5)]
        /* 0x138 */ public float BackgroundAlpha;
        [NMS(Index = 4)]
        /* 0x13C */ public float ButtonFlashAlpha;
        [NMS(Index = 3)]
        /* 0x140 */ public float ButtonFlashRate;
        [NMS(Index = 0)]
        /* 0x144 */ public float FadeInFlashTime;
        [NMS(Index = 1)]
        /* 0x148 */ public float LookSpeed;
        [NMS(Index = 2)]
        /* 0x14C */ public float StartHoldTime;
    }
}
