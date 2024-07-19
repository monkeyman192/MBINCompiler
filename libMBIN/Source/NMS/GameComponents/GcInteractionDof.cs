namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FFB3A89F531FF33, NameHash = 0xC968BD76)]
    public class GcInteractionDof : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public float FarFadeDistance;
        [NMS(Index = 4)]
        /* 0x04 */ public float FarPlane;
        [NMS(Index = 3)]
        /* 0x08 */ public float NearPlaneAdjust;
        [NMS(Index = 2)]
        /* 0x0C */ public float NearPlaneMin;
        [NMS(Index = 0)]
        /* 0x10 */ public bool IsEnabled;
        [NMS(Index = 1)]
        /* 0x11 */ public bool UseGlobals;
    }
}
