using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BC266A4CB498F03, NameHash = 0xB0A39161047DD10D)]
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
        [NMS(Size = 0xD, EnumType = typeof(HUDStartupEnum))]
        /* 0x000 */ public GcHUDStartup[] HUDStartup;
        /* 0x138 */ public float BackgroundAlpha;
        /* 0x13C */ public float ButtonFlashAlpha;
        /* 0x140 */ public float ButtonFlashRate;
        /* 0x144 */ public float FadeInFlashTime;
        /* 0x148 */ public float LookSpeed;
        /* 0x14C */ public float StartHoldTime;
    }
}
