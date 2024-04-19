using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D52BE7161729552, NameHash = 0x9A9B4993026AA411)]
    public class GcIKConstraint : NMSTemplate
    {
        /* 0x00 */ public GcPlayerCharacterIKOverrideData DefaultState;
        /* 0x20 */ public NMSString0x10 Id;
        /* 0x30 */ public List<GcPlayerCharacterIKStateData> States;
        /* 0x40 */ public GcCreatureIkType Type;
        /* 0x44 */ public NMSString0x100 JointName;
    }
}
