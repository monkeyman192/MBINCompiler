namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE16295F97CAA527, NameHash = 0x5148874790D0404C)]
    public class GcPlanetWaterColourData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Colour FoamColour;
        [NMS(Index = 3)]
        /* 0x10 */ public Colour WaterColourAdd;
        [NMS(Index = 2)]
        /* 0x20 */ public Colour WaterColourBase;
        [NMS(Index = 1)]
        /* 0x30 */ public Colour WaterFogColourFar;
        [NMS(Index = 0)]
        /* 0x40 */ public Colour WaterFogColourNear;
    }
}
