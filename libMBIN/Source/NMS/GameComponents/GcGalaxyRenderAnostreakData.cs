namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB57646BA374E31A1, NameHash = 0x916C4DD873AEFE6B)]
    public class GcGalaxyRenderAnostreakData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Colour InnerColour;
        [NMS(Index = 0)]
        /* 0x10 */ public Colour OuterColour;
        [NMS(Index = 4)]
        /* 0x20 */ public float Contrast;
        [NMS(Index = 3)]
        /* 0x24 */ public float HorizontalScale;
        [NMS(Index = 2)]
        /* 0x28 */ public float VerticalCompression;
    }
}
