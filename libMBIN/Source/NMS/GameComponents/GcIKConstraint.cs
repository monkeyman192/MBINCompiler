using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D52BE7161729552, NameHash = 0x9A9B4993026AA411)]
    public class GcIKConstraint : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcPlayerCharacterIKOverrideData DefaultState;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 4)]
        /* 0x30 */ public List<GcPlayerCharacterIKStateData> States;
        [NMS(Index = 2)]
        /* 0x40 */ public GcCreatureIkType Type;
        [NMS(Index = 1)]
        /* 0x44 */ public NMSString0x100 JointName;
    }
}
