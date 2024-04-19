namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B0E82653246BCA4, NameHash = 0x66AD46574EA03C5C)]
    public class GcChildNode : NMSTemplate
    {
        /* 0x00 */ public Vector3f JointPositionInBone;
        /* 0x10 */ public Vector3f PositionInBone;
        /* 0x20 */ public NMSString0x40 NodeName;
        /* 0x60 */ public bool JointPositionInBoneSet;
    }
}
