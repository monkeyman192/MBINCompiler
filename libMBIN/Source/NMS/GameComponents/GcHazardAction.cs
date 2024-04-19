using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF973957877E0F6AF, NameHash = 0x2FCEFF0AE05742C0)]
    public class GcHazardAction : NMSTemplate
    {
        /* 0x0 */ public GcPlayerHazardType Hazard;
        /* 0x4 */ public float Radius;
        /* 0x8 */ public float Strength;
        /* 0xC */ public bool RadiusBasedStrength;
    }
}
