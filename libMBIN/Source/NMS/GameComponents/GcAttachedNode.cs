namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x955DA96E4D426CD4, NameHash = 0x6F644A9834B845DB)]
    public class GcAttachedNode : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public Vector3f RelativeTransform_Axis0;
        [NMS(Index = 8)]
        /* 0x10 */ public Vector3f RelativeTransform_Axis1;
        [NMS(Index = 9)]
        /* 0x20 */ public Vector3f RelativeTransform_Axis2;
        [NMS(Index = 10)]
        /* 0x30 */ public Vector3f RelativeTransform_Position;
        [NMS(Index = 6)]
        /* 0x40 */ public float BlendStrength;
        [NMS(Index = 4)]
        /* 0x44 */ public float MaxRenderIFraction;
        [NMS(Index = 5)]
        /* 0x48 */ public float MaxRenderJFraction;
        [NMS(Index = 2)]
        /* 0x4C */ public float MinRenderIFraction;
        [NMS(Index = 3)]
        /* 0x50 */ public float MinRenderJFraction;
        [NMS(Index = 1)]
        /* 0x54 */ public NMSString0x40 NodeName;
        [NMS(Index = 0)]
        /* 0x94 */ public bool Enabled;
    }
}
