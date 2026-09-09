namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CEE797FD3294116, NameHash = 0x8702A842)]
    public class GcGravityVolumeType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 NodeNameStartsWith;
        [NMS(Index = 2)]
        /* 0x10 */ public float CornerRadius;
        [NMS(Index = 3)]
        /* 0x14 */ public float FalloffDistance;
        [NMS(Index = 1)]
        /* 0x18 */ public float GravityStrength;
        [NMS(Index = 5)]
        /* 0x1C */ public bool BlendGravityWithFalloff;
        [NMS(Index = 4)]
        /* 0x1D */ public bool DeactivateNode;
        [NMS(Index = 6)]
        /* 0x1E */ public bool IsCapsuleInY;
    }
}
