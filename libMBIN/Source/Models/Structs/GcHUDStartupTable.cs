namespace libMBIN.Models.Structs
{
    public class GcHUDStartupTable : NMSTemplate        // size: 0x80
    {
        /* 0x00 */ public float FadeInFlashTime;        // 40000000h
        /* 0x04 */ public float LookSpeed;              // 41700000h
        /* 0x08 */ public float StartHoldTime;          // 40000000h
        /* 0x0C */ public float ButtonFlashRate;        // 3DCCCCCDh
        /* 0x10 */ public float ButtonFlashAlpha;       // 3E4CCCCDh
        /* 0x14 */ public float BackgroundAlpha;        // 3F666666h
        [NMS(Size = 0xD)]
        /* 0x18 */ public GcHUDStartup[] HUDStartup;
    }
}
