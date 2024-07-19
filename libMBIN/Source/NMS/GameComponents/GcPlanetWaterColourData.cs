namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7391EB224D2309D, NameHash = 0x16BE3C3E)]
    public class GcPlanetWaterColourData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Colour FoamColour;
        [NMS(Index = 4)]
        /* 0x10 */ public Colour WaterColourAdd;
        [NMS(Index = 3)]
        /* 0x20 */ public Colour WaterColourBase;
        [NMS(Index = 2)]
        /* 0x30 */ public Colour WaterFogColourFar;
        [NMS(Index = 1)]
        /* 0x40 */ public Colour WaterFogColourNear;
        [NMS(Index = 0)]
        /* 0x50 */ public float SelectionWeighting;
    }
}
