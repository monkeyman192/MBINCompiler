namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B0E82653246BCA4, NameHash = 0x66AD46574EA03C5C)]
    public class GcChildNode : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f JointPositionInBone;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f PositionInBone;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x40 NodeName;
        [NMS(Index = 3)]
        /* 0x60 */ public bool JointPositionInBoneSet;
    }
}
