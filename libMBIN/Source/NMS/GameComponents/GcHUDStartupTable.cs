using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0xCEADD5CEA12946E4, NameHash = 0xB0A39161047DD10D)]
    public class GcHUDStartupTable : NMSTemplate
    {
        /* 0x00 */ public float FadeInFlashTime;        // 40000000h
        /* 0x04 */ public float LookSpeed;              // 41700000h
        /* 0x08 */ public float StartHoldTime;          // 40000000h
        /* 0x0C */ public float ButtonFlashRate;        // 3DCCCCCDh
        /* 0x10 */ public float ButtonFlashAlpha;       // 3E4CCCCDh
        /* 0x14 */ public float BackgroundAlpha;        // 3F666666h
        public enum HUDStartupEnum { WaitingForInit, Startup, Booting, LifeSupport, Shield, ShieldEffect, Scanner, jetpack, Weapon, Finishing, DiscoverPlanet, Done, Inactive}
        [NMS(Size = 0xD, EnumType = typeof(HUDStartupEnum))]
        /* 0x18 */ public GcHUDStartup[] HUDStartup;
    }
}
