namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAEB5B93A395579A3, NameHash = 0xF95FF845E00A143C)]
    public class TkPostProcessData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public float BrightnessDepth;
        [NMS(Index = 8)]
        /* 0x04 */ public float BrightnessFinal;
        [NMS(Index = 6)]
        /* 0x08 */ public float ContrastDepth;
        [NMS(Index = 9)]
        /* 0x0C */ public float ContrastFinal;
        [NMS(Index = 3)]
        /* 0x10 */ public float DOFFarAmount;
        [NMS(Index = 1)]
        /* 0x14 */ public float DOFFarPlane;
        [NMS(Index = 2)]
        /* 0x18 */ public float DOFNearAmount;
        [NMS(Index = 0)]
        /* 0x1C */ public float DOFNearPlane;
        [NMS(Index = 4)]
        /* 0x20 */ public float SaturationDepth;
        [NMS(Index = 7)]
        /* 0x24 */ public float SaturationFinal;
    }
}
