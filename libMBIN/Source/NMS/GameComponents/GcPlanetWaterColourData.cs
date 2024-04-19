namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE16295F97CAA527, NameHash = 0x5148874790D0404C)]
    public class GcPlanetWaterColourData : NMSTemplate
    {
        /* 0x00 */ public Colour FoamColour;
        /* 0x10 */ public Colour WaterColourAdd;
        /* 0x20 */ public Colour WaterColourBase;
        /* 0x30 */ public Colour WaterFogColourFar;
        /* 0x40 */ public Colour WaterFogColourNear;
    }
}
