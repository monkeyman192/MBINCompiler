using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E692218EF2AC71A, NameHash = 0xB9DD91F357A56979)]
    public class GcProjectorOffsetData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcInWorldUIScreenData Active;
        [NMS(Index = 3)]
        /* 0x30 */ public GcInWorldUIScreenData Inactive;
        [NMS(Index = 1)]
        /* 0x60 */ public Vector2f ScreenScale;
        [NMS(Index = 0)]
        /* 0x68 */ public float Scale;
    }
}
