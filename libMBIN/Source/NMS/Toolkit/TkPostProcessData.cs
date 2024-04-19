namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAEB5B93A395579A3, NameHash = 0xF95FF845E00A143C)]
    public class TkPostProcessData : NMSTemplate
    {
        /* 0x00 */ public float BrightnessDepth;
        /* 0x04 */ public float BrightnessFinal;
        /* 0x08 */ public float ContrastDepth;
        /* 0x0C */ public float ContrastFinal;
        /* 0x10 */ public float DOFFarAmount;
        /* 0x14 */ public float DOFFarPlane;
        /* 0x18 */ public float DOFNearAmount;
        /* 0x1C */ public float DOFNearPlane;
        /* 0x20 */ public float SaturationDepth;
        /* 0x24 */ public float SaturationFinal;
    }
}
