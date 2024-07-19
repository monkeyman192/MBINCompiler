using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA6B7F8D35D3DAA3, NameHash = 0x2A1249C2)]
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
