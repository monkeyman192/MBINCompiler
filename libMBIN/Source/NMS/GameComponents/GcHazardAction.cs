using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DA9B6157D7A6887, NameHash = 0x2FCEFF0AE05742C0)]
    public class GcHazardAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPlayerHazardType Hazard;
        [NMS(Index = 2)]
        /* 0x4 */ public float Radius;
        [NMS(Index = 1)]
        /* 0x8 */ public float Strength;
        [NMS(Index = 3)]
        /* 0xC */ public bool RadiusBasedStrength;
    }
}
