namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE61FFF81577D8E8, NameHash = 0x6F644A9834B845DB)]
    public class GcAttachedNode : NMSTemplate
    {
        /* 0x00 */ public Vector3f RelativeTransform_Axis0;
        /* 0x10 */ public Vector3f RelativeTransform_Axis1;
        /* 0x20 */ public Vector3f RelativeTransform_Axis2;
        /* 0x30 */ public Vector3f RelativeTransform_Position;
        /* 0x40 */ public float BlendStrength;
        /* 0x44 */ public float MaxRenderIFraction;
        /* 0x48 */ public float MaxRenderJFraction;
        /* 0x4C */ public float MinRenderIFraction;
        /* 0x50 */ public float MinRenderJFraction;
        /* 0x54 */ public NMSString0x40 NodeName;
        /* 0x94 */ public bool Enabled;
    }
}
