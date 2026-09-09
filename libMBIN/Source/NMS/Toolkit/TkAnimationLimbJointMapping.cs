namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x48B431371A768B1B, NameHash = 0x949D1CCE)]
    public class TkAnimationLimbJointMapping : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Limb;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x40 JointName;
    }
}
