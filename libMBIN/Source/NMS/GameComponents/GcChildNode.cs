namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x201E0AD9D2F13BE7, NameHash = 0x22A25F9B)]
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
