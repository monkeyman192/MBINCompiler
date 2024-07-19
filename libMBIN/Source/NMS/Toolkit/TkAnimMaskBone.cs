namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x871FBE2D8A78D352, NameHash = 0x792E9B30)]
    public class TkAnimMaskBone : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public int NameHash;
        [NMS(Index = 2)]
        /* 0x04 */ public float RotationWeight;
        [NMS(Index = 3)]
        /* 0x08 */ public float TranslationWeight;
        [NMS(Index = 0)]
        /* 0x0C */ public NMSString0x40 Name;
        [NMS(Index = 5)]
        /* 0x4C */ public bool ChildrenInheritWeights;
        [NMS(Index = 4)]
        /* 0x4D */ public bool LinkWeights;
    }
}
